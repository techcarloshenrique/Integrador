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
            this.tbc_file = new System.Windows.Forms.TabControl();
            this.tb_env = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_export = new System.Windows.Forms.TextBox();
            this.tb_import = new System.Windows.Forms.TextBox();
            this.tb_rec = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_import_mb_pc = new System.Windows.Forms.TextBox();
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
            this.tb_env.Controls.Add(this.label2);
            this.tb_env.Controls.Add(this.label1);
            this.tb_env.Controls.Add(this.tb_export);
            this.tb_env.Controls.Add(this.tb_import);
            this.tb_env.Location = new System.Drawing.Point(4, 25);
            this.tb_env.Name = "tb_env";
            this.tb_env.Padding = new System.Windows.Forms.Padding(3);
            this.tb_env.Size = new System.Drawing.Size(872, 373);
            this.tb_env.TabIndex = 0;
            this.tb_env.Text = "Diretórios: Importação / Exportação";
            this.tb_env.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Exportação:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Importação:";
            // 
            // tb_export
            // 
            this.tb_export.Enabled = false;
            this.tb_export.Location = new System.Drawing.Point(133, 64);
            this.tb_export.Name = "tb_export";
            this.tb_export.Size = new System.Drawing.Size(350, 23);
            this.tb_export.TabIndex = 18;
            this.tb_export.Click += new System.EventHandler(this.tb_export_Click);
            // 
            // tb_import
            // 
            this.tb_import.Enabled = false;
            this.tb_import.Location = new System.Drawing.Point(133, 32);
            this.tb_import.Name = "tb_import";
            this.tb_import.Size = new System.Drawing.Size(350, 23);
            this.tb_import.TabIndex = 17;
            this.tb_import.Click += new System.EventHandler(this.tb_import_Click);
            // 
            // tb_rec
            // 
            this.tb_rec.Controls.Add(this.label3);
            this.tb_rec.Controls.Add(this.tb_import_mb_pc);
            this.tb_rec.Location = new System.Drawing.Point(4, 25);
            this.tb_rec.Name = "tb_rec";
            this.tb_rec.Padding = new System.Windows.Forms.Padding(3);
            this.tb_rec.Size = new System.Drawing.Size(872, 373);
            this.tb_rec.TabIndex = 1;
            this.tb_rec.Text = "Arquivos de Recepção";
            this.tb_rec.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "Mobile/PC";
            // 
            // tb_import_mb_pc
            // 
            this.tb_import_mb_pc.Enabled = false;
            this.tb_import_mb_pc.Location = new System.Drawing.Point(133, 32);
            this.tb_import_mb_pc.Name = "tb_import_mb_pc";
            this.tb_import_mb_pc.Size = new System.Drawing.Size(350, 23);
            this.tb_import_mb_pc.TabIndex = 20;
            this.tb_import_mb_pc.TextChanged += new System.EventHandler(this.tb_import_mb_pc_Click);
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
            this.bt_edit.Enabled = false;
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
            this.Name = "frm_file";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Envio / Recepção";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
        private System.Windows.Forms.TextBox tb_export;
        private System.Windows.Forms.TextBox tb_import;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog ofd_1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button bt_save;
        private System.Windows.Forms.Button bt_edit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_import_mb_pc;
    }
}