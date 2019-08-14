using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Integrador
{
    public partial class frm_drag_and_drop : Form
    {
        public frm_drag_and_drop()
        {
            InitializeComponent();
        }

        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ListBox listBoxOrigem = sender as ListBox;
            if (listBoxOrigem != null && listBoxOrigem.SelectedItem != null)
                DoDragDrop(sender, DragDropEffects.Move);
            
        }

        private void listBox2_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(ListBox)))
                e.Effect = DragDropEffects.Move;
            else
                e.Effect = DragDropEffects.None;
        }

        private void listBox2_DragDrop(object sender, DragEventArgs e)
        {
            var listBoxOrigem = e.Data.GetData(typeof(ListBox)) as ListBox;
            var listBoxDestino = sender as ListBox;
            if (listBoxOrigem != null && listBoxDestino != null)
            {
                listBoxDestino.Items.Add(listBoxOrigem.SelectedItem);
                listBoxOrigem.Items.Remove(listBoxOrigem.SelectedItem);
            }
        }

        private void textBox1_DragLeave(object sender, DragEventArgs e)
        {
            string[] arquivos = e.Data.GetData(DataFormats.FileDrop) as string[];
            if (arquivos != null && arquivos.Any())
                textBox1.Text = arquivos.First();
        }
    }
}
