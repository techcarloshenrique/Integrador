namespace Integrador
{
    partial class frm_vend
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.bt_select_all = new System.Windows.Forms.Button();
            this.bt_gerar = new System.Windows.Forms.Button();
            this.flp_vend = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.flowLayoutPanel1.Controls.Add(this.bt_gerar);
            this.flowLayoutPanel1.Controls.Add(this.bt_select_all);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 361);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(884, 45);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // bt_select_all
            // 
            this.bt_select_all.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_select_all.Image = global::Integrador.Properties.Resources.application_cascade;
            this.bt_select_all.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_select_all.Location = new System.Drawing.Point(650, 7);
            this.bt_select_all.Name = "bt_select_all";
            this.bt_select_all.Size = new System.Drawing.Size(142, 30);
            this.bt_select_all.TabIndex = 22;
            this.bt_select_all.Text = "Selecionar Tudo";
            this.bt_select_all.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_select_all.UseVisualStyleBackColor = true;
            // 
            // bt_gerar
            // 
            this.bt_gerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_gerar.Image = global::Integrador.Properties.Resources.cog_go;
            this.bt_gerar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_gerar.Location = new System.Drawing.Point(798, 7);
            this.bt_gerar.Name = "bt_gerar";
            this.bt_gerar.Size = new System.Drawing.Size(75, 30);
            this.bt_gerar.TabIndex = 21;
            this.bt_gerar.Text = "Gerar";
            this.bt_gerar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_gerar.UseVisualStyleBackColor = true;
            // 
            // flp_vend
            // 
            this.flp_vend.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.flp_vend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flp_vend.Location = new System.Drawing.Point(0, 0);
            this.flp_vend.Name = "flp_vend";
            this.flp_vend.Size = new System.Drawing.Size(884, 361);
            this.flp_vend.TabIndex = 1;
            // 
            // frm_vend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 406);
            this.ControlBox = false;
            this.Controls.Add(this.flp_vend);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "frm_vend";
            this.Text = "Vendedores";
            this.Load += new System.EventHandler(this.frm_vend_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button bt_select_all;
        private System.Windows.Forms.Button bt_gerar;
        private System.Windows.Forms.FlowLayoutPanel flp_vend;
    }
}