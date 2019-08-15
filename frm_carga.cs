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

            conn = frm_main.Conexao.obterConexao();

            String query = "SELECT SU.CODIGO, SU.NOME FROM SONIC_USUARIOS SU";

            SqlCommand retorno = new SqlCommand(query, conn);

            SqlDataReader row = retorno.ExecuteReader();

            // CRIANDO UM  E POPULANDO UM DATATABLE COM O RETORNO DA QUERY
            DataTable tabela = new DataTable();
            tabela.Load(row);

            // CONTANDO O TOTAL DE LINHAS DO RETORNO PARA O VALOR MAXIMO DA PROGRESSBAR
            int rows = tabela.Rows.Count;

            // LAÇO DA TABELA
            using (SqlDataReader DR = retorno.ExecuteReader())
            {

                // SE A CONSULTA RETORNAR LINHAS
                if (DR.HasRows)
                {

                    // Make room to hold a row's values.
                    object[] values = new object[DR.FieldCount];

                    cb_vendedor.Items.Add("TODOS OS USUARIOS");

                    // Loop while the reader has unread data.
                    while (DR.Read())
                    {
                        
                        DR.GetValues(values);

                        //cb_vendedor.Items.Add(values[0]);
                        cb_vendedor.Items.Add(values[0] + " - " + values[1]);

                    }
                   
                    cb_vendedor.SelectedIndex = 0;

                }
            }

            frm_main.Conexao.fecharConexao(conn);

        }

        private void btn_gerar_Click(object sender, EventArgs e)
        {

            String vendedor = cb_vendedor.Text;
            this.Close();
            (this.Owner as frm_main).gerarCargaVendedores(vendedor, false);
            
        }

        private void btn_gerar_transmitir_Click(object sender, EventArgs e)
        {
            String vendedor = cb_vendedor.Text;
            this.Close();
            (this.Owner as frm_main).gerarCargaVendedores(vendedor, true);

        }
    }
}
