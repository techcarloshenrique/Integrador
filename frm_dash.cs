using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Integrador
{
    public partial class frm_dash : Form
    {
        public frm_dash()
        {
            InitializeComponent();
  
        }

        private void fillDash1() {

            //dash_pb_progress1.Visible = true;
            // LAÇO PARA O PANEL DE PEDIDOS RECEBIDOS / NÃO PROCESSADOS
            for (int i = 0; i < 4; i++)
            {

                // NOME DO CLIENTE
                Panel pn = new Panel();
                PictureBox pb_cli = new PictureBox();
                pb_cli.Image = Properties.Resources.user;
                pb_cli.Size = new System.Drawing.Size(17, 15);
                pb_cli.Location = new Point(4, 4);
                Label lb_cli = new Label();
                lb_cli.Location = new Point(24, 3);
                lb_cli.MinimumSize = new System.Drawing.Size(350, 0);
                lb_cli.Font = new Font("Letter Gothic", 10, FontStyle.Bold);
                lb_cli.Text = "NOME DO CLIENTE";
                lb_cli.ForeColor = Color.FromArgb(64, 64, 64);

                // NUMERO DO PEDIDO
                PictureBox pb_ped = new PictureBox();
                pb_ped.Image = Properties.Resources.package;
                pb_ped.Size = new System.Drawing.Size(17, 15);
                pb_ped.Location = new Point(4, 22);
                Label lb_ped = new Label();
                lb_ped.Location = new Point(24, 24);
                lb_ped.MinimumSize = new System.Drawing.Size(200, 0);
                lb_ped.Font = new Font("Letter Gothic", 8, FontStyle.Regular);
                lb_ped.Text = "20187125001";
                lb_ped.ForeColor = Color.FromArgb(64, 64, 64);

                // DATA DO PEDIDO
                Label lb_data = new Label();
                lb_data.Location = new Point(282, 23);
                lb_data.MinimumSize = new System.Drawing.Size(350, 0);
                lb_data.Font = new Font("Letter Gothic", 8, FontStyle.Italic);
                lb_data.Text = "01/08/2018 15:30";

                // NOME DO VENDEDOR
                PictureBox pb_vend = new PictureBox();
                pb_vend.Image = Properties.Resources.user_suit;
                pb_vend.Size = new System.Drawing.Size(17, 15);
                pb_vend.Location = new Point(4, 43);
                Label lb_vend = new Label();
                lb_vend.Location = new Point(24, 44);
                lb_vend.MinimumSize = new System.Drawing.Size(250, 0);
                lb_vend.Font = new Font("Letter Gothic", 8, FontStyle.Regular);
                lb_vend.Text = "NOME DO VENDEDOR";
                lb_vend.ForeColor = Color.FromArgb(64, 64, 64);

                pn.Width = 385;
                pn.Height = 62;
                pn.BackColor = Color.FromArgb(255, 255, 192);
                pn.Controls.Add(pb_cli);
                pn.Controls.Add(lb_cli);
                pn.Controls.Add(pb_ped);
                pn.Controls.Add(lb_ped);
                pn.Controls.Add(lb_data);
                pn.Controls.Add(pb_vend);
                pn.Controls.Add(lb_vend);

                flp_1.Controls.Add(pn);


            }




        }
        private void fillDash2()
        {

            //dash_pb_progress2.Visible = true;
            // LAÇO PARA O PANEL DE PEDIDOS RECEBIDOS / PROCESSADOS
            for (int i = 0; i < 7; i++)
            {

                // NOME DO CLIENTE
                Panel pn = new Panel();
                PictureBox pb_cli = new PictureBox();
                pb_cli.Image = Properties.Resources.user;
                pb_cli.Size = new System.Drawing.Size(17, 15);
                pb_cli.Location = new Point(4, 4);
                Label lb_cli = new Label();
                lb_cli.Location = new Point(24, 3);
                lb_cli.MinimumSize = new System.Drawing.Size(350, 0);
                lb_cli.Font = new Font("Letter Gothic", 10, FontStyle.Bold);
                lb_cli.Text = "NOME DO CLIENTE";
                lb_cli.ForeColor = Color.FromArgb(64, 64, 64);

                // NUMERO DO PEDIDO
                PictureBox pb_ped = new PictureBox();
                pb_ped.Image = Properties.Resources.package;
                pb_ped.Size = new System.Drawing.Size(17, 15);
                pb_ped.Location = new Point(4, 22);
                Label lb_ped = new Label();
                lb_ped.Location = new Point(24, 24);
                lb_ped.MinimumSize = new System.Drawing.Size(200, 0);
                lb_ped.Font = new Font("Letter Gothic", 8, FontStyle.Regular);
                lb_ped.Text = "20187125001";
                lb_ped.ForeColor = Color.FromArgb(64, 64, 64);

                // DATA DO PEDIDO
                Label lb_data = new Label();
                lb_data.Location = new Point(282, 23);
                lb_data.MinimumSize = new System.Drawing.Size(350, 0);
                lb_data.Font = new Font("Letter Gothic", 8, FontStyle.Italic);
                lb_data.Text = "01/08/2018 15:30";

                // NOME DO VENDEDOR
                PictureBox pb_vend = new PictureBox();
                pb_vend.Image = Properties.Resources.user_suit;
                pb_vend.Size = new System.Drawing.Size(17, 15);
                pb_vend.Location = new Point(4, 43);
                Label lb_vend = new Label();
                lb_vend.Location = new Point(24, 44);
                lb_vend.MinimumSize = new System.Drawing.Size(220, 0);
                lb_vend.Font = new Font("Letter Gothic", 8, FontStyle.Regular);
                lb_vend.Text = "NOME DO VENDEDOR NOME DO VENDEDOR NOME";
                lb_vend.ForeColor = Color.FromArgb(0, 0, 0);

                // NOME DO ARQUIVO
                Label lb_file = new Label();
                lb_file.Location = new Point(235, 40);
                lb_file.MinimumSize = new System.Drawing.Size(150, 0);
                lb_file.Font = new Font("Letter Gothic", 8, FontStyle.Regular);
                lb_file.Text = "0001000045601082018.TXT";
                lb_file.TextAlign = ContentAlignment.MiddleRight;
                lb_file.ForeColor = Color.FromArgb(64, 64, 64);

                pn.Width = 385;
                pn.Height = 62;
                pn.BackColor = Color.PaleGreen;
                pn.Controls.Add(pb_cli);
                pn.Controls.Add(lb_cli);
                pn.Controls.Add(pb_ped);
                pn.Controls.Add(lb_ped);
                pn.Controls.Add(lb_data);
                pn.Controls.Add(pb_vend);
                pn.Controls.Add(lb_vend);
                pn.Controls.Add(lb_file);

                flp_2.Controls.Add(pn);


            }


        }

        private void fillDash3(String ped_today, String ped_week, String ped_month, String cli_today, String cli_week, String cli_month)
        {


            lb_1.Text = ped_today;
            lb_2.Text = ped_week;
            lb_3.Text = ped_month;
            lb_4.Text = cli_today;
            lb_5.Text = cli_week;
            lb_6.Text = cli_month;


        }

        private void frm_dash_Load(object sender, EventArgs e)
        {

            SqlConnection conn = frm_main.Conexao.obterConexao();

            Int32 ped_today = 0;
            Int32 ped_week = 0;
            Int32 ped_month = 0;
            Int32 cli_today = 0;
            Int32 cli_week = 0;
            Int32 cli_month = 0;

            try {
                String query_ped_today = "SELECT * FROM ST_PED_DAY";
                SqlCommand retorno1 = new SqlCommand(query_ped_today, conn);
                ped_today = (Int32)retorno1.ExecuteScalar();
            }
            catch (Exception)
            {

            }

            try {
                String query_ped_week = "SELECT * FROM ST_PED_WEEK";
                SqlCommand retorno2 = new SqlCommand(query_ped_week, conn);
                ped_week = (Int32)retorno2.ExecuteScalar();
            }
            catch(Exception)
            {

            }

            try
            {
                String query_ped_month = "SELECT * FROM ST_PED_MONTH";
                SqlCommand retorno3 = new SqlCommand(query_ped_month, conn);
                ped_month = (Int32)retorno3.ExecuteScalar();
            }
            catch (Exception)
            {

            }

            try
            {
                String query_cli_today = "SELECT * FROM ST_CLI_DAY";
                SqlCommand retorno4 = new SqlCommand(query_cli_today, conn);
                cli_today = (Int32)retorno4.ExecuteScalar();
            }
            catch (Exception)
            {

            }

            try
            {
                String query_cli_week = "SELECT * FROM ST_CLI_WEEK";
                SqlCommand retorno5 = new SqlCommand(query_cli_week, conn);
                cli_week = (Int32)retorno5.ExecuteScalar();
            }
            catch (Exception)
            {

            }

            try
            {
                String query_cli_month = "SELECT * FROM ST_CLI_MONTH";
                SqlCommand retorno6 = new SqlCommand(query_cli_month, conn);
                cli_month = (Int32)retorno6.ExecuteScalar();
            }
            catch (Exception)
            {

            }

            fillDash1();
            fillDash2();
            fillDash3(ped_today.ToString(), ped_week.ToString(), ped_month.ToString(), cli_today.ToString(), cli_week.ToString(), cli_month.ToString());

            conn.Close();

        }
    }
}
