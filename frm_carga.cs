using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Threading;

namespace Integrador
{
    public partial class frm_carga : Form
    {
  
        public frm_carga()
        {
           
            InitializeComponent();

        }

        SqlConnection conn;

        private void frm_carga_Load(object sender, EventArgs e)
        {

            loadGridView();

        }

        public void loadGridView() {

            conn = Conexao.obterConexao();

            String query = "SELECT SU.CODIGO_USUARIO, SU.NOME FROM SONIC_USUARIOS SU GROUP BY SU.CODIGO_USUARIO, SU.NOME ";

            SqlCommand retorno = new SqlCommand(query, conn);

            SqlDataReader row = retorno.ExecuteReader();

            // CRIANDO UM  E POPULANDO UM DATATABLE COM O RETORNO DA QUERY
            DataTable tabela = new DataTable();
            tabela.Load(row);

            dgv_usuario.DataSource = tabela;
            //dgv_usuario.MultiSelect = false;
            dgv_usuario.DefaultCellStyle.SelectionBackColor = Color.PaleGreen;
            dgv_usuario.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgv_usuario.Rows[0].Selected = true;
            DataGridViewColumn c = dgv_usuario.Columns[0];
            c.Width = 60;
            Conexao.fecharConexao();

        }

        private void btn_gerar_Click(object sender, EventArgs e)
        {

            if (dgv_usuario.SelectedCells.Count > 0)
            {

                List<string> userId = new List<string>();
                List<string> userName = new List<string>();
                //List<string> userName = new List<string> { };

                foreach (DataGridViewRow r in dgv_usuario.SelectedRows)
                {

                    userId.Add(r.Cells[0].Value.ToString());
                    userName.Add(r.Cells[1].Value.ToString());

                }
                this.Close();
                //(this.Owner as frm_main).gerarCargaVendedores(vendedor, false);
                (this.Owner as frm_main).gerarCargaUsuariosTabela(userId, userName, false);

            }
            else {

                MessageBox.Show("Selecione ao menos 1 usuário");
            }

        }

        private void btn_gerar_transmitir_Click(object sender, EventArgs e)
        {

            if (dgv_usuario.SelectedCells.Count > 0)
            {

                List<string> userId = new List<string>();
                List<string> userName = new List<string>();
                //List<string> userName = new List<string> { };

                foreach (DataGridViewRow r in dgv_usuario.SelectedRows)
                {

                    userId.Add(r.Cells[0].Value.ToString());
                    userName.Add(r.Cells[1].Value.ToString());

                }
                this.Close();
                //(this.Owner as frm_main).gerarCargaVendedores(vendedor, false);
                (this.Owner as frm_main).gerarCargaUsuariosTabela(userId, userName, true);

            }
            else
            {

                MessageBox.Show("Selecione ao menos 1 usuário");
            }

        }

        private void cb_all_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_all.Checked)
            {

                dgv_usuario.SelectAll();

            }
            else {

                dgv_usuario.ClearSelection();
                lb_count.Text = "0";
            }
        }

        private void dgv_usuario_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (dgv_usuario.SelectedCells.Count > 0)
            {

                int count = 0;
                foreach (DataGridViewRow r in dgv_usuario.SelectedRows)
                {
                    count++;

                }

                lb_count.Text = count.ToString();
             
            }
          
        }
    }
}
