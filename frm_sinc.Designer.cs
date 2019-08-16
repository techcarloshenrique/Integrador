namespace Integrador
{
    partial class frm_sinc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.dgv_sinc = new System.Windows.Forms.DataGridView();
            this.dgv_sinc_itens = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sinc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sinc_itens)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(704, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // dgv_sinc
            // 
            this.dgv_sinc.AllowUserToAddRows = false;
            this.dgv_sinc.AllowUserToDeleteRows = false;
            this.dgv_sinc.AllowUserToOrderColumns = true;
            this.dgv_sinc.AllowUserToResizeRows = false;
            this.dgv_sinc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_sinc.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgv_sinc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_sinc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_sinc.GridColor = System.Drawing.SystemColors.Window;
            this.dgv_sinc.Location = new System.Drawing.Point(12, 42);
            this.dgv_sinc.Name = "dgv_sinc";
            this.dgv_sinc.ReadOnly = true;
            this.dgv_sinc.RowHeadersVisible = false;
            this.dgv_sinc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_sinc.Size = new System.Drawing.Size(680, 176);
            this.dgv_sinc.TabIndex = 1;
            // 
            // dgv_sinc_itens
            // 
            this.dgv_sinc_itens.AllowUserToResizeRows = false;
            this.dgv_sinc_itens.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgv_sinc_itens.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_sinc_itens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_sinc_itens.Location = new System.Drawing.Point(12, 223);
            this.dgv_sinc_itens.Name = "dgv_sinc_itens";
            this.dgv_sinc_itens.ReadOnly = true;
            this.dgv_sinc_itens.RowHeadersVisible = false;
            this.dgv_sinc_itens.Size = new System.Drawing.Size(680, 176);
            this.dgv_sinc_itens.TabIndex = 2;
            // 
            // frm_sinc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 411);
            this.Controls.Add(this.dgv_sinc_itens);
            this.Controls.Add(this.dgv_sinc);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_sinc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sincronizações";
            this.Load += new System.EventHandler(this.frm_sinc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sinc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sinc_itens)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.DataGridView dgv_sinc;
        private System.Windows.Forms.DataGridView dgv_sinc_itens;
    }
}