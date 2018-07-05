namespace Integrador
{
    partial class frm_consulta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tb_main = new System.Windows.Forms.TabControl();
            this.tp_vend = new System.Windows.Forms.TabPage();
            this.dgv_vend = new System.Windows.Forms.DataGridView();
            this.ts_vend = new System.Windows.Forms.ToolStrip();
            this.ts_refresh = new System.Windows.Forms.ToolStripButton();
            this.tb_prod = new System.Windows.Forms.TabPage();
            this.dgv_prod = new System.Windows.Forms.DataGridView();
            this.ts_prod = new System.Windows.Forms.ToolStrip();
            this.ts_prod_refresh = new System.Windows.Forms.ToolStripButton();
            this.tb_main.SuspendLayout();
            this.tp_vend.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vend)).BeginInit();
            this.ts_vend.SuspendLayout();
            this.tb_prod.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_prod)).BeginInit();
            this.ts_prod.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_main
            // 
            this.tb_main.Controls.Add(this.tp_vend);
            this.tb_main.Controls.Add(this.tb_prod);
            this.tb_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_main.Location = new System.Drawing.Point(0, 0);
            this.tb_main.Name = "tb_main";
            this.tb_main.SelectedIndex = 0;
            this.tb_main.Size = new System.Drawing.Size(884, 406);
            this.tb_main.TabIndex = 0;
            // 
            // tp_vend
            // 
            this.tp_vend.Controls.Add(this.dgv_vend);
            this.tp_vend.Controls.Add(this.ts_vend);
            this.tp_vend.Location = new System.Drawing.Point(4, 22);
            this.tp_vend.Name = "tp_vend";
            this.tp_vend.Padding = new System.Windows.Forms.Padding(3);
            this.tp_vend.Size = new System.Drawing.Size(876, 380);
            this.tp_vend.TabIndex = 0;
            this.tp_vend.Text = "Vendedores";
            this.tp_vend.UseVisualStyleBackColor = true;
            // 
            // dgv_vend
            // 
            this.dgv_vend.AllowUserToAddRows = false;
            this.dgv_vend.AllowUserToDeleteRows = false;
            this.dgv_vend.AllowUserToOrderColumns = true;
            this.dgv_vend.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv_vend.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_vend.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_vend.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgv_vend.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_vend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_vend.Location = new System.Drawing.Point(3, 26);
            this.dgv_vend.Name = "dgv_vend";
            this.dgv_vend.ReadOnly = true;
            this.dgv_vend.Size = new System.Drawing.Size(870, 351);
            this.dgv_vend.TabIndex = 1;
            // 
            // ts_vend
            // 
            this.ts_vend.BackColor = System.Drawing.SystemColors.Control;
            this.ts_vend.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ts_vend.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ts_vend.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts_refresh});
            this.ts_vend.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.ts_vend.Location = new System.Drawing.Point(3, 3);
            this.ts_vend.Name = "ts_vend";
            this.ts_vend.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.ts_vend.Size = new System.Drawing.Size(870, 23);
            this.ts_vend.TabIndex = 0;
            this.ts_vend.Text = "Barra de Ferramentas";
            // 
            // ts_refresh
            // 
            this.ts_refresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ts_refresh.Image = global::Integrador.Properties.Resources.arrow_refresh;
            this.ts_refresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_refresh.Name = "ts_refresh";
            this.ts_refresh.Size = new System.Drawing.Size(23, 20);
            this.ts_refresh.Text = "Atualizar";
            this.ts_refresh.Click += new System.EventHandler(this.ts_refresh_Click);
            // 
            // tb_prod
            // 
            this.tb_prod.Controls.Add(this.dgv_prod);
            this.tb_prod.Controls.Add(this.ts_prod);
            this.tb_prod.Location = new System.Drawing.Point(4, 22);
            this.tb_prod.Name = "tb_prod";
            this.tb_prod.Padding = new System.Windows.Forms.Padding(3);
            this.tb_prod.Size = new System.Drawing.Size(876, 380);
            this.tb_prod.TabIndex = 1;
            this.tb_prod.Text = "Produtos";
            this.tb_prod.UseVisualStyleBackColor = true;
            // 
            // dgv_prod
            // 
            this.dgv_prod.AllowUserToAddRows = false;
            this.dgv_prod.AllowUserToDeleteRows = false;
            this.dgv_prod.AllowUserToOrderColumns = true;
            this.dgv_prod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_prod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_prod.Location = new System.Drawing.Point(3, 26);
            this.dgv_prod.Name = "dgv_prod";
            this.dgv_prod.ReadOnly = true;
            this.dgv_prod.Size = new System.Drawing.Size(870, 351);
            this.dgv_prod.TabIndex = 2;
            // 
            // ts_prod
            // 
            this.ts_prod.BackColor = System.Drawing.SystemColors.Control;
            this.ts_prod.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ts_prod.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ts_prod.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts_prod_refresh});
            this.ts_prod.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.ts_prod.Location = new System.Drawing.Point(3, 3);
            this.ts_prod.Name = "ts_prod";
            this.ts_prod.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.ts_prod.Size = new System.Drawing.Size(870, 23);
            this.ts_prod.TabIndex = 1;
            this.ts_prod.Text = "Barra de Ferramentas";
            // 
            // ts_prod_refresh
            // 
            this.ts_prod_refresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ts_prod_refresh.Image = global::Integrador.Properties.Resources.arrow_refresh;
            this.ts_prod_refresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_prod_refresh.Name = "ts_prod_refresh";
            this.ts_prod_refresh.Size = new System.Drawing.Size(23, 20);
            this.ts_prod_refresh.Text = "Atualizar";
            this.ts_prod_refresh.Click += new System.EventHandler(this.ts_prod_refresh_Click);
            // 
            // frm_consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 406);
            this.Controls.Add(this.tb_main);
            this.Name = "frm_consulta";
            this.Text = "Consulta";
            this.Load += new System.EventHandler(this.frm_vend_Load);
            this.tb_main.ResumeLayout(false);
            this.tp_vend.ResumeLayout(false);
            this.tp_vend.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vend)).EndInit();
            this.ts_vend.ResumeLayout(false);
            this.ts_vend.PerformLayout();
            this.tb_prod.ResumeLayout(false);
            this.tb_prod.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_prod)).EndInit();
            this.ts_prod.ResumeLayout(false);
            this.ts_prod.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tb_main;
        private System.Windows.Forms.TabPage tp_vend;
        private System.Windows.Forms.ToolStrip ts_vend;
        private System.Windows.Forms.ToolStripButton ts_refresh;
        private System.Windows.Forms.TabPage tb_prod;
        private System.Windows.Forms.DataGridView dgv_vend;
        private System.Windows.Forms.DataGridView dgv_prod;
        private System.Windows.Forms.ToolStrip ts_prod;
        private System.Windows.Forms.ToolStripButton ts_prod_refresh;
    }
}