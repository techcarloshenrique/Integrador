namespace Integrador
{
    partial class frm_secao
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
            this.btn_selecionar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_secao = new System.Windows.Forms.ComboBox();
            this.cb_usuario = new System.Windows.Forms.CheckBox();
            this.pn_query = new System.Windows.Forms.Panel();
            this.rtb_query = new System.Windows.Forms.RichTextBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.pn_query.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.flowLayoutPanel1.Controls.Add(this.btn_selecionar);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 180);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(284, 45);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // btn_selecionar
            // 
            this.btn_selecionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_selecionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_selecionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_selecionar.Location = new System.Drawing.Point(183, 8);
            this.btn_selecionar.Name = "btn_selecionar";
            this.btn_selecionar.Size = new System.Drawing.Size(88, 30);
            this.btn_selecionar.TabIndex = 3;
            this.btn_selecionar.Text = "Selecionar";
            this.btn_selecionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_selecionar.UseVisualStyleBackColor = true;
            this.btn_selecionar.Click += new System.EventHandler(this.btn_selecionar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Selecione uma visão...";
            // 
            // cb_secao
            // 
            this.cb_secao.FormattingEnabled = true;
            this.cb_secao.Location = new System.Drawing.Point(12, 41);
            this.cb_secao.Name = "cb_secao";
            this.cb_secao.Size = new System.Drawing.Size(259, 21);
            this.cb_secao.TabIndex = 10;
            this.cb_secao.SelectedIndexChanged += new System.EventHandler(this.cb_secao_SelectedIndexChanged);
            // 
            // cb_usuario
            // 
            this.cb_usuario.AutoSize = true;
            this.cb_usuario.Location = new System.Drawing.Point(12, 76);
            this.cb_usuario.Name = "cb_usuario";
            this.cb_usuario.Size = new System.Drawing.Size(129, 17);
            this.cb_usuario.TabIndex = 11;
            this.cb_usuario.Text = "Por código de usuário";
            this.cb_usuario.UseVisualStyleBackColor = true;
            this.cb_usuario.CheckedChanged += new System.EventHandler(this.cb_usuario_CheckedChanged);
            // 
            // pn_query
            // 
            this.pn_query.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pn_query.Controls.Add(this.rtb_query);
            this.pn_query.Location = new System.Drawing.Point(0, 103);
            this.pn_query.Name = "pn_query";
            this.pn_query.Size = new System.Drawing.Size(284, 78);
            this.pn_query.TabIndex = 12;
            // 
            // rtb_query
            // 
            this.rtb_query.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.rtb_query.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_query.Location = new System.Drawing.Point(12, 8);
            this.rtb_query.Name = "rtb_query";
            this.rtb_query.Size = new System.Drawing.Size(259, 59);
            this.rtb_query.TabIndex = 0;
            this.rtb_query.Text = "";
            // 
            // frm_secao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(284, 225);
            this.Controls.Add(this.pn_query);
            this.Controls.Add(this.cb_usuario);
            this.Controls.Add(this.cb_secao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_secao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seção";
            this.Load += new System.EventHandler(this.frm_secao_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.pn_query.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btn_selecionar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_secao;
        private System.Windows.Forms.CheckBox cb_usuario;
        private System.Windows.Forms.Panel pn_query;
        private System.Windows.Forms.RichTextBox rtb_query;
    }
}