using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace Integrador
{
    class LogWriter
    {

        private string m_exePath = string.Empty;
        public LogWriter(string logMessage, string logDetail)
        {
            LogWrite(logMessage, logDetail);
        }
        public void LogWrite(string logMessage, string logDetail)
        {
            m_exePath = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            try
            {
                using (StreamWriter w = File.AppendText(m_exePath + "\\sonic.log"))
                {
                    Log(logMessage, logDetail, w);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Log(string logMessage, string logDetail, TextWriter txtWriter)
        {
            try
            {
                txtWriter.Write("Log Entry: ");
                txtWriter.WriteLine("{0} {1}", DateTime.Now.ToLongTimeString(),
                DateTime.Now.ToLongDateString());
                txtWriter.WriteLine("  :");
                txtWriter.WriteLine("  :{0}", logMessage);
                txtWriter.WriteLine("  :{0}", logDetail);
                txtWriter.WriteLine("-------------------------------");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }

}
