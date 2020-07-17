using System;
using System.Collections;
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

        public bool formAberto(String form)
        {

            try
            {

                if (Application.OpenForms[form] != null)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Erro", MessageBoxButtons.OK);
                new LogWriter(ex.Message, ex.StackTrace);
            }

            return false;
        }

        public void abrirFormDialog(String form, Form origem)
        {

            if (formAberto(form))
            {
                Application.OpenForms[form].BringToFront();
            }
            else
            {
                origem.ShowDialog();
            }

        }

        private void frm_query_Load(object sender, EventArgs e)
        {
            loadSiteList();
            loadUserList();
        }

        public String checkTabActive() {
            String tab = String.Empty;
            if (tbc_arquivos.SelectedTab == tbc_arquivos.TabPages["tp_site"])
            {
                tab = "SITE";
            }
            else {
                tab = "USUARIOS";
            }
            return tab;
        }

        public void loadSiteList() {
            String query = "SELECT secao FROM SONIC_SECAO_SITE";
            conn = Conexao.obterConexao();

            SqlCommand retorno = new SqlCommand(query, conn);
            SqlDataReader row = retorno.ExecuteReader();
            DataTable lista = new DataTable();
            if (row.HasRows) {
                lista.Load(row);
                dgv_site.ReadOnly = true;
            }
            dgv_site.AdvancedCellBorderStyle.All = DataGridViewAdvancedCellBorderStyle.None;
            dgv_site.AllowUserToAddRows = false;
            dgv_site.DataSource = lista;
            dgv_site.ColumnHeadersVisible = false;
            dgv_site.RowHeadersVisible = false;
            dgv_site.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_site.AllowUserToResizeRows = false;
           
            dgv_site.DefaultCellStyle.SelectionBackColor = Color.PaleGreen;
            dgv_site.DefaultCellStyle.SelectionForeColor = Color.Black;
            if (dgv_site.Rows.Count > 0)
            {
                dgv_site.Rows[0].Selected = true;
                SqlCommand cmd = new SqlCommand("SELECT TOP 5 query FROM SONIC_SECAO_SITE ORDER BY id", conn);
                rtb_site_query.Text = cmd.ExecuteScalar().ToString();

            }
            else
            {
                rtb_site_query.Text = "";
            }
            
        }

        public void loadUserList()
        {
            String query = "SELECT secao, usuario FROM SONIC_SECAO_USUARIOS";
            conn = Conexao.obterConexao();

            SqlCommand retorno = new SqlCommand(query, conn);
            SqlDataReader row = retorno.ExecuteReader();
            DataTable lista = new DataTable();
            if (row.HasRows)
            {
                lista.Load(row);
                dgv_usuarios.ReadOnly = true;
            }
            dgv_usuarios.AdvancedCellBorderStyle.All = DataGridViewAdvancedCellBorderStyle.None;
            dgv_usuarios.AllowUserToAddRows = false;
            dgv_usuarios.DataSource = lista;
            dgv_usuarios.ColumnHeadersVisible = false;
            dgv_usuarios.RowHeadersVisible = false;
            dgv_usuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_usuarios.AllowUserToResizeRows = false;

            dgv_usuarios.DefaultCellStyle.SelectionBackColor = Color.PaleGreen;
            dgv_usuarios.DefaultCellStyle.SelectionForeColor = Color.Black;
            if (dgv_usuarios.Rows.Count > 0)
            {
                dgv_usuarios.Rows[0].Selected = true;
                SqlCommand cmd = new SqlCommand("SELECT TOP 5 query FROM SONIC_SECAO_USUARIOS ORDER BY id", conn);
                rtb_usuarios_query.Text = cmd.ExecuteScalar().ToString();
            }
            else
            {
                rtb_usuarios_query.Text = "";
            }

        }

        private void loadExampleList(Boolean site)
        {

            //Task.Run(() => GetDetailsForFileById(site));

            DataGridView common;
            String query = String.Empty;
            PictureBox pb = null;
            if (site)
            {
                query = rtb_site_query.Text.Replace("*", "TOP 5 * ").Replace("WHERE CODIGO_USUARIO = ?","");
                common = dgv_site_exemplo;
                pb = pb_site_progress;
            }
            else {
                query = rtb_usuarios_query.Text.Replace("*", "TOP 5 * ").Replace("WHERE CODIGO_USUARIO = ?", "");
                common = dgv_usuarios_exemplo;
                pb = pb_usuarios_progress;

            }

            conn = Conexao.obterConexao();
            SqlCommand retorno = new SqlCommand(query, conn);
            SqlDataReader row = null;
            try
            {
                row = retorno.ExecuteReader();
                DataTable lista = new DataTable();
                if (row.HasRows)
                {
                    lista.Load(row);
                    common.ReadOnly = true;
                    pb.Visible = false;
                }
                common.AdvancedCellBorderStyle.All = DataGridViewAdvancedCellBorderStyle.None;
                common.AllowUserToAddRows = false;
                common.DataSource = lista;
                //common.ColumnHeadersVisible = false;
                //common.RowHeadersVisible = false;
                //common.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                common.AllowUserToResizeRows = false;
                common.DefaultCellStyle.SelectionBackColor = Color.PaleGreen;
                common.DefaultCellStyle.SelectionForeColor = Color.Black;
            }
            catch (SqlException ex)
            {
                common.DataSource = null;
                common.Refresh();
                pb.Visible = false;
                MessageBox.Show(ex.Message);
            }
           
            
        }

        public async Task GetDetailsForFileById(Boolean site)
        {

            DataTable lista = new DataTable();
            SqlCommand retorno;
            DataGridView common;
            conn = Conexao.obterConexao();
            String query = String.Empty;
            PictureBox pb = null;
            if (site)
            {
                query = rtb_site_query.Text;
                common = dgv_site_exemplo;
                pb = pb_site_progress;
            }
            else
            {
                query = rtb_usuarios_query.Text.Replace("*", "TOP 1 * ");
                common = dgv_site_exemplo;
                pb = pb_site_progress;

            }

            using (conn)
            {
                using (retorno = new SqlCommand(query, conn))
                {
                    retorno.CommandType = CommandType.Text;

                    //retorno.Parameters.AddWithValue("Id", id);

                    await conn.OpenAsync();

                    using (var reader = await retorno.ExecuteReaderAsync())
                    {
                        if (await reader.ReadAsync())
                        {
                            pb.Visible = false;
                            lista.Load(reader);
                            common.AdvancedCellBorderStyle.All = DataGridViewAdvancedCellBorderStyle.None;
                            common.AllowUserToAddRows = false;
                            common.DataSource = lista;
                            //common.ColumnHeadersVisible = false;
                            //common.RowHeadersVisible = false;
                            //common.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                            common.AllowUserToResizeRows = false;
                            common.DefaultCellStyle.SelectionBackColor = Color.PaleGreen;
                            common.DefaultCellStyle.SelectionForeColor = Color.Black;
                        }
                    }
                }
            }

        }

        public void loadComBoList() {
            //tb_secao.CharacterCasing = CharacterCasing.Upper;
            conn = Conexao.obterConexao();
            List<string> tables = new List<string>();
            DataTable dt = conn.GetSchema("Views");

            ArrayList valuesList = new ArrayList();
            SqlCommand command = new SqlCommand("SELECT SECAO FROM SONIC_QUERY", conn);
            SqlDataReader dataReader = command.ExecuteReader();
            int count = 0;
            while (dataReader.Read())
            {
                valuesList.Add(dataReader[0].ToString());
                //MessageBox.Show(valuesList[count].ToString());
                count += 1;
            }
            conn.Close();
            int count2 = 0;
        
            foreach (DataRow rowTables in dt.Rows)
            {

                string tablename = (string)rowTables[2];

                if (!valuesList.Contains(tablename.ToString()))
                {
                    //cb_view.Items.Add(tablename);
                }


                count2 += 1;
            }
        }

        public void loadDataGridView() {

           
            String query = "SELECT * FROM SONIC_QUERY";
            conn = Conexao.obterConexao();
     
            SqlCommand retorno = new SqlCommand(query, conn);
            SqlDataReader row = retorno.ExecuteReader();
            DataTable lista = new DataTable();
            lista.Load(row);
            //dgv_query.DataSource = lista;
            //if (dgv_query.Rows.Count > 0) {
            //    dgv_query.Rows[0].Selected = true;
            //}
            //dgv_query.DefaultCellStyle.SelectionBackColor = Color.PaleGreen;
            //dgv_query.DefaultCellStyle.SelectionForeColor = Color.Black;
            //DataGridViewColumn c = dgv_query.Columns[0];
            //DataGridViewColumn d = dgv_query.Columns[3];
            //DataGridViewColumn e = dgv_query.Columns[4];
           // d.ReadOnly = false;
            //e.ReadOnly = false;
            //c.Width = 30;
            //d.Width = 50;
            //e.Width = 50;


            //for (int i = 0; i < dgv_query.Columns.Count; i++)
           // {

             //   dgv_query.Columns[i].HeaderText = Util.FirstCharToUpper(dgv_query.Columns[i].Name.Replace("_", " "));
                //dgv_query.Columns[i].ReadOnly = false;

            //}


        }

        private void bt_save_Click(object sender, EventArgs e)
        {

            /*if (cb_view.Text == "" || tb_secao.Text == "" || cb_destino.Text == "" || rtb_query.Text == "")
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
                    _query += " WHERE CODIGO_USUARIO = ?";
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

            }*/

        }

        private void bt_testar_Click(object sender, EventArgs e)
        {
            /*if (rtb_query.Text == "")
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

              
            }*/

        }

        void bgw_DoWork(object sender, DoWorkEventArgs e)
        {

            try {
                conn = Conexao.obterConexao();
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

            /*pb_progress.Visible = false;
            lb_result.Visible = true;
            if (tabela.Rows.Count == 0)
            {
                lb_result.ForeColor = System.Drawing.Color.Red;
            }
            else
            {

                lb_result.ForeColor = System.Drawing.Color.ForestGreen;

            }

            lb_result.Text = tabela.Rows.Count + " registros encontrados.";*/
        }

        private void cb_view_SelectedIndexChanged(object sender, EventArgs e)
        {
            //tb_secao.Text = cb_view.Text.Replace("SONIC_", "[") + "]";
            //rtb_query.Text = "SELECT * FROM " + cb_view.Text;
        }

        private void tsb_refresh_Click(object sender, EventArgs e)
        {
            loadDataGridView();
        }

        private void cb_view_DropDown(object sender, EventArgs e)
        {
            //cb_view.Text = "";
            //cb_view.Items.Clear();
            //loadComBoList();
        }

        private void dgv_site_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgv_site.Rows[e.RowIndex].Selected = true;
            tsb_site_salvar.Enabled = false;
            rtb_site_query.Enabled = false;
            if (e.ColumnIndex == 0){
                conn = Conexao.obterConexao();
                dgv_site_exemplo.DataSource = null;
                dgv_site_exemplo.Refresh();
                rtb_site_query.Text = "";
                SqlCommand cmd = new SqlCommand("SELECT query FROM SONIC_SECAO_SITE WHERE secao = '" + dgv_site.CurrentCell.Value.ToString() + "'", conn);
                rtb_site_query.Text = cmd.ExecuteScalar().ToString();
            }
            
        }
        private void dgv_usuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgv_usuarios.Rows[e.RowIndex].Selected = true;
            tsb_usuarios_salvar.Enabled = false;
            rtb_usuarios_query.Enabled = false;
            if (e.ColumnIndex==0) {
                conn = Conexao.obterConexao();
                dgv_usuarios_exemplo.DataSource = null;
                dgv_usuarios_exemplo.Refresh();
                rtb_usuarios_query.Text = "";
                SqlCommand cmd = new SqlCommand("SELECT query FROM SONIC_SECAO_USUARIOS WHERE secao = '" + dgv_usuarios.CurrentCell.Value.ToString() + "'", conn);
                rtb_usuarios_query.Text = cmd.ExecuteScalar().ToString();
            }
        }

        private void tsb_site_excluir_Click(object sender, EventArgs e)
        {

           if (dgv_site.SelectedRows.Count > 0)
           {

               DialogResult res = MessageBox.Show("Deseja excluir o(s) registro(s)?", "Excluir", MessageBoxButtons.OKCancel);
               if (res == DialogResult.OK) {


                   try
                   {

                       String secao = String.Empty;
                       String query = String.Empty;
                       conn = Conexao.obterConexao();

                       foreach (DataGridViewRow r in dgv_site.SelectedRows)
                       {

                           secao = r.Cells[0].Value.ToString();
                           query = "DELETE FROM SONIC_SECAO_SITE WHERE secao = '" + r.Cells[0].Value.ToString() + "'";
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
                       loadSiteList();
                   }

               }

           }
           else
           {
               MessageBox.Show("Por favor, selecione uma linha.", "Aviso");
           }

        }

        private void tsb_usuarios_excluir_Click(object sender, EventArgs e)
        {
            if (dgv_usuarios.SelectedRows.Count > 0)
            {

                DialogResult res = MessageBox.Show("Deseja excluir o(s) registro(s)?", "Excluir", MessageBoxButtons.OKCancel);
                if (res == DialogResult.OK)
                {


                    try
                    {

                        String secao = String.Empty;
                        String query = String.Empty;
                        conn = Conexao.obterConexao();

                        foreach (DataGridViewRow r in dgv_usuarios.SelectedRows)
                        {

                            secao = r.Cells[0].Value.ToString();
                            query = "DELETE FROM SONIC_SECAO_USUARIOS WHERE secao = '" + r.Cells[0].Value.ToString() + "'";
                            SqlCommand com = new SqlCommand(query, conn);
                            com.ExecuteNonQuery();

                        }

                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        conn.Close();
                        loadUserList();
                    }

                }

            }
            else
            {
                MessageBox.Show("Por favor, selecione uma linha.", "Aviso");
            }
        }

        private void tbs_site_add_Click(object sender, EventArgs e)
        {

            String form = "frm_secao";
            frm_secao db = new frm_secao(this);
            abrirFormDialog(form, db);
           
        }
        private void tsb_usuarios_add_Click(object sender, EventArgs e)
        {
            String form = "frm_secao";
            frm_secao db = new frm_secao(this);
            abrirFormDialog(form, db);
        }

        private void bt_site_validar_Click(object sender, EventArgs e)
        {
            pb_site_progress.Visible = true;
            loadExampleList(true);
            //Task.Run(() => GetDetailsForFileById(true));
        }
        private void bt_usuarios_validar_Click(object sender, EventArgs e)
        {
            pb_usuarios_progress.Visible = true;
            loadExampleList(false);
        }

       
        private void tsb_site_editar_Click(object sender, EventArgs e)
        {
            rtb_site_query.Enabled = true;
            tsb_site_salvar.Enabled = true;
        }
        private void tsb_usuarios_editar_Click(object sender, EventArgs e)
        {
            rtb_usuarios_query.Enabled = true;
            tsb_usuarios_salvar.Enabled = true;
        }

        private void tsb_site_salvar_Click(object sender, EventArgs e)
        {
            query = "UPDATE SONIC_SECAO_SITE SET query = '" + rtb_site_query.Text + "' WHERE secao = '"+ dgv_site.CurrentCell.Value.ToString() + "'";
            SqlCommand com = new SqlCommand(query, conn);
            com.ExecuteNonQuery();
            tsb_site_salvar.Enabled = false;
            rtb_site_query.Enabled = false;
        }

       

        private void tsb_usuarios_salvar_Click(object sender, EventArgs e)
        {
            query = "UPDATE SONIC_SECAO_USUARIOS SET query = '" + rtb_usuarios_query.Text + "' WHERE secao = '" + dgv_usuarios.CurrentCell.Value.ToString() + "'";
            SqlCommand com = new SqlCommand(query, conn);
            com.ExecuteNonQuery();
            tsb_usuarios_salvar.Enabled = false;
            rtb_usuarios_query.Enabled = false;
        }
    }
}
