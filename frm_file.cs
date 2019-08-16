using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Integrador
{
    public partial class frm_file : Form
    {
        public frm_file()
        {
            InitializeComponent();
        }

        private void bt_save_Click(object sender, EventArgs e)
        {

            if (tb_processado.Text == "" 
                || tb_recebido.Text == "" 
                || tb_vendedores.Text == "" 
                || tb_query.Text == "" 
                || tb_site.Text == "" 
                || tb_carga.Text == ""
                || tb_imagens.Text == "")
            {
                MessageBox.Show("Defina todos os diretórios.", "Atenção!");

            }
            else
            {

                // BOTÃO PARA SALVAR OS DIRETORIOS
                Properties.Settings.Default.PROCESSADOS = tb_processado.Text;
                Properties.Settings.Default.RECEBIDOS = tb_recebido.Text;
                Properties.Settings.Default.USUARIOS = tb_vendedores.Text;
                Properties.Settings.Default.QUERYS = tb_query.Text;
                Properties.Settings.Default.SITES = tb_site.Text;
                Properties.Settings.Default.CARGA = tb_carga.Text;
                Properties.Settings.Default.IMAGENS = tb_imagens.Text;
                Properties.Settings.Default.Save();

                tb_recebido.Enabled = false;
                tb_processado.Enabled = false;
                tb_vendedores.Enabled = false;
                tb_query.Enabled = false;
                tb_site.Enabled = false;
                tb_carga.Enabled = false;
                tb_imagens.Enabled = false;
                bt_edit.Enabled = true;
                bt_save.Enabled = false;

                // MENSAGEM DE DIRETORIO SALVO
                MessageBox.Show("Salvo com sucesso!");
                goto close;
            }

            close:

            this.Dispose();

        }

        private void bt_edit_Click(object sender, EventArgs e)
        {

            //MessageBox.Show(tbc_file.SelectedTab.Name, "Teste");
            bt_save.Enabled = true;
            tb_recebido.Enabled = true;
            tb_processado.Enabled = true;
            tb_vendedores.Enabled = true;
            tb_query.Enabled = true;
            tb_site.Enabled = true;
            tb_carga.Enabled = true;
            tb_imagens.Enabled = true;
            bt_edit.Enabled = false;

        }

       
        private void frm_file_Load(object sender, EventArgs e)
        {

                String folder = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + Properties.Settings.Default.DEFAULT_PATH;

                tb_recebido.Text = Properties.Settings.Default.RECEBIDOS;
                tb_processado.Text = Properties.Settings.Default.PROCESSADOS;
                tb_vendedores.Text = Properties.Settings.Default.USUARIOS;
                tb_query.Text = Properties.Settings.Default.QUERYS;
                tb_site.Text = Properties.Settings.Default.SITES;
                tb_carga.Text = Properties.Settings.Default.CARGA;
                tb_imagens.Text = Properties.Settings.Default.IMAGENS;
                tb_ftp_vend.Text = Properties.Settings.Default.FTP_USUARIOS;
                tb_ftp_imagens.Text = Properties.Settings.Default.FTP_IMAGENS;


        }

        private void tb_recebido_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog salvar = new FolderBrowserDialog();
            if (salvar.ShowDialog() == DialogResult.OK)
            {

                // SALVA O DIRETORIO ESCOLHIDO
                tb_recebido.Text = salvar.SelectedPath;

            }
        }


        private void tb_processado_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog salvar = new FolderBrowserDialog();
            if (salvar.ShowDialog() == DialogResult.OK)
            {

                // SALVA O DIRETORIO ESCOLHIDO
                tb_processado.Text = salvar.SelectedPath;

            }
        }


        private void tb_vendedores_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog salvar = new FolderBrowserDialog();
            if (salvar.ShowDialog() == DialogResult.OK)
            {

                // SALVA O DIRETORIO ESCOLHIDO
                tb_vendedores.Text = salvar.SelectedPath;

            }
        }

        private void tb_query_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog salvar = new FolderBrowserDialog();
            if (salvar.ShowDialog() == DialogResult.OK)
            {

                // SALVA O DIRETORIO ESCOLHIDO
                tb_query.Text = salvar.SelectedPath;

            }
        }

        private void tb_site_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog salvar = new FolderBrowserDialog();
            if (salvar.ShowDialog() == DialogResult.OK)
            {
                // SALVA O DIRETORIO ESCOLHIDO
                tb_site.Text = salvar.SelectedPath;
            }
        }

        private void tb_carga_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog salvar = new FolderBrowserDialog();
            if (salvar.ShowDialog() == DialogResult.OK)
            {
                // SALVA O DIRETORIO ESCOLHIDO
                tb_carga.Text = salvar.SelectedPath;
            }
        }

        private void tb_imagens_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog salvar = new FolderBrowserDialog();
            if (salvar.ShowDialog() == DialogResult.OK)
            {
                // SALVA O DIRETORIO ESCOLHIDO
                tb_imagens.Text = salvar.SelectedPath;

            }
        }
    }
}
