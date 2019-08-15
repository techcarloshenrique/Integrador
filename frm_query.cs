using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Integrador
{
    public partial class frm_query : Form
    {

        SqlConnection conn;
        public frm_query()
        {
            InitializeComponent();
            
        }

        private void frm_query_Load(object sender, EventArgs e)
        {

            cb_destino.Items.Add("SITE");
            cb_destino.Items.Add("CARGA");
            cb_destino.SelectedIndex = 0;
            loadDataGridView();

        }

        public void loadDataGridView() {


            String query = "SELECT * FROM query";
            conn = frm_main.Conexao.obterConexao();
            SqlCommand retorno = new SqlCommand(query, conn);
            SqlDataReader row = retorno.ExecuteReader();
            DataTable lista = new DataTable();
            lista.Load(row);
            dgv_query.DataSource = lista;
            //dgv_query.SelectionMode = DataGridViewSelectionMode.FullColumnSelect;
            //dgv_query.ColumnS = DataGridViewColumnSortMode.NotSortable;
            dgv_query.MultiSelect = false;
            for (int i = 0; i < dgv_query.Columns.Count; i++)
            {

                dgv_query.Columns[i].HeaderText = FirstCharToUpper(dgv_query.Columns[i].Name.Replace("_", " "));

            }


        }

        public static string FirstCharToUpper(string value)
        {
            char[] array = value.ToCharArray();
            // Handle the first letter in the string.  
            if (array.Length >= 1)
            {
                if (char.IsLower(array[0]))
                {
                    array[0] = char.ToUpper(array[0]);
                }
            }
            // Scan through the letters, checking for spaces.  
            // ... Uppercase the lowercase letters following spaces.  
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i - 1] == ' ')
                {
                    if (char.IsLower(array[i]))
                    {
                        array[i] = char.ToUpper(array[i]);
                    }
                }
            }
            return new string(array);
        }

        private void bt_save_Click(object sender, EventArgs e)
        {
            conn = frm_main.Conexao.obterConexao();
            String nome_view = tb_view.Text;
            String nome_secao = tb_secao.Text;
            String destino = cb_destino.SelectedItem.ToString().ToLower();
            String _query = rtb_query.Text;
            String query = "INSERT INTO query " +
                            "(id, nome_view, nome_secao, destino, query) VALUES " +
                            "((SELECT ISNULL(MAX(id)+1,1) FROM query WITH(SERIALIZABLE, UPDLOCK)), '" + nome_view+"', '"+nome_secao+"', '"+destino+"', '"+_query+"')";
            SqlCommand com = new SqlCommand(query, conn);
            com.ExecuteNonQuery();
            dgv_query.Update();
            dgv_query.Refresh();
            loadDataGridView();
            conn.Close();
            
        }

    }
}
