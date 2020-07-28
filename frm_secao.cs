using System;
using System.Collections;
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
    public partial class frm_secao : Form
    {
        frm_query _frm_query;
        SqlConnection conn;
        public frm_secao(frm_query frm_query)
        {
            InitializeComponent();
            _frm_query = frm_query;
        }

     
        private void frm_secao_Load(object sender, EventArgs e)
        {
            loadComBoList();
        }

        public void loadComBoList()
        {
            //tb_secao.CharacterCasing = CharacterCasing.Upper;
            conn = Conexao.obterConexao();
            List<string> tables = new List<string>();
            DataTable dt = conn.GetSchema("Views");

            ArrayList valuesList = new ArrayList();
            SqlCommand com1 = new SqlCommand("SELECT nome_view FROM SONIC_SECAO_SITE UNION SELECT nome_view FROM SONIC_SECAO_USUARIOS", conn);
            SqlDataReader dataReader = com1.ExecuteReader();
            int count = 0;
            while (dataReader.Read())
            {
                valuesList.Add(dataReader[0].ToString());
                //MessageBox.Show(valuesList[count].ToString());
                count += 1;
            }
 
            conn.Close();
            int count2 = 0;
            cb_secao.IntegralHeight = false;
            cb_secao.MaxDropDownItems = 8;
            foreach (DataRow rowTables in dt.Rows)
            {

                string tablename = (string)rowTables[2];

                if (!valuesList.Contains(tablename.ToString()))
                {
                    cb_secao.Items.Add(tablename);
                }

                count2 += 1;
            }
           
        }

        private void btn_selecionar_Click(object sender, EventArgs e)
        {
           if (cb_secao.Text == "")
           {

               //MessageBox.Show("Preencha todos os campos","Aviso");
               Messages m = new Messages();
               m.dialogMessage("Selecione um visão...", Messages.INFO);

           }
           else
           {
                Boolean site = true;
                String query = String.Empty;
                String _query = rtb_query.Text;
                String nome_view = cb_secao.Text;
                String secao =  cb_secao.Text.Replace("SONIC_","");

                switch (_frm_query.checkTabActive()) {
                    case "SITE":
                        query =
                           "INSERT INTO SONIC_SECAO_SITE " +
                           "(nome_view, secao, query) VALUES " +
                           "('" + nome_view + "', '" + secao + "', '" + _query + "')";
                        break;
                    case "USUARIOS":
                        site = false;
                        query =
                           "INSERT INTO SONIC_SECAO_USUARIOS " +
                           "(nome_view, secao, usuario, query) VALUES " +
                           "('" + nome_view + "', '" + secao + "', '" + (cb_usuario.Checked ? 1 : 0) + "', '" + _query + "')";
                        break;
                }

               Database d = new Database();
               d.Insert(query);
               d.closeConn();
               loadList(site);
               Close();
                
           }
        }
        private void loadList(Boolean site) {
            if (site)
            {
                _frm_query.loadSiteList();
            }
            else {
                _frm_query.loadUserList();
            }
        }

        private void cb_secao_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_usuario.Checked = false;
            rtb_query.Text = "SELECT * FROM " + cb_secao.SelectedItem.ToString();
        }

        private void cb_usuario_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_usuario.Checked)
            {
                rtb_query.Text = "SELECT * FROM " + cb_secao.SelectedItem.ToString() + " WHERE CODIGO_USUARIO = ? ";
                
            }
            else {
                rtb_query.Text = "SELECT * FROM " + cb_secao.SelectedItem.ToString();
            }
        }
    }
}
