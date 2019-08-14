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
    public partial class frm_site : Form
    {
        public frm_site()
        {
            InitializeComponent();
        }
        public void GravarDados(String site, String licenca)
        {

            // DEFINE TODAS AS VARIAVEIS DE CONEXAO
            Properties.Settings.Default.Reload();
            Properties.Settings.Default.SITE = site;
            Properties.Settings.Default.Save();
            Properties.Settings.Default.LICENSA = licenca;
            Properties.Settings.Default.Save();


            //MessageBox.Show("Salvo com sucesso!", "Conexão");


        }
        private void bt_salvar_Click(object sender, EventArgs e)
        {
            if (tb_site.Text.Length < 11 || tb_site.Text.Length > 11 || tb_site.Text == "")
            {
                MessageBox.Show("Site inválido","Erro");
            }
            else {
                GravarDados(tb_site.Text, tb_licensa.Text);
                frm_main m = new frm_main();
                String form = "frm_main";

                try
                {

                    if (Application.OpenForms[form] != null)
                    {
                        this.Close();
                        Application.OpenForms[form].BringToFront();
                    }
                    else {
                        m.Show();
                        this.Close();
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Erro");

                }

               
                
            }

            
        }

        private void frm_site_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.SITE != "") {
                tb_site.Text = Properties.Settings.Default.SITE;
                tb_site.Enabled = false;
            }
           
           
        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
