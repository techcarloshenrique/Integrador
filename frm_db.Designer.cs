namespace Integrador
{
    partial class frm_db
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_db));
            this.tb_main = new System.Windows.Forms.TabControl();
            this.tb_db = new System.Windows.Forms.TabPage();
            this.tb_database = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_pass = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_user = new System.Windows.Forms.TextBox();
            this.lb_user = new System.Windows.Forms.Label();
            this.tb_port = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_ip = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_sgbd = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tt_port = new System.Windows.Forms.ToolTip(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.bt_save = new System.Windows.Forms.Button();
            this.bt_teste = new System.Windows.Forms.Button();
            this.bt_edit = new System.Windows.Forms.Button();
            this.tb_main.SuspendLayout();
            this.tb_db.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_main
            // 
            this.tb_main.Controls.Add(this.tb_db);
            this.tb_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_main.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_main.Location = new System.Drawing.Point(0, 0);
            this.tb_main.Name = "tb_main";
            this.tb_main.SelectedIndex = 0;
            this.tb_main.Size = new System.Drawing.Size(884, 406);
            this.tb_main.TabIndex = 0;
            // 
            // tb_db
            // 
            this.tb_db.BackColor = System.Drawing.Color.Gainsboro;
            this.tb_db.Controls.Add(this.tb_database);
            this.tb_db.Controls.Add(this.label9);
            this.tb_db.Controls.Add(this.label8);
            this.tb_db.Controls.Add(this.label7);
            this.tb_db.Controls.Add(this.label6);
            this.tb_db.Controls.Add(this.tb_pass);
            this.tb_db.Controls.Add(this.label5);
            this.tb_db.Controls.Add(this.tb_user);
            this.tb_db.Controls.Add(this.lb_user);
            this.tb_db.Controls.Add(this.tb_port);
            this.tb_db.Controls.Add(this.label3);
            this.tb_db.Controls.Add(this.tb_ip);
            this.tb_db.Controls.Add(this.label1);
            this.tb_db.Controls.Add(this.cb_sgbd);
            this.tb_db.Controls.Add(this.label2);
            this.tb_db.Location = new System.Drawing.Point(4, 25);
            this.tb_db.Name = "tb_db";
            this.tb_db.Padding = new System.Windows.Forms.Padding(3);
            this.tb_db.Size = new System.Drawing.Size(876, 377);
            this.tb_db.TabIndex = 0;
            this.tb_db.Text = "Conexão";
            // 
            // tb_database
            // 
            this.tb_database.Enabled = false;
            this.tb_database.Location = new System.Drawing.Point(133, 96);
            this.tb_database.Name = "tb_database";
            this.tb_database.Size = new System.Drawing.Size(121, 23);
            this.tb_database.TabIndex = 19;
            this.tt_port.SetToolTip(this.tb_database, "Se omitido será usada  porta padrão: 1433");
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(19, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 17);
            this.label9.TabIndex = 20;
            this.label9.Text = "Database:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Enabled = false;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label8.Location = new System.Drawing.Point(260, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(185, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "Lista de SGBD\'s disponíveis";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Enabled = false;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label7.Location = new System.Drawing.Point(260, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "IP ou endereço NetBios";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Enabled = false;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label6.Location = new System.Drawing.Point(260, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Padrão: 1433";
            // 
            // tb_pass
            // 
            this.tb_pass.Enabled = false;
            this.tb_pass.Location = new System.Drawing.Point(133, 192);
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.Size = new System.Drawing.Size(121, 23);
            this.tb_pass.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Senha";
            // 
            // tb_user
            // 
            this.tb_user.Enabled = false;
            this.tb_user.Location = new System.Drawing.Point(133, 160);
            this.tb_user.Name = "tb_user";
            this.tb_user.Size = new System.Drawing.Size(121, 23);
            this.tb_user.TabIndex = 4;
            // 
            // lb_user
            // 
            this.lb_user.AutoSize = true;
            this.lb_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_user.Location = new System.Drawing.Point(19, 163);
            this.lb_user.Name = "lb_user";
            this.lb_user.Size = new System.Drawing.Size(61, 17);
            this.lb_user.TabIndex = 12;
            this.lb_user.Text = "Usuário:";
            // 
            // tb_port
            // 
            this.tb_port.Enabled = false;
            this.tb_port.Location = new System.Drawing.Point(133, 128);
            this.tb_port.Name = "tb_port";
            this.tb_port.Size = new System.Drawing.Size(121, 23);
            this.tb_port.TabIndex = 3;
            this.tt_port.SetToolTip(this.tb_port, "Se omitido será usada  porta padrão: 1433");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Porta:";
            // 
            // tb_ip
            // 
            this.tb_ip.Enabled = false;
            this.tb_ip.Location = new System.Drawing.Point(133, 64);
            this.tb_ip.Name = "tb_ip";
            this.tb_ip.Size = new System.Drawing.Size(121, 23);
            this.tb_ip.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Provider:";
            // 
            // cb_sgbd
            // 
            this.cb_sgbd.FormattingEnabled = true;
            this.cb_sgbd.Items.AddRange(new object[] {
            "SQL_SERVER"});
            this.cb_sgbd.Location = new System.Drawing.Point(133, 32);
            this.cb_sgbd.Name = "cb_sgbd";
            this.cb_sgbd.Size = new System.Drawing.Size(121, 24);
            this.cb_sgbd.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Endereço:";
            // 
            // tt_port
            // 
            this.tt_port.ToolTipTitle = "Porta";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.flowLayoutPanel1.Controls.Add(this.bt_save);
            this.flowLayoutPanel1.Controls.Add(this.bt_teste);
            this.flowLayoutPanel1.Controls.Add(this.bt_edit);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 361);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(884, 45);
            this.flowLayoutPanel1.TabIndex = 22;
            // 
            // bt_save
            // 
            this.bt_save.Enabled = false;
            this.bt_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_save.Image = global::Integrador.Properties.Resources.disk;
            this.bt_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_save.Location = new System.Drawing.Point(796, 8);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(75, 30);
            this.bt_save.TabIndex = 12;
            this.bt_save.Text = "Salvar";
            this.bt_save.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_save.UseVisualStyleBackColor = true;
            this.bt_save.Click += new System.EventHandler(this.bt_save_Click);
            // 
            // bt_teste
            // 
            this.bt_teste.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_teste.Image = global::Integrador.Properties.Resources.database;
            this.bt_teste.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_teste.Location = new System.Drawing.Point(714, 8);
            this.bt_teste.Name = "bt_teste";
            this.bt_teste.Size = new System.Drawing.Size(76, 30);
            this.bt_teste.TabIndex = 10;
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
            this.bt_edit.Location = new System.Drawing.Point(632, 8);
            this.bt_edit.Name = "bt_edit";
            this.bt_edit.Size = new System.Drawing.Size(76, 30);
            this.bt_edit.TabIndex = 11;
            this.bt_edit.Text = "Editar";
            this.bt_edit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_edit.UseVisualStyleBackColor = true;
            this.bt_edit.Click += new System.EventHandler(this.bt_edit_Click_1);
            // 
            // frm_db
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 406);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.tb_main);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "frm_db";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Banco de Dados";
            this.Load += new System.EventHandler(this.frm_db_Load);
            this.tb_main.ResumeLayout(false);
            this.tb_db.ResumeLayout(false);
            this.tb_db.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tb_main;
        private System.Windows.Forms.TabPage tb_db;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_port;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_ip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_sgbd;
        private System.Windows.Forms.ToolTip tt_port;
        private System.Windows.Forms.TextBox tb_user;
        private System.Windows.Forms.Label lb_user;
        private System.Windows.Forms.TextBox tb_pass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_database;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button bt_save;
        private System.Windows.Forms.Button bt_teste;
        private System.Windows.Forms.Button bt_edit;
    }
}