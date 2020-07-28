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
using System.Net;
using System.Security;
using System.Xml;
using System.Xml.Linq;

namespace Integrador
{

    public partial class frm_main : Form
    {

        public frm_main()
        {

            String[] arguments = Environment.GetCommandLineArgs();
            

            if (arguments.Length > 2 && arguments[1] == "--site")
            {

                Console.WriteLine(arguments[1]);
                //frm_main f = new frm_main();
                //f.gerarCargaVendedores("TODOS OS VENDEDORES", false);
            }
            else {


                Util.Arquivo u = new Util.Arquivo();
                u.createFolder("\\Sonic", true);
                u.createFolder("\\Sonic\\Usuarios", true);
                u.createFolder("\\Sonic\\Recebidos", true);
                u.createFolder("\\Sonic\\Processados", true);
                u.createFolder("\\Sonic\\Usuarios", true);
                u.createFolder("\\Sonic\\Querys", true);
                u.createFolder("\\Sonic\\Sites", true);
                u.createFolder("\\Sonic\\Imagens", true);
                u.createFolder("\\Sonic\\Ceps", true);

                if (Properties.Settings.Default.SITE == "")
                {

                    //frm_site s = new frm_site();
                    //s.Show();
                    Application.Run(new frm_site());
                }
                else
                {

                    InitializeComponent();
                    //notifyIcon1.Icon = new Icon(GetType(), "add.ico");
                    loadDashboard();
                    Conexao conn = new Conexao();
                }


            }



        }

        public void loadDashboard() {

            if (!Conexao.validarConexao())
            {
                tool_home.Enabled = false;
                menu_ts_trans.Visible = false;
                menu_ts_consultas.Visible = false;
            }
            else
            {
                String form = "frm_dashboard";
                frm_dashboard dash = new frm_dashboard();
                abrirForm(form, dash, this);

            }

        }

        public void montarResultadoSite(SqlConnection conexao, string nome_arquivo, string query)
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

                // CAMINHO PADRÃO PARA GERAÇÃO DO(S) ARQUIVO(S)
                string caminho = Properties.Settings.Default.SITES + "\\";

                // NOME DA SAIDA DO(S) ARQUIVO(S)
                String site = Properties.Settings.Default.SITE + ".TXT";


                // LAÇO DA TABELA
                using (SqlDataReader DR = retorno.ExecuteReader())
                {

                    // SE A CONSULTA RETORNAR LINHAS
                    if (DR.HasRows)
                    {

                        // CRIANDO O ARQUIVO PARA A GRAVAÇÃO DOS DADOS
                        StreamWriter valor = new StreamWriter(caminho + site, true, Encoding.GetEncoding("ISO-8859-1"));

                        // ATUALIZANDO O LABEL DO PROGRESS
                        lb_progress.Text = "EXPORTANDO -> " + nome_arquivo.Substring(3);

                        //Thread.Sleep(100);

                        String file = nome_arquivo.Replace(".TXT", "");
                        String secao = file.Substring(3);
                        valor.Write("[" + secao + "]");
                        valor.WriteLine();

                        int a = 1;

                        // ENQUANTO HOUVER LEITURA NAS LINHAS DO RETORNO
                        while (DR.Read())
                        {

                            valor.Write(a + "=");

                            // LAÇO PARA LER AS COLUNAS DA LINHA
                            for (int i = 0; i < DR.FieldCount; i++)
                            {

                                valor.Write(DR[i] + ";", true);

                            }

                            // QUEBRA DE LINHA
                            valor.WriteLine();
                            a++;

                        }

                        // FECHA O ARQUIVO
                        valor.Close();

                    }

                }

            }

