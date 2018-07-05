namespace Integrador
{
    partial class frm_ag
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ag));
            this.tb_main = new System.Windows.Forms.TabControl();
            this.tb_ftp = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.bt_save = new System.Windows.Forms.Button();
            this.bt_test = new System.Windows.Forms.Button();
            this.bt_edit = new System.Windows.Forms.Button();
            this.tb_main.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_main
            // 
            this.tb_main.Controls.Add(this.tb_ftp);
            this.tb_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_main.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_main.Location = new System.Drawing.Point(0, 0);
            this.tb_main.Name = "tb_main";
            this.tb_main.SelectedIndex = 0;
            this.tb_main.Size = new System.Drawing.Size(884, 406);
            this.tb_main.TabIndex = 0;
            // 
            // tb_ftp
            // 
            this.tb_ftp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ftp.Location = new System.Drawing.Point(4, 25);
            this.tb_ftp.Name = "tb_ftp";
            this.tb_ftp.Padding = new System.Windows.Forms.Padding(3);
            this.tb_ftp.Size = new System.Drawing.Size(876, 377);
            this.tb_ftp.TabIndex = 0;
            this.tb_ftp.Text = "Agendamento";
            this.tb_ftp.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.bt_save);
            this.flowLayoutPanel1.Controls.Add(this.bt_test);
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
            this.bt_save.TabIndex = 19;
            this.bt_save.Text = "Salvar";
            this.bt_save.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_save.UseVisualStyleBackColor = true;
            // 
            // bt_test
            // 
            this.bt_test.Enabled = false;
            this.bt_test.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_test.Image = global::Integrador.Properties.Resources.connect;
            this.bt_test.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_test.Location = new System.Drawing.Point(714, 8);
            this.bt_test.Name = "bt_test";
            this.bt_test.Size = new System.Drawing.Size(76, 30);
            this.bt_test.TabIndex = 21;
            this.bt_test.Text = "Testar";
            this.bt_test.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_test.UseVisualStyleBackColor = true;
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
            this.bt_edit.TabIndex = 20;
            this.bt_edit.Text = "Editar";
            this.bt_edit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_edit.UseVisualStyleBackColor = true;
            // 
            // frm_ag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 406);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.tb_main);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_ag";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Agendamento";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tb_main.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tb_main;
        private System.Windows.Forms.TabPage tb_ftp;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button bt_save;
        private System.Windows.Forms.Button bt_test;
        private System.Windows.Forms.Button bt_edit;
    }
}