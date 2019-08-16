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
    public partial class frm_query : Form
    {

        SqlConnection conn;
        DataTable tabela;
        String query;
        public frm_query()
        {
            InitializeComponent();
            
        }

        private void frm_query_Load(object sender, EventArgs e)
        {
            tb_secao.CharacterCasing = CharacterCasing.Upper;
            conn = frm_main.Conexao.obterConexao();
            List<string> tables = new List<string>();
            DataTable dt = conn.GetSchema("Tables");

            foreach (DataRow rowTables in dt.Rows)
            {
                string tablename = (string)rowTables[2];
                cb_view.Items.Add(tablename);
            }
            cb_view.SelectedIndex = 0;
            cb_destino.Items.Add("SITE");
            cb_destino.Items.Add("CARGA");
            cb_destino.SelectedIndex = 0;
            loadDataGridView();
        }

      
        public void loadDataGridView() {

           
            String query = "SELECT * FROM SONIC_QUERY";
            conn = frm_main.Conexao.obterConexao();
            SqlCommand retorno = new SqlCommand(query, conn);
            SqlDataReader row = retorno.ExecuteReader();
            DataTable lista = new DataTable();
            lista.Load(row);
            dgv_query.DataSource = lista;
            if (dgv_query.Rows.Count > 0) {
                dgv_query.Rows[0].Selected = true;
            }
            dgv_query.DefaultCellStyle.SelectionBackColor = Color.PaleGreen;
            dgv_query.DefaultCellStyle.SelectionForeColor = Color.Black;
            DataGridViewColumn c = dgv_query.Columns[0];
            DataGridViewColumn d = dgv_query.Columns[3];
            DataGridViewColumn e = dgv_query.Columns[4];
            c.Width = 30;
            d.Width = 50;
            e.Width = 50;


            for (int i = 0; i < dgv_query.Columns.Count; i++)
            {

                dgv_query.Columns[i].HeaderText = Util.FirstCharToUpper(dgv_query.Columns[i].Name.Replace("_", " "));

            }


        }

        private void bt_save_Click(object sender, EventArgs e)
        {

            if (cb_view.Text == "" || tb_secao.Text == "" || cb_destino.Text == "" || rtb_query.Text == "")
            {
                //MessageBox.Show("Preencha todos os campos","Aviso");
                Messages m = new Messages();
                m.dialogMessage("Preencha todos os campos", Messages.INFO);
                    
            }
            else {

                lb_result.Visible = false;

                int usuario = 0;
                String _query = rtb_query.Text;

                if (cb_usuario.Checked)
                {
                    _query += " WHERE USUARIO = ?";
                    usuario = 1;
                }
                String nome_view = cb_view.Text;
                String nome_secao = tb_secao.Text;
                String destino = cb_destino.SelectedItem.ToString().ToLower();
                  
                String query = 
                    "INSERT INTO SONIC_QUERY " +
                    "(id, nome_view, nome_secao, destino, usuario, query) VALUES " +
                    "((SELECT ISNULL(MAX(id)+1,1) FROM SONIC_QUERY WITH(SERIALIZABLE, UPDLOCK)), '" + nome_view + "', '" + nome_secao + "', '" + destino + "', " +usuario+ ", '" + _query + "')";

                Database d = new Database();
                d.Insert(query);
                d.closeConn();
                loadDataGridView();
                tb_secao.Text = "";
                rtb_query.Text = "";

            }

        }

        private void bt_testar_Click(object sender, EventArgs e)
        {
            if (rtb_query.Text == "")
            {
                MessageBox.Show("Query não pode ficar em branco", "Aviso");
            }
            else {

                pb_progress.Visible = true;
                query = rtb_query.Text;
                BackgroundWorker bgw = new BackgroundWorker();
                bgw = new BackgroundWorker();
                bgw.WorkerReportsProgress = true;
                //bgw.ProgressChanged += new ProgressChangedEventHandler(bgw_ProgressChanged);
                bgw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bgw_RunWorkerCompleted);
                bgw.DoWork += new DoWorkEventHandler(bgw_DoWork);
                bgw.RunWorkerAsync();

              
            }

        }

        void bgw_DoWork(object sender, DoWorkEventArgs e)
        {

            try {
                conn = Connect.obterConexao();
                SqlCommand retorno = new SqlCommand(query, conn);
                SqlDataReader row = retorno.ExecuteReader();
                tabela = new DataTable();
                tabela.Load(row);
            }
            catch (SqlException ex) {
                MessageBox.Show(ex.Message);
            }
            
        }

        void bgw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

            pb_progress.Visible = false;
            lb_result.Visible = true;
            if (tabela.Rows.Count == 0)
            {
                lb_result.ForeColor = System.Drawing.Color.Red;
            }
            else
            {

                lb_result.ForeColor = System.Drawing.Color.ForestGreen;

            }

            lb_result.Text = "A consulta retornou " + tabela.Rows.Count + " registros.";
        }

        private void cb_view_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_secao.Text = cb_view.Text.Replace("SONIC_", "[") + "]";
            rtb_query.Text = "SELECT * FROM " + cb_view.Text;
        }

        private void tsb_excluir_Click(object sender, EventArgs e)
        {
            if (dgv_query.SelectedRows.Count > 0)
            {

                DialogResult res = MessageBox.Show("Deseja excluir o(s) registro(s)?", "Excluir", MessageBoxButtons.OKCancel);
                if (res == DialogResult.OK) {


                    try
                    {

                        String id = String.Empty;
                        String query = String.Empty;
                        conn = frm_main.Conexao.obterConexao();

                        foreach (DataGridViewRow r in dgv_query.SelectedRows)
                        {

                            id = r.Cells[0].Value.ToString();
                            query = "DELETE FROM SONIC_QUERY WHERE id = " + id;
                            SqlCommand com = new SqlCommand(query, conn);
                            com.ExecuteNonQuery();

                        }

                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally {
                        conn.Close();
                        loadDataGridView();
                    }
                   
                }
                
            }
            else
            {
                MessageBox.Show("Por favor, selecione uma linha.", "Aviso");
            }
        }

        private void tsb_refresh_Click(object sender, EventArgs e)
        {
            loadDataGridView();
        }
    }
}
