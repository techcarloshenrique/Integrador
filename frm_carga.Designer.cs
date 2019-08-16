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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.dgv_usuario = new System.Windows.Forms.DataGridView();
            this.cb_all = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_gerar_transmitir = new System.Windows.Forms.Button();
            this.btn_gerar = new System.Windows.Forms.Button();
            this.lb_selecionados = new System.Windows.Forms.Label();
            this.lb_count = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_usuario)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.flowLayoutPanel1.Controls.Add(this.btn_gerar_transmitir);
            this.flowLayoutPanel1.Controls.Add(this.btn_gerar);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 221);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(434, 45);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // dgv_usuario
            // 
            this.dgv_usuario.AllowUserToAddRows = false;
            this.dgv_usuario.AllowUserToDeleteRows = false;
            this.dgv_usuario.AllowUserToOrderColumns = true;
            this.dgv_usuario.AllowUserToResizeRows = false;
            this.dgv_usuario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_usuario.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgv_usuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_usuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_usuario.Location = new System.Drawing.Point(12, 76);
            this.dgv_usuario.Name = "dgv_usuario";
            this.dgv_usuario.ReadOnly = true;
            this.dgv_usuario.RowHeadersVisible = false;
            this.dgv_usuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_usuario.Size = new System.Drawing.Size(406, 133);
            this.dgv_usuario.TabIndex = 5;
            this.dgv_usuario.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dgv_usuario_RowStateChanged);
            // 
            // cb_all
            // 
            this.cb_all.AutoSize = true;
            this.cb_all.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_all.Location = new System.Drawing.Point(12, 49);
            this.cb_all.Name = "cb_all";
            this.cb_all.Size = new System.Drawing.Size(67, 21);
            this.cb_all.TabIndex = 6;
            this.cb_all.Text = "Todos";
            this.cb_all.UseVisualStyleBackColor = true;
            this.cb_all.CheckedChanged += new System.EventHandler(this.cb_all_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(409, 31);
            this.panel1.TabIndex = 7;
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
            // lb_selecionados
            // 
            this.lb_selecionados.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_selecionados.AutoSize = true;
            this.lb_selecionados.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_selecionados.Location = new System.Drawing.Point(288, 49);
            this.lb_selecionados.Name = "lb_selecionados";
            this.lb_selecionados.Size = new System.Drawing.Size(97, 17);
            this.lb_selecionados.TabIndex = 8;
            this.lb_selecionados.Text = "Selecionados:";
            this.lb_selecionados.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_count
            // 
            this.lb_count.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_count.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_count.Location = new System.Drawing.Point(381, 50);
            this.lb_count.Name = "lb_count";
            this.lb_count.Size = new System.Drawing.Size(40, 16);
            this.lb_count.TabIndex = 9;
            this.lb_count.Text = "1";
            this.lb_count.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frm_carga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(434, 266);
            this.Controls.Add(this.lb_count);
            this.Controls.Add(this.lb_selecionados);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cb_all);
            this.Controls.Add(this.dgv_usuario);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frm_carga";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carga - Vendedores";
            this.Load += new System.EventHandler(this.frm_carga_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_usuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_gerar_transmitir;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btn_gerar;
        private System.Windows.Forms.DataGridView dgv_usuario;
        private System.Windows.Forms.CheckBox cb_all;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_selecionados;
        private System.Windows.Forms.Label lb_count;
    }
}