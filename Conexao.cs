using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integrador
{
    class Conexao : IDisposable
    {
        // CAPTURA OS VALORES GRAVADOS NO APP [STRING DE CONEXAO]
        private static string connString =
            "Server=" + Properties.Settings.Default.IP
            + "," + Properties.Settings.Default.PORT
            + ";Database=" + Properties.Settings.Default.DATABASE
            + ";User Id=" + Properties.Settings.Default.USER
            + ";Password=" + Properties.Settings.Default.PASS;
        private static SqlConnection conn;// = null;
        public Conexao() {
            if ((conn = obterConexao()) == null)
            {
                this.Dispose();
            }
        }

        public static SqlConnection obterConexao() {

            // INSTANCIANDO UMA NOVA CONEXAO
            conn = new SqlConnection(connString);

            // SE CONEXAO COM SUCESSO...
            try
            {

                // ABRE A CONEXAO E RETORNA AO CHAMADOR DO MÉTODO
                conn.Open();

            }
            catch (SqlException ex)
            {
                conn = null;

                new LogWriter(ex.Message, ex.StackTrace);

                // UMA BOA PRATICA É GRAVAR A EXCEÇÃO EM UM ARQUIVO DE LOG
            }

            return  conn;

        }

        // MÉTODO DA CLASSE PARA FECHAR A CONEXAO
        public static void fecharConexao()
        {
            if (conn != null && conn.State != ConnectionState.Closed)
            {
                conn.Close();
            }
        }

        public static bool validarConexao(string c)
        {

            bool connected = false;
            SqlConnection cn = new SqlConnection(c);
            // SOLICITAR CONEXAO USANDO A CLASSE DE CONEXAO
            try
            {

                // ABRE A CONEXAO E RETORNA AO CHAMADOR DO MÉTODO
                cn.Open();

            }
            catch (SqlException ex)
            {
                connected = false;
                new LogWriter(ex.StackTrace, ex.ToString());

                // UMA BOA PRATICA É GRAVAR A EXCEÇÃO EM UM ARQUIVO DE LOG
            }
            if (cn == null || cn.State == ConnectionState.Closed)
            {
                // PODEMOS ABRIR UM MESSAGEBOX PARA UM FEEDBACK DA CONEXAO
                //MessageBox.Show("Conexao não ok", "");
                connected = false;
            }
            else
            {

                // COMO É APENAS UM TESTE, PODEMOS FECHAR A CONEXAO
                connected = true;
                cn.Close();

            }
            return connected;

        }
        public static bool validarConexao()
        {

            bool connected = false;

            // SOLICITAR CONEXAO USANDO A CLASSE DE CONEXAO
            SqlConnection conn = Conexao.obterConexao();

            if (conn == null && conn.State != ConnectionState.Closed)
            {
                // PODEMOS ABRIR UM MESSAGEBOX PARA UM FEEDBACK DA CONEXAO
                //MessageBox.Show("Conexao não ok", "");
            }
            else
            {

                // COMO É APENAS UM TESTE, PODEMOS FECHAR A CONEXAO
                connected = true;
                Conexao.fecharConexao();

            }
            return connected;

        }

        public void Dispose()
        {
            conn.Dispose();
        }
    }

}

