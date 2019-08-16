using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Integrador
{
    class Messages
    {

        public static int INFO = 0;
        public static int WARNING = 1;
        public static int ERROR = 2;
        public void dialogMessage(String msg, int title)
        {
            String t = String.Empty;
            switch (title) {
                case 0:
                    t = "Aviso";
                    break;
                case 1:
                    t = "Atenção";
                    break;
                case 2:
                    t = "Erro";
                    break;
              

            }
            MessageBox.Show(msg, t);

        }

        public DialogResult dialogMessageResult(String msg, int title)
        {
            String t = String.Empty;
            switch (title)
            {
                case 0:
                    t = "Aviso";
                    break;
                case 1:
                    t = "Atenção";
                    break;
                case 2:
                    t = "Erro";
                    break;


            }
            DialogResult res = MessageBox.Show(msg, t, MessageBoxButtons.OKCancel);

            return res;

        }

    }
}
