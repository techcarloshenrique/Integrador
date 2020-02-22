using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Integrador
{
    public partial class frm_db : Form
    {
        public frm_db()
        {
            InitializeComponent();
        }

        public void GravarDados(String ip, String porta, String database, String user, String senha)
        {

            // DEFINE TODAS AS VARIAVEIS DE CONEXAO
            Properties.Settings.Default.Reload();
            Properties.Settings.Default.IP = ip;
            Properties.Settings.Default.Save();
            Properties.Settings.Default.PORT = porta;
            Properties.Settings.Default.Save();
            Properties.Settings.Default.USER = user;
            Properties.Settings.Default.Save();
            Properties.Settings.Default.DATABASE = database;
            Properties.Settings.Default.Save();
            Properties.Settings.Default.PASS = senha;
            Properties.Settings.Default.Save();
            Properties.Settings.Default.Upgrade();
            Properties.Settings.Default.CONN = "Conectado!";
            tb_ip.Enabled = false;
            tb_database.Enabled = false;
            tb_port.Enabled = false;
            tb_user.Enabled = false;
            tb_pass.Enabled = false;
            MessageBox.Show("Salvo com sucesso!", "Conexão");
            this.Close();


        }

        public void testarConexao()
        {

            // SE QUALQUER VERIAVEL(TEXTBOX) ESTIVER NULA
            if (
                    tb_ip.Text == ""
                || tb_port.Text == ""
                || tb_database.Text == ""
                || tb_user.Text == ""
                || tb_pass.Text == ""
                )
            {
                // MENSAGEM DE ERRO
                MessageBox.Show("Preencha todos os campos!", "Atenção!");
            }
            else
            {

                // MONTA STRING DE CONEXAO COM A BASE DE DADOS
                String ip = tb_ip.Text;
                String porta = tb_port.Text;
                String database = tb_database.Text;
                String user = tb_user.Text;
                String senha = tb_pass.Text;
                String con =
                    "Server=" + ip +
                    "," + porta +
                    ";Database=" + database +
                    ";User Id=" + user +
                    ";Password=" + senha;
              

                // TENTA CONECTAR
              
                    if (Conexao.validarConexao(con))
                    {
                        MessageBox.Show("Conexao realizada com sucesso!", "Conexão");
                    }
                    else {
                        MessageBox.Show("Não foi possível obter conexão.", "Erro");
                    }
            
            }
        }

        private void frm_db_Load(object sender, EventArgs e)
        {
            if (
                  Properties.Settings.Default.IP != ""
               && Properties.Settings.Default.PORT != ""
               && Properties.Settings.Default.DATABASE != ""
               && Properties.Settings.Default.USER != ""
               && Properties.Settings.Default.PASS != ""
               )
            {
                bt_teste.Enabled = false;
                bt_edit.Enabled = true;
                // AO INICIAR O FORM PREENCHE COM ALGUNS DADOS JÁ EXISTENTES
                tb_ip.Text = Properties.Settings.Default.IP;
                tb_port.Text = Properties.Settings.Default.PORT;
                tb_database.Text = Properties.Settings.Default.DATABASE;
                tb_user.Text = Properties.Settings.Default.USER;
                tb_pass.Text = Properties.Settings.Default.PASS;
            }

            
        }

        private void bt_teste_Click(object sender, EventArgs e)
        {

            /*pb_progress.Visible = true;
            BackgroundWorker bgw = new BackgroundWorker();
            bgw = new BackgroundWorker();
            bgw.WorkerReportsProgress = true;
            bgw.ProgressChanged += new ProgressChangedEventHandler(bgw_ProgressChanged);
            bgw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bgw_RunWorkerCompleted);
            bgw.DoWork += new DoWorkEventHandler(bgw_DoWork);
            bgw.RunWorkerAsync();*/

            Thread t = new Thread(() => testarConexao());
            t.Start();

            //testarConexao();
        }

        void bgw_DoWork(object sender, DoWorkEventArgs e)
        {

            testarConexao();

        }

        void bgw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            
        }

        void bgw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            pb_progress.Visible = false;
            bt_save.Enabled = true;
        }

        private void bt_save_Click(object sender, EventArgs e)
        {
            bt_teste.Enabled = false;
            bt_save.Enabled = false;
            GravarDados(tb_ip.Text, tb_port.Text, tb_database.Text, tb_user.Text, tb_pass.Text);
        }

        private void bt_edit_Click_1(object sender, EventArgs e)
        {
            bt_teste.Enabled = true;
            tb_ip.Enabled = true;
            tb_database.Enabled = true;
            tb_port.Enabled = true;
            tb_user.Enabled = true;
            tb_pass.Enabled = true;
        }
    }
}
