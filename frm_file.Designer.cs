namespace Integrador
{
    partial class frm_file
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_file));
            this.tbc_file = new System.Windows.Forms.TabControl();
            this.tb_env = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.tb_imagens = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_carga = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_site = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_query = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_vendedores = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_processado = new System.Windows.Forms.TextBox();
            this.tb_recebido = new System.Windows.Forms.TextBox();
            this.tb_rec = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_ftp_imagens = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_ftp_vend = new System.Windows.Forms.TextBox();
            this.ofd_1 = new System.Windows.Forms.OpenFileDialog();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.bt_save = new System.Windows.Forms.Button();
            this.bt_edit = new System.Windows.Forms.Button();
            this.tbc_file.SuspendLayout();
            this.tb_env.SuspendLayout();
            this.tb_rec.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbc_file
            // 
            this.tbc_file.Controls.Add(this.tb_env);
            this.tbc_file.Controls.Add(this.tb_rec);
            this.tbc_file.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbc_file.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbc_file.Location = new System.Drawing.Point(0, 0);
            this.tbc_file.Name = "tbc_file";
            this.tbc_file.SelectedIndex = 0;
            this.tbc_file.Size = new System.Drawing.Size(880, 402);
            this.tbc_file.TabIndex = 1;
            // 
            // tb_env
            // 
            this.tb_env.Controls.Add(this.label13);
            this.tb_env.Controls.Add(this.tb_imagens);
            this.tb_env.Controls.Add(this.label7);
            this.tb_env.Controls.Add(this.tb_carga);
            this.tb_env.Controls.Add(this.label6);
            this.tb_env.Controls.Add(this.tb_site);
            this.tb_env.Controls.Add(this.label5);
            this.tb_env.Controls.Add(this.tb_query);
            this.tb_env.Controls.Add(this.label4);
            this.tb_env.Controls.Add(this.tb_vendedores);
            this.tb_env.Controls.Add(this.label2);
            this.tb_env.Controls.Add(this.label1);
            this.tb_env.Controls.Add(this.tb_processado);
            this.tb_env.Controls.Add(this.tb_recebido);
            this.tb_env.Location = new System.Drawing.Point(4, 25);
            this.tb_env.Name = "tb_env";
            this.tb_env.Padding = new System.Windows.Forms.Padding(3);
            this.tb_env.Size = new System.Drawing.Size(872, 373);
            this.tb_env.TabIndex = 0;
            this.tb_env.Text = "Diretórios: Locais";
            this.tb_env.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(62, 234);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 17);
            this.label13.TabIndex = 30;
            this.label13.Text = "Imagens:";
            // 
            // tb_imagens
            // 
            this.tb_imagens.Enabled = false;
            this.tb_imagens.Location = new System.Drawing.Point(133, 231);
            this.tb_imagens.Name = "tb_imagens";
            this.tb_imagens.Size = new System.Drawing.Size(544, 23);
            this.tb_imagens.TabIndex = 29;
            this.tb_imagens.Click += new System.EventHandler(this.tb_imagens_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(77, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 17);
            this.label7.TabIndex = 28;
            this.label7.Text = "Carga:";
            // 
            // tb_carga
            // 
            this.tb_carga.Enabled = false;
            this.tb_carga.Location = new System.Drawing.Point(133, 196);
            this.tb_carga.Name = "tb_carga";
            this.tb_carga.Size = new System.Drawing.Size(544, 23);
            this.tb_carga.TabIndex = 27;
            this.tb_carga.Click += new System.EventHandler(this.tb_carga_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(91, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 17);
            this.label6.TabIndex = 26;
            this.label6.Text = "Site:";
            // 
            // tb_site
            // 
            this.tb_site.Enabled = false;
            this.tb_site.Location = new System.Drawing.Point(133, 162);
            this.tb_site.Name = "tb_site";
            this.tb_site.Size = new System.Drawing.Size(544, 23);
            this.tb_site.TabIndex = 25;
            this.tb_site.Click += new System.EventHandler(this.tb_site_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 24;
            this.label5.Text = "Querys:";
            // 
            // tb_query
            // 
            this.tb_query.Enabled = false;
            this.tb_query.Location = new System.Drawing.Point(133, 129);
            this.tb_query.Name = "tb_query";
            this.tb_query.Size = new System.Drawing.Size(544, 23);
            this.tb_query.TabIndex = 23;
            this.tb_query.Click += new System.EventHandler(this.tb_query_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "Vendedores";
            // 
            // tb_vendedores
            // 
            this.tb_vendedores.Enabled = false;
            this.tb_vendedores.Location = new System.Drawing.Point(133, 96);
            this.tb_vendedores.Name = "tb_vendedores";
            this.tb_vendedores.Size = new System.Drawing.Size(544, 23);
            this.tb_vendedores.TabIndex = 21;
            this.tb_vendedores.Click += new System.EventHandler(this.tb_vendedores_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Processados:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Recebidos:";
            // 
            // tb_processado
            // 
            this.tb_processado.Enabled = false;
            this.tb_processado.Location = new System.Drawing.Point(133, 64);
            this.tb_processado.Name = "tb_processado";
            this.tb_processado.Size = new System.Drawing.Size(544, 23);
            this.tb_processado.TabIndex = 18;
            this.tb_processado.Click += new System.EventHandler(this.tb_processado_Click);
            // 
            // tb_recebido
            // 
            this.tb_recebido.Enabled = false;
            this.tb_recebido.Location = new System.Drawing.Point(133, 32);
            this.tb_recebido.Name = "tb_recebido";
            this.tb_recebido.Size = new System.Drawing.Size(544, 23);
            this.tb_recebido.TabIndex = 17;
            this.tb_recebido.Click += new System.EventHandler(this.tb_recebido_Click);
            // 
            // tb_rec
            // 
            this.tb_rec.Controls.Add(this.label11);
            this.tb_rec.Controls.Add(this.label10);
            this.tb_rec.Controls.Add(this.label8);
            this.tb_rec.Controls.Add(this.tb_ftp_imagens);
            this.tb_rec.Controls.Add(this.label3);
            this.tb_rec.Controls.Add(this.tb_ftp_vend);
            this.tb_rec.Location = new System.Drawing.Point(4, 25);
            this.tb_rec.Name = "tb_rec";
            this.tb_rec.Padding = new System.Windows.Forms.Padding(3);
            this.tb_rec.Size = new System.Drawing.Size(872, 373);
            this.tb_rec.TabIndex = 1;
            this.tb_rec.Text = "Diretórios: FTP";
            this.tb_rec.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label11.Location = new System.Drawing.Point(323, 67);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(212, 17);
            this.label11.TabIndex = 28;
            this.label11.Text = "Imagens dos produtos / clientes.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label10.Location = new System.Drawing.Point(323, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(173, 17);
            this.label10.TabIndex = 27;
            this.label10.Text = "Arquivos dos vendedores.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(59, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 17);
            this.label8.TabIndex = 25;
            this.label8.Text = "Imagens";
            // 
            // tb_ftp_imagens
            // 
            this.tb_ftp_imagens.Enabled = false;
            this.tb_ftp_imagens.Location = new System.Drawing.Point(133, 64);
            this.tb_ftp_imagens.Name = "tb_ftp_imagens";
            this.tb_ftp_imagens.Size = new System.Drawing.Size(184, 23);
            this.tb_ftp_imagens.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "Vendedores:";
            // 
            // tb_ftp_vend
            // 
            this.tb_ftp_vend.Enabled = false;
            this.tb_ftp_vend.Location = new System.Drawing.Point(133, 32);
            this.tb_ftp_vend.Name = "tb_ftp_vend";
            this.tb_ftp_vend.Size = new System.Drawing.Size(184, 23);
            this.tb_ftp_vend.TabIndex = 20;
            // 
            // ofd_1
            // 
            this.ofd_1.FileName = "openFileDialog1";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.bt_save);
            this.flowLayoutPanel1.Controls.Add(this.bt_edit);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 357);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(880, 45);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // bt_save
            // 
            this.bt_save.Enabled = false;
            this.bt_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_save.Image = global::Integrador.Properties.Resources.disk;
            this.bt_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_save.Location = new System.Drawing.Point(792, 8);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(75, 30);
            this.bt_save.TabIndex = 16;
            this.bt_save.Text = "Salvar";
            this.bt_save.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_save.UseVisualStyleBackColor = true;
            this.bt_save.Click += new System.EventHandler(this.bt_save_Click);
            // 
            // bt_edit
            // 
            this.bt_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_edit.Image = global::Integrador.Properties.Resources.pencil;
            this.bt_edit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_edit.Location = new System.Drawing.Point(710, 8);
            this.bt_edit.Name = "bt_edit";
            this.bt_edit.Size = new System.Drawing.Size(76, 30);
            this.bt_edit.TabIndex = 17;
            this.bt_edit.Text = "Editar";
            this.bt_edit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_edit.UseVisualStyleBackColor = true;
            this.bt_edit.Click += new System.EventHandler(this.bt_edit_Click);
            // 
            // frm_file
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 402);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.tbc_file);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_file";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Envio / Recepção";
            this.Load += new System.EventHandler(this.frm_file_Load);
            this.tbc_file.ResumeLayout(false);
            this.tb_env.ResumeLayout(false);
            this.tb_env.PerformLayout();
            this.tb_rec.ResumeLayout(false);
            this.tb_rec.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbc_file;
        private System.Windows.Forms.TabPage tb_env;
        private System.Windows.Forms.TabPage tb_rec;
        private System.Windows.Forms.TextBox tb_processado;
        private System.Windows.Forms.TextBox tb_recebido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog ofd_1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button bt_save;
        private System.Windows.Forms.Button bt_edit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_ftp_vend;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_vendedores;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_query;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_site;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_carga;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_ftp_imagens;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tb_imagens;
    }
}