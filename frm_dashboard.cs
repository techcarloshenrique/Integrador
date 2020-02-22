using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
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

        //private static String[] rec_files = null;
        private static int rec_count = 0;
        //private static int proc_count = 0;

        private void frm_dashboard_Load(object sender, EventArgs e)
        {

            this.Dock = DockStyle.Fill;
            this.WindowState = FormWindowState.Minimized;
            this.WindowState = FormWindowState.Maximized;
            //pnl_1.Width = MdiParent.Width;

            flp_processado.Dock = DockStyle.Fill;
            flp_recebidos.Dock = DockStyle.Fill;

            pnl_recebido.Width = (MdiParent.Width / 2)-10;
            pnl_processado.Width = (MdiParent.Width / 2)-10;
            pnl_processado.Left = pnl_processado.Width;



            pnl_rec.Width = (MdiParent.Width / 2)-16;
            pnl_cli.Width = (MdiParent.Width / 2)-16;
            pnl_cli.Location = new Point(pnl_rec.Width+9, 3);

            Thread recebido = new Thread(() => {

                fillDashPedidosRecebidos();

            });

            Thread processado = new Thread(() => {

                fillDashPedidosProcessados();

            });

            Thread info = new Thread(() => {

                //fillDashInfo();

            });

                recebido.Start();
                processado.Start();
                //info.Start();

        }


        private void fillDashPedidosRecebidos()
        {
            pnl_recebido_header.Invoke(new Action(() => pb_recebido.Visible = true));
            pn_recebido_pedido.Invoke(new Action(() => flp_recebidos.Controls.Clear()));

            if (Properties.Settings.Default.RECEBIDOS != "")
            {
                goto carregar;
            }
            else {

                goto error;

            }

            carregar:

            pn_recebido_pedido.Invoke(new Action(() => flp_recebidos.Visible = true));

            string path = Properties.Settings.Default.RECEBIDOS;
            DirectoryInfo diretorio = new DirectoryInfo(path);

            try {

                // CAPTURA TODOS OS ARQUIVOS COM EXTENSÃO TXT DO DIRETORIO DE IMPORTAÇÃO
                FileInfo[] file = diretorio.GetFiles("*.TXT");

                rec_count = file.Length;

                //MessageBox.Show(rec_count.ToString());

                String[] dados = null;
                // ADICIONA O NOME DE CADA UM EM UMA LINHA DA SESSÃO
                foreach (FileInfo fileinfo in file)
                {

                    //rec_files[rec_count] = fileinfo.ToString();

                    int counter = 0;
                    string line;
                    StreamReader files = new StreamReader(@path + "\\" + fileinfo.ToString());

                    //for (int i=0; i < rec_count; i++) {
                    //}

                    while ((line = files.ReadLine()) != null)
                    {
                        //System.Console.WriteLine(line);
                        dados = line.Split(';');
                        //MessageBox.Show(dados[0]);
                        counter++;
                    }

                    Panel pn = new Panel();

                    if (file.Length > 6)
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
                    //lb_cli.MinimumSize = new System.Drawing.Size(400, 0);
                    lb_cli.AutoSize = true;
                    lb_cli.Font = new Font("Arial", 10, FontStyle.Bold);
                    lb_cli.Text = dados[3];
                    lb_cli.ForeColor = Color.FromArgb(64, 64, 64);
                    //lb_cli.BorderStyle = BorderStyle.FixedSingle;

                    // DATA DO PEDIDO
                    Label lb_data = new Label();
                    lb_data.Location = new Point(pn.Width - 98, 4);
                    lb_data.AutoSize = true;
                    //lb_data.MinimumSize = new System.Drawing.Size(110, 0);
                    lb_data.Font = new Font("Arial", 8, FontStyle.Italic);
                    lb_data.Text = dados[4].Substring(0, 2) + '/' + dados[4].Substring(2, 2) + '/' + dados[4].Substring(4, 4) + ' ' + dados[4].Substring(8, 2) + ':' + dados[4].Substring(10, 2);
                    //lb_data.TextAlign = ContentAlignment.MiddleRight;
                    //lb_data.BorderStyle = BorderStyle.FixedSingle;

                    // NUMERO DO PEDIDO
                    PictureBox pb_ped = new PictureBox();
                    pb_ped.Image = Properties.Resources.package;
                    pb_ped.Size = new System.Drawing.Size(17, 15);
                    pb_ped.Location = new Point(4, 22);
                    Label lb_ped = new Label();
                    lb_ped.Location = new Point(24, 24);
                    lb_ped.AutoSize = true;
                    //lb_ped.MinimumSize = new System.Drawing.Size(200, 0);
                    lb_ped.Font = new Font("Arial", 8, FontStyle.Regular);
                    lb_ped.Text = "20187125001";
                    lb_ped.ForeColor = Color.FromArgb(64, 64, 64);
                    //lb_ped.BorderStyle = BorderStyle.FixedSingle;


                    // NOME DO VENDEDOR
                    PictureBox pb_vend = new PictureBox();
                    pb_vend.Image = Properties.Resources.user_suit;
                    pb_vend.Size = new System.Drawing.Size(17, 15);
                    pb_vend.Location = new Point(4, 43);
                    Label lb_vend = new Label();
                    lb_vend.Location = new Point(24, 44);
                    lb_vend.AutoSize = true;
                    //lb_vend.MinimumSize = new System.Drawing.Size(250, 0);
                    lb_vend.Font = new Font("Arial", 8, FontStyle.Regular);
                    lb_vend.Text = dados[1];
                    lb_vend.ForeColor = Color.FromArgb(64, 64, 64);
                    //lb_vend.BorderStyle = BorderStyle.FixedSingle;

                    // NOME DO ARQUIVO
                    Label lb_file = new Label();
                    lb_file.Location = new Point(pn.Width - 165, 22);
                    lb_file.MinimumSize = new System.Drawing.Size(160, 0);
                    lb_file.Font = new Font("Arial", 8, FontStyle.Regular);
                    lb_file.Text = fileinfo.ToString();
                    lb_file.TextAlign = ContentAlignment.MiddleRight;
                    lb_file.ForeColor = Color.FromArgb(64, 64, 64);
                    //lb_file.BorderStyle = BorderStyle.FixedSingle;

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

            }
            catch (Exception e) {

                MessageBox.Show(e.Message, "Erro");

            }

            goto end;

            error:

            pn_recebido_pedido.Invoke(new Action(() => pn_recebido_pedido.Controls.Remove(flp_recebidos)));
            Label erro = new Label();
            erro.Text = "Diretório de arquivos recebidos não configurado...";
            erro.ForeColor = Color.White;
            erro.Location = new Point(20, pn_recebido_pedido.Height / 2);
            erro.Font = new Font("Arial", 14, FontStyle.Regular);
            erro.MinimumSize = new System.Drawing.Size(pn_recebido_pedido.Width - 50, 0);
            pn_recebido_pedido.Invoke(new Action(() => pn_recebido_pedido.Controls.Add(erro)));

            goto end;

            end:

            Thread.Sleep(1000);
            pnl_recebido_header.Invoke(new Action(() => pb_recebido.Visible = false));


        }

        private void fillDashPedidosProcessados()
        {

            pnl_processado_header.Invoke(new Action(() => pb_processado.Visible = true));
            pn_processado_pedido.Invoke(new Action(() => flp_processado.Controls.Clear()));

            if (Properties.Settings.Default.PROCESSADOS != "")
            {
                goto carregar;
            }
            else
            {

                goto error;

            }

            carregar:

            pn_processado_pedido.Invoke(new Action(() => flp_processado.Visible = true));

            string path = Properties.Settings.Default.PROCESSADOS;
            DirectoryInfo diretorio = new DirectoryInfo(path);

            try
            {

                // CAPTURA TODOS OS ARQUIVOS COM EXTENSÃO TXT DO DIRETORIO DE IMPORTAÇÃO
                FileInfo[] file = diretorio.GetFiles("*.TXT");

                String[] dados = null;

                // ADICIONA O NOME DE CADA UM EM UMA LINHA DA SESSÃO
                foreach (FileInfo fileinfo in file)
                {


                    int counter = 0;
                    string line;
                    StreamReader files = new StreamReader(@path + "\\" + fileinfo.ToString());

                    while ((line = files.ReadLine()) != null)
                    {
                        //System.Console.WriteLine(line);
                        dados = line.Split(';');
                        //MessageBox.Show(dados[0]);
                        counter++;
                    }

                    // NOME DO CLIENTE
                    Panel pn = new Panel();

                    if (file.Length > 6)
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
                    lb_cli.Font = new Font("Arial", 10, FontStyle.Bold);
                    lb_cli.Text = dados[3];
                    lb_cli.ForeColor = Color.FromArgb(64, 64, 64);
                    //lb_cli.BorderStyle = BorderStyle.FixedSingle;

                    // DATA DO PEDIDO
                    Label lb_data = new Label();
                    lb_data.Location = new Point(pn.Width - 98, 4);
                    lb_data.AutoSize = true;
                    //lb_data.MinimumSize = new System.Drawing.Size(110, 0);
                    lb_data.Font = new Font("Arial", 8, FontStyle.Italic);
                    lb_data.Text = dados[4].Substring(0, 2) + '/' + dados[4].Substring(2, 2) + '/' + dados[4].Substring(4, 4) + ' ' + dados[4].Substring(8, 2) + ':' + dados[4].Substring(10, 2);
                    //lb_data.BorderStyle = BorderStyle.FixedSingle;

                    // NUMERO DO PEDIDO
                    PictureBox pb_ped = new PictureBox();
                    pb_ped.Image = Properties.Resources.package;
                    pb_ped.Size = new System.Drawing.Size(17, 15);
                    pb_ped.Location = new Point(4, 22);
                    Label lb_ped = new Label();
                    lb_ped.Location = new Point(24, 24);
                    lb_ped.AutoSize = true;
                    //lb_ped.MinimumSize = new System.Drawing.Size(200, 0);
                    lb_ped.Font = new Font("Arial", 8, FontStyle.Regular);
                    lb_ped.Text = "20187125001";
                    lb_ped.ForeColor = Color.FromArgb(64, 64, 64);
                    //lb_ped.BorderStyle = BorderStyle.FixedSingle;

                    // NOME DO VENDEDOR
                    PictureBox pb_vend = new PictureBox();
                    pb_vend.Image = Properties.Resources.user_suit;
                    pb_vend.Size = new System.Drawing.Size(17, 15);
                    pb_vend.Location = new Point(4, 43);
                    Label lb_vend = new Label();
                    lb_vend.Location = new Point(24, 44);
                    lb_vend.AutoSize = true;
                    //lb_vend.MinimumSize = new System.Drawing.Size(220, 0);
                    lb_vend.Font = new Font("Arial", 8, FontStyle.Regular);
                    lb_vend.Text = dados[1];
                    lb_vend.ForeColor = Color.FromArgb(0, 0, 0);
                    //lb_vend.BorderStyle = BorderStyle.FixedSingle;

                    // NOME DO ARQUIVO
                    Label lb_file = new Label();
                    lb_file.Location = new Point(pn.Width - 165, 22);
                    //lb_file.AutoSize = true;
                    lb_file.MinimumSize = new System.Drawing.Size(160, 0);
                    //lb_file.MinimumSize = new System.Drawing.Size(160, 0);
                    lb_file.Font = new Font("Arial", 8, FontStyle.Regular);
                    lb_file.Text = fileinfo.ToString();
                    lb_file.TextAlign = ContentAlignment.MiddleRight;
                    lb_file.ForeColor = Color.FromArgb(64, 64, 64);
                    //lb_file.BorderStyle = BorderStyle.FixedSingle;

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

            }
            catch (Exception e){

                MessageBox.Show(e.Message, "Erro");

            }

            goto end;

            error:

            pn_processado_pedido.Invoke(new Action(() => pn_processado_pedido.Controls.Remove(flp_processado)));
            Label erro = new Label();
            erro.Text = "Diretório de arquivos processados não configurado...";
            erro.ForeColor = Color.White;
            erro.Location = new Point(20, pn_processado_pedido.Height / 2);
            erro.Font = new Font("Arial", 14, FontStyle.Regular);
            erro.MinimumSize = new System.Drawing.Size(pn_processado_pedido.Width - 50, 0);
            pn_processado_pedido.Invoke(new Action(() => pn_processado_pedido.Controls.Add(erro)));

            goto end;

            end:

            Thread.Sleep(1000);
            pnl_processado_header.Invoke(new Action(() => pb_processado.Visible = false));

        }

        private void fillDashInfo()
        {

            

            String query_rec_today = "SELECT * FROM ST_PED_DAY";
            String query_rec_week = "SELECT * FROM ST_PED_WEEK";
            String query_rec_month = "SELECT * FROM ST_PED_MONTH";
            String query_rec_last_month = "SELECT * FROM ST_PED_LAST_MONTH";
            String query_proc_today = "SELECT * FROM ST_CLI_DAY";
            String query_proc_week = "SELECT * FROM ST_CLI_WEEK";
            String query_proc_month = "SELECT * FROM ST_CLI_MONTH";
            String query_proc_last_month = "SELECT * FROM ST_CLI_LAST_MONTH";

            Int32 int_rec_today = 0;
            Int32 int_rec_week = 0;
            Int32 int_rec_month = 0;
            Int32 int_rec_last_month = 0;
            Int32 int_proc_today = 0;
            Int32 int_proc_week = 0;
            Int32 int_proc_month = 0;
            Int32 int_proc_last_month = 0;

            SqlConnection conn = null;

            try
            {
                conn = Conexao.obterConexao();
            }
            catch (SqlException e)
            {

                MessageBox.Show("Aparentemente não há conexão com banco de dados.\n\nDetalhe do erro: " + e.Message, "Erro.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //pn_ped_today.Invoke(new Action(() => pb_ped.Visible = false));
                //pn_cli_today.Invoke(new Action(() => pb_cli.Visible = false));

            }
            

            if (conn != null || conn.State != ConnectionState.Closed)
            {

                try
                {

   
                    SqlCommand retorno1 = new SqlCommand(query_rec_today, conn);
                    int_rec_today = (Int32)retorno1.ExecuteScalar();
                    SqlCommand retorno2 = new SqlCommand(query_rec_week, conn);
                    int_rec_week = (Int32)retorno2.ExecuteScalar();
                    SqlCommand retorno3 = new SqlCommand(query_rec_month, conn);
                    int_rec_month = (Int32)retorno3.ExecuteScalar();
                    SqlCommand retorno4 = new SqlCommand(query_rec_last_month, conn);
                    int_rec_last_month = (Int32)retorno4.ExecuteScalar();
                    SqlCommand retorno5 = new SqlCommand(query_proc_today, conn);
                    int_proc_today = (Int32)retorno5.ExecuteScalar();
                    SqlCommand retorno6 = new SqlCommand(query_proc_week, conn);
                    int_proc_week = (Int32)retorno6.ExecuteScalar();
                    SqlCommand retorno7 = new SqlCommand(query_proc_month, conn);
                    int_proc_month = (Int32)retorno7.ExecuteScalar();
                    SqlCommand retorno8 = new SqlCommand(query_proc_last_month, conn);
                    int_proc_last_month = (Int32)retorno8.ExecuteScalar();

                    Panel rec_today = new Panel();
                    rec_today.Size = new System.Drawing.Size((pnl_rec.Width / 4) - 5, 88);
                    rec_today.BackColor = Color.FromArgb(153, 180, 209);
                    rec_today.Location = new Point(5, 32);
                    Label lb_rec_today = new Label();
                    lb_rec_today.AutoSize = true;
                    lb_rec_today.Location = new Point(3, 3);
                    lb_rec_today.Text = "HOJE";
                    lb_rec_today.ForeColor = Color.White;
                    lb_rec_today.Font = new Font("Arial", 10, FontStyle.Bold);
                    Label lb_rec_t_value = new Label();
                    lb_rec_t_value.Location = new Point(5, rec_today.Height / 4);
                    lb_rec_t_value.Text = int_rec_today.ToString();
                    lb_rec_t_value.MinimumSize = new System.Drawing.Size(rec_today.Width-10, (rec_today.Height) - (rec_today.Height/3));
                    if (int_rec_today.ToString().Length < 4)
                    {
                        lb_rec_t_value.Font = new Font("Arial", rec_today.Height / 2, FontStyle.Regular);
                    }
                    else {
                        lb_rec_t_value.Font = new Font("Arial", rec_today.Height / 3, FontStyle.Regular);
                    }
                    lb_rec_t_value.TextAlign = ContentAlignment.MiddleCenter;
                    //lb_t_value.BackColor = Color.Green;
                    lb_rec_t_value.ForeColor = Color.White;
                    rec_today.Controls.Add(lb_rec_today);
                    rec_today.Controls.Add(lb_rec_t_value);


                    Panel rec_week = new Panel();
                    rec_week.Size = new System.Drawing.Size((pnl_cli.Width / 4) - 5, 88);
                    rec_week.BackColor = Color.FromArgb(153, 180, 209);
                    rec_week.Location = new Point(rec_today.Width + 10, 32);
                    Label lb_rec_week = new Label();
                    lb_rec_week.AutoSize = true;
                    lb_rec_week.Location = new Point(3, 3);
                    lb_rec_week.Text = "ESSA SEMANA";
                    lb_rec_week.ForeColor = Color.White;
                    lb_rec_week.Font = new Font("Arial", 10, FontStyle.Bold);
                    Label lb_rec_w_value = new Label();
                    lb_rec_w_value.Location = new Point(5, rec_week.Height / 4);
                    lb_rec_w_value.Text = int_rec_week.ToString();
                    lb_rec_w_value.MinimumSize = new System.Drawing.Size(rec_week.Width - 10, (rec_week.Height) - (rec_week.Height / 3));
                    if (int_rec_week.ToString().Length < 4)
                    {
                        lb_rec_w_value.Font = new Font("Arial", rec_week.Height / 2, FontStyle.Regular);
                    }
                    else
                    {
                        lb_rec_w_value.Font = new Font("Arial", rec_week.Height / 3, FontStyle.Regular);
                    }
                    lb_rec_w_value.TextAlign = ContentAlignment.MiddleCenter;
                    //lb_t_value.BackColor = Color.Green;
                    lb_rec_w_value.ForeColor = Color.White;
                    rec_week.Controls.Add(lb_rec_week);
                    rec_week.Controls.Add(lb_rec_w_value);

                    Panel rec_month = new Panel();
                    rec_month.Size = new System.Drawing.Size((pnl_cli.Width / 4) - 5, 88);
                    rec_month.BackColor = Color.FromArgb(153, 180, 209);
                    rec_month.Location = new Point(rec_today.Width + rec_week.Width + 15, 32);
                    Label lb_rec_month = new Label();
                    lb_rec_month.AutoSize = true;
                    lb_rec_month.Location = new Point(3, 3);
                    lb_rec_month.Text = "MÊS ATUAL";
                    lb_rec_month.ForeColor = Color.White;
                    lb_rec_month.Font = new Font("Arial", 10, FontStyle.Bold);
                    Label lb_rec_m_value = new Label();
                    lb_rec_m_value.Location = new Point(5, rec_month.Height / 4);
                    lb_rec_m_value.Text = int_rec_month.ToString();
                    lb_rec_m_value.MinimumSize = new System.Drawing.Size(rec_month.Width - 10, (rec_month.Height) - (rec_month.Height / 3));
                    if (int_rec_month.ToString().Length < 4)
                    {
                        lb_rec_m_value.Font = new Font("Arial", rec_month.Height / 2, FontStyle.Regular);
                    }
                    else
                    {
                        lb_rec_m_value.Font = new Font("Arial", rec_month.Height / 3, FontStyle.Regular);
                    }
                    lb_rec_m_value.TextAlign = ContentAlignment.MiddleCenter;
                    //lb_rec_m_value.BackColor = Color.Green;
                    lb_rec_m_value.ForeColor = Color.White;
                    rec_month.Controls.Add(lb_rec_month);
                    rec_month.Controls.Add(lb_rec_m_value);

                    Panel rec_last_month = new Panel();
                    rec_last_month.Size = new System.Drawing.Size((pnl_cli.Width / 4) - 6, 88);
                    rec_last_month.BackColor = Color.FromArgb(153, 180, 209);
                    rec_last_month.Location = new Point(rec_today.Width + rec_week.Width + rec_month.Width + 20, 32);
                    Label lb_rec_last_month = new Label();
                    lb_rec_last_month.AutoSize = true;
                    lb_rec_last_month.Location = new Point(3, 3);
                    lb_rec_last_month.Text = "MÊS ANTERIOR";
                    lb_rec_last_month.ForeColor = Color.White;
                    lb_rec_last_month.Font = new Font("Arial", 10, FontStyle.Bold);
                    Label lb_rec_lm_value = new Label();
                    lb_rec_lm_value.Location = new Point(5, rec_last_month.Height / 4);
                    lb_rec_lm_value.Text = int_rec_last_month.ToString();
                    lb_rec_lm_value.MinimumSize = new System.Drawing.Size(rec_last_month.Width - 10, (rec_last_month.Height) - (rec_last_month.Height / 3));
                    if (int_rec_last_month.ToString().Length < 4)
                    {
                        lb_rec_lm_value.Font = new Font("Arial", rec_last_month.Height / 2, FontStyle.Regular);
                    }
                    else
                    {
                        lb_rec_lm_value.Font = new Font("Arial", rec_last_month.Height / 3, FontStyle.Regular);
                    }
                    lb_rec_lm_value.TextAlign = ContentAlignment.MiddleCenter;
                    //lb_t_value.BackColor = Color.Green;
                    lb_rec_lm_value.ForeColor = Color.White;
                    rec_last_month.Controls.Add(lb_rec_last_month);
                    rec_last_month.Controls.Add(lb_rec_lm_value);

                    Panel proc_today = new Panel();
                    proc_today.Size = new System.Drawing.Size((pnl_cli.Width / 4) - 5, 88);
                    proc_today.BackColor = Color.FromArgb(153, 180, 209);
                    proc_today.Location = new Point(5, 32);
                    Label lb_proc_today = new Label();
                    lb_proc_today.AutoSize = true;
                    lb_proc_today.Location = new Point(3, 3);
                    lb_proc_today.Text = "HOJE";
                    lb_proc_today.ForeColor = Color.White;
                    lb_proc_today.Font = new Font("Arial", 10, FontStyle.Bold);
                    Label lb_proc_t_value = new Label();
                    lb_proc_t_value.Location = new Point(5, proc_today.Height / 4);
                    lb_proc_t_value.Text = int_proc_today.ToString();
                    lb_proc_t_value.MinimumSize = new System.Drawing.Size(proc_today.Width - 10, (proc_today.Height) - (proc_today.Height / 3));
                    if (int_proc_today.ToString().Length < 4)
                    {
                        lb_proc_t_value.Font = new Font("Arial", proc_today.Height / 2, FontStyle.Regular);
                    }
                    else
                    {
                        lb_proc_t_value.Font = new Font("Arial", proc_today.Height / 3, FontStyle.Regular);
                    }
                    lb_proc_t_value.TextAlign = ContentAlignment.MiddleCenter;
                    //lb_t_value.BackColor = Color.Green;
                    lb_proc_t_value.ForeColor = Color.White;
                    proc_today.Controls.Add(lb_proc_today);
                    proc_today.Controls.Add(lb_proc_t_value);


                    Panel proc_week = new Panel();
                    proc_week.Size = new System.Drawing.Size((pnl_cli.Width / 4) - 5, 88);
                    proc_week.BackColor = Color.FromArgb(153, 180, 209);
                    proc_week.Location = new Point(proc_today.Width + 10, 32);
                    Label lb_proc_week = new Label();
                    lb_proc_week.AutoSize = true;
                    lb_proc_week.Location = new Point(3, 3);
                    lb_proc_week.Text = "ESSA SEMANA";
                    lb_proc_week.ForeColor = Color.White;
                    lb_proc_week.Font = new Font("Arial", 10, FontStyle.Bold);
                    Label lb_proc_w_value = new Label();
                    lb_proc_w_value.Location = new Point(5, proc_week.Height / 4);
                    lb_proc_w_value.Text = int_proc_week.ToString();
                    lb_proc_w_value.MinimumSize = new System.Drawing.Size(proc_week.Width - 10, (proc_week.Height) - (proc_week.Height / 3));
                    if (int_proc_week.ToString().Length < 4)
                    {
                        lb_proc_w_value.Font = new Font("Arial", proc_week.Height / 2, FontStyle.Regular);
                    }
                    else
                    {
                        lb_proc_w_value.Font = new Font("Arial", proc_week.Height / 3, FontStyle.Regular);
                    }
                    lb_proc_w_value.TextAlign = ContentAlignment.MiddleCenter;
                    //lb_t_value.BackColor = Color.Green;
                    lb_proc_w_value.ForeColor = Color.White;
                    proc_week.Controls.Add(lb_proc_week);
                    proc_week.Controls.Add(lb_proc_w_value);

                    Panel proc_month = new Panel();
                    proc_month.Size = new System.Drawing.Size((pnl_cli.Width / 4) - 5, 88);
                    proc_month.BackColor = Color.FromArgb(153, 180, 209);
                    proc_month.Location = new Point(proc_today.Width + proc_week.Width + 15, 32);
                    Label lb_proc_month = new Label();
                    lb_proc_month.AutoSize = true;
                    lb_proc_month.Location = new Point(3, 3);
                    lb_proc_month.Text = "MÊS ATUAL";
                    lb_proc_month.ForeColor = Color.White;
                    lb_proc_month.Font = new Font("Arial", 10, FontStyle.Bold);
                    Label lb_proc_m_value = new Label();
                    lb_proc_m_value.Location = new Point(5, proc_month.Height / 4);
                    lb_proc_m_value.Text = int_proc_month.ToString();
                    lb_proc_m_value.MinimumSize = new System.Drawing.Size(proc_month.Width - 10, (proc_month.Height) - (proc_month.Height / 3));
                    if (int_proc_month.ToString().Length < 4)
                    {
                        lb_proc_m_value.Font = new Font("Arial", proc_month.Height / 2, FontStyle.Regular);
                    }
                    else
                    {
                        lb_proc_m_value.Font = new Font("Arial", proc_month.Height / 3, FontStyle.Regular);
                    }
                    lb_proc_m_value.TextAlign = ContentAlignment.MiddleCenter;
                    //lb_t_value.BackColor = Color.Green;
                    lb_proc_m_value.ForeColor = Color.White;
                    proc_month.Controls.Add(lb_proc_month);
                    proc_month.Controls.Add(lb_proc_m_value);

                    Panel proc_last_month = new Panel();
                    proc_last_month.Size = new System.Drawing.Size((pnl_cli.Width / 4) - 6, 88);
                    proc_last_month.BackColor = Color.FromArgb(153, 180, 209);
                    proc_last_month.Location = new Point(proc_today.Width + proc_week.Width + proc_month.Width + 20, 32);
                    Label lb_proc_last_month = new Label();
                    lb_proc_last_month.AutoSize = true;
                    lb_proc_last_month.Location = new Point(3, 3);
                    lb_proc_last_month.Text = "MÊS ANTERIOR";
                    lb_proc_last_month.ForeColor = Color.White;
                    lb_proc_last_month.Font = new Font("Arial", 10, FontStyle.Bold);
                    Label lb_proc_lm_value = new Label();
                    lb_proc_lm_value.Location = new Point(5, proc_last_month.Height / 4);
                    lb_proc_lm_value.Text = int_proc_last_month.ToString();
                    lb_proc_lm_value.MinimumSize = new System.Drawing.Size(proc_last_month.Width - 10, (proc_last_month.Height) - (proc_last_month.Height / 3));
                    if (int_proc_last_month.ToString().Length < 4)
                    {
                        lb_proc_lm_value.Font = new Font("Arial", proc_last_month.Height / 2, FontStyle.Regular);
                    }
                    else
                    {
                        lb_proc_lm_value.Font = new Font("Arial", proc_last_month.Height / 3, FontStyle.Regular);
                    }
                    lb_proc_lm_value.TextAlign = ContentAlignment.MiddleCenter;
                    //lb_t_value.BackColor = Color.Green;
                    lb_proc_lm_value.ForeColor = Color.White;
                    proc_last_month.Controls.Add(lb_proc_last_month);
                    proc_last_month.Controls.Add(lb_proc_lm_value);

                    pnl_rec.Invoke(new Action(() => pnl_rec.Controls.Add(rec_today)));
                    pnl_rec.Invoke(new Action(() => pnl_rec.Controls.Add(rec_week)));
                    pnl_rec.Invoke(new Action(() => pnl_rec.Controls.Add(rec_month)));
                    pnl_rec.Invoke(new Action(() => pnl_rec.Controls.Add(rec_last_month)));

                    pnl_cli.Invoke(new Action(() => pnl_cli.Controls.Add(proc_today)));
                    pnl_cli.Invoke(new Action(() => pnl_cli.Controls.Add(proc_week)));
                    pnl_cli.Invoke(new Action(() => pnl_cli.Controls.Add(proc_month)));
                    pnl_cli.Invoke(new Action(() => pnl_cli.Controls.Add(proc_last_month)));

                    Thread.Sleep(2000);

                    pnl_rec.Invoke(new Action(() => pb_rec.Visible = false));
                    pnl_cli.Invoke(new Action(() => pb_proc.Visible = false));
                    

                }
                catch (SqlException e)
                {

                    MessageBox.Show("Aparentemente existe erro em alguma consulta com banco de dados.\n\nDetalhe do erro: " + e.Message, "Erro.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    pnl_rec.Invoke(new Action(() => pb_rec.Visible = false));
                    pnl_cli.Invoke(new Action(() => pb_proc.Visible = false));

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

            if (string.Format("{0:HH:mm:ss}", dt) == "22:10" + ":00")
            {

                Thread recebido = new Thread(() => {

                    fillDashPedidosRecebidos();

                });
                recebido.Start();

            }

        }
    }
}
