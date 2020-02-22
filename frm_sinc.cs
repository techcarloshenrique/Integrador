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
    public partial class frm_sinc : Form
    {
        
        public frm_sinc()
        {
            InitializeComponent();
        }

        private void frm_sinc_Load(object sender, EventArgs e)
        {
            loadDataGridView();
        }

        public void loadDataGridView()
        {


            String sql = "SELECT * FROM SONIC_SINCRONIZACAO";
            String sqli = "SELECT * FROM SONIC_SINCRONIZACAO_ARQUIVOS";
            Database db = new Database();
            dgv_sinc.DataSource = db.select(sql);
            dgv_sinc_itens.DataSource = db.select(sqli);
            db.closeConn();
            if (dgv_sinc.Rows.Count > 0)
            {
                dgv_sinc.Rows[0].Selected = true;
            }
            if (dgv_sinc_itens.Rows.Count > 0)
            {
                dgv_sinc_itens.Rows[0].Selected = true;
            }
            dgv_sinc.DefaultCellStyle.SelectionBackColor = Color.PaleGreen;
            dgv_sinc.DefaultCellStyle.SelectionForeColor = Color.Black;
            DataGridViewColumn c = dgv_sinc.Columns[0];
            c.Width = 30;
            dgv_sinc_itens.DefaultCellStyle.SelectionBackColor = Color.PaleGreen;
            dgv_sinc_itens.DefaultCellStyle.SelectionForeColor = Color.Black;
            DataGridViewColumn d = dgv_sinc_itens.Columns[0];
            d.Width = 30;

            for (int i = 0; i < dgv_sinc.Columns.Count; i++)
            {

                dgv_sinc.Columns[i].HeaderText = Util.FirstCharToUpper(dgv_sinc.Columns[i].Name.Replace("_", " "));

            }
            for (int i = 0; i < dgv_sinc_itens.Columns.Count; i++)
            {

                dgv_sinc_itens.Columns[i].HeaderText = Util.FirstCharToUpper(dgv_sinc_itens.Columns[i].Name.Replace("_", " "));

            }


        }
    }
}
