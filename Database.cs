using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integrador
{
    class Database
    {
        SqlCommand com;
        DateTime time = DateTime.Now;
        SqlConnection c = Conexao.obterConexao();
        string time_db = "yyyy-MM-dd HH:mm:ss";

        public void Insert(string sql) {

            try
            {
                com = new SqlCommand(sql, c);
                com.ExecuteNonQuery();
                new LogWriter("Executed Query:", "Instruction -> INSERT...\n  :Query ->" + sql);
            }
            catch (SqlException ex)
            {
                new LogWriter(ex.Message, ex.StackTrace+"\n   Executed Query:\n"+sql);
                Messages m = new Messages();
                m.dialogMessage(ex.Message, Messages.ERROR);

            }
            

        }

        public void closeConn() {
            c.Close();
        }

        public void saveSincronizacao(string fluxo, string tipo_fluxo) {

            
            string sql =
                " INSERT INTO SONIC_SINCRONIZACAO " +
                " (id, fluxo, tipo_fluxo, data) " +
                " VALUES " +
                " ((SELECT ISNULL(MAX(id)+1,1) FROM SONIC_SINCRONIZACAO WITH(SERIALIZABLE, UPDLOCK)) " +
                " , '"+fluxo+"', '"+tipo_fluxo+"', '" + time.ToString(time_db) + "')";
            Insert(sql);
            new LogWriter("Executed Query:", "Instruction -> INSERT...\n  :Query ->"+sql);

        }

        public void saveSincronizacaoItens(string arquivo)
        {


            string sql =
                " INSERT INTO SONIC_SINCRONIZACAO_ARQUIVOS " +
                " (id, sincronizacao, nome, hora) " +
                " VALUES " +
                " ((SELECT ISNULL(MAX(id)+1,1) FROM SONIC_SINCRONIZACAO_ARQUIVOS WITH(SERIALIZABLE, UPDLOCK)) " +
                " , (SELECT MAX(id) FROM SONIC_SINCRONIZACAO WITH(SERIALIZABLE, UPDLOCK)),'" + arquivo + "', '" + time.ToString(time_db) + "')";
            Insert(sql);
            new LogWriter("Executed Query:", "Instruction -> INSERT...\n  :Query -> "+sql);
        }

        public DataTable select(string sql) {

            com = new SqlCommand(sql, c);
            SqlDataReader row = com.ExecuteReader();
            DataTable lista = new DataTable();
            lista.Load(row);
            new LogWriter("Executed Query:", "Instruction -> SELECT...\n  :Query -> " + sql);
            return lista;
        }

    }
}
