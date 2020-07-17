namespace Integrador
{
    partial class frm_query
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tbs_site_add = new System.Windows.Forms.ToolStripButton();
            this.tsb_site_excluir = new System.Windows.Forms.ToolStripButton();
            this.tsb_site_editar = new System.Windows.Forms.ToolStripButton();
            this.tsb_site_salvar = new System.Windows.Forms.ToolStripButton();
            this.tbc_arquivos = new System.Windows.Forms.TabControl();
            this.tp_site = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_site_exemplo = new System.Windows.Forms.DataGridView();
            this.pb_site_progress = new System.Windows.Forms.PictureBox();
            this.bt_site_validar = new System.Windows.Forms.Button();
            this.rtb_site_query = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_site = new System.Windows.Forms.DataGridView();
            this.tp_usuarios = new System.Windows.Forms.TabPage();
            this.pb_usuarios_progress = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_usuarios_validar = new System.Windows.Forms.Button();
            this.dgv_usuarios_exemplo = new System.Windows.Forms.DataGridView();
            this.rtb_usuarios_query = new System.Windows.Forms.RichTextBox();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tsb_usuarios_add = new System.Windows.Forms.ToolStripButton();
            this.tsb_usuarios_excluir = new System.Windows.Forms.ToolStripButton();
            this.tsb_usuarios_editar = new System.Windows.Forms.ToolStripButton();
            this.tsb_usuarios_salvar = new System.Windows.Forms.ToolStripButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgv_usuarios = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            this.tbc_arquivos.SuspendLayout();
            this.tp_site.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_site_exemplo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_site_progress)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_site)).BeginInit();
            this.tp_usuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_usuarios_progress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_usuarios_exemplo)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_usuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbs_site_add,
            this.tsb_site_excluir,
            this.tsb_site_editar,
            this.tsb_site_salvar});
            this.toolStrip1.Location = new System.Drawing.Point(6, 15);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(626, 27);
            this.toolStrip1.TabIndex = 34;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tbs_site_add
            // 
            this.tbs_site_add.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbs_site_add.Image = global::Integrador.Properties.Resources.add;
            this.tbs_site_add.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbs_site_add.Name = "tbs_site_add";
            this.tbs_site_add.Size = new System.Drawing.Size(23, 24);
            this.tbs_site_add.Text = "inserir";
            this.tbs_site_add.Click += new System.EventHandler(this.tbs_site_add_Click);
            // 
            // tsb_site_excluir
            // 
            this.tsb_site_excluir.AutoSize = false;
            this.tsb_site_excluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_site_excluir.Image = global::Integrador.Properties.Resources.delete;
            this.tsb_site_excluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_site_excluir.Name = "tsb_site_excluir";
            this.tsb_site_excluir.Size = new System.Drawing.Size(20, 26);
            this.tsb_site_excluir.Text = "Excluir";
            this.tsb_site_excluir.Click += new System.EventHandler(this.tsb_site_excluir_Click);
            // 
            // tsb_site_editar
            // 
            this.tsb_site_editar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_site_editar.Image = global::Integrador.Properties.Resources.application_edit;
            this.tsb_site_editar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_site_editar.Name = "tsb_site_editar";
            this.tsb_site_editar.Size = new System.Drawing.Size(23, 24);
            this.tsb_site_editar.Text = "Editar";
            this.tsb_site_editar.Click += new System.EventHandler(this.tsb_site_editar_Click);
            // 
            // tsb_site_salvar
            // 
            this.tsb_site_salvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_site_salvar.Enabled = false;
            this.tsb_site_salvar.Image = global::Integrador.Properties.Resources.disk;
            this.tsb_site_salvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_site_salvar.Name = "tsb_site_salvar";
            this.tsb_site_salvar.Size = new System.Drawing.Size(23, 24);
            this.tsb_site_salvar.Text = "Salvar";
            this.tsb_site_salvar.Click += new System.EventHandler(this.tsb_site_salvar_Click);
            // 
            // tbc_arquivos
            // 
            this.tbc_arquivos.Controls.Add(this.tp_site);
            this.tbc_arquivos.Controls.Add(this.tp_usuarios);
            this.tbc_arquivos.Location = new System.Drawing.Point(12, 12);
            this.tbc_arquivos.Name = "tbc_arquivos";
            this.tbc_arquivos.SelectedIndex = 0;
            this.tbc_arquivos.Size = new System.Drawing.Size(676, 383);
            this.tbc_arquivos.TabIndex = 35;
            // 
            // tp_site
            // 
            this.tp_site.Controls.Add(this.label1);
            this.tp_site.Controls.Add(this.dgv_site_exemplo);
            this.tp_site.Controls.Add(this.pb_site_progress);
            this.tp_site.Controls.Add(this.bt_site_validar);
            this.tp_site.Controls.Add(this.rtb_site_query);
            this.tp_site.Controls.Add(this.toolStrip1);
            this.tp_site.Controls.Add(this.groupBox2);
            this.tp_site.Location = new System.Drawing.Point(4, 22);
            this.tp_site.Name = "tp_site";
            this.tp_site.Padding = new System.Windows.Forms.Padding(3);
            this.tp_site.Size = new System.Drawing.Size(668, 357);
            this.tp_site.TabIndex = 0;
            this.tp_site.Text = "Site";
            this.tp_site.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(309, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "No máximo 5 registros serão exibidos.";
            // 
            // dgv_site_exemplo
            // 
            this.dgv_site_exemplo.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dgv_site_exemplo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_site_exemplo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_site_exemplo.Location = new System.Drawing.Point(6, 215);
            this.dgv_site_exemplo.Name = "dgv_site_exemplo";
            this.dgv_site_exemplo.Size = new System.Drawing.Size(656, 136);
            this.dgv_site_exemplo.TabIndex = 38;
            // 
            // pb_site_progress
            // 
            this.pb_site_progress.Image = global::Integrador.Properties.Resources.loader2;
            this.pb_site_progress.Location = new System.Drawing.Point(638, 15);
            this.pb_site_progress.Name = "pb_site_progress";
            this.pb_site_progress.Size = new System.Drawing.Size(24, 25);
            this.pb_site_progress.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_site_progress.TabIndex = 37;
            this.pb_site_progress.TabStop = false;
            this.pb_site_progress.Visible = false;
            // 
            // bt_site_validar
            // 
            this.bt_site_validar.Location = new System.Drawing.Point(594, 184);
            this.bt_site_validar.Name = "bt_site_validar";
            this.bt_site_validar.Size = new System.Drawing.Size(68, 25);
            this.bt_site_validar.TabIndex = 36;
            this.bt_site_validar.Text = "Validar";
            this.bt_site_validar.UseVisualStyleBackColor = true;
            this.bt_site_validar.Click += new System.EventHandler(this.bt_site_validar_Click);
            // 
            // rtb_site_query
            // 
            this.rtb_site_query.Enabled = false;
            this.rtb_site_query.Location = new System.Drawing.Point(309, 54);
            this.rtb_site_query.Name = "rtb_site_query";
            this.rtb_site_query.Size = new System.Drawing.Size(353, 124);
            this.rtb_site_query.TabIndex = 35;
            this.rtb_site_query.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_site);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(6, 45);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(297, 164);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Seção";
            // 
            // dgv_site
            // 
            this.dgv_site.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgv_site.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_site.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_site.Location = new System.Drawing.Point(6, 22);
            this.dgv_site.Name = "dgv_site";
            this.dgv_site.Size = new System.Drawing.Size(285, 127);
            this.dgv_site.TabIndex = 0;
            this.dgv_site.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_site_CellClick);
            // 
            // tp_usuarios
            // 
            this.tp_usuarios.Controls.Add(this.pb_usuarios_progress);
            this.tp_usuarios.Controls.Add(this.label2);
            this.tp_usuarios.Controls.Add(this.bt_usuarios_validar);
            this.tp_usuarios.Controls.Add(this.dgv_usuarios_exemplo);
            this.tp_usuarios.Controls.Add(this.rtb_usuarios_query);
            this.tp_usuarios.Controls.Add(this.toolStrip2);
            this.tp_usuarios.Controls.Add(this.groupBox4);
            this.tp_usuarios.Location = new System.Drawing.Point(4, 22);
            this.tp_usuarios.Name = "tp_usuarios";
            this.tp_usuarios.Padding = new System.Windows.Forms.Padding(3);
            this.tp_usuarios.Size = new System.Drawing.Size(668, 357);
            this.tp_usuarios.TabIndex = 1;
            this.tp_usuarios.Text = "Usuários";
            this.tp_usuarios.UseVisualStyleBackColor = true;
            // 
            // pb_usuarios_progress
            // 
            this.pb_usuarios_progress.Image = global::Integrador.Properties.Resources.loader2;
            this.pb_usuarios_progress.Location = new System.Drawing.Point(638, 15);
            this.pb_usuarios_progress.Name = "pb_usuarios_progress";
            this.pb_usuarios_progress.Size = new System.Drawing.Size(24, 25);
            this.pb_usuarios_progress.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_usuarios_progress.TabIndex = 42;
            this.pb_usuarios_progress.TabStop = false;
            this.pb_usuarios_progress.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(309, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "No máximo 5 registros serão exibidos.";
            // 
            // bt_usuarios_validar
            // 
            this.bt_usuarios_validar.Location = new System.Drawing.Point(594, 184);
            this.bt_usuarios_validar.Name = "bt_usuarios_validar";
            this.bt_usuarios_validar.Size = new System.Drawing.Size(68, 25);
            this.bt_usuarios_validar.TabIndex = 40;
            this.bt_usuarios_validar.Text = "Validar";
            this.bt_usuarios_validar.UseVisualStyleBackColor = true;
            this.bt_usuarios_validar.Click += new System.EventHandler(this.bt_usuarios_validar_Click);
            // 
            // dgv_usuarios_exemplo
            // 
            this.dgv_usuarios_exemplo.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dgv_usuarios_exemplo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_usuarios_exemplo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_usuarios_exemplo.Location = new System.Drawing.Point(6, 215);
            this.dgv_usuarios_exemplo.Name = "dgv_usuarios_exemplo";
            this.dgv_usuarios_exemplo.Size = new System.Drawing.Size(656, 136);
            this.dgv_usuarios_exemplo.TabIndex = 39;
            // 
            // rtb_usuarios_query
            // 
            this.rtb_usuarios_query.Enabled = false;
            this.rtb_usuarios_query.Location = new System.Drawing.Point(309, 54);
            this.rtb_usuarios_query.Name = "rtb_usuarios_query";
            this.rtb_usuarios_query.Size = new System.Drawing.Size(353, 124);
            this.rtb_usuarios_query.TabIndex = 38;
            this.rtb_usuarios_query.Text = "";
            // 
            // toolStrip2
            // 
            this.toolStrip2.AutoSize = false;
            this.toolStrip2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_usuarios_add,
            this.tsb_usuarios_excluir,
            this.tsb_usuarios_editar,
            this.tsb_usuarios_salvar});
            this.toolStrip2.Location = new System.Drawing.Point(6, 15);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip2.Size = new System.Drawing.Size(626, 27);
            this.toolStrip2.TabIndex = 37;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // tsb_usuarios_add
            // 
            this.tsb_usuarios_add.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_usuarios_add.Image = global::Integrador.Properties.Resources.add;
            this.tsb_usuarios_add.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_usuarios_add.Name = "tsb_usuarios_add";
            this.tsb_usuarios_add.Size = new System.Drawing.Size(23, 24);
            this.tsb_usuarios_add.Text = "Incluir";
            this.tsb_usuarios_add.Click += new System.EventHandler(this.tsb_usuarios_add_Click);
            // 
            // tsb_usuarios_excluir
            // 
            this.tsb_usuarios_excluir.AutoSize = false;
            this.tsb_usuarios_excluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_usuarios_excluir.Image = global::Integrador.Properties.Resources.delete;
            this.tsb_usuarios_excluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_usuarios_excluir.Name = "tsb_usuarios_excluir";
            this.tsb_usuarios_excluir.Size = new System.Drawing.Size(20, 26);
            this.tsb_usuarios_excluir.Text = "Excluir";
            this.tsb_usuarios_excluir.Click += new System.EventHandler(this.tsb_usuarios_excluir_Click);
            // 
            // tsb_usuarios_editar
            // 
            this.tsb_usuarios_editar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_usuarios_editar.Image = global::Integrador.Properties.Resources.application_edit;
            this.tsb_usuarios_editar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_usuarios_editar.Name = "tsb_usuarios_editar";
            this.tsb_usuarios_editar.Size = new System.Drawing.Size(23, 24);
            this.tsb_usuarios_editar.Text = "Editar";
            this.tsb_usuarios_editar.Click += new System.EventHandler(this.tsb_usuarios_editar_Click);
            // 
            // tsb_usuarios_salvar
            // 
            this.tsb_usuarios_salvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_usuarios_salvar.Enabled = false;
            this.tsb_usuarios_salvar.Image = global::Integrador.Properties.Resources.disk;
            this.tsb_usuarios_salvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_usuarios_salvar.Name = "tsb_usuarios_salvar";
            this.tsb_usuarios_salvar.Size = new System.Drawing.Size(23, 24);
            this.tsb_usuarios_salvar.Text = "Salvar";
            this.tsb_usuarios_salvar.Click += new System.EventHandler(this.tsb_usuarios_salvar_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgv_usuarios);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(6, 45);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(297, 164);
            this.groupBox4.TabIndex = 35;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Seção";
            // 
            // dgv_usuarios
            // 
            this.dgv_usuarios.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgv_usuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_usuarios.Location = new System.Drawing.Point(6, 22);
            this.dgv_usuarios.Name = "dgv_usuarios";
            this.dgv_usuarios.Size = new System.Drawing.Size(285, 127);
            this.dgv_usuarios.TabIndex = 0;
            this.dgv_usuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_usuarios_CellClick);
            // 
            // frm_query
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(700, 407);
            this.Controls.Add(this.tbc_arquivos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_query";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuração / Gerador de Arquivos";
            this.Load += new System.EventHandler(this.frm_query_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tbc_arquivos.ResumeLayout(false);
            this.tp_site.ResumeLayout(false);
            this.tp_site.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_site_exemplo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_site_progress)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_site)).EndInit();
            this.tp_usuarios.ResumeLayout(false);
            this.tp_usuarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_usuarios_progress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_usuarios_exemplo)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_usuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsb_site_excluir;
        private System.Windows.Forms.ToolStripButton tbs_site_add;
        private System.Windows.Forms.TabControl tbc_arquivos;
        private System.Windows.Forms.TabPage tp_site;
        private System.Windows.Forms.TabPage tp_usuarios;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_site;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton tsb_usuarios_add;
        private System.Windows.Forms.ToolStripButton tsb_usuarios_excluir;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgv_usuarios;
        private System.Windows.Forms.ToolStripButton tsb_site_salvar;
        private System.Windows.Forms.RichTextBox rtb_site_query;
        private System.Windows.Forms.RichTextBox rtb_usuarios_query;
        private System.Windows.Forms.ToolStripButton tsb_usuarios_salvar;
        private System.Windows.Forms.Button bt_site_validar;
        private System.Windows.Forms.PictureBox pb_site_progress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_site_exemplo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_usuarios_validar;
        private System.Windows.Forms.DataGridView dgv_usuarios_exemplo;
        private System.Windows.Forms.PictureBox pb_usuarios_progress;
        private System.Windows.Forms.ToolStripButton tsb_site_editar;
        private System.Windows.Forms.ToolStripButton tsb_usuarios_editar;
    }
}