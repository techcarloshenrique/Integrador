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


                String ambient = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
                String folder = "\\Sonic";

                if (!Directory.Exists(ambient + folder))
                {

                    Properties.Settings.Default.DEFAULT_PATH = ambient + folder + "\\Sonic";
                    Properties.Settings.Default.PROCESSADOS = ambient + folder + "\\Processados";
                    Properties.Settings.Default.RECEBIDOS = ambient + folder + "\\Recebidos";
                    Properties.Settings.Default.VENDEDORES = ambient + folder + "\\Vendedores";
                    Properties.Settings.Default.QUERYS = ambient + folder + "\\Querys";
                    Properties.Settings.Default.SITES = ambient + folder + "\\Sites";
                    Properties.Settings.Default.CARGA = ambient + folder + "\\Carga";
                    Properties.Settings.Default.IMAGENS = ambient + folder + "\\Imagens";
                    Properties.Settings.Default.Save();
                    Properties.Settings.Default.Reload();

                    System.IO.Directory.CreateDirectory(ambient + folder);
                    System.IO.Directory.CreateDirectory(ambient + folder + "\\Sites");
                    System.IO.Directory.CreateDirectory(ambient + folder + "\\Carga");
                    System.IO.Directory.CreateDirectory(ambient + folder + "\\Querys");
                    System.IO.Directory.CreateDirectory(ambient + folder + "\\Recebidos");
                    System.IO.Directory.CreateDirectory(ambient + folder + "\\Processados");
                    System.IO.Directory.CreateDirectory(ambient + folder + "\\Vendedores");
                    System.IO.Directory.CreateDirectory(ambient + folder + "\\Imagens");

                }

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

            if (!ConexaoLoad())
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

        public void EnviarArquivosFTP(DirectoryInfo from, String to, String ext, Boolean server)
        {
            String ftp;
            String user;
            String pass;

            if (server)
            {
                ftp = Properties.Settings.Default.FTP_SERVER_IP;
                user = Properties.Settings.Default.FTP_SERVER_USER;
                pass = Properties.Settings.Default.FTP_SERVER_PASS;
            }
            else {
                ftp = Properties.Settings.Default.FTP_EMPRESA_IP;
                user = Properties.Settings.Default.FTP_EMPRESA_USER;
                pass = Properties.Settings.Default.FTP_EMPRESA_PASS;
            }

            FileInfo[] files = from.GetFiles(ext);

            if (files.Length > 0)
            {

                img_tick.Image = Properties.Resources.loader2;
                lb_progress.Visible = true;
                lb_progress.Text = "CONECTANTO COM O SERVIDOR FTP... ";

                try
                {
                    int count = 1;
                    foreach (FileInfo file in files)
                    {

                        FtpWebRequest request = (FtpWebRequest)FtpWebRequest.Create("ftp://" + ftp + to + file.Name);
                        request.Credentials = new NetworkCredential(user, pass);
                        request.Method = WebRequestMethods.Ftp.UploadFile;
                        request.KeepAlive = false;
                        request.UseBinary = true;
                        request.Timeout = 60000 * 2;

                        lb_progress.Text = "ENVIANDO -> " + file.Name +" - "+ count+"/"+files.Length;

                        //Thread.Sleep(500);

                        FileStream stream = File.OpenRead(from.ToString() + "\\" + file.Name);
                        Stream reqStream = request.GetRequestStream();
                        byte[] buffer = new byte[4096 * 2];
                        int nRead = 0;
                        while ((nRead = stream.Read(buffer, 0, buffer.Length)) != 0)
                        {
                            reqStream.Write(buffer, 0, nRead);
                        }
                        stream.Close();
                        reqStream.Close();

                        count++;

                    }


                }
                catch (WebException ex)
                {
                    MessageBox.Show(ex.ToString(), "Erro");
                }

                DateTime dt = DateTime.Now;
                string data = (string.Format("{0:dd/MM/yyyy}", dt));
                string hora = (string.Format("{0:HH:mm}", dt));
                Properties.Settings.Default.LASTEXPORT = "ÚLTIMO ENVIO REALIZADO EM " + data + " ÀS " + hora;
                Properties.Settings.Default.Save();
                Properties.Settings.Default.Reload();
                img_tick.Image = Properties.Resources.tick;
                lb_progress.Text = Properties.Settings.Default.LASTEXPORT;

            }
            else
            {
                MessageBox.Show("Nenhum arquivo para ser enviado.", "Aviso");
            }
        }

        public class Ftp {

            // METODO PARA ENVIAR ARQUIVOS VIA FTP
            public void EnviarArquivoFTP(DirectoryInfo di)
            {

                FileInfo[] files = di.GetFiles("*.TXT");

                if (files.Length > 0)
                {

                    //Atualizar
                    //ss.Invoke(new Action(() => f.img_tick.Image = Properties.Resources.loader2));
                    //ss.Invoke(new Action(() => f.lb_progress.Visible = true));
                    //ss.Invoke(new Action(() => f.lb_progress.Text = "CONECTANTO COM O SERVIDOR FTP... "));

                    try
                    {

                        foreach (FileInfo file in files)
                        {

                            FtpWebRequest request = (FtpWebRequest)FtpWebRequest.Create("ftp://" + Properties.Settings.Default.FTP_EMPRESA_IP + "/" + file.Name);
                            request.Credentials = new NetworkCredential(Properties.Settings.Default.FTP_EMPRESA_USER, Properties.Settings.Default.FTP_EMPRESA_PASS);
                            request.Method = WebRequestMethods.Ftp.UploadFile;
                            request.KeepAlive = false;
                            request.UseBinary = true;
                            request.Timeout = 60000 * 2;

                            //f.lb_progress.Text = "ENVIANDO "+file.Name;

                            //Thread.Sleep(500);

                            FileStream stream = File.OpenRead(di.ToString() + "\\" + file.Name);
                            Stream reqStream = request.GetRequestStream();
                            byte[] buffer = new byte[4096 * 2];
                            int nRead = 0;
                            while ((nRead = stream.Read(buffer, 0, buffer.Length)) != 0)
                            {
                                reqStream.Write(buffer, 0, nRead);
                            }
                            stream.Close();
                            reqStream.Close();

                        }


                    }
                    catch (WebException ex)
                    {

                        //throw new Exception("Erro ao tentar enviar o arquivo...\n");
                        MessageBox.Show(ex.ToString(), "Erro");
                    }

                    DateTime dt = DateTime.Now;
                    string data = (string.Format("{0:dd/MM/yyyy}", dt));
                    string hora = (string.Format("{0:HH:mm}", dt));
                    Properties.Settings.Default.LASTEXPORT = "ÚLTIMO ENVIO REALIZADO EM " + data + " ÀS " + hora;
                    Properties.Settings.Default.Save();
                    Properties.Settings.Default.Reload();
                    //f.ss_main.Invoke(new Action(() => f.img_tick.Image = Properties.Resources.tick));
                    //f.ss_main.Invoke(new Action(() => f.lb_progress.Text = Properties.Settings.Default.LASTEXPORT));

                }
                else {
                    MessageBox.Show("Nenhum arquivo para ser enviado.", "Aviso");
                }
            }


            // METODO PARA BAIXAR ARQUIVOS VIA FTP
            public static void BaixarArquivoFTP(string url, string local, string usuario, string senha)
            {
                try
                {
                    FtpWebRequest request = (FtpWebRequest)WebRequest.Create(url);
                    request.Method = WebRequestMethods.Ftp.DownloadFile;
                    request.Credentials = new NetworkCredential(usuario, senha);
                    request.UseBinary = true;
                    using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
                    {
                        using (Stream rs = response.GetResponseStream())
                        {
                            using (FileStream ws = new FileStream(local, FileMode.Create))
                            {
                                byte[] buffer = new byte[2048];
                                int bytesRead = rs.Read(buffer, 0, buffer.Length);
                                while (bytesRead > 0)
                                {
                                    ws.Write(buffer, 0, bytesRead);
                                    bytesRead = rs.Read(buffer, 0, buffer.Length);
                                }
                            }
                        }
                    }
                }
                catch
                {
                    throw;
                }
            }

            public void MoverArquivoFtp(string ftpURL, string UserName, string Password, string ftpDirectory, string ftpDirectoryProcessed, string FileName)
            {
                FtpWebRequest ftpRequest = null;
                FtpWebResponse ftpResponse = null;
                try
                {
                    ftpRequest = (FtpWebRequest)WebRequest.Create(ftpURL + "/" + ftpDirectory + "/" + FileName);
                    ftpRequest.Credentials = new NetworkCredential(UserName, Password);
                    ftpRequest.UseBinary = true;
                    ftpRequest.UsePassive = true;
                    ftpRequest.KeepAlive = true;
                    ftpRequest.Method = WebRequestMethods.Ftp.Rename;
                    ftpRequest.RenameTo = ftpDirectoryProcessed + "/" + FileName;
                    ftpResponse = (FtpWebResponse)ftpRequest.GetResponse();
                    ftpResponse.Close();
                    ftpRequest = null;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            public void CriarDiretorioFTP(string pasta)
            {
                String path = String.Format("ftp://{0}{1}", "localhost/", pasta);
                FtpWebRequest ftpRequest;
                FtpWebResponse ftpResponse;
                try
                {
                    ftpRequest = (FtpWebRequest)WebRequest.Create(path);
                    ftpRequest.Credentials = new NetworkCredential("asabranca", "123456");
                    ftpRequest.UseBinary = true;
                    ftpRequest.UsePassive = true;
                    ftpRequest.KeepAlive = true;
                    ftpRequest.Method = WebRequestMethods.Ftp.MakeDirectory;
                    ftpResponse = (FtpWebResponse)ftpRequest.GetResponse();
                    ftpResponse.Close();
                    ftpRequest = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao criar a pasta", ex.ToString());
                }
                return;
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

            catch (Exception erro)
            {

                MessageBox.Show("Erro ao exportar o arquivo " + nome_arquivo + "\n\nDetalhe do erro: " + erro.Message);

            }
        }

        public void gerarCargaVendedores(SqlConnection conexao, string saida, string secao, string query)
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
                string caminho = Properties.Settings.Default.VENDEDORES + "\\";
 
                // LAÇO DA TABELA
                using (SqlDataReader DR = retorno.ExecuteReader())
                {

                    // CRIANDO O ARQUIVO PARA A GRAVAÇÃO DOS DADOS
                    StreamWriter valor = new StreamWriter(caminho + saida, true, Encoding.GetEncoding("ISO-8859-1"));

                    valor.Write(secao);

                    // SE A CONSULTA RETORNAR LINHAS
                    if (DR.HasRows)
                    {


                        //Thread.Sleep(100);

                        //valor.Write(secao);
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
                    else {
                        valor.WriteLine();
                        valor.Close();
                    }

                }

            }

            catch (Exception erro)
            {

                MessageBox.Show("Erro ao exportar o arquivo " + saida + "\n\nDetalhe do erro: " + erro.Message);

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

            try {

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
                    else {

                        img_tick.Image = Properties.Resources.error;
                        lb_progress.Visible = true;
                        lb_progress.Text = "BASE DE DADOS INDISPONÍVEL NO MOMENTO.";
                        MessageBox.Show("Não existem arquivos no diretório " + Properties.Settings.Default.QUERYS, "Erro.", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }

                    // FECHANDO A CONEXAO COM O BANCO
                    Conexao.fecharConexao(conn);
                    DateTime dt = DateTime.Now;
                    string data = (string.Format("{0:dd/MM/yyyy}", dt));
                    string hora = (string.Format("{0:HH:mm}", dt));
                    Properties.Settings.Default.LASTEXPORT = "ÚLTIMA EXPORTAÇÃO FINALIZADA EM " + data + " ÀS " + hora;
                    Properties.Settings.Default.Save();
                    Properties.Settings.Default.Reload();
                    img_tick.Image = Properties.Resources.tick;
                    lb_progress.Text = Properties.Settings.Default.LASTEXPORT;
                }
                else {
                    img_tick.Image = Properties.Resources.error;
                    lb_progress.Visible = true;
                    lb_progress.Text = "BASE DE DADOS INDISPONÍVEL NO MOMENTO.";
                    MessageBox.Show("Não foi possível realizar a operação.", "Erro.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


            }
            catch (SqlException e)
            {
                img_tick.Image = Properties.Resources.error;
                lb_progress.Visible = true;
                lb_progress.Text = "BASE DE DADOS INDISPONÍVEL NO MOMENTO.";
                MessageBox.Show("Não foi possível realizar a operação.\n\nDetalhe do erro: " + e.Message, "Erro.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

            if (vendedor == "TODOS OS VENDEDORES")
            {
                select = "SELECT SU.ID, SU.NOME FROM SONIC_USUARIOS SU";
            }
            else
            {
                select = "SELECT SU.ID, SU.NOME FROM SONIC_USUARIOS SU WHERE SU.NOME = '" + nome + "'";
            }

            // APAGA TODOS OS ARQUIVOS DO DIRETORIO DE VENDEDORES
            DirectoryInfo vend = new DirectoryInfo(Properties.Settings.Default.VENDEDORES);

            try
            {

                // INSTANCIANDO UMA NOVA CONEXAO
                SqlConnection connect = Conexao.obterConexao();

                //PREPARA O SELECT
                SqlCommand retorno = new SqlCommand(select, connect);

                //EXECUTA O SELECT
                SqlDataReader row = retorno.ExecuteReader();

                // CRIANDO UM  E POPULANDO UM DATATABLE COM O RETORNO DO SELECT
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

                            id[i-1] = values[0].ToString();
                            name[i-1] = values[1].ToString();

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

                                DirectoryInfo di = new DirectoryInfo(Properties.Settings.Default.VENDEDORES);

                                foreach (FileInfo txt in di.GetFiles(saida))
                                {
                                    txt.Delete();
                                }

                                int count = x + 1;
                                lb_progress.Text = "EXPORTANDO -> " + pessoa + " [" + saida + "] - "+ count + "/" + rows;

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
                        Conexao.fecharConexao(connect);
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
            catch (SqlException e)
            {
                img_tick.Image = Properties.Resources.error;
                lb_progress.Visible = true;
                lb_progress.Text = "BASE DE DADOS INDISPONÍVEL NO MOMENTO.";
                MessageBox.Show("Não foi possível realizar a operação.\n\nDetalhe do erro: " + e.Message, "Erro.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

            this.MinimumSize = new System.Drawing.Size(this.Width, this.Height);
            pb_close.Location = new Point(this.Width - 60, 30);
            pb_change.Location = new Point(this.Width - 100, 30);
            lb_progress.Width = (ss_main.Width / 3);
            ts_user.Width = (ss_main.Width / 3);
            ts_hora.Width = (ss_main.Width / 3)-43;


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

        private void ms_main_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

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
            Thread site = new Thread(() => gerarSite());
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
            Thread enviar = new Thread(() => EnviarArquivosFTP(from, to, "*.ZIP", false));
            enviar.Start();

        }

        public void enviarSite() {

            DirectoryInfo from = new DirectoryInfo(Properties.Settings.Default.SITES);
            String to = Properties.Settings.Default.FTP_SONIC_SITES;
            Thread enviar = new Thread(() => EnviarArquivosFTP(from, to, "*.TXT", true));
            enviar.Start();

        }

        public void gerarCargaVendedores(String vendedor, bool transmitir)
        {
            Thread gerarT = new Thread(() => listarArquivosCarga(vendedor, transmitir));
            gerarT.Start();
        }

        public void enviarCargaParaFtp() {
            DirectoryInfo from = new DirectoryInfo(Properties.Settings.Default.VENDEDORES);
            String to = Properties.Settings.Default.FTP_VENDEDORES;
            Thread enviar = new Thread(() => EnviarArquivosFTP(from, to, "*.TXT", false));
            enviar.Start();
        }

        public void teste() {
            MessageBox.Show("Teste");
        }

        private void vendedoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
