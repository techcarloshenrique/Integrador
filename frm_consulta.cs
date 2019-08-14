using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Integrador
{
    public partial class frm_consulta : Form
    {
        public frm_consulta()
        {
            InitializeComponent();
        }

        // CLASSE USADA PARA INICIAR AS CONEXÕES
        class Conexao
        {
            // CAPTURA OS VALORES GRAVADOS NO APP [STRING DE CONEXAO]
            private static string connString =
                "Server=" + Properties.Settings.Default.IP
                + "," + Properties.Settings.Default.PORT
                + ";Database=" + Properties.Settings.Default.DATABASE
                + ";User Id=" + Properties.Settings.Default.USER
                + ";Password=" + Properties.Settings.Default.PASS;


            // REPRESENTA A CONEXAO COM O BANCO
            private static SqlConnection conn = null;

            // MÉTODO DA CLASSE PARA OBTER A CONEXAO
            public static SqlConnection obterConexao()
            {

                // INSTANCIANDO UMA NOVA CONEXAO
                conn = new SqlConnection(connString);

                // SE CONEXAO COM SUCESSO...
                try
                {

                    // ABRE A CONEXAO E RETORNA AO CHAMADOR DO MÉTODO
                    conn.Open();

                }
                catch (SqlException)
                {
                    conn = null;
                    //MessageBox.Show(sqle.Message);

                    // UMA BOA PRATICA É GRAVAR A EXCEÇÃO EM UM ARQUIVO DE LOG
                }

                // RETORNA A CONEXAO
                return conn;
            }

            // MÉTODO DA CLASSE PARA FECHAR A CONEXAO
            public static void fecharConexao(SqlConnection conn)
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        // TESTAR A CONEXAO COM OS DADOS JA GRAVADOS
        public bool ConexaoLoad()
        {

            bool connected = false;
            // CARREGAR OS DADOS DE STATUS DA CONEXÃO NA TELA PRINCIPAL
            //gt_lbl_main_servidor_endereco.Text = Properties.Settings.Default.IP + "," +
            //Properties.Settings.Default.PORT;
            //gt_lbl_main_servidor_database.Text = Properties.Settings.Default.DATABASE;

            // SOLICITAR CONEXAO USANDO A CLASSE DE CONEXAO
            SqlConnection conn = Conexao.obterConexao();

            if (conn == null)
            {
                // PODEMOS ABRIR UM MESSAGEBOX PARA UM FEEDBACK DA CONEXAO
                //MessageBox.Show("Conexao não ok", "");
            }
            else
            {

                // COMO É APENAS UM TESTE, PODEMOS FECHAR A CONEXAO
                connected = true;
                Conexao.fecharConexao(conn);

            }
            return connected;

        }


        public void montarResultado(string query, DataGridView dgv)
        {

            // INSTANCIANDO UMA NOVA CONEXAO
            SqlConnection conn = Conexao.obterConexao();

            try
            {
                SqlCommand retorno = new SqlCommand(query, conn);
                SqlDataReader row = retorno.ExecuteReader();

                // CRIANDO UM  E POPULANDO UM DATATABLE COM O RETORNO DA QUERY
                DataTable tabela = new DataTable();
                tabela.Load(row);

                // CONTANDO O TOTAL DE LINHAS DO RETORNO PARA O VALOR MAXIMO DA PROGRESSBAR
                int rows = tabela.Rows.Count;


                // LAÇO DA TABELA
                using (SqlDataReader DR = retorno.ExecuteReader())
                {

                    dgv.Columns.Clear();
                    dgv.Rows.Clear();
                    // SE A CONSULTA RETORNAR LINHAS
                    if (DR.HasRows)
                    {

                        frm_main form = new frm_main();
                        // Get field information.
                        DataTable schema = DR.GetSchemaTable();
                        int field_num = 0;
                        foreach (DataRow schema_row in schema.Rows)
                        {
                            // Create the column.
                            int col_num = dgv.Columns.Add(field_num.ToString(),schema_row.Field<string>("ColumnName"));

                            field_num++;

                            // Make the column size to fit its data.
                            dgv.Columns[col_num].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                        }

                        // Make room to hold a row's values.
                        object[] values = new object[DR.FieldCount];

                        // Loop while the reader has unread data.
                        while (DR.Read())
                        {
                            // Add this row to the DataGridView.
                            DR.GetValues(values);
                            dgv.Rows.Add(values);
                        }

                        // ENQUANTO HOUVER LEITURA NAS LINHAS DO RETORNO
                        /*while (DR.Read())
                        {


                            //tabela.Columns.Add(DR[""].ToString, typeof(String));
                            // LAÇO PARA LER AS COLUNAS DA LINHA
                            for (int i = 0; i < DR.FieldCount; i++)
                            {

                                MessageBox.Show(DR[i] + "\t", "");
                            }

                        }*/


                    }
                }

            }

            catch (Exception ex)
            {

                MessageBox.Show("Erro ao exportar o arquivo  \n\nDetalhe do erro: " + ex.Message);

            }
        }

        public void gerarConsulta(System.IO.DirectoryInfo arquivos, String nome, DataGridView dgv)
        {

            // STRING QUE RECEBE O DIRETÓRIO    
            string diretorio = Properties.Settings.Default.RECEBIDOS + "\\";

            // INSTANCIANDO UMA NOVA CONEXAO
            SqlConnection conn = Conexao.obterConexao();

            // OBTENDO OS ARQUIVOS PARA MONTAR QUERY
            FileInfo[] file = arquivos.GetFiles(nome+".TXT");
            foreach (System.IO.FileInfo fileinfo in file)
            {


                // CAPTURANDO O ARQUVIO
                string query = string.Empty;
                string arquivo = fileinfo.ToString();

                // LENDO O ARQUIVO
                System.IO.StreamReader sr = new System.IO.StreamReader(diretorio + arquivo);
                string line = sr.ReadLine();

                // LAÇO PA CONCATENAR AS LINHAS E MONTAR A QUERY
                while (line != null)
                {
                    query += line;
                    line = sr.ReadLine();
                }
                //String query2 = "SELECT * FROM ST_VENDEDORES";
                // AQUI DECIDE O QUE FAZER COM A QUERY GERADA
                //GravarTXT(conn, arquivo, query);
                //montarResultado(conn, arquivo, query2, dgv);
                // FECHANDO O OBJETO STREAMREADER
                sr.Close();

            }

            // FECHANDO A CONEXAO COM O BANCO
            Conexao.fecharConexao(conn);


        }

        class Temp
        {


            public void copiar(System.IO.DirectoryInfo dir)
            {

                FileInfo[] file = dir.GetFiles("*.TXT");

                foreach (FileInfo fileinfo in file)
                {

                    File.Copy(dir + "\\" + fileinfo.ToString(), "C:\\" + fileinfo.ToString(), true);

                }

            }
            public void deletar(DirectoryInfo dir)
            {

                FileInfo[] file = dir.GetFiles("*.TXT");

                foreach (FileInfo fileinfo in file)
                {

                    File.Delete(dir + fileinfo.ToString());

                }

            }

            // MÉTODO PARA LER OS ARQUIVOS NO DIRETORIO - RETORNA O DIRETORIO
            public DirectoryInfo lerConsulta(string importacao)
            {

                DirectoryInfo diretorio = new DirectoryInfo(importacao);
                return diretorio;

            }

        }
        private void frm_vend_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string importacao = Properties.Settings.Default.RECEBIDOS;
            DirectoryInfo import = new DirectoryInfo(importacao);

            Temp file = new Temp();
            // gerarConsulta(file.lerConsulta(importacao));
            //Thread gerar = new Thread(() => gerarConsulta(file.lerConsulta(importacao)));
            //gerar.Start();
        }

        private void ts_refresh_Click(object sender, EventArgs e)
        {
            //string importacao = Properties.Settings.Default.IMPORTACAO;
            //DirectoryInfo import = new DirectoryInfo(importacao);

            //Temp file = new Temp();
            String query = "SELECT * FROM ST_VENDEDORES";

            montarResultado(query, dgv_vend);
            //gerarConsulta(file.lerConsulta(importacao),"VENDEDORES", dgv_vend);
            //Thread gerar = new Thread(() => gerarConsulta(file.lerConsulta(importacao)));
            //gerar.Start();
        }

        private void ts_prod_refresh_Click(object sender, EventArgs e)
        {
            string importacao = Properties.Settings.Default.RECEBIDOS;
            DirectoryInfo import = new DirectoryInfo(importacao);
            
            Temp file = new Temp();
            gerarConsulta(file.lerConsulta(importacao), "PRODUTOS", dgv_prod);
            //Thread gerar = new Thread(() => gerarConsulta(file.lerConsulta(importacao)));
            //gerar.Start();
        }
    }
}
