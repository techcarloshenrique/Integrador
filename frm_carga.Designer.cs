namespace Integrador
{
    partial class frm_carga
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
            this.cb_vendedor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_gerar_transmitir = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_gerar = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cb_vendedor
            // 
            this.cb_vendedor.FormattingEnabled = true;
            this.cb_vendedor.IntegralHeight = false;
            this.cb_vendedor.Location = new System.Drawing.Point(89, 36);
            this.cb_vendedor.MaxDropDownItems = 5;
            this.cb_vendedor.Name = "cb_vendedor";
            this.cb_vendedor.Size = new System.Drawing.Size(332, 21);
            this.cb_vendedor.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Vendedor:";
            // 
            // btn_gerar_transmitir
            // 
            this.btn_gerar_transmitir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_gerar_transmitir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_gerar_transmitir.Image = global::Integrador.Properties.Resources.cog_go;
            this.btn_gerar_transmitir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_gerar_transmitir.Location = new System.Drawing.Point(274, 8);
            this.btn_gerar_transmitir.Name = "btn_gerar_transmitir";
            this.btn_gerar_transmitir.Size = new System.Drawing.Size(147, 30);
            this.btn_gerar_transmitir.TabIndex = 3;
            this.btn_gerar_transmitir.Text = "Gerar / Transmitir";
            this.btn_gerar_transmitir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_gerar_transmitir.UseVisualStyleBackColor = true;
            this.btn_gerar_transmitir.Click += new System.EventHandler(this.btn_gerar_transmitir_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.flowLayoutPanel1.Controls.Add(this.btn_gerar_transmitir);
            this.flowLayoutPanel1.Controls.Add(this.btn_gerar);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 87);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(434, 45);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // btn_gerar
            // 
            this.btn_gerar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_gerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_gerar.Image = global::Integrador.Properties.Resources.cog;
            this.btn_gerar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_gerar.Location = new System.Drawing.Point(192, 8);
            this.btn_gerar.Name = "btn_gerar";
            this.btn_gerar.Size = new System.Drawing.Size(76, 30);
            this.btn_gerar.TabIndex = 4;
            this.btn_gerar.Text = "Gerar";
            this.btn_gerar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_gerar.UseVisualStyleBackColor = true;
            this.btn_gerar.Click += new System.EventHandler(this.btn_gerar_Click);
            // 
            // frm_carga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(434, 132);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_vendedor);
            this.Name = "frm_carga";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carga - Vendedores";
            this.Load += new System.EventHandler(this.frm_carga_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_vendedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_gerar_transmitir;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btn_gerar;
    }
}