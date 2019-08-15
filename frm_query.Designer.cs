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
            this.bt_save = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.rtb_query = new System.Windows.Forms.RichTextBox();
            this.cb_destino = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_view = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_secao = new System.Windows.Forms.TextBox();
            this.Tabela = new System.Windows.Forms.GroupBox();
            this.dgv_query = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_apagar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.Tabela.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_query)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_save);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.rtb_query);
            this.groupBox1.Controls.Add(this.cb_destino);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tb_view);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.tb_secao);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(675, 176);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados de conexão da Empresa";
            // 
            // bt_save
            // 
            this.bt_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_save.Image = global::Integrador.Properties.Resources.add;
            this.bt_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_save.Location = new System.Drawing.Point(572, 132);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(75, 30);
            this.bt_save.TabIndex = 37;
            this.bt_save.Text = "Inserir";
            this.bt_save.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_save.UseVisualStyleBackColor = true;
            this.bt_save.Click += new System.EventHandler(this.bt_save_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(293, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 36;
            this.label3.Text = "Query:";
            // 
            // rtb_query
            // 
            this.rtb_query.Location = new System.Drawing.Point(296, 70);
            this.rtb_query.Name = "rtb_query";
            this.rtb_query.Size = new System.Drawing.Size(351, 56);
            this.rtb_query.TabIndex = 3;
            this.rtb_query.Text = "";
            // 
            // cb_destino
            // 
            this.cb_destino.FormattingEnabled = true;
            this.cb_destino.Location = new System.Drawing.Point(140, 102);
            this.cb_destino.Name = "cb_destino";
            this.cb_destino.Size = new System.Drawing.Size(121, 24);
            this.cb_destino.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 28;
            this.label2.Text = "Nome da View:";
            // 
            // tb_view
            // 
            this.tb_view.Location = new System.Drawing.Point(140, 38);
            this.tb_view.Name = "tb_view";
            this.tb_view.Size = new System.Drawing.Size(121, 23);
            this.tb_view.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 105);
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
            this.label9.Size = new System.Drawing.Size(113, 17);
            this.label9.TabIndex = 31;
            this.label9.Text = "Nome da Seção:";
            // 
            // tb_secao
            // 
            this.tb_secao.Location = new System.Drawing.Point(140, 70);
            this.tb_secao.Name = "tb_secao";
            this.tb_secao.Size = new System.Drawing.Size(121, 23);
            this.tb_secao.TabIndex = 1;
            // 
            // Tabela
            // 
            this.Tabela.Controls.Add(this.dgv_query);
            this.Tabela.Location = new System.Drawing.Point(12, 194);
            this.Tabela.Name = "Tabela";
            this.Tabela.Size = new System.Drawing.Size(675, 162);
            this.Tabela.TabIndex = 31;
            this.Tabela.TabStop = false;
            this.Tabela.Text = "Tabela";
            // 
            // dgv_query
            // 
            this.dgv_query.AllowUserToAddRows = false;
            this.dgv_query.AllowUserToDeleteRows = false;
            this.dgv_query.AllowUserToOrderColumns = true;
            this.dgv_query.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_query.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_query.Location = new System.Drawing.Point(6, 19);
            this.dgv_query.Name = "dgv_query";
            this.dgv_query.ReadOnly = true;
            this.dgv_query.Size = new System.Drawing.Size(663, 137);
            this.dgv_query.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.flowLayoutPanel1.Controls.Add(this.btn_apagar);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 365);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(699, 45);
            this.flowLayoutPanel1.TabIndex = 32;
            // 
            // btn_apagar
            // 
            this.btn_apagar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_apagar.Enabled = false;
            this.btn_apagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_apagar.Image = global::Integrador.Properties.Resources.delete;
            this.btn_apagar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_apagar.Location = new System.Drawing.Point(610, 8);
            this.btn_apagar.Name = "btn_apagar";
            this.btn_apagar.Size = new System.Drawing.Size(76, 30);
            this.btn_apagar.TabIndex = 4;
            this.btn_apagar.Text = "Apagar";
            this.btn_apagar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_apagar.UseVisualStyleBackColor = true;
            // 
            // frm_query
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(699, 410);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.Tabela);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_query";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_query";
            this.Load += new System.EventHandler(this.frm_query_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Tabela.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_query)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cb_destino;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_view;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_secao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtb_query;
        private System.Windows.Forms.Button bt_save;
        private System.Windows.Forms.GroupBox Tabela;
        private System.Windows.Forms.DataGridView dgv_query;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btn_apagar;
    }
}