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
    public partial class frm_main : Form
    {

        public frm_main()
        {
            InitializeComponent();

            if (!ConexaoLoad())
            {
                tool_home.Enabled = false;
                menu_ts_trans.Visible = false;
                menu_ts_consultas.Visible = false;
            }
            else {
                String form = "frm_dashboard";
                frm_dashboard dash = new frm_dashboard();
                abrirForm(form, dash, this);
            }


        }

        // CLASSE USADA PARA INICIAR AS CONEXÕES
        public class Conexao
        {
            // CAPTURA OS VALORES GRAVADOS NO APP [STRING DE CONEXAO]
            private static string connString =
                "Server=" + Properties.Settings.Default.IP
                + "," + Properties.Settings.Default.PORT
                + ";Database=" + Properties.Settings.Default.DATABASE
                + ";User Id=" + Properties.Settings.Default.USER
                + ";Password=" + Properties.Settings.Default.PASS;


            // REPRESENTA A CONEXAO COM O BANCO
            private static SqlConnection conn;// = null;

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


        public void montarResultado(SqlConnection conexao, string nome_arquivo, string query)
        {

            try
            {
                SqlCommand retorno = new SqlCommand(query, conexao);
                SqlDataReader row = retorno.ExecuteReader();

                // CRIANDO UM  E POPULANDO UM DATATABLE COM O RETORNO DA QUERY
                DataTable tabela = new DataTable();
                tabela.Load(row);

                // CONTANDO O TOTAL DE LINHAS DO RETORNO PARA O VALOR MAXIMO DA PROGRESSBAR
                int rows = tabela.Rows.Count;


                // LAÇO DA TABELA
                using (SqlDataReader DR = retorno.ExecuteReader())
                {


                    // SE A CONSULTA RETORNAR LINHAS
                    if (DR.HasRows)
                    {
                        // CAMINHO PADRÃO PARA EXPORTAÇÃO DOS ARQUIVOS
                        string caminho = Properties.Settings.Default.EXPORTACAO + "\\";

                        // CRIANDO O ARQUIVO PARA A GRAVAÇÃO DOS DADOS
                        StreamWriter valor = new StreamWriter(caminho + nome_arquivo, false, Encoding.GetEncoding("ISO-8859-1"));

                        // ATUALIZANDO O LABEL DO PROGRESS
                        ss_main.Invoke(new Action(() => lb_progress.Text = "EXPORTANDO -> " + nome_arquivo));

                        Thread.Sleep(500);

                        // ENQUANTO HOUVER LEITURA NAS LINHAS DO RETORNO
                        while (DR.Read())
                        {

                       
                                // LAÇO PARA LER AS COLUNAS DA LINHA
                                for (int i = 0; i < DR.FieldCount; i++)
                                {

                                    valor.Write(DR[i] + "\t");


                                }


                            // QUEBRA DE LINHA
                            valor.WriteLine();

                        }

                        // FECHA O ARQUIVO
                        valor.Close();


                    }

                   

                }

            }

            catch (Exception erro)
            {

                MessageBox.Show("Erro ao exportar o arquivo " + nome_arquivo + "\n\nDetalhe do erro: " + erro.Message);

            }
        }

        public void gerarArquivos(DirectoryInfo arquivos)
        {
            // EXIBINDO O PROGRESS E O LABEL
            ss_main.Invoke(new Action(() => img_tick.Visible = true));
            ss_main.Invoke(new Action(() => img_tick.Image = Properties.Resources.loader2));
            ss_main.Invoke(new Action(() => lb_progress.Visible = true));
            ss_main.Invoke(new Action(() => lb_progress.Text = "CONECTANTO COM A BASE DE DADOS... "));

            // STRING QUE RECEBE O DIRETÓRIO    
            string diretorio = Properties.Settings.Default.IMPORTACAO + "\\";

            try {

                // INSTANCIANDO UMA NOVA CONEXAO
                SqlConnection conn = Conexao.obterConexao();

                if (conn != null && conn.State != ConnectionState.Closed)
                {
                    // OBTENDO OS ARQUIVOS PARA MONTAR QUERY
                    FileInfo[] file = arquivos.GetFiles("*.TXT");
                    foreach (FileInfo fileinfo in file)
                    {

                        // CAPTURANDO O ARQUVIO
                        string query = string.Empty;
                        string arquivo = fileinfo.ToString();

                        // LENDO O ARQUIVO
                        System.IO.StreamReader sr = new StreamReader(diretorio + arquivo);
                        string line = sr.ReadLine();

                        // LAÇO PA CONCATENAR AS LINHAS E MONTAR A QUERY
                        while (line != null)
                        {
                            query += line;
                            line = sr.ReadLine();
                        }

                        // AQUI DECIDE O QUE FAZER COM A QUERY GERADA
                        //GravarTXT(conn, arquivo, query);
                        montarResultado(conn, arquivo, query);
                        // FECHANDO O OBJETO STREAMREADER
                        sr.Close();

                    }

                    // FECHANDO A CONEXAO COM O BANCO
                    Conexao.fecharConexao(conn);
                    DateTime dt = DateTime.Now;
                    string data = (string.Format("{0:dd/MM/yyyy}", dt));
                    string hora = (string.Format("{0:HH:mm}", dt));
                    Properties.Settings.Default.LASTEXPORT = "ÚLTIMA EXPORTAÇÃO FINALIZADA EM " + data + " ÀS " + hora;
                    Properties.Settings.Default.Save();
                    Properties.Settings.Default.Reload();
                    ss_main.Invoke(new Action(() => img_tick.Image = Properties.Resources.tick));
                    ss_main.Invoke(new Action(() => lb_progress.Text = Properties.Settings.Default.LASTEXPORT));
                }
                else {
                    ss_main.Invoke(new Action(() => img_tick.Image = Properties.Resources.error));
                    ss_main.Invoke(new Action(() => lb_progress.Visible = true));
                    ss_main.Invoke(new Action(() => lb_progress.Text = "BASE DE DADOS INDISPONÍVEL NO MOMENTO."));
                    MessageBox.Show("Não foi possível conectar com a base de dados.","Erro.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
  

            }
            catch(Exception e)
            {
                ss_main.Invoke(new Action(() => img_tick.Image = Properties.Resources.error));
                ss_main.Invoke(new Action(() => lb_progress.Visible = true));
                ss_main.Invoke(new Action(() => lb_progress.Text = "BASE DE DADOS INDISPONÍVEL NO MOMENTO."));
                MessageBox.Show("Não foi possível conectar com a base de dados.\n\nDetalhe do erro: " + e.Message, "Erro.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

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

        private bool exportarArquivos()
        {

            bool result = false;
            // TESTA SE EXISTE CAMINHO PARA EXPORTAÇÃO
            if (Properties.Settings.Default.EXPORTACAO == "")
            {

                // SE NÃO EXISTIR EXIBE MENSAGEM
                MessageBox.Show("Defina o caminho para a exportação do arquivo!", "Erro");

                // ABRE A TELA PARA DEFINIR O CAMINHO
                frm_file exp = new frm_file();
                exp.ShowDialog();
                

            }
            else
            {


                string importacao = Properties.Settings.Default.IMPORTACAO;
                DirectoryInfo import = new DirectoryInfo(importacao);

                Temp file = new Temp();

                gerarArquivos(file.lerConsulta(importacao));

                result = true;

            }

            return result;

        }

        public void logout() {

            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                if (Application.OpenForms[i].Name != "frm_main")
                    Application.OpenForms[i].Close();
            }

            //String form = "frm_login";
            frm_login login = new frm_login();
            login.ShowDialog();

        }

        private void frm_main_Load(object sender, EventArgs e)
        {

            this.MinimumSize = new System.Drawing.Size(this.Width, this.Height);
            pb_close.Location = new Point(this.Width - 60, 30);
            pb_change.Location = new Point(this.Width - 100, 30);
            //CheckForIllegalCrossThreadCalls = false;




            //lb_status.Text = "CONECTADO EM -> [" + Properties.Settings.Default.DATABASE+"]";
            //pb_status.Image = Properties.Resources.ic_circle_filled_green;

            bool result = false;
            Thread thread = new Thread(() => {
                
                result  = ConexaoLoad();

            });

            thread.Start();
            thread.Join();

            if (result) {

                img_tick.Visible = true;
                lb_progress.Visible = true;

                if (Properties.Settings.Default.LASTEXPORT != "")
                {
                    
                    lb_progress.Text = Properties.Settings.Default.LASTEXPORT;
                    
                }
                else {

                    img_tick.Image = Properties.Resources.ic_circle_filled_green;
                    lb_progress.Text = "CONECTADO - > [" + Properties.Settings.Default.DATABASE + "]";
                }

            }
            else {

                img_tick.Visible = true;
                img_tick.Image = Properties.Resources.ic_circle_filled_red;
                lb_progress.Visible = true;
                lb_progress.Text = "Desconectado!";
                //var d = new ThreadExceptionDialog(e);
                //d.ShowDialog();

            }


        }

        public bool formAberto(String form) {

            try {

                if (Application.OpenForms[form] != null) {
                    return true;
                }
            }
            catch(Exception ex) {
            }

            return false;
        }

        public void abrirForm(String form, Form origem, Form destino)
        {

            origem.MdiParent = destino;
            
            if (formAberto(form))
            {
                Application.OpenForms[form].BringToFront();
            }
            else
            {
                origem.Show();
            }

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bancoDeDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String form = "frm_db";
            frm_db db = new frm_db();
            abrirForm(form, db, this);

        }

        private void fTPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String form = "frm_ftp";
            frm_ftp ftp = new frm_ftp();
            abrirForm(form, ftp, this);
  
        }

        private void ag_ts_Click(object sender, EventArgs e)
        {
            String form = "frm_ag";
            frm_ag ag = new frm_ag();
            abrirForm(form, ag, this);

        }

        private void ms_main_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ts_ftp_Click(object sender, EventArgs e)
        {
            String form = "frm_ftp";
            frm_ftp ftp = new frm_ftp();
            abrirForm(form, ftp, this);

        }


        private void ts_db_Click(object sender, EventArgs e)
        {
            String form = "frm_db";
            frm_db db = new frm_db();
            abrirForm(form, db, this);

        }

        private void tool_ag_Click(object sender, EventArgs e)
        {
            String form = "frm_ag";
            frm_ag ag = new frm_ag();
            abrirForm(form, ag, this);

        }

        private void tool_file_Click(object sender, EventArgs e)
        {
            String form = "frm_file";
            frm_file file = new frm_file();
            abrirForm(form, file, this);

        }

        private void menu_ts_env_rec_Click(object sender, EventArgs e)
        {
            String form = "frm_file";
            frm_file file = new frm_file();
            abrirForm(form, file, this);

        }


        private void dashToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String form = "frm_dash";
            frm_dash dash = new frm_dash();
            abrirForm(form, dash, this);

        }

        private void pb_cancel_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            else
            {
                Application.Exit();
            }
        }

        private void menu_ts_sobre_Click(object sender, EventArgs e)
        {
            //string importacao = Properties.Settings.Default.IMPORTACAO;
            //DirectoryInfo import = new DirectoryInfo(importacao);

            frm_sobre sobre = new frm_sobre();
            sobre.ShowDialog();

            //Temp file = new Temp();

            //Thread gerar = new Thread(() => gerarConsulta(file.lerConsulta(importacao)));
            //gerar.Start();
            
        }

        private void tool_home_Click(object sender, EventArgs e)
        {
            String form = "frm_dashboard";
            frm_dashboard dash = new frm_dashboard();
            abrirForm(form, dash, this);

        }

        private void menu_ts_vend_Click(object sender, EventArgs e)
        {
            String form = "frm_vend";
            frm_vend vend = new frm_vend();
            abrirForm(form, vend, this);

        }

        private void gerar_pc_mobile_Click(object sender, EventArgs e)
        {

            Thread gerar = new Thread(() => exportarArquivos());
            gerar.Start();


        }

        private void tool_gerar_Click(object sender, EventArgs e)
        {
            
            Thread gerar = new Thread(() => exportarArquivos());
            gerar.Start();
        }

        private void tool_ajuda_Click(object sender, EventArgs e)
        {
            //String form = "frm_login";
            frm_login db = new frm_login();
            db.ShowDialog();

            /*if (formAberto(form))
            {
                Application.OpenForms[form].BringToFront();


            }
            else
            {
                abrirForm(db, this);
            }*/
        }

        private void pb_change_Click(object sender, EventArgs e)
        {
            logout();
        }

        private void menu_ts_logout_Click(object sender, EventArgs e)
        {
            logout();
        }

        private void menu_ts_change_pass_Click(object sender, EventArgs e)
        {
            //String form = "frm_login";
            frm_pass pass = new frm_pass();
            pass.ShowDialog();
        }
    }
}