            catch (Exception ex)
            {

                MessageBox.Show("Erro ao exportar o arquivo " + nome_arquivo + "\n\nDetalhe do erro: " + ex.Message);
                new LogWriter(ex.Message, ex.StackTrace);
            }
            finally {

            }
        }

        public void montarResultadoSiteTabela(SqlConnection conexao, string secao, string query)
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

                // CAMINHO PADRÃO PARA GERAÇÃO DO(S) ARQUIVO(S)
                string caminho = Properties.Settings.Default.SITES + "\\";

                // NOME DA SAIDA DO(S) ARQUIVO(S)
                String site = Properties.Settings.Default.SITE + ".TXT";

                // CRIANDO O ARQUIVO PARA A GRAVAÇÃO DOS DADOS
                StreamWriter valor = new StreamWriter(caminho + site, true, Encoding.GetEncoding("ISO-8859-1"));
               

                // LAÇO DA TABELA
                using (SqlDataReader DR = retorno.ExecuteReader())
                {

   
                    valor.Write(secao);
                    // ATUALIZANDO O LABEL DO PROGRESS
                    lb_progress.Text = "EXPORTANDO -> " + secao;

                    // SE A CONSULTA RETORNAR LINHAS
                    if (DR.HasRows)
                    {

                        valor.WriteLine();
                        valor.Write("###TOTAL=" + rows);
                        valor.WriteLine();
                        valor.Write("###COLUNAS(SEQUENCIAL=;");
                        for (int i = 0; i < DR.FieldCount; i++)
                        {
                            valor.Write(DR.GetName(i) + ";");
                        }
                        valor.Write(")");
                        valor.WriteLine();
                        int a = 1;

                        // ENQUANTO HOUVER LEITURA NAS LINHAS DO RETORNO
                        while (DR.Read())
                        {

                            valor.Write(a + "=");


                            // LAÇO PARA LER AS COLUNAS DA LINHA
                            for (int i = 0; i < DR.FieldCount; i++)
                            {

                                valor.Write(DR[i] + ";", true);

                            }

                            // QUEBRA DE LINHA
                            valor.WriteLine();
                            a++;

                        }

                        // FECHA O ARQUIVO
                        valor.Close();

                    }

                }

            }

            catch (Exception ex)
            {

                MessageBox.Show("Erro ao exportar o arquivo " + secao + "\n\nDetalhe do erro: " + ex.Message);
                new LogWriter(ex.Message, ex.StackTrace);
            }
        }

        public void montarResultadoSiteTabelaXML(SqlConnection conexao, string secao, string query)
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

                // CAMINHO PADRÃO PARA GERAÇÃO DO(S) ARQUIVO(S)
                string caminho = Properties.Settings.Default.SITES + "\\";

                // NOME DA SAIDA DO(S) ARQUIVO(S)
                String site = Properties.Settings.Default.SITE + ".xml";

                // LAÇO DA TABELA
                using (SqlDataReader DR = retorno.ExecuteReader())
                {

                    lb_progress.Text = "EXPORTANDO -> " + secao;
                   
                    if (!File.Exists(caminho + site))
                    {

                        using (XmlTextWriter writer = new XmlTextWriter(@caminho + site, Encoding.GetEncoding("ISO-8859-1")))
                        {
                            writer.WriteStartDocument();
                            writer.Formatting = Formatting.Indented;
                            writer.WriteStartElement("dados");

                            if (DR.HasRows)
                            {
                                List<string> mylistColumn = new List<string>();
                                mylistColumn.Add("SEQUENCIAL=");
                                for (int i = 0; i < DR.FieldCount; i++)
                                {
                                    mylistColumn.Add(DR.GetName(i));
                                }
                                writer.WriteStartElement("secao");
                                writer.WriteAttributeString("nome", secao);
                                writer.WriteElementString("colunas", string.Join("|", mylistColumn.ToArray()));

                                int a = 1;

                                while (DR.Read())
                                {

                                    List<string> mylistValue = new List<string>();
                                    mylistValue.Add(a + "=");        
                                    for (int i = 0; i < DR.FieldCount; i++)
                                    {

                                        mylistValue.Add(DR[i].ToString());

                                    }

                                    writer.WriteElementString("valores", string.Join("|", mylistValue.ToArray()));

                                    a++;

                                }

                                writer.WriteElementString("total", rows + "");

                            }

                            writer.Close();
                        
                        }

                    }
                    else {

                        XDocument doc = XDocument.Load(@caminho + site);
                        XElement root = new XElement("secao");

                        
                       
                        if (DR.HasRows)
                            {

                            List<string> mylistColumn = new List<string>();
                            mylistColumn.Add("SEQUENCIAL=");
                            for (int i = 0; i < DR.FieldCount; i++)
                                {
                                    mylistColumn.Add(DR.GetName(i));
                                }

                            root.Add(new XAttribute("nome", secao));
                            root.Add(new XElement("colunas", string.Join("|", mylistColumn.ToArray())));

                            int a = 1;
                            
                            while (DR.Read())
                                {
                             
                                List<string> mylistValues = new List<string>();
                                mylistValues.Add(a+"=");
                                for (int i = 0; i < DR.FieldCount; i++)
                                    {

                                        mylistValues.Add(DR[i].ToString());

                                    }

                                root.Add(new XElement("valores", string.Join("|", mylistValues.ToArray())));

                                a++;

                                }

                        }

                        root.Add(new XElement("total", rows));
                        doc.Element("dados").Add(root);
                        doc.Save(@caminho+site);
                        

                    }

                }
                
            }

            catch (Exception ex)
            {

                MessageBox.Show("Erro ao exportar o arquivo " + secao + "\n\nDetalhe do erro: " + ex.Message);
                new LogWriter(ex.Message, ex.StackTrace);
            }
        }

        public void gerarCargaVendedores(SqlConnection conexao, string saida, string secao, string query)
        {

            try
            {
                SqlCommand retorno = new SqlCommand(query, conexao);
                SqlDataReader row = retorno.ExecuteReader();

                // CRIANDO E POPULANDO UM DATATABLE COM O RETORNO DA QUERY
                DataTable tabela = new DataTable();
                tabela.Load(row);

                // CONTANDO O TOTAL DE LINHAS DO RETORNO PARA O VALOR MAXIMO DA PROGRESSBAR
                int rows = tabela.Rows.Count;

                // CAMINHO PADRÃO PARA GERAÇÃO DO(S) ARQUIVO(S)
                string caminho = Properties.Settings.Default.USUARIOS + "\\";

                // LAÇO DA TABELA
                using (SqlDataReader DR = retorno.ExecuteReader())
                {

                    // CRIANDO O ARQUIVO PARA A GRAVAÇÃO DOS DADOS
                    StreamWriter valor = new StreamWriter(caminho + saida, true, Encoding.GetEncoding("ISO-8859-1"));

                    valor.Write(secao);

                    // SE A CONSULTA RETORNAR LINHAS
                    if (DR.HasRows)
                    {

                        valor.WriteLine();
                        valor.Write("###TOTAL="+rows);
                        valor.WriteLine();
                        valor.Write("###COLUNAS(SEQUENCIAL=;");
                        for (int i = 0; i < DR.FieldCount; i++)
                        {
                            valor.Write(DR.GetName(i)+";");
                        }
                        valor.Write(")");
                        valor.WriteLine();
                        int a = 1;

                        // ENQUANTO HOUVER LEITURA NAS LINHAS DO RETORNO
                        while (DR.Read())
                        {

                            valor.Write(a + "=");

                            // LAÇO PARA LER AS COLUNAS DA LINHA
                            for (int i = 0; i < DR.FieldCount; i++)
                            {

                                valor.Write(DR[i] + ";", true);

                            }

                            // QUEBRA DE LINHA
                            valor.WriteLine();
                            a++;

                        }

                        // FECHA O ARQUIVO
                        valor.Close();

                    }
                    else
                    {
                        valor.WriteLine();
                        valor.Close();
                    }

                }

            }

            catch (Exception ex)
            {

                MessageBox.Show("Erro ao exportar o arquivo " + saida + "\n\nDetalhe do erro: " + ex.Message);
                new LogWriter(ex.Message, ex.StackTrace);
            }
            finally {
                
            }
        }

        public void gerarCargaUsuariosXML(SqlConnection conexao, string saida, string secao, string query)
        {

            try
            {
                SqlCommand retorno = new SqlCommand(query, conexao);
                SqlDataReader row = retorno.ExecuteReader();

                // CRIANDO E POPULANDO UM DATATABLE COM O RETORNO DA QUERY
                DataTable tabela = new DataTable();
                tabela.Load(row);

                // CONTANDO O TOTAL DE LINHAS DO RETORNO PARA O VALOR MAXIMO DA PROGRESSBAR
                int rows = tabela.Rows.Count;

                // CAMINHO PADRÃO PARA GERAÇÃO DO(S) ARQUIVO(S)
                string caminho = Properties.Settings.Default.USUARIOS + "\\";

                // LAÇO DA TABELA
                using (SqlDataReader DR = retorno.ExecuteReader())
                {


                    if (!File.Exists(caminho + saida))
                    {

                        using (XmlTextWriter writer = new XmlTextWriter(@caminho + saida, Encoding.GetEncoding("UTF-8")))
                        {
                            writer.WriteStartDocument();
                            writer.Formatting = Formatting.Indented;
                            writer.WriteStartElement("dados");
                            writer.WriteStartElement("secao");
                            writer.WriteAttributeString("nome", secao);

                            List<string> mylistColumn = new List<string>();
                            mylistColumn.Add("SEQUENCIAL=");
                            for (int i = 0; i < DR.FieldCount; i++)
                            {
                                mylistColumn.Add(DR.GetName(i));
                            }

                            writer.WriteElementString("colunas", string.Join("|", mylistColumn.ToArray()));

                            if (DR.HasRows)
                            {
                               
                                int a = 1;

                                while (DR.Read())
                                {

                                    List<string> mylistValue = new List<string>();
                                    mylistValue.Add(a + "=");
                                    for (int i = 0; i < DR.FieldCount; i++)
                                    {

                                        mylistValue.Add(DR[i].ToString());

                                    }

                                    writer.WriteElementString("valores", string.Join("|", mylistValue.ToArray()));

                                    a++;

                                }

                                writer.WriteElementString("total", rows + "");

                            }

                            writer.Close();

                        }

                    }
                    else
                    {

                        XDocument doc = XDocument.Load(@caminho + saida);
                        XElement root = new XElement("secao");

                        root.Add(new XAttribute("nome", secao));
                        List<string> mylistColumn = new List<string>();
                        mylistColumn.Add("SEQUENCIAL=");

                        for (int i = 0; i < DR.FieldCount; i++)
                        {
                            mylistColumn.Add(DR.GetName(i));
                        }

                        root.Add(new XElement("colunas", string.Join("|", mylistColumn.ToArray())));

                        if (DR.HasRows)
                        {

                           

                            int a = 1;

                            while (DR.Read())
                            {

                                List<string> mylistValues = new List<string>();
                                mylistValues.Add(a + "=");
                                for (int i = 0; i < DR.FieldCount; i++)
                                {

                                    mylistValues.Add(DR[i].ToString());

                                }

                                root.Add(new XElement("valores", string.Join("|", mylistValues.ToArray())));

                                a++;

                            }

                        }

                        root.Add(new XElement("total", rows));
                        doc.Element("dados").Add(root);
                        doc.Save(@caminho + saida);


                    }


                }

            }

            catch (Exception ex)
            {

                MessageBox.Show("Erro ao exportar o arquivo " + saida + "\n\nDetalhe do erro: " + ex.Message);
                new LogWriter(ex.Message, ex.StackTrace);
            }
            finally
            {

            }
        }


        public void montarSite(DirectoryInfo arquivos)
        {
            // EXIBINDO O PROGRESS E O LABEL
            img_tick.Visible = true;
            img_tick.Image = Properties.Resources.loader2;
            lb_progress.Visible = true;
            lb_progress.Text = "CONECTANTO COM A BASE DE DADOS... ";

            // APAGA TODOS OS ARQUIVOS DO DIRETORIO DE SITES
            DirectoryInfo di = new DirectoryInfo(Properties.Settings.Default.SITES);

            foreach (FileInfo file in di.GetFiles())
            {
                file.Delete();
            }
            foreach (DirectoryInfo dir in di.GetDirectories())
            {
                dir.Delete(true);
            }

            // STRING QUE RECEBE O DIRETÓRIO    
            string diretorio = Properties.Settings.Default.QUERYS + "\\";

            try
            {

                // INSTANCIANDO UMA NOVA CONEXAO
                SqlConnection conn = Conexao.obterConexao();

                if (conn != null && conn.State != ConnectionState.Closed)
                {
                    // OBTENDO OS ARQUIVOS PARA MONTAR QUERY
                    FileInfo[] file = arquivos.GetFiles("*.TXT");

                    if (file.Length > 0)
                    {

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
                            montarResultadoSite(conn, arquivo, query);
                            // FECHANDO O OBJETO STREAMREADER
                            sr.Close();

                        }

                    }
                    else
                    {

                        img_tick.Image = Properties.Resources.error;
                        lb_progress.Visible = true;
                        lb_progress.Text = "BASE DE DADOS INDISPONÍVEL NO MOMENTO.";
                        MessageBox.Show("Não existem arquivos no diretório " + Properties.Settings.Default.QUERYS, "Erro.", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }

                    // FECHANDO A CONEXAO COM O BANCO
                    Conexao.fecharConexao();
                    DateTime dt = DateTime.Now;
                    string data = (string.Format("{0:dd/MM/yyyy}", dt));
                    string hora = (string.Format("{0:HH:mm}", dt));
                    Properties.Settings.Default.LASTEXPORT = "ÚLTIMA EXPORTAÇÃO FINALIZADA EM " + data + " ÀS " + hora;
                    Properties.Settings.Default.Save();
                    Properties.Settings.Default.Reload();
                    img_tick.Image = Properties.Resources.tick;
                    lb_progress.Text = Properties.Settings.Default.LASTEXPORT;

                   

                }
                else
                {
                    img_tick.Image = Properties.Resources.error;
                    lb_progress.Visible = true;
                    lb_progress.Text = "BASE DE DADOS INDISPONÍVEL NO MOMENTO.";
                    MessageBox.Show("Não foi possível realizar a operação.", "Erro.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


            }
            catch (SqlException ex)
            {
                img_tick.Image = Properties.Resources.error;
                lb_progress.Visible = true;
                lb_progress.Text = "BASE DE DADOS INDISPONÍVEL NO MOMENTO.";
                MessageBox.Show("Não foi possível realizar a operação.\n\nDetalhe do erro: " + ex.Message, "Erro.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                new LogWriter(ex.Message, ex.StackTrace);
            }
            finally {

                

            }


        }

        public void montarCargaVendedores(DirectoryInfo diretorio, String vendedor, bool transmitir)
        {
            // EXIBINDO O PROGRESS E O LABEL
            img_tick.Visible = true;
            img_tick.Image = Properties.Resources.loader2;
            lb_progress.Visible = true;
            lb_progress.Text = "CONECTANTO COM A BASE DE DADOS... ";

            String[] id = null;
            String[] name = null;
            String select = String.Empty;
            int inicio = vendedor.IndexOf("-");
            String nome = vendedor.Substring(inicio + 2, vendedor.Length - (inicio + 2));

            if (vendedor == "TODOS OS USUARIOS")
            {
                select = "SELECT SU.CODIGO_USUARIO, SU.NOME FROM SONIC_USUARIOS SU";
            }
            else
            {
                select = "SELECT SU.CODIGO_USUARIO, SU.NOME FROM SONIC_USUARIOS SU WHERE SU.NOME = '" + nome + "'";
            }

            // APAGA TODOS OS ARQUIVOS DO DIRETORIO DE VENDEDORES
            DirectoryInfo vend = new DirectoryInfo(Properties.Settings.Default.USUARIOS);

            try
            {

                // INSTANCIANDO UMA NOVA CONEXAO
                SqlConnection connect = Conexao.obterConexao();

                //PREPARA O SELECT
                SqlCommand retorno = new SqlCommand(select, connect);

                //EXECUTA O SELECT
                SqlDataReader row = retorno.ExecuteReader();

                // CRIANDO E POPULA UM DATATABLE COM O RETORNO DO SELECT
                DataTable tabela = new DataTable();
                tabela.Load(row);

                // CONTANDO O TOTAL DE LINHAS DO RETORNO
                int rows = tabela.Rows.Count;

                using (SqlDataReader DR = retorno.ExecuteReader())
                {

                    // SE A CONSULTA RETORNAR LINHAS
                    if (DR.HasRows)
                    {

                        // ALIMENTA OS VALORES EM UM OBJETO
                        object[] values = new object[DR.FieldCount];

                        // INSTACIA AS VARIAVEIA ARA ARMAZENAR O ID E O NOME DO VENDEDOR
                        id = new string[rows];
                        name = new string[rows];

                        // LAÇO PARA PREENCHER AS VARIÁVEIS
                        int i = 1;
                        while (DR.Read())
                        {

                            DR.GetValues(values);

                            id[i - 1] = values[0].ToString();
                            name[i - 1] = values[1].ToString();

                            i++;

                        }

                    }
                }

                if (connect != null && connect.State != ConnectionState.Closed)
                {
                    // OBTENDO OS ARQUIVOS PARA MONTAR QUERY
                    FileInfo[] file = diretorio.GetFiles("*.TXT");

                    if (file.Length > 0)

                    {

                        foreach (FileInfo fileinfo in file)
                        {

                            // CAPTURANDO O ARQUVIO
                            string query = string.Empty;
                            string arquivo = fileinfo.ToString();

                            // LAÇO PARA CADA VENDEDOR SELECIONADO
                            for (int x = 0; x < rows; x++)
                            {

                                StreamReader sr = new StreamReader(diretorio + "\\" + arquivo);

                                String secao = "";
                                String saida = id[x].PadLeft(5, '0') + ".TXT";
                                String pessoa = name[x];
                                String line = sr.ReadLine();

                                DirectoryInfo di = new DirectoryInfo(Properties.Settings.Default.USUARIOS);

                                foreach (FileInfo txt in di.GetFiles(saida))
                                {
                                    txt.Delete();
                                }

                                int count = x + 1;
                                lb_progress.Text = "EXPORTANDO -> " + pessoa + " [" + saida + "] - " + count + "/" + rows;

                                // LAÇO PARA CONCATENAR AS LINHAS E MONTAR CADA QUERY CONTIDA NO ARQUIVO
                                while (!sr.EndOfStream)
                                {

                                    while (line.IndexOf("}") != 0)
                                    {

                                        if (line.IndexOf("{") == 0 || line == null || line.Equals("\n") || line.Equals("\t"))
                                        {
                                            line = sr.ReadLine();
                                        }
                                        else
                                        {
                                            query += line;
                                        }

                                        if (line.IndexOf("[") == 0)
                                        {
                                            secao = line;
                                        }

                                        //query += line;
                                        line = sr.ReadLine();
                                        query = query.Replace("%$%", id[x]);
                                        query = query.Replace("\r\n", " ");
                                        query = query.Replace("\t", " ");


                                    }
                                    if (query != null && query.Equals("") == false)
                                    {

                                        gerarCargaVendedores(connect, saida, secao, query);

                                    }

                                    line = sr.ReadLine();
                                    query = "";

                                }

                                sr.Close();

                            }

                        }

                    }
                    else
                    {
                        img_tick.Image = Properties.Resources.error;
                        lb_progress.Visible = true;
                        lb_progress.Text = "BASE DE DADOS INDISPONÍVEL NO MOMENTO.";
                        MessageBox.Show("Não há arquivos no diretório " + diretorio, "Erro.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    if (transmitir)
                    {
                        enviarCargaParaFtp();
                    }
                    else
                    {

                        // FECHANDO A CONEXAO COM O BANCO
                        Conexao.fecharConexao();
                        DateTime dt = DateTime.Now;
                        string data = (string.Format("{0:dd/MM/yyyy}", dt));
                        string hora = (string.Format("{0:HH:mm}", dt));
                        Properties.Settings.Default.LASTEXPORT = "ÚLTIMA EXPORTAÇÃO FINALIZADA EM " + data + " ÀS " + hora;
                        Properties.Settings.Default.Save();
                        Properties.Settings.Default.Reload();
                        img_tick.Image = Properties.Resources.tick;
                        lb_progress.Text = Properties.Settings.Default.LASTEXPORT;

                    }

                }
                else
                {
                    img_tick.Image = Properties.Resources.error;
                    lb_progress.Visible = true;
                    lb_progress.Text = "BASE DE DADOS INDISPONÍVEL NO MOMENTO.";
                    MessageBox.Show("Não foi possível realizar a operação.", "Erro.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }



            }
            catch (SqlException ex)
            {
                img_tick.Image = Properties.Resources.error;
                lb_progress.Visible = true;
                lb_progress.Text = "BASE DE DADOS INDISPONÍVEL NO MOMENTO.";
                MessageBox.Show("Não foi possível realizar a operação.\n\nDetalhe do erro: " + ex.Message, "Erro.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                new LogWriter(ex.Message, ex.StackTrace);
            }
            finally {
                
            }

        }

        public void montarSiteTabela()
        {
            // EXIBINDO O PROGRESS E O LABEL
            img_tick.Visible = true;
            img_tick.Image = Properties.Resources.loader2;
            lb_progress.Visible = true;
            lb_progress.Text = "CONECTANTO COM A BASE DE DADOS... ";

            // APAGA TODOS OS ARQUIVOS DO DIRETORIO DE SITES
            DirectoryInfo di = new DirectoryInfo(Properties.Settings.Default.SITES);

            foreach (FileInfo file in di.GetFiles())
            {
                file.Delete();
            }
            foreach (DirectoryInfo dir in di.GetDirectories())
            {
                dir.Delete(true);
            }

            // STRING QUE RECEBE O DIRETÓRIO    
            string diretorio = Properties.Settings.Default.QUERYS + "\\";

            try
            {

                // INSTANCIANDO UMA NOVA CONEXAO
                SqlConnection conn = Conexao.obterConexao();

                if (conn != null && conn.State != ConnectionState.Closed)
                {
                    // OBTENDO OS ARQUIVOS PARA MONTAR QUERY
                    //FileInfo[] file = arquivos.GetFiles("*.TXT");

                    // CAPTURANDO O ARQUVIO
                    //string query = string.Empty;
                    String carga = "SELECT * FROM SONIC_SECAO_SITE ORDER BY id";
                    //PREPARA O SELECT
                    SqlCommand result = new SqlCommand(carga, conn);

                    //EXECUTA O SELECT
                    SqlDataReader row = result.ExecuteReader();

                    // CRIANDO E POPULA UM DATATABLE COM O RETORNO DO SELECT
                    DataTable lista = new DataTable();
                    lista.Load(row);

                    DataGridView dgv = new DataGridView();
                    dgv.DataSource = lista;

                    // CONTANDO O TOTAL DE LINHAS DO RETORNO
                    int countQuery = lista.Rows.Count;

                    // SE HOUVER ALGUMA SEÇÃO CADASTRADA NA TABELA QUERY
                    if (countQuery > 0)
                    {

                        Database db = new Database();

                        db.saveSincronizacao("saida", "site");
                        db.saveSincronizacaoItens(Properties.Settings.Default.SITE+".TXT");
                        db.closeConn();

                        String query = String.Empty;
                        String secao = String.Empty;
                        for (int x = 0; x < countQuery; x++)
                        {
                           
                            query = lista.Rows[x].ItemArray[3].ToString();
                            secao = lista.Rows[x].ItemArray[2].ToString();

                            // AQUI DECIDE O QUE FAZER COM A QUERY GERADA
                            //montarResultadoSiteTabela(conn, secao, query);
                            montarResultadoSiteTabelaXML(conn, secao, query);
                            // FECHANDO O OBJETO STREAMREADER

                        }

                    }
                    else
                    {

                        DialogResult res = MessageBox.Show("Não há nenhuma seção para gerar site. \n\nDeseja cadastrar agora?", "Atenção", MessageBoxButtons.YesNo);
                        if (res == DialogResult.Yes)
                        {
                            String form = "frm_query";
                            frm_query q = new frm_query();
                            abrirFormDialog(form, q);
                        }

                    }

                    // FECHANDO A CONEXAO COM O BANCO
                    Conexao.fecharConexao();
                    DateTime dt = DateTime.Now;
                    string data = (string.Format("{0:dd/MM/yyyy}", dt));
                    string hora = (string.Format("{0:HH:mm}", dt));
                    Properties.Settings.Default.LASTEXPORT = "ÚLTIMA EXPORTAÇÃO FINALIZADA EM " + data + " ÀS " + hora;
                    Properties.Settings.Default.Save();
                    Properties.Settings.Default.Reload();
                    img_tick.Image = Properties.Resources.tick;
                    lb_progress.Text = Properties.Settings.Default.LASTEXPORT;
                }
                else
                {
                    img_tick.Image = Properties.Resources.error;
                    lb_progress.Visible = true;
                    lb_progress.Text = "BASE DE DADOS INDISPONÍVEL NO MOMENTO.";
                    MessageBox.Show("Não foi possível realizar a operação.", "Erro.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


            }
            catch (SqlException ex)
            {
                img_tick.Image = Properties.Resources.error;
                lb_progress.Visible = true;
                lb_progress.Text = "BASE DE DADOS INDISPONÍVEL NO MOMENTO.";
                MessageBox.Show("Não foi possível realizar a operação.\n\nDetalhe do erro: " + ex.Message, "Erro.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                new LogWriter(ex.Message, ex.StackTrace);
            }
            finally {
               
            }

        }


        public void montarCargaUsuariosTabela(List<string> uId, List<string> uName, bool transmitir)
        {

            List<string> userId = uId;
            List<string> userName = uName;

            // EXIBINDO O PROGRESS E O LABEL
            img_tick.Visible = true;
            img_tick.Image = Properties.Resources.loader2;
            lb_progress.Visible = true;
            lb_progress.Text = "CONECTANTO COM A BASE DE DADOS... ";

            try
            {

                // INSTANCIANDO UMA NOVA CONEXAO
                SqlConnection connect = Conexao.obterConexao();

                if (connect != null && connect.State != ConnectionState.Closed)
                {

                    // CAPTURANDO O ARQUVIO
                    //string query = string.Empty;
                    String carga = "SELECT * FROM SONIC_SECAO_USUARIOS ORDER BY id";
                    //PREPARA O SELECT
                    SqlCommand result = new SqlCommand(carga, connect);

                    //EXECUTA O SELECT
                    SqlDataReader row = result.ExecuteReader();

                    // CRIANDO E POPULA UM DATATABLE COM O RETORNO DO SELECT
                    DataTable lista = new DataTable();
                    lista.Load(row);

                    DataGridView dgv = new DataGridView();
                    dgv.DataSource = lista;

                    // CONTANDO O TOTAL DE LINHAS DO RETORNO
                    int countQuery = lista.Rows.Count;

                    // SE HOUVER ALGUMA SEÇÃO CADASTRADA NA TABELA QUERY
                    if (countQuery > 0)
                    {

                        Database db = new Database();
                        db.saveSincronizacao("saida","carga");
                        String query = String.Empty;
                        String secao = String.Empty;
                        // LAÇO PARA CADA VENDEDOR SELECIONADO
                        for (int x = 0; x < userId.Count; x++)
                        {

                            String saida = userId[x].ToString().PadLeft(5, '0') + ".xml";
                            String pessoa = userName[x].ToString();

                            db.saveSincronizacaoItens(saida);

                            DirectoryInfo di = new DirectoryInfo(Properties.Settings.Default.USUARIOS);

                            if (di.Exists)
                            {
                                foreach (FileInfo txt in di.GetFiles(saida))
                                {
                                        txt.Delete();
                                }
                            }
                            else {

                                Util.Arquivo u = new Util.Arquivo();
                                u.createFolder(Properties.Settings.Default.USUARIOS, false);

                             }

             

                            int countVend = x + 1;
                            lb_progress.Text = "EXPORTANDO -> " + pessoa + " [" + saida + "] - " + countVend + "/" + userId.Count;

                            for (int y = 0; y < countQuery; y++)
                            {

                                query = lista.Rows[y].ItemArray[4].ToString();
                                secao = lista.Rows[y].ItemArray[2].ToString();
                                String z = String.Empty;
                                if (query.IndexOf("?") != -1 && query.Contains("?"))
                                {
                                   
                                    query = query.Replace("?", userId[x]);
                                    //MessageBox.Show(query.Replace("?", "A"));
                                    //MessageBox.Show(userId[x]);
                                    
                                }

                                //gerarCargaVendedores(connect, saida, secao, query);
                                gerarCargaUsuariosXML(connect, saida, secao, query);


                            }

                        }

                        db.closeConn();

                        if (transmitir)
                        {
                            enviarCargaParaFtp();
                        }
                        else
                        {

                            goto EndSuccess;

                        }

                    }

                    else
                    {

                        Conexao.fecharConexao();
                        img_tick.Image = Properties.Resources.tick;
                        lb_progress.Text = Properties.Settings.Default.LASTEXPORT;
                        DialogResult res = MessageBox.Show("Não há nenhuma seção cadastrada para gerar dados. \n\nDeseja cadastrar agora?", "Atenção", MessageBoxButtons.YesNo);

                        if (res == DialogResult.Yes)
                        {
                            String form = "frm_query";
                            frm_query q = new frm_query();
                            q.selectTab(1);
                            abrirFormDialog(form, q);
                                             
                        }

                        

                    }


                }
                else
                {
                    img_tick.Image = Properties.Resources.error;
                    lb_progress.Visible = true;
                    lb_progress.Text = "BASE DE DADOS INDISPONÍVEL NO MOMENTO.";
                    MessageBox.Show("Não foi possível realizar a operação.", "Erro.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            EndSuccess:

                // FECHANDO A CONEXAO COM O BANCO
                Conexao.fecharConexao();
                DateTime dt = DateTime.Now;
                string data = (string.Format("{0:dd/MM/yyyy}", dt));
                string hora = (string.Format("{0:HH:mm}", dt));
                Properties.Settings.Default.LASTEXPORT = "ÚLTIMA EXPORTAÇÃO FINALIZADA EM " + data + " ÀS " + hora;
                Properties.Settings.Default.Save();
                Properties.Settings.Default.Reload();
                img_tick.Image = Properties.Resources.tick;
                lb_progress.Text = Properties.Settings.Default.LASTEXPORT;


            }
            catch (SqlException ex)
            {
                img_tick.Image = Properties.Resources.error;
                lb_progress.Visible = true;
                lb_progress.Text = "BASE DE DADOS INDISPONÍVEL NO MOMENTO.";
                MessageBox.Show("Não foi possível realizar a operação.\n\nDetalhe do erro: " + ex.Message, "Erro.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                new LogWriter(ex.Message, ex.StackTrace);
            }
            finally {
                
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
            public DirectoryInfo lerArquivos(string caminho)
            {

                DirectoryInfo diretorio = new DirectoryInfo(caminho);
                return diretorio;

            }

        }

        private void gerarSite()
        {
            // TESTA SE EXISTE CAMINHO PARA EXPORTAÇÃO
            if (Properties.Settings.Default.QUERYS == "")
            {
                // SE NÃO EXISTIR EXIBE MENSAGEM
                MessageBox.Show("Defina o caminho para a geração do(s) arquivo(s)!", "Erro");

                // ABRE A TELA PARA DEFINIR O CAMINHO
                frm_file exp = new frm_file();
                exp.ShowDialog();
            }
            else
            {
                string query = Properties.Settings.Default.QUERYS;
                DirectoryInfo import = new DirectoryInfo(query);
                Temp file = new Temp();
                montarSite(file.lerArquivos(query));
            }

        }

        public bool listarArquivosCarga(String vendedor, bool transmitir)
        {

            bool result = false;
            // TESTA SE EXISTE CAMINHO PARA EXPORTAÇÃO
            if (Properties.Settings.Default.CARGA == "")
            {

                // SE NÃO EXISTIR EXIBE MENSAGEM
                MessageBox.Show("Defina o caminho para a geração do(s) arquivo(s)!", "Erro");

                // ABRE A TELA PARA DEFINIR O CAMINHO
                frm_file exp = new frm_file();
                exp.ShowDialog();

            }
            else
            {

                Temp file = new Temp();

                montarCargaVendedores(file.lerArquivos(Properties.Settings.Default.CARGA), vendedor, transmitir);

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

            frm_login login = new frm_login();
            login.ShowDialog();

        }

        private void frm_main_Load(object sender, EventArgs e)
        {

            string logfile = System.IO.Path.GetDirectoryName(Application.ExecutablePath)+"\\sonic.log";
            if (!File.Exists(logfile)) {
                File.Create(logfile).Dispose();
            }
            this.MinimumSize = new System.Drawing.Size(this.Width, this.Height);
            pb_close.Location = new Point(this.Width - 60, 30);
            pb_change.Location = new Point(this.Width - 100, 30);
            ss_main.Width = this.Width;
            lb_progress.Width = (ss_main.Width / 3)-15;
            ts_user.Width = (ss_main.Width / 3)-15;
            ts_hora.Width = (ss_main.Width / 3)-25;


            bool result = false;
            Thread thread = new Thread(() => {
                
                result  = Conexao.validarConexao();

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

            }

        }

        public bool formAberto(String form) {

            try {

                if (Application.OpenForms[form] != null) {
                    return true;
                }
            }
            catch(Exception ex) {
                MessageBox.Show(ex.ToString(), "Erro", MessageBoxButtons.OK);
                new LogWriter(ex.Message, ex.StackTrace);
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

        public void abrirFormDialog(String form, Form origem)
        {

            if (formAberto(form))
            {
                Application.OpenForms[form].BringToFront();
            }
            else
            {
                origem.ShowDialog();
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

  
        private void ts_ftp_Click(object sender, EventArgs e)
        {
            String form = "frm_ftp";
            frm_ftp ftp = new frm_ftp();
            abrirFormDialog(form, ftp);
        }

        private void ts_db_Click(object sender, EventArgs e)
        {
            String form = "frm_db";
            frm_db db = new frm_db();
            abrirFormDialog(form, db);
        }

        private void tool_ag_Click(object sender, EventArgs e)
        {
            String form = "frm_ag";
            frm_ag ag = new frm_ag();
            abrirFormDialog(form, ag);
        }

        private void tool_file_Click(object sender, EventArgs e)
        {
            String form = "frm_file";
            frm_file file = new frm_file();
            abrirFormDialog(form, file);
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
            frm_sobre sobre = new frm_sobre();
            sobre.ShowDialog();
        }

        private void tool_home_Click(object sender, EventArgs e)
        {
            String form = "frm_dashboard";
            frm_dashboard dashboard = new frm_dashboard();
            abrirForm(form, dashboard, this);

        }

        private void menu_ts_vend_Click(object sender, EventArgs e)
        {
            String form = "frm_vend";
            frm_vend vend = new frm_vend();
            abrirFormDialog(form, vend);

        }

        private void tool_gerar_Click(object sender, EventArgs e)
        {
            frm_carga f = new frm_carga();
            f.Owner = this;
            f.ShowDialog();
        }

        private void tool_ajuda_Click(object sender, EventArgs e)
        {
            frm_login db = new frm_login();
            db.ShowDialog();

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
            frm_pass pass = new frm_pass();
            pass.ShowDialog();
        }

        private void tool_sobre_Click(object sender, EventArgs e)
        {
            frm_sobre sobre = new frm_sobre();
            sobre.ShowDialog();
        }

        private void dragAndDropToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_drag_and_drop dad = new frm_drag_and_drop();
            dad.Show();
        }

        private void menu_ts_licenca_Click(object sender, EventArgs e)
        {
            frm_site site = new frm_site();
            site.ShowDialog();
        }

        private void gerar_carga_Click(object sender, EventArgs e)
        {
            frm_carga f = new frm_carga();
            f.Owner = this;
            f.ShowDialog();
        }

        private void gerar_site_Click(object sender, EventArgs e)
        {
            //Thread site = new Thread(() => gerarSite());
            //site.Start();
            Thread site = new Thread(() => montarSiteTabela());
            site.Start();
        }


        private void menu_ts_enviar_site_Click(object sender, EventArgs e)
        {
            if (!verificarDadosFTP())
            {
                MessageBox.Show("Defina os dados de conexão com o servidor FTP.", "Erro");
                frm_ftp f = new frm_ftp();
                f.ShowDialog();
            }
            else
            {
                enviarSite();
            }
        }

        private void menu_ts_enviar_carga_Click(object sender, EventArgs e)
        {
           if (!verificarDadosFTP())
            {
                MessageBox.Show("Defina os dados de conexão com o servidor FTP.", "Erro");
                frm_ftp f = new frm_ftp();
                f.ShowDialog();
            }

            else
            {
                enviarCargaParaFtp();
            }
        }

        private void menu_ts_enviar_imagens_Click(object sender, EventArgs e)
        {
           if (!verificarDadosFTP())
            {
                MessageBox.Show("Defina os dados de conexão com o servidor FTP.", "Erro");
                frm_ftp f = new frm_ftp();
                f.ShowDialog();
            }
            else
            {
                enviarImagensFTP();
            }
        }

        public bool verificarDadosFTP() {

            if (Properties.Settings.Default.FTP_EMPRESA_IP == ""
               || Properties.Settings.Default.FTP_EMPRESA_USER == ""
               || Properties.Settings.Default.FTP_EMPRESA_PASS == "")
            {
                return false;
            }
            else {
                return true;
            }

        }

        public void enviarImagensFTP() {

            DirectoryInfo from = new DirectoryInfo(Properties.Settings.Default.IMAGENS);
            String to = Properties.Settings.Default.FTP_IMAGENS;
            //Ftp.Transmit t = new Ftp.Transmit();
            Thread enviar = new Thread(() => new Ftp.Transmit().EnviarArquivosFTP(from, to, "*.ZIP", false));
            enviar.Start();

        }

        public void enviarSite() {

            DirectoryInfo from = new DirectoryInfo(Properties.Settings.Default.SITES);
            String to = Properties.Settings.Default.FTP_SONIC_SITES;
            //Ftp.Transmit t = new Ftp.Transmit();
            Thread enviar = new Thread(() => new Ftp.Transmit().EnviarArquivosFTP(from, to, "*.TXT", true));
            enviar.Start();

        }

        public void gerarCargaVendedores(String vendedor, bool transmitir)
        {
            Thread gerarT = new Thread(() => listarArquivosCarga(vendedor, transmitir));
            gerarT.Start();
        }

        public void gerarCargaUsuariosTabela(List<string> userId, List<string> userName, bool transmitir)
        {
            Thread gerarT = new Thread(() => montarCargaUsuariosTabela(userId, userName, transmitir));
            gerarT.Start();
        }

        public void enviarCargaParaFtp() {
            DirectoryInfo from = new DirectoryInfo(Properties.Settings.Default.USUARIOS);
            String to = Properties.Settings.Default.FTP_USUARIOS;
            Thread enviar = new Thread(() => new Ftp.Transmit().EnviarArquivosFTP(from, to, "*.TXT", false));
            enviar.Start();
        }

        public void teste() {
            MessageBox.Show("Teste");
        }

        private void vendedoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void tool_query_Click(object sender, EventArgs e)
        {

            String form = "frm_query";
            frm_query query = new frm_query();
            abrirFormDialog(form, query);

        }

        private void menu_ts_logs_Click(object sender, EventArgs e)
        {
            String form = "frm_log";
            frm_log l = new frm_log();
            abrirFormDialog(form, l);
        }

        private void menu_ts_sincronizacoes_Click(object sender, EventArgs e)
        {
            String form = "frm_sinc";
            frm_sinc s = new frm_sinc();
            abrirFormDialog(form, s);
        }

        private void arquivos_cep_Click(object sender, EventArgs e)
        {
            new Arquivo.Gravar().gerarCepPorEstado();
        }
    }
}
