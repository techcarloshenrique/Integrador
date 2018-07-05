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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.bt_save = new System.Windows.Forms.Button();
            this.bt_teste = new System.Windows.Forms.Button();
            this.bt_edit = new System.Windows.Forms.Button();
            this.tb_ftp.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_ftp
            // 
            this.tb_ftp.Controls.Add(this.tabPage1);
            this.tb_ftp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_ftp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ftp.Location = new System.Drawing.Point(0, 0);
            this.tb_ftp.Name = "tb_ftp";
            this.tb_ftp.SelectedIndex = 0;
            this.tb_ftp.Size = new System.Drawing.Size(884, 406);
            this.tb_ftp.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(876, 377);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "FTP";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.bt_save);
            this.flowLayoutPanel1.Controls.Add(this.bt_teste);
            this.flowLayoutPanel1.Controls.Add(this.bt_edit);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 361);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(884, 45);
            this.flowLayoutPanel1.TabIndex = 1;
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
            this.bt_save.TabIndex = 17;
            this.bt_save.Text = "Salvar";
            this.bt_save.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_save.UseVisualStyleBackColor = true;
            // 
            // bt_teste
            // 
            this.bt_teste.Enabled = false;
            this.bt_teste.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_teste.Image = global::Integrador.Properties.Resources.connect;
            this.bt_teste.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_teste.Location = new System.Drawing.Point(714, 8);
            this.bt_teste.Name = "bt_teste";
            this.bt_teste.Size = new System.Drawing.Size(76, 30);
            this.bt_teste.TabIndex = 19;
            this.bt_teste.Text = "Testar";
            this.bt_teste.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_teste.UseVisualStyleBackColor = true;
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
            this.bt_edit.TabIndex = 18;
            this.bt_edit.Text = "Editar";
            this.bt_edit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_edit.UseVisualStyleBackColor = true;
            // 
            // frm_ftp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(884, 406);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.tb_ftp);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_ftp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FTP";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tb_ftp.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tb_ftp;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button bt_save;
        private System.Windows.Forms.Button bt_teste;
        private System.Windows.Forms.Button bt_edit;
    }
}