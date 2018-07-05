using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Integrador
{
    public partial class frm_dashboard : Form
    {
        public frm_dashboard()
        {
            InitializeComponent();

        }

        private void frm_dashboard_Load(object sender, EventArgs e)
        {

            this.Dock = DockStyle.Fill;
            this.WindowState = FormWindowState.Minimized;
            this.WindowState = FormWindowState.Maximized;
            pnl_1.Width = MdiParent.Width;

            flp_processado.Dock = DockStyle.Fill;
            flp_recebidos.Dock = DockStyle.Fill;

            pnl_recebido.Width = (MdiParent.Width / 2)-10;
            pnl_processado.Width = (MdiParent.Width / 2)-10;
            pnl_processado.Left = pnl_processado.Width;

            pnl_ped.Width = (MdiParent.Width / 2);
            pnl_cli.Width = (MdiParent.Width / 2);
            pnl_cli.Left = (MdiParent.Width / 2)-10;

            Thread recebido = new Thread(() => {

                fillDashPedidosRecebidos();

            });

            Thread processado = new Thread(() => {

                fillDashPedidosProcessados();

            });

            Thread info = new Thread(() => {

                fillDashInfo();

            });

            recebido.Start();
            processado.Start();
            info.Start();

        }

        private void fillDashPedidosRecebidos()
        {
            pnl_recebido_header.Invoke(new Action(() => pb_recebido.Visible = true));
            pn_recebido_pedido.Invoke(new Action(() => flp_recebidos.Controls.Clear()));

            // LAÇO PARA O PAINEL DE PEDIDOS RECEBIDOS / NÃO PROCESSADOS
            for (int i = 0; i < 10; i++)
            {

                // NOME DO CLIENTE
                Panel pn = new Panel();
                PictureBox pb_cli = new PictureBox();
                pb_cli.Image = Properties.Resources.user;
                pb_cli.Size = new System.Drawing.Size(17, 15);
                pb_cli.Location = new Point(4, 4);
                Label lb_cli = new Label();
                lb_cli.Location = new Point(24, 3);
                lb_cli.MinimumSize = new System.Drawing.Size(400, 0);
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
                lb_data.Location = new Point(530, 4);
                lb_data.MinimumSize = new System.Drawing.Size(110, 0);
                lb_data.Font = new Font("Letter Gothic", 8, FontStyle.Italic);
                lb_data.Text = "01/08/2018 15:30";
                //lb_data.TextAlign = ContentAlignment.MiddleRight;
                //lb_data.BorderStyle = BorderStyle.FixedSingle;

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

                // NOME DO ARQUIVO
                Label lb_file = new Label();
                lb_file.Location = new Point(475, 22);
                lb_file.MinimumSize = new System.Drawing.Size(160, 0);
                lb_file.Font = new Font("Letter Gothic", 8, FontStyle.Regular);
                lb_file.Text = "0001000045601082018.TXT";
                lb_file.TextAlign = ContentAlignment.MiddleRight;
                lb_file.ForeColor = Color.FromArgb(64, 64, 64);

                int teste = 7;

                if (teste > 6)
                {
                    pn.Width = (MdiParent.Width / 2) - 50;
                }
                else
                {
                    pn.Width = (MdiParent.Width / 2) - 33;
                }

                pn.Height = 62;
                pn.BackColor = Color.FromArgb(255, 255, 192);
                pn.Controls.Add(pb_cli);
                pn.Controls.Add(lb_cli);
                pn.Controls.Add(pb_ped);
                pn.Controls.Add(lb_ped);
                pn.Controls.Add(lb_data);
                pn.Controls.Add(pb_vend);
                pn.Controls.Add(lb_vend);
                pn.Controls.Add(lb_file);

                pn_recebido_pedido.Invoke(new Action(() => flp_recebidos.Controls.Add(pn)));

            }

            Thread.Sleep(1000);

            pnl_recebido_header.Invoke(new Action(() => pb_recebido.Visible = false));


        }

        private void fillDashPedidosProcessados()
        {

            // LAÇO PARA O PANEL DE PEDIDOS RECEBIDOS / PROCESSADOS
            for (int i = 0; i < 12; i++)
            {

                // NOME DO CLIENTE
                Panel pn = new Panel();

                int teste = 12;

                if (teste > 6)
                {
                    pn.Width = (MdiParent.Width / 2) - 50;
                }
                else
                {
                    pn.Width = (MdiParent.Width / 2) - 32;
                }

                // NOME DO CLIENTE
                PictureBox pb_cli = new PictureBox();
                pb_cli.Image = Properties.Resources.user;
                pb_cli.Size = new System.Drawing.Size(17, 15);
                pb_cli.Location = new Point(4, 4);
                Label lb_cli = new Label();
                lb_cli.Location = new Point(24, 3);
                lb_cli.AutoSize = true;
                //lb_cli.MaximumSize = 
                //lb_cli.MinimumSize = new System.Drawing.Size(150, 0);
                lb_cli.Font = new Font("Letter Gothic", 10, FontStyle.Bold);
                lb_cli.Text = "NOME DO CLIENTE";
                lb_cli.ForeColor = Color.FromArgb(64, 64, 64);
                lb_cli.BorderStyle = BorderStyle.FixedSingle;

                // DATA DO PEDIDO
                Label lb_data = new Label();
                lb_data.Location = new Point(pn.Width-110, 4);
                lb_data.AutoSize = true;
                //lb_data.MinimumSize = new System.Drawing.Size(110, 0);
                lb_data.Font = new Font("Letter Gothic", 8, FontStyle.Italic);
                lb_data.Text = "01/08/2018 15:30";
                lb_data.BorderStyle = BorderStyle.FixedSingle;

                // NUMERO DO PEDIDO
                PictureBox pb_ped = new PictureBox();
                pb_ped.Image = Properties.Resources.package;
                pb_ped.Size = new System.Drawing.Size(17, 15);
                pb_ped.Location = new Point(4, 22);
                Label lb_ped = new Label();
                lb_ped.Location = new Point(24, 24);
                lb_ped.AutoSize = true;
                //lb_ped.MinimumSize = new System.Drawing.Size(200, 0);
                lb_ped.Font = new Font("Letter Gothic", 8, FontStyle.Regular);
                lb_ped.Text = "20187125001";
                lb_ped.ForeColor = Color.FromArgb(64, 64, 64);
                lb_ped.BorderStyle = BorderStyle.FixedSingle;

                // NOME DO VENDEDOR
                PictureBox pb_vend = new PictureBox();
                pb_vend.Image = Properties.Resources.user_suit;
                pb_vend.Size = new System.Drawing.Size(17, 15);
                pb_vend.Location = new Point(4, 42);
                Label lb_vend = new Label();
                lb_vend.Location = new Point(24, 42);
                lb_vend.AutoSize = true;
                //lb_vend.MinimumSize = new System.Drawing.Size(220, 0);
                lb_vend.Font = new Font("Letter Gothic", 8, FontStyle.Regular);
                lb_vend.Text = "NOME DO VENDEDOR NOME DO VENDEDOR NOME";
                lb_vend.ForeColor = Color.FromArgb(0, 0, 0);
                lb_vend.BorderStyle = BorderStyle.FixedSingle;

                // NOME DO ARQUIVO
                Label lb_file = new Label();
                lb_file.Location = new Point(pn.Width-152, 22);
                lb_file.AutoSize = true;
                //lb_file.MinimumSize = new System.Drawing.Size(160, 0);
                lb_file.Font = new Font("Letter Gothic", 8, FontStyle.Regular);
                lb_file.Text = "0001000045601082018.TXT";
                lb_file.TextAlign = ContentAlignment.MiddleRight;
                lb_file.ForeColor = Color.FromArgb(64, 64, 64);
                lb_file.BorderStyle = BorderStyle.FixedSingle;

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

                pn_processado_pedido.Invoke(new Action(() => flp_processado.Controls.Add(pn)));

            }

            Thread.Sleep(1000);

            pnl_processado_header.Invoke(new Action(() => pb_processado.Visible = false));

        }

        private void fillDashInfo()
        {

            Int32 ped_today = 0;
            Int32 ped_week = 0;
            Int32 ped_month = 0;
            Int32 ped_last_month = 0;
            Int32 cli_today = 0;
            Int32 cli_week = 0;
            Int32 cli_month = 0;
            Int32 cli_last_month = 0;

            //pn_ped_today.Width = Parent.Width / 5;

            SqlConnection conn = null;

            try
            {
                conn = frm_main.Conexao.obterConexao();
            }
            catch (SqlException e)
            {

                MessageBox.Show("Aparentemente não há conexão com banco de dados.\n\nDetalhe do erro: " + e.Message, "Erro.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                pn_ped_today.Invoke(new Action(() => pb_ped.Visible = false));
                pn_cli_today.Invoke(new Action(() => pb_cli.Visible = false));

            }
            

            if (conn != null || conn.State != ConnectionState.Closed)
            {

                try
                {

                    String query_ped_today = "SELECT * FROM ST_PED_DAY";
                    String query_ped_week = "SELECT * FROM ST_PED_WEEK";
                    String query_ped_month = "SELECT * FROM ST_PED_MONTH";
                    String query_ped_last_month = "SELECT * FROM ST_PED_LAST_MONTH";
                    String query_cli_today = "SELECT * FROM ST_CLI_DAY";
                    String query_cli_week = "SELECT * FROM ST_CLI_WEEK";
                    String query_cli_month = "SELECT * FROM ST_CLI_MONTH";
                    String query_cli_last_month = "SELECT * FROM ST_CLI_LAST_MONTH";

                    SqlCommand retorno1 = new SqlCommand(query_ped_today, conn);
                    ped_today = (Int32)retorno1.ExecuteScalar();
                    SqlCommand retorno2 = new SqlCommand(query_ped_week, conn);
                    ped_week = (Int32)retorno2.ExecuteScalar();
                    SqlCommand retorno3 = new SqlCommand(query_ped_month, conn);
                    ped_month = (Int32)retorno3.ExecuteScalar();
                    SqlCommand retorno4 = new SqlCommand(query_ped_last_month, conn);
                    ped_last_month = (Int32)retorno4.ExecuteScalar();
                    SqlCommand retorno5 = new SqlCommand(query_cli_today, conn);
                    cli_today = (Int32)retorno5.ExecuteScalar();
                    SqlCommand retorno6 = new SqlCommand(query_cli_week, conn);
                    cli_week = (Int32)retorno6.ExecuteScalar();
                    SqlCommand retorno7 = new SqlCommand(query_cli_month, conn);
                    cli_month = (Int32)retorno7.ExecuteScalar();
                    SqlCommand retorno8 = new SqlCommand(query_cli_last_month, conn);
                    cli_last_month = (Int32)retorno8.ExecuteScalar();

                    Thread.Sleep(2000);

                    pn_ped_today.Invoke(new Action(() => pb_ped.Visible = false));
                    pn_cli_today.Invoke(new Action(() => pb_cli.Visible = false));

                    pn_ped_today.Invoke(new Action(() => lb_ped_today.Text = ped_today.ToString()));
                    pn_ped_week.Invoke(new Action(() => lb_ped_week.Text = ped_week.ToString()));
                    pn_ped_month.Invoke(new Action(() => lb_ped_month.Text = ped_month.ToString()));
                    pn_ped_last_month.Invoke(new Action(() => lb_ped_last_month.Text = ped_last_month.ToString()));
                    pn_cli_today.Invoke(new Action(() => lb_cli_today.Text = cli_today.ToString()));
                    pn_cli_week.Invoke(new Action(() => lb_cli_week.Text = cli_week.ToString()));
                    pn_cli_month.Invoke(new Action(() => lb_cli_month.Text = cli_month.ToString()));
                    pn_cli_last_month.Invoke(new Action(() => lb_cli_last_month.Text = cli_last_month.ToString()));

                    pn_ped_today.Invoke(new Action(() => lb_ped_today.Visible = true));
                    pn_ped_week.Invoke(new Action(() => lb_ped_week.Visible = true));
                    pn_ped_month.Invoke(new Action(() => lb_ped_month.Visible = true));
                    pn_ped_last_month.Invoke(new Action(() => lb_ped_last_month.Visible = true));
                    pn_cli_today.Invoke(new Action(() => lb_cli_today.Visible = true));
                    pn_cli_week.Invoke(new Action(() => lb_cli_week.Visible = true));
                    pn_cli_month.Invoke(new Action(() => lb_cli_month.Visible = true));
                    pn_cli_last_month.Invoke(new Action(() => lb_cli_last_month.Visible = true));

                }
                catch (SqlException e)
                {

                    MessageBox.Show("Aparentemente existe erro em alguma consulta com banco de dados.\n\nDetalhe do erro: " + e.Message, "Erro.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    pn_ped_today.Invoke(new Action(() => pb_ped.Visible = false));
                    pn_cli_today.Invoke(new Action(() => pb_cli.Visible = false));

                }

                conn.Close();

            }

            //conn.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread recebido = new Thread(() => {

                fillDashPedidosRecebidos();

            });
            recebido.Start();

        }

        private void tm_main_Tick(object sender, EventArgs e)
        {
            // INSTANCIA UM OBJETO DE DATA E HORA
            DateTime dt = DateTime.Now;

            string data = (string.Format("{0:HH:mm:ss}", dt));
            char primeira = char.ToUpper(data[0]);
            //label1.Text = primeira + data.Substring(1);
            //label1.Text = data;
            //label1.Update();

            if (string.Format("{0:HH:mm:ss}", dt) == "20:47" + ":00")
            {

                Thread recebido = new Thread(() => {

                    fillDashPedidosRecebidos();

                });
                recebido.Start();

            }

        }
    }
}
