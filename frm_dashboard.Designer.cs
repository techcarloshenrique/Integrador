namespace Integrador
{
    partial class frm_dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_dashboard));
            this.pnl_recebido = new System.Windows.Forms.Panel();
            this.pn_recebido_pedido = new System.Windows.Forms.Panel();
            this.flp_recebidos = new System.Windows.Forms.FlowLayoutPanel();
            this.pnl_recebido_header = new System.Windows.Forms.Panel();
            this.pb_recebido = new System.Windows.Forms.PictureBox();
            this.pb_recebido_cor = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.pnl_processado = new System.Windows.Forms.Panel();
            this.pn_processado_pedido = new System.Windows.Forms.Panel();
            this.flp_processado = new System.Windows.Forms.FlowLayoutPanel();
            this.pnl_processado_header = new System.Windows.Forms.Panel();
            this.pb_processado = new System.Windows.Forms.PictureBox();
            this.pb_processado_cor = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.pnl_rec = new System.Windows.Forms.Panel();
            this.pb_rec = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.pnl_1 = new System.Windows.Forms.Panel();
            this.pnl_cli = new System.Windows.Forms.Panel();
            this.pb_proc = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tm_main = new System.Windows.Forms.Timer(this.components);
            this.pnl_recebido.SuspendLayout();
            this.pn_recebido_pedido.SuspendLayout();
            this.pnl_recebido_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_recebido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_recebido_cor)).BeginInit();
            this.pnl_processado.SuspendLayout();
            this.pn_processado_pedido.SuspendLayout();
            this.pnl_processado_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_processado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_processado_cor)).BeginInit();
            this.pnl_rec.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_rec)).BeginInit();
            this.pnl_1.SuspendLayout();
            this.pnl_cli.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_proc)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_recebido
            // 
            this.pnl_recebido.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnl_recebido.Controls.Add(this.pn_recebido_pedido);
            this.pnl_recebido.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_recebido.Location = new System.Drawing.Point(0, 0);
            this.pnl_recebido.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_recebido.Name = "pnl_recebido";
            this.pnl_recebido.Padding = new System.Windows.Forms.Padding(3);
            this.pnl_recebido.Size = new System.Drawing.Size(372, 321);
            this.pnl_recebido.TabIndex = 4;
            // 
            // pn_recebido_pedido
            // 
            this.pn_recebido_pedido.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pn_recebido_pedido.Controls.Add(this.flp_recebidos);
            this.pn_recebido_pedido.Controls.Add(this.pnl_recebido_header);
            this.pn_recebido_pedido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_recebido_pedido.Location = new System.Drawing.Point(3, 3);
            this.pn_recebido_pedido.Name = "pn_recebido_pedido";
            this.pn_recebido_pedido.Size = new System.Drawing.Size(366, 315);
            this.pn_recebido_pedido.TabIndex = 0;
            // 
            // flp_recebidos
            // 
            this.flp_recebidos.AutoScroll = true;
            this.flp_recebidos.AutoSize = true;
            this.flp_recebidos.BackColor = System.Drawing.SystemColors.ControlLight;
            this.flp_recebidos.Location = new System.Drawing.Point(19, 53);
            this.flp_recebidos.Margin = new System.Windows.Forms.Padding(0);
            this.flp_recebidos.Name = "flp_recebidos";
            this.flp_recebidos.Padding = new System.Windows.Forms.Padding(5);
            this.flp_recebidos.Size = new System.Drawing.Size(59, 50);
            this.flp_recebidos.TabIndex = 1;
            this.flp_recebidos.Visible = false;
            // 
            // pnl_recebido_header
            // 
            this.pnl_recebido_header.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pnl_recebido_header.Controls.Add(this.pb_recebido);
            this.pnl_recebido_header.Controls.Add(this.pb_recebido_cor);
            this.pnl_recebido_header.Controls.Add(this.label11);
            this.pnl_recebido_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_recebido_header.Location = new System.Drawing.Point(0, 0);
            this.pnl_recebido_header.Name = "pnl_recebido_header";
            this.pnl_recebido_header.Size = new System.Drawing.Size(366, 38);
            this.pnl_recebido_header.TabIndex = 0;
            // 
            // pb_recebido
            // 
            this.pb_recebido.BackColor = System.Drawing.Color.Transparent;
            this.pb_recebido.Image = global::Integrador.Properties.Resources.loader2;
            this.pb_recebido.Location = new System.Drawing.Point(343, 6);
            this.pb_recebido.Name = "pb_recebido";
            this.pb_recebido.Size = new System.Drawing.Size(26, 25);
            this.pb_recebido.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_recebido.TabIndex = 7;
            this.pb_recebido.TabStop = false;
            // 
            // pb_recebido_cor
            // 
            this.pb_recebido_cor.Image = global::Integrador.Properties.Resources.ic_circle_filled_yellow;
            this.pb_recebido_cor.Location = new System.Drawing.Point(10, 11);
            this.pb_recebido_cor.Name = "pb_recebido_cor";
            this.pb_recebido_cor.Size = new System.Drawing.Size(17, 15);
            this.pb_recebido_cor.TabIndex = 4;
            this.pb_recebido_cor.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label11.Location = new System.Drawing.Point(33, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(309, 16);
            this.label11.TabIndex = 3;
            this.label11.Text = "PEDIDOS RECEBIDOS / NÃO PROCESSADOS";
            // 
            // pnl_processado
            // 
            this.pnl_processado.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnl_processado.Controls.Add(this.pn_processado_pedido);
            this.pnl_processado.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_processado.Location = new System.Drawing.Point(372, 0);
            this.pnl_processado.Name = "pnl_processado";
            this.pnl_processado.Padding = new System.Windows.Forms.Padding(3);
            this.pnl_processado.Size = new System.Drawing.Size(365, 321);
            this.pnl_processado.TabIndex = 5;
            // 
            // pn_processado_pedido
            // 
            this.pn_processado_pedido.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pn_processado_pedido.Controls.Add(this.flp_processado);
            this.pn_processado_pedido.Controls.Add(this.pnl_processado_header);
            this.pn_processado_pedido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_processado_pedido.Location = new System.Drawing.Point(3, 3);
            this.pn_processado_pedido.Name = "pn_processado_pedido";
            this.pn_processado_pedido.Size = new System.Drawing.Size(359, 315);
            this.pn_processado_pedido.TabIndex = 0;
            // 
            // flp_processado
            // 
            this.flp_processado.AutoScroll = true;
            this.flp_processado.BackColor = System.Drawing.SystemColors.ControlLight;
            this.flp_processado.Location = new System.Drawing.Point(21, 53);
            this.flp_processado.Margin = new System.Windows.Forms.Padding(0);
            this.flp_processado.Name = "flp_processado";
            this.flp_processado.Padding = new System.Windows.Forms.Padding(5);
            this.flp_processado.Size = new System.Drawing.Size(58, 50);
            this.flp_processado.TabIndex = 2;
            this.flp_processado.Visible = false;
            // 
            // pnl_processado_header
            // 
            this.pnl_processado_header.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pnl_processado_header.Controls.Add(this.pb_processado);
            this.pnl_processado_header.Controls.Add(this.pb_processado_cor);
            this.pnl_processado_header.Controls.Add(this.label12);
            this.pnl_processado_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_processado_header.Location = new System.Drawing.Point(0, 0);
            this.pnl_processado_header.Name = "pnl_processado_header";
            this.pnl_processado_header.Size = new System.Drawing.Size(359, 38);
            this.pnl_processado_header.TabIndex = 1;
            // 
            // pb_processado
            // 
            this.pb_processado.BackColor = System.Drawing.Color.Transparent;
            this.pb_processado.Image = global::Integrador.Properties.Resources.loader2;
            this.pb_processado.Location = new System.Drawing.Point(313, 6);
            this.pb_processado.Name = "pb_processado";
            this.pb_processado.Size = new System.Drawing.Size(26, 25);
            this.pb_processado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_processado.TabIndex = 7;
            this.pb_processado.TabStop = false;
            // 
            // pb_processado_cor
            // 
            this.pb_processado_cor.Image = global::Integrador.Properties.Resources.ic_circle_filled_green;
            this.pb_processado_cor.Location = new System.Drawing.Point(10, 11);
            this.pb_processado_cor.Name = "pb_processado_cor";
            this.pb_processado_cor.Size = new System.Drawing.Size(17, 15);
            this.pb_processado_cor.TabIndex = 4;
            this.pb_processado_cor.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label12.Location = new System.Drawing.Point(33, 10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(274, 16);
            this.label12.TabIndex = 3;
            this.label12.Text = "PEDIDOS RECEBIDOS / PROCESSADOS";
            // 
            // pnl_rec
            // 
            this.pnl_rec.BackColor = System.Drawing.SystemColors.Control;
            this.pnl_rec.Controls.Add(this.pb_rec);
            this.pnl_rec.Controls.Add(this.label13);
            this.pnl_rec.Location = new System.Drawing.Point(3, 3);
            this.pnl_rec.Name = "pnl_rec";
            this.pnl_rec.Padding = new System.Windows.Forms.Padding(3);
            this.pnl_rec.Size = new System.Drawing.Size(199, 123);
            this.pnl_rec.TabIndex = 3;
            this.pnl_rec.Visible = false;
            // 
            // pb_rec
            // 
            this.pb_rec.BackColor = System.Drawing.Color.Transparent;
            this.pb_rec.Image = global::Integrador.Properties.Resources.loader2;
            this.pb_rec.Location = new System.Drawing.Point(164, 3);
            this.pb_rec.Name = "pb_rec";
            this.pb_rec.Size = new System.Drawing.Size(26, 25);
            this.pb_rec.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_rec.TabIndex = 6;
            this.pb_rec.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label13.Location = new System.Drawing.Point(2, 8);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(156, 16);
            this.label13.TabIndex = 14;
            this.label13.Text = "PEDIDOS RECEBIDOS";
            // 
            // pnl_1
            // 
            this.pnl_1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnl_1.Controls.Add(this.pnl_cli);
            this.pnl_1.Controls.Add(this.pnl_rec);
            this.pnl_1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_1.Location = new System.Drawing.Point(0, 321);
            this.pnl_1.Margin = new System.Windows.Forms.Padding(20);
            this.pnl_1.MinimumSize = new System.Drawing.Size(0, 100);
            this.pnl_1.Name = "pnl_1";
            this.pnl_1.Size = new System.Drawing.Size(831, 129);
            this.pnl_1.TabIndex = 3;
            // 
            // pnl_cli
            // 
            this.pnl_cli.BackColor = System.Drawing.SystemColors.Control;
            this.pnl_cli.Controls.Add(this.pb_proc);
            this.pnl_cli.Controls.Add(this.label1);
            this.pnl_cli.Location = new System.Drawing.Point(208, 3);
            this.pnl_cli.Name = "pnl_cli";
            this.pnl_cli.Padding = new System.Windows.Forms.Padding(3);
            this.pnl_cli.Size = new System.Drawing.Size(226, 123);
            this.pnl_cli.TabIndex = 15;
            this.pnl_cli.Visible = false;
            // 
            // pb_proc
            // 
            this.pb_proc.BackColor = System.Drawing.Color.Transparent;
            this.pb_proc.Image = global::Integrador.Properties.Resources.loader2;
            this.pb_proc.Location = new System.Drawing.Point(168, 3);
            this.pb_proc.Name = "pb_proc";
            this.pb_proc.Size = new System.Drawing.Size(26, 25);
            this.pb_proc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_proc.TabIndex = 6;
            this.pb_proc.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(2, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "CLIENTES ATENDIDOS";
            // 
            // tm_main
            // 
            this.tm_main.Enabled = true;
            this.tm_main.Interval = 1000;
            this.tm_main.Tick += new System.EventHandler(this.tm_main_Tick);
            // 
            // frm_dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(831, 450);
            this.Controls.Add(this.pnl_processado);
            this.Controls.Add(this.pnl_recebido);
            this.Controls.Add(this.pnl_1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_dashboard_Load);
            this.pnl_recebido.ResumeLayout(false);
            this.pn_recebido_pedido.ResumeLayout(false);
            this.pn_recebido_pedido.PerformLayout();
            this.pnl_recebido_header.ResumeLayout(false);
            this.pnl_recebido_header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_recebido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_recebido_cor)).EndInit();
            this.pnl_processado.ResumeLayout(false);
            this.pn_processado_pedido.ResumeLayout(false);
            this.pnl_processado_header.ResumeLayout(false);
            this.pnl_processado_header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_processado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_processado_cor)).EndInit();
            this.pnl_rec.ResumeLayout(false);
            this.pnl_rec.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_rec)).EndInit();
            this.pnl_1.ResumeLayout(false);
            this.pnl_cli.ResumeLayout(false);
            this.pnl_cli.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_proc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnl_recebido;
        private System.Windows.Forms.Panel pnl_processado;
        private System.Windows.Forms.Panel pnl_recebido_header;
        private System.Windows.Forms.FlowLayoutPanel flp_recebidos;
        private System.Windows.Forms.Panel pnl_rec;
        private System.Windows.Forms.Panel pnl_1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel pnl_processado_header;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pb_recebido_cor;
        private System.Windows.Forms.PictureBox pb_processado_cor;
        private System.Windows.Forms.FlowLayoutPanel flp_processado;
        private System.Windows.Forms.Panel pn_processado_pedido;
        private System.Windows.Forms.Panel pn_recebido_pedido;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pb_rec;
        private System.Windows.Forms.PictureBox pb_recebido;
        private System.Windows.Forms.PictureBox pb_processado;
        private System.Windows.Forms.Timer tm_main;
        private System.Windows.Forms.Panel pnl_cli;
        private System.Windows.Forms.PictureBox pb_proc;
        private System.Windows.Forms.Label label1;
    }
}