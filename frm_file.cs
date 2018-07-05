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

            switch (tbc_file.SelectedTab.Name) {

                case "tbc_env":

                    if (tb_export.Text == "" || tb_import.Text == "")
                    {
                        MessageBox.Show("Defina os disretórios de IMPORTAÇÕ E EXPORTAÇÃO.", "Atenção!");

                    }
                    else
                    {

                        // BOTÃO PARA SALVAR OS DIRETORIOS
                        Properties.Settings.Default.EXPORTACAO = tb_export.Text;
                        Properties.Settings.Default.Save();
                        Properties.Settings.Default.IMPORTACAO = tb_import.Text;
                        Properties.Settings.Default.Save();

                        tb_import.Enabled = false;
                        tb_export.Enabled = false;
                        bt_edit.Enabled = true;
                        bt_save.Enabled = false;


                        // MENSAGEM DE DIRETORIO SALVO
                        MessageBox.Show("Salvo com sucesso!");

                    }


                    break;

                case "tbc_rec":

                    if (tb_import_mb_pc.Text == "")
                    {
                        MessageBox.Show("Defina o disretório Mobile/PC.", "Atenção!");

                    }
                    else
                    {

                        // BOTÃO PARA SALVAR OS DIRETORIOS
                        Properties.Settings.Default.MOBILE_PC = tb_import_mb_pc.Text;
                        Properties.Settings.Default.Save();

                        tb_import_mb_pc.Enabled = false;
                        bt_edit.Enabled = true;
                        bt_save.Enabled = false;


                        // MENSAGEM DE DIRETORIO SALVO
                        MessageBox.Show("Salvo com sucesso!");

                    }

                    break;
            }


        }

        private void bt_edit_Click(object sender, EventArgs e)
        {

            //MessageBox.Show(tbc_file.SelectedTab.Name, "Teste");

            switch (tbc_file.SelectedTab.Name)
            {

                case "tbc_env":

                    //tb_import.Enabled = true;
                    //tb_export.Enabled = true;
                    bt_save.Enabled = true;

                    break;

                case "tbc_rec":

                    tb_import_mb_pc.Enabled = true;
                    //bt_save.Enabled = true;

                break;

                default:
                    break;
            }
            
        }

        private void tb_import_Click(object sender, EventArgs e)
        {
            // BUSCAR DIRETORIO DE IMPORTAÇÃO/EXPORTAÇÃO

            FolderBrowserDialog salvar = new FolderBrowserDialog();
            if (salvar.ShowDialog() == DialogResult.OK)
            {

                // SALVA O DIRETORIO ESCOLHIDO
                tb_import.Text = salvar.SelectedPath;

            }
        }

        private void tb_export_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog salvar = new FolderBrowserDialog();
            if (salvar.ShowDialog() == DialogResult.OK)
            {

                // SALVA O DIRETORIO ESCOLHIDO
                tb_export.Text = salvar.SelectedPath;

            }
        }

       

        private void frm_file_Load(object sender, EventArgs e)
        {

           
            //this.WindowState = FormWindowState.Normal;
            //this.WindowState = FormWindowState.Normal;
            if (Properties.Settings.Default.IMPORTACAO != "" && Properties.Settings.Default.EXPORTACAO != "")
            {
                bt_edit.Enabled = true;
                tb_import.Text = Properties.Settings.Default.IMPORTACAO;
                tb_export.Text = Properties.Settings.Default.EXPORTACAO;
            }
            else {
                bt_save.Enabled = true;
            }
            //this.Width = 300;
            //this.Height = 300;

        }

        private void tb_import_mb_pc_Click(object sender, EventArgs e)
        {
            // BUSCAR DIRETORIO MOBILE/PC

            FolderBrowserDialog salvar = new FolderBrowserDialog();
            if (salvar.ShowDialog() == DialogResult.OK)
            {

                // SALVA O DIRETORIO ESCOLHIDO
                tb_import_mb_pc.Text = salvar.SelectedPath;

            }

        }
    }
}
