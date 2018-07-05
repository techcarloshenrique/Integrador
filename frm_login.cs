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
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bt_entrar_Click(object sender, EventArgs e)
        {
            this.Close();
            //frm_dashboard dash = new frm_dashboard();
            //dash.Show();

            frm_main control = new frm_main();

            String form = "frm_dashboard";
            frm_dashboard db = new frm_dashboard();

            if (control.formAberto(form))
            {
                Application.OpenForms[form].BringToFront();
            }
            else
            {
                //control.abrirForm(db, frm_main.opened);
            }

        }
    }
}
