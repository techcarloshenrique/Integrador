using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Integrador
{
    public partial class frm_log : Form
    {
        public frm_log()
        {
            InitializeComponent();
        }

        private void frm_log_Load(object sender, EventArgs e)
        {
            string content = File.ReadAllText(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\sonic.log");
            rtb_logs.Text = content;
        }
    }
}
