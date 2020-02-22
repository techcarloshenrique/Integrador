using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Integrador
{
    class Ftp
    {

        Transmit transmit = new Transmit();
        Teste t = new Teste();
        public class Teste {
        }

        public class Transmit {

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
                        new LogWriter(ex.Message, ex.StackTrace);

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
                else
                {
                    MessageBox.Show("Nenhum arquivo para ser enviado.", "Aviso");
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
                else
                {
                    ftp = Properties.Settings.Default.FTP_EMPRESA_IP;
                    user = Properties.Settings.Default.FTP_EMPRESA_USER;
                    pass = Properties.Settings.Default.FTP_EMPRESA_PASS;
                }

                FileInfo[] files = from.GetFiles(ext);

                if (files.Length > 0)
                {

                    //img_tick.Image = Properties.Resources.loader2;
                    //lb_progress.Visible = true;
                    //lb_progress.Text = "CONECTANTO COM O SERVIDOR FTP... ";

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

                            //lb_progress.Text = "ENVIANDO -> " + file.Name + " - " + count + "/" + files.Length;

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
                        System.Windows.Forms.MessageBox.Show(ex.ToString(), ex.StackTrace);
                    }

                    DateTime dt = DateTime.Now;
                    string data = (string.Format("{0:dd/MM/yyyy}", dt));
                    string hora = (string.Format("{0:HH:mm}", dt));
                    Properties.Settings.Default.LASTEXPORT = "ÚLTIMO ENVIO REALIZADO EM " + data + " ÀS " + hora;
                    Properties.Settings.Default.Save();
                    Properties.Settings.Default.Reload();
                    //img_tick.Image = Properties.Resources.tick;
                    //lb_progress.Text = Properties.Settings.Default.LASTEXPORT;

                }
                else
                {
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
                    new LogWriter(ex.Message, ex.StackTrace);
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
                    new LogWriter(ex.Message, ex.StackTrace);
                }
                return;
            }

        }

    }

}
