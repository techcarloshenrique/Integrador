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
    public partial class frm_vend : Form
    {
        public frm_vend()
        {
            InitializeComponent();
        }

        SqlConnection conn = frm_main.Conexao.obterConexao();

        protected void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Control ctr = ((CheckBox)sender).Parent;
            if (((CheckBox)sender).Checked)
            {
                ctr.BackColor = Color.FromArgb(192, 255, 192);
            }
            else {
                ctr.BackColor = Color.FromArgb(255, 255, 255);
            }
            MessageBox.Show(((CheckBox)sender).Name);
            
            
        }

        protected void teste() {

            Control[] ctrls = flp_vend.Controls.Find("pn", false);

            foreach (Control c in ctrls) {

                Control[] tbxs = c.Controls.Find("cb", true);

                foreach (Control a in tbxs) {

                  
                   // MessageBox.Show(a.ToString(), "");

                }


            }

        }
        protected void chk_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox[] boxes = new CheckBox[7];
            /*boxes[0] = this.CheckBoxID;
            boxes[1] = this.CheckBoxID;
            boxes[2] = this.CheckBoxID;
            boxes[3] = this.CheckBoxID;
            boxes[4] = this.CheckBoxID;
            boxes[5] = this.CheckBoxID;
            boxes[6] = this.CheckBoxID; //you can add checkboxes as you want*/

            CheckBox chkBox = (CheckBox)sender;
            //string chkID = chkBox.ID;
            //bool allChecked = true;

            //if (chkBox.Checked == false) {
            //    allChecked = false;
            //}
                
            foreach (CheckBox chkBoxes in boxes)
            {
                if (chkBox.Checked == true)
                {
                    if (chkBoxes.Checked == false) {
                    }
                        //allChecked = false;
                }
            }
           // this.CheckBoxIDALL.Checked = allChecked; //Here place the main CheckBox
        }

        private void frm_vend_Load(object sender, EventArgs e)
        {

            SqlConnection conn = frm_main.Conexao.obterConexao();

            String query = "SELECT * FROM SONIC_USUARIOS";

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

                    // Loop while the reader has unread data.
                    while (DR.Read())
                    {
                        // Add this row to the DataGridView.
                        DR.GetValues(values);
                        //dgv.Rows.Add(values);

                        Panel pn = new Panel();
                        pn.Name = "pn";
                        pn.Size = new System.Drawing.Size(165, 105);
                        pn.BackColor = Color.White;
                        pn.Cursor = Cursors.Hand;
                        PictureBox pb = new PictureBox();
                        pb.Size = new System.Drawing.Size(82, 78);
                        pb.Image = Properties.Resources.icon_user;
                        pb.SizeMode = PictureBoxSizeMode.StretchImage;
                        pb.Location = new Point(3, 3);
                        Label lb_cod = new Label();
                        lb_cod.Text = values[0].ToString();
                        lb_cod.AutoSize = true;
                        lb_cod.Font = new Font("Letter Gothic", 16, FontStyle.Bold);
                        lb_cod.TextAlign = ContentAlignment.MiddleCenter;
                        lb_cod.ForeColor = Color.Gray;
                        lb_cod.MinimumSize = new System.Drawing.Size(70, 0);
                        lb_cod.Location = new Point(90, 6);
                        Label lb_name = new Label();
                        lb_name.Text = values[1].ToString();
                        lb_name.AutoSize = true;
                        lb_name.Font = new Font("Letter Gothic", 8, FontStyle.Bold);
                        lb_name.TextAlign = ContentAlignment.MiddleCenter;
                        lb_name.ForeColor = Color.Gray;
                        lb_name.MinimumSize = new System.Drawing.Size(155, 0);
                        lb_name.Location = new Point(5, 86);
                        CheckBox cb = new CheckBox();
                        cb.Location = new Point(117, 50);
                        cb.Name = "cb";

                        cb.CheckedChanged += new EventHandler(CheckBox_CheckedChanged);

                        pn.Controls.Add(pb);
                        pn.Controls.Add(lb_cod);
                        pn.Controls.Add(lb_name);
                        pn.Controls.Add(cb);

                        flp_vend.Controls.Add(pn);


                    }

                    // ENQUANTO HOUVER LEITURA NAS LINHAS DO RETORNO
                    /*while (DR.Read())
                    {


                        //tabela.Columns.Add(DR[""].ToString, typeof(String));
                        // LAÇO PARA LER AS COLUNAS DA LINHA
                        for (int i = 0; i < DR.FieldCount; i++)
                        {

                            MessageBox.Show(DR[i] + "\t", "");
                        }

                    }*/


                }
            }

        }

        private void bt_gerar_Click(object sender, EventArgs e)
        {

        }

        private void bt_select_all_Click(object sender, EventArgs e)
        {
            teste();
        }

        private void bt_gerar_Click_1(object sender, EventArgs e)
        {

        }
    }
}
