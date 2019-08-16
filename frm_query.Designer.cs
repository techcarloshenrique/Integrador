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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_usuario = new System.Windows.Forms.CheckBox();
            this.cb_view = new System.Windows.Forms.ComboBox();
            this.pb_progress = new System.Windows.Forms.PictureBox();
            this.lb_result = new System.Windows.Forms.Label();
            this.bt_testar = new System.Windows.Forms.Button();
            this.bt_save = new System.Windows.Forms.Button();
            this.rtb_query = new System.Windows.Forms.RichTextBox();
            this.cb_destino = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_secao = new System.Windows.Forms.TextBox();
            this.dgv_query = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsb_refresh = new System.Windows.Forms.ToolStripButton();
            this.tsb_excluir = new System.Windows.Forms.ToolStripButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_progress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_query)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_usuario);
            this.groupBox1.Controls.Add(this.cb_view);
            this.groupBox1.Controls.Add(this.pb_progress);
            this.groupBox1.Controls.Add(this.lb_result);
            this.groupBox1.Controls.Add(this.bt_testar);
            this.groupBox1.Controls.Add(this.bt_save);
            this.groupBox1.Controls.Add(this.rtb_query);
            this.groupBox1.Controls.Add(this.cb_destino);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.tb_secao);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(676, 176);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seções / Query\'s";
            // 
            // cb_usuario
            // 
            this.cb_usuario.AutoSize = true;
            this.cb_usuario.Location = new System.Drawing.Point(235, 101);
            this.cb_usuario.Name = "cb_usuario";
            this.cb_usuario.Size = new System.Drawing.Size(100, 21);
            this.cb_usuario.TabIndex = 3;
            this.cb_usuario.Text = "Por usuário";
            this.cb_usuario.UseVisualStyleBackColor = true;
            // 
            // cb_view
            // 
            this.cb_view.FormattingEnabled = true;
            this.cb_view.Location = new System.Drawing.Point(92, 40);
            this.cb_view.Name = "cb_view";
            this.cb_view.Size = new System.Drawing.Size(243, 24);
            this.cb_view.TabIndex = 40;
            this.cb_view.SelectedIndexChanged += new System.EventHandler(this.cb_view_SelectedIndexChanged);
            // 
            // pb_progress
            // 
            this.pb_progress.Image = global::Integrador.Properties.Resources.loader2;
            this.pb_progress.Location = new System.Drawing.Point(455, 132);
            this.pb_progress.Name = "pb_progress";
            this.pb_progress.Size = new System.Drawing.Size(30, 30);
            this.pb_progress.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_progress.TabIndex = 5;
            this.pb_progress.TabStop = false;
            this.pb_progress.Visible = false;
            // 
            // lb_result
            // 
            this.lb_result.AutoSize = true;
            this.lb_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_result.ForeColor = System.Drawing.Color.ForestGreen;
            this.lb_result.Location = new System.Drawing.Point(26, 141);
            this.lb_result.Name = "lb_result";
            this.lb_result.Size = new System.Drawing.Size(128, 17);
            this.lb_result.TabIndex = 39;
            this.lb_result.Text = "A consula retornou";
            this.lb_result.Visible = false;
            // 
            // bt_testar
            // 
            this.bt_testar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_testar.Image = global::Integrador.Properties.Resources.database_go;
            this.bt_testar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_testar.Location = new System.Drawing.Point(491, 132);
            this.bt_testar.Name = "bt_testar";
            this.bt_testar.Size = new System.Drawing.Size(75, 30);
            this.bt_testar.TabIndex = 5;
            this.bt_testar.Text = "Testar";
            this.bt_testar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_testar.UseVisualStyleBackColor = true;
            this.bt_testar.Click += new System.EventHandler(this.bt_testar_Click);
            // 
            // bt_save
            // 
            this.bt_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_save.Image = global::Integrador.Properties.Resources.add;
            this.bt_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_save.Location = new System.Drawing.Point(572, 132);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(75, 30);
            this.bt_save.TabIndex = 6;
            this.bt_save.Text = "Inserir";
            this.bt_save.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_save.UseVisualStyleBackColor = true;
            this.bt_save.Click += new System.EventHandler(this.bt_save_Click);
            // 
            // rtb_query
            // 
            this.rtb_query.Location = new System.Drawing.Point(341, 41);
            this.rtb_query.Name = "rtb_query";
            this.rtb_query.Size = new System.Drawing.Size(306, 81);
            this.rtb_query.TabIndex = 4;
            this.rtb_query.Text = "";
            // 
            // cb_destino
            // 
            this.cb_destino.FormattingEnabled = true;
            this.cb_destino.Location = new System.Drawing.Point(92, 98);
            this.cb_destino.Name = "cb_destino";
            this.cb_destino.Size = new System.Drawing.Size(137, 24);
            this.cb_destino.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 28;
            this.label2.Text = "View:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 33;
            this.label1.Text = "Destino:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(26, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 17);
            this.label9.TabIndex = 31;
            this.label9.Text = "Seção:";
            // 
            // tb_secao
            // 
            this.tb_secao.Enabled = false;
            this.tb_secao.Location = new System.Drawing.Point(92, 70);
            this.tb_secao.Name = "tb_secao";
            this.tb_secao.Size = new System.Drawing.Size(243, 23);
            this.tb_secao.TabIndex = 1;
            // 
            // dgv_query
            // 
            this.dgv_query.AllowUserToAddRows = false;
            this.dgv_query.AllowUserToDeleteRows = false;
            this.dgv_query.AllowUserToOrderColumns = true;
            this.dgv_query.AllowUserToResizeRows = false;
            this.dgv_query.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_query.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_query.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_query.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_query.GridColor = System.Drawing.SystemColors.Window;
            this.dgv_query.Location = new System.Drawing.Point(12, 221);
            this.dgv_query.Name = "dgv_query";
            this.dgv_query.ReadOnly = true;
            this.dgv_query.RowHeadersVisible = false;
            this.dgv_query.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_query.Size = new System.Drawing.Size(676, 176);
            this.dgv_query.TabIndex = 33;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_refresh,
            this.tsb_excluir});
            this.toolStrip1.Location = new System.Drawing.Point(12, 191);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(675, 27);
            this.toolStrip1.TabIndex = 34;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsb_refresh
            // 
            this.tsb_refresh.AutoSize = false;
            this.tsb_refresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_refresh.Image = global::Integrador.Properties.Resources.arrow_refresh;
            this.tsb_refresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_refresh.Name = "tsb_refresh";
            this.tsb_refresh.Size = new System.Drawing.Size(20, 26);
            this.tsb_refresh.Text = "Refresh";
            this.tsb_refresh.Click += new System.EventHandler(this.tsb_refresh_Click);
            // 
            // tsb_excluir
            // 
            this.tsb_excluir.AutoSize = false;
            this.tsb_excluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_excluir.Image = global::Integrador.Properties.Resources.delete;
            this.tsb_excluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_excluir.Name = "tsb_excluir";
            this.tsb_excluir.Size = new System.Drawing.Size(20, 26);
            this.tsb_excluir.Text = "Excluir";
            this.tsb_excluir.Click += new System.EventHandler(this.tsb_excluir_Click);
            // 
            // frm_query
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(700, 409);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgv_query);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_query";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuração / Gerador de Arquivos";
            this.Load += new System.EventHandler(this.frm_query_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_progress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_query)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cb_destino;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_secao;
        private System.Windows.Forms.RichTextBox rtb_query;
        private System.Windows.Forms.Button bt_save;
        private System.Windows.Forms.Label lb_result;
        private System.Windows.Forms.Button bt_testar;
        public System.Windows.Forms.PictureBox pb_progress;
        private System.Windows.Forms.DataGridView dgv_query;
        private System.Windows.Forms.ComboBox cb_view;
        private System.Windows.Forms.CheckBox cb_usuario;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsb_refresh;
        private System.Windows.Forms.ToolStripButton tsb_excluir;
    }
}