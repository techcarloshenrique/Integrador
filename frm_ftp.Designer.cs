namespace Integrador
{
    partial class frm_ftp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ftp));
            this.tb_ftp = new System.Windows.Forms.TabControl();
            this.tb_page_empresa = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_tab_empresa_pass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_tab_empresa_address = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_tab_empresa_user = new System.Windows.Forms.TextBox();
            this.tb_page_server = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tb_tab_server_pass = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_tab_server_address = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_tab_server_user = new System.Windows.Forms.TextBox();
            this.flp_ftp = new System.Windows.Forms.FlowLayoutPanel();
            this.bt_save = new System.Windows.Forms.Button();
            this.bt_teste = new System.Windows.Forms.Button();
            this.bt_edit = new System.Windows.Forms.Button();
            this.tb_ftp.SuspendLayout();
            this.tb_page_empresa.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tb_page_server.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.flp_ftp.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_ftp
            // 
            this.tb_ftp.Controls.Add(this.tb_page_empresa);
            this.tb_ftp.Controls.Add(this.tb_page_server);
            this.tb_ftp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_ftp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ftp.Location = new System.Drawing.Point(0, 0);
            this.tb_ftp.Name = "tb_ftp";
            this.tb_ftp.SelectedIndex = 0;
            this.tb_ftp.Size = new System.Drawing.Size(465, 308);
            this.tb_ftp.TabIndex = 0;
            // 
            // tb_page_empresa
            // 
            this.tb_page_empresa.BackColor = System.Drawing.SystemColors.Window;
            this.tb_page_empresa.Controls.Add(this.groupBox2);
            this.tb_page_empresa.Controls.Add(this.groupBox1);
            this.tb_page_empresa.Location = new System.Drawing.Point(4, 25);
            this.tb_page_empresa.Name = "tb_page_empresa";
            this.tb_page_empresa.Padding = new System.Windows.Forms.Padding(3);
            this.tb_page_empresa.Size = new System.Drawing.Size(457, 279);
            this.tb_page_empresa.TabIndex = 0;
            this.tb_page_empresa.Text = "FTP - Empresa";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.groupBox2.Location = new System.Drawing.Point(8, 158);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(441, 74);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalhe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label3.Location = new System.Drawing.Point(26, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(330, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Usado para enviar e receber arquivo dos usuários.";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_tab_empresa_pass);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tb_tab_empresa_address);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.tb_tab_empresa_user);
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(440, 146);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados de conexão da Empresa";
            // 
            // tb_tab_empresa_pass
            // 
            this.tb_tab_empresa_pass.Enabled = false;
            this.tb_tab_empresa_pass.Location = new System.Drawing.Point(140, 102);
            this.tb_tab_empresa_pass.Name = "tb_tab_empresa_pass";
            this.tb_tab_empresa_pass.PasswordChar = '*';
            this.tb_tab_empresa_pass.Size = new System.Drawing.Size(121, 23);
            this.tb_tab_empresa_pass.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 28;
            this.label2.Text = "Endereço:";
            // 
            // tb_tab_empresa_address
            // 
            this.tb_tab_empresa_address.Enabled = false;
            this.tb_tab_empresa_address.Location = new System.Drawing.Point(140, 38);
            this.tb_tab_empresa_address.Name = "tb_tab_empresa_address";
            this.tb_tab_empresa_address.Size = new System.Drawing.Size(121, 23);
            this.tb_tab_empresa_address.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 33;
            this.label1.Text = "Senha:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(38, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 17);
            this.label9.TabIndex = 31;
            this.label9.Text = "Usuário:";
            // 
            // tb_tab_empresa_user
            // 
            this.tb_tab_empresa_user.Enabled = false;
            this.tb_tab_empresa_user.Location = new System.Drawing.Point(140, 70);
            this.tb_tab_empresa_user.Name = "tb_tab_empresa_user";
            this.tb_tab_empresa_user.Size = new System.Drawing.Size(121, 23);
            this.tb_tab_empresa_user.TabIndex = 30;
            // 
            // tb_page_server
            // 
            this.tb_page_server.Controls.Add(this.groupBox3);
            this.tb_page_server.Controls.Add(this.groupBox4);
            this.tb_page_server.Location = new System.Drawing.Point(4, 25);
            this.tb_page_server.Name = "tb_page_server";
            this.tb_page_server.Padding = new System.Windows.Forms.Padding(3);
            this.tb_page_server.Size = new System.Drawing.Size(457, 279);
            this.tb_page_server.TabIndex = 1;
            this.tb_page_server.Text = "FTP - Servidor";
            this.tb_page_server.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.groupBox3.Location = new System.Drawing.Point(8, 158);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(441, 74);
            this.groupBox3.TabIndex = 37;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Detalhe";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label4.Location = new System.Drawing.Point(26, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(275, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Usado para enviar o arquivo inicial (SITE).";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tb_tab_server_pass);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.tb_tab_server_address);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.tb_tab_server_user);
            this.groupBox4.Location = new System.Drawing.Point(8, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(440, 146);
            this.groupBox4.TabIndex = 36;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Dados de conexão do Servidor";
            // 
            // tb_tab_server_pass
            // 
            this.tb_tab_server_pass.Enabled = false;
            this.tb_tab_server_pass.Location = new System.Drawing.Point(140, 102);
            this.tb_tab_server_pass.Name = "tb_tab_server_pass";
            this.tb_tab_server_pass.PasswordChar = '*';
            this.tb_tab_server_pass.Size = new System.Drawing.Size(121, 23);
            this.tb_tab_server_pass.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 17);
            this.label6.TabIndex = 28;
            this.label6.Text = "Endereço:";
            // 
            // tb_tab_server_address
            // 
            this.tb_tab_server_address.Enabled = false;
            this.tb_tab_server_address.Location = new System.Drawing.Point(140, 38);
            this.tb_tab_server_address.Name = "tb_tab_server_address";
            this.tb_tab_server_address.Size = new System.Drawing.Size(121, 23);
            this.tb_tab_server_address.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(46, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 17);
            this.label7.TabIndex = 33;
            this.label7.Text = "Senha:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(38, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 17);
            this.label8.TabIndex = 31;
            this.label8.Text = "Usuário:";
            // 
            // tb_tab_server_user
            // 
            this.tb_tab_server_user.Enabled = false;
            this.tb_tab_server_user.Location = new System.Drawing.Point(140, 70);
            this.tb_tab_server_user.Name = "tb_tab_server_user";
            this.tb_tab_server_user.Size = new System.Drawing.Size(121, 23);
            this.tb_tab_server_user.TabIndex = 30;
            // 
            // flp_ftp
            // 
            this.flp_ftp.Controls.Add(this.bt_save);
            this.flp_ftp.Controls.Add(this.bt_teste);
            this.flp_ftp.Controls.Add(this.bt_edit);
            this.flp_ftp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flp_ftp.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flp_ftp.Location = new System.Drawing.Point(0, 263);
            this.flp_ftp.Name = "flp_ftp";
            this.flp_ftp.Padding = new System.Windows.Forms.Padding(5);
            this.flp_ftp.Size = new System.Drawing.Size(465, 45);
            this.flp_ftp.TabIndex = 1;
            // 
            // bt_save
            // 
            this.bt_save.Enabled = false;
            this.bt_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_save.Image = global::Integrador.Properties.Resources.disk;
            this.bt_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_save.Location = new System.Drawing.Point(377, 8);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(75, 30);
            this.bt_save.TabIndex = 17;
            this.bt_save.Text = "Salvar";
            this.bt_save.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_save.UseVisualStyleBackColor = true;
            this.bt_save.Click += new System.EventHandler(this.bt_save_Click);
            // 
            // bt_teste
            // 
            this.bt_teste.Enabled = false;
            this.bt_teste.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_teste.Image = global::Integrador.Properties.Resources.connect;
            this.bt_teste.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_teste.Location = new System.Drawing.Point(295, 8);
            this.bt_teste.Name = "bt_teste";
            this.bt_teste.Size = new System.Drawing.Size(76, 30);
            this.bt_teste.TabIndex = 19;
            this.bt_teste.Text = "Testar";
            this.bt_teste.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_teste.UseVisualStyleBackColor = true;
            this.bt_teste.Click += new System.EventHandler(this.bt_teste_Click);
            // 
            // bt_edit
            // 
            this.bt_edit.Enabled = false;
            this.bt_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_edit.Image = global::Integrador.Properties.Resources.pencil;
            this.bt_edit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_edit.Location = new System.Drawing.Point(213, 8);
            this.bt_edit.Name = "bt_edit";
            this.bt_edit.Size = new System.Drawing.Size(76, 30);
            this.bt_edit.TabIndex = 18;
            this.bt_edit.Text = "Editar";
            this.bt_edit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_edit.UseVisualStyleBackColor = true;
            this.bt_edit.Click += new System.EventHandler(this.bt_edit_Click);
            // 
            // frm_ftp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(465, 308);
            this.Controls.Add(this.flp_ftp);
            this.Controls.Add(this.tb_ftp);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_ftp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FTP";
            this.Load += new System.EventHandler(this.frm_ftp_Load);
            this.SizeChanged += new System.EventHandler(this.frm_ftp_SizeChanged);
            this.tb_ftp.ResumeLayout(false);
            this.tb_page_empresa.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tb_page_server.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.flp_ftp.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tb_ftp;
        private System.Windows.Forms.TabPage tb_page_empresa;
        private System.Windows.Forms.FlowLayoutPanel flp_ftp;
        private System.Windows.Forms.Button bt_save;
        private System.Windows.Forms.Button bt_teste;
        private System.Windows.Forms.Button bt_edit;
        private System.Windows.Forms.TabPage tb_page_server;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_tab_empresa_pass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_tab_empresa_address;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_tab_empresa_user;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox tb_tab_server_pass;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_tab_server_address;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_tab_server_user;
    }
}