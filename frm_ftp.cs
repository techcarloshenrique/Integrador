using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace Integrador
{
    public partial class frm_ftp : Form
    {
        public frm_ftp()
        {
            InitializeComponent();

        }

        class FTPConnection
        {

            FtpWebRequest ftpRequest;

            public bool TestConnection(String address, String user, String pass)
            {

                bool result = false;

                ftpRequest = (FtpWebRequest)FtpWebRequest.Create("ftp://"+address);
                ftpRequest.Method = WebRequestMethods.Ftp.ListDirectory;
                ftpRequest.Credentials = new NetworkCredential(user, pass);
                try
                {
                    result = true;
                    WebResponse response = ftpRequest.GetResponse();
                    MessageBox.Show("Conexão bem sucedida!", "FTP");
                }
                catch (WebException ex)
                {
                    //throw new Exception("Falha na conexão!\n");
                    MessageBox.Show("Falha na conexão!\n"+ex, "FTP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    result = false;
                }

                return result;
            }
        }

        private void bt_teste_Click(object sender, EventArgs e)
        {

            if (tb_ftp.SelectedTab == tb_ftp.TabPages["tb_page_empresa"])
            {
                if (tb_tab_empresa_address.Text.Equals("") || tb_tab_empresa_user.Text.Equals("") || tb_tab_empresa_pass.Text.Equals(""))
                {

                    MessageBox.Show("Preencha todos os campos!", "Atenção");
                    tb_tab_empresa_address.Focus();

                }
                else
                {


                    FTPConnection ftp = new FTPConnection();
                    if (ftp.TestConnection(tb_tab_empresa_address.Text, tb_tab_empresa_user.Text, tb_tab_empresa_pass.Text))
                    {
                        bt_save.Enabled = true;
                    }
                }
            }
            else {
                if (tb_tab_server_address.Text.Equals("") || tb_tab_server_user.Text.Equals("") || tb_tab_server_pass.Text.Equals(""))
                {

                    MessageBox.Show("Preencha todos os campos!", "Atenção");
                    tb_tab_server_address.Focus();

                }
                else
                {


                    FTPConnection ftp = new FTPConnection();
                    if (ftp.TestConnection(tb_tab_server_address.Text, tb_tab_server_user.Text, tb_tab_server_pass.Text))
                    {
                        bt_save.Enabled = true;
                    }
                }
            }

              

        }

        private void bt_save_Click(object sender, EventArgs e)
        {

            if (tb_ftp.SelectedTab == tb_ftp.TabPages["tb_page_empresa"])
            {
                if (tb_tab_empresa_address.Text.Equals("") || tb_tab_empresa_user.Text.Equals("") || tb_tab_empresa_pass.Text.Equals(""))
                {

                    MessageBox.Show("Preencha todos os campos!", "Atenção");
                    tb_tab_empresa_address.Focus();

                }
                else
                {
                    Properties.Settings.Default.Reload();
                    Properties.Settings.Default.FTP_EMPRESA_IP = tb_tab_empresa_address.Text;
                    Properties.Settings.Default.FTP_EMPRESA_USER = tb_tab_empresa_user.Text;
                    Properties.Settings.Default.FTP_EMPRESA_PASS = tb_tab_empresa_pass.Text;
                    Properties.Settings.Default.Save();
                    bt_teste.Enabled = false;
                    bt_save.Enabled = false;
                    bt_edit.Enabled = true;
                    tb_tab_empresa_address.Enabled = false;
                    tb_tab_empresa_user.Enabled = false;
                    tb_tab_empresa_pass.Enabled = false;
                    MessageBox.Show("Salvo com sucesso!", "FTP");
                    this.Close();
                }
            }
            else {

                 if (tb_tab_server_address.Text.Equals("") || tb_tab_server_user.Text.Equals("") || tb_tab_server_pass.Text.Equals(""))
                {

                    MessageBox.Show("Preencha todos os campos!", "Atenção");
                    tb_tab_empresa_address.Focus();

                }
                else
                {
                    Properties.Settings.Default.Reload();
                    Properties.Settings.Default.FTP_SERVER_IP = tb_tab_server_address.Text;
                    Properties.Settings.Default.FTP_SERVER_USER = tb_tab_server_user.Text;
                    Properties.Settings.Default.FTP_SERVER_PASS = tb_tab_server_pass.Text;
                    Properties.Settings.Default.Save();
                    bt_teste.Enabled = false;
                    bt_save.Enabled = false;
                    bt_edit.Enabled = true;
                    tb_tab_server_address.Enabled = false;
                    tb_tab_server_user.Enabled = false;
                    tb_tab_server_pass.Enabled = false;
                    MessageBox.Show("Salvo com sucesso!", "FTP");
                    this.Close();
                }

            }

            
        }

        private void frm_ftp_Load(object sender, EventArgs e)
        {
            //panel_ftp.Left = (this.Width / 2) - (panel_ftp.Width / 2);
            //panel_ftp.Top = (this.Height / 2) - (panel_ftp.Height / 2) - flp_ftp.Height;
            //panel_ftp.Anchor = AnchorStyles.None;

            if (Properties.Settings.Default.FTP_EMPRESA_IP != ""
                && Properties.Settings.Default.FTP_EMPRESA_USER != ""
                && Properties.Settings.Default.FTP_EMPRESA_PASS != ""
                 && Properties.Settings.Default.FTP_SERVER_IP != ""
                && Properties.Settings.Default.FTP_SERVER_USER != ""
                && Properties.Settings.Default.FTP_SERVER_PASS != "")
            {
                tb_tab_empresa_address.Text = Properties.Settings.Default.FTP_EMPRESA_IP;
                tb_tab_empresa_user.Text = Properties.Settings.Default.FTP_EMPRESA_USER;
                tb_tab_empresa_pass.Text = Properties.Settings.Default.FTP_EMPRESA_PASS;
                tb_tab_server_address.Text = Properties.Settings.Default.FTP_SERVER_IP;
                tb_tab_server_user.Text = Properties.Settings.Default.FTP_SERVER_USER;
                tb_tab_server_pass.Text = Properties.Settings.Default.FTP_SERVER_PASS;
                bt_edit.Enabled = true;
            }
            else
            {
                bt_teste.Enabled = true;
                tb_tab_empresa_address.Enabled = true;
                tb_tab_empresa_user.Enabled = true;
                tb_tab_empresa_pass.Enabled = true;
                tb_tab_server_address.Enabled = true;
                tb_tab_server_user.Enabled = true;
                tb_tab_server_pass.Enabled = true;
            }
        }

        private void bt_edit_Click(object sender, EventArgs e)
        {
            
                bt_teste.Enabled = true;
                tb_tab_empresa_address.Enabled = true;
                tb_tab_empresa_user.Enabled = true;
                tb_tab_empresa_pass.Enabled = true;
                tb_tab_server_address.Enabled = true;
                tb_tab_server_user.Enabled = true;
                tb_tab_server_pass.Enabled = true;
                bt_edit.Enabled = false;
        
            
            
        }

        private void frm_ftp_SizeChanged(object sender, EventArgs e)
        {
            //panel_ftp.Left = (this.Width / 2) - (panel_ftp.Width / 2);
            //panel_ftp.Top = (this.Height / 2) - (panel_ftp.Height / 2)-flp_ftp.Height;
            //panel_ftp.Anchor = AnchorStyles.None;
        }

    }
}
