namespace Integrador
{
    partial class frm_main
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_main));
            this.ms_main = new System.Windows.Forms.MenuStrip();
            this.menu_ts_sistema = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_ts_licenca = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.menu_ts_change_pass = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_ts_logout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.menu_ts_sair = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_ts_config = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_ts_conn = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_ts_db = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_ts_ftp = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_ts_file = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_ts_env_rec = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_ts_ag = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.usuariosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_ts_trans = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_ts_env = new System.Windows.Forms.ToolStripMenuItem();
            this.gerar_site = new System.Windows.Forms.ToolStripMenuItem();
            this.gerar_carga = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_ts_rec = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_ts_enviar = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_ts_enviar_site = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_ts_enviar_carga = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.menu_ts_enviar_imagens = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_ts_receber = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_ts_receber_pedidos = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_ts_consultas = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_ts_vend = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_ts_janela = new System.Windows.Forms.ToolStripMenuItem();
            this.testesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dragAndDropToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_ts_ajuda = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.menu_ts_sobre = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_main = new System.Windows.Forms.ToolStrip();
            this.tool_home = new System.Windows.Forms.ToolStripButton();
            this.tool_db = new System.Windows.Forms.ToolStripButton();
            this.tool_ftp = new System.Windows.Forms.ToolStripButton();
            this.tool_ag = new System.Windows.Forms.ToolStripButton();
            this.tool_file = new System.Windows.Forms.ToolStripButton();
            this.tool_query = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tool_gerar_arquivos = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tool_ajuda = new System.Windows.Forms.ToolStripButton();
            this.ss_main = new System.Windows.Forms.StatusStrip();
            this.img_tick = new System.Windows.Forms.ToolStripStatusLabel();
            this.lb_progress = new System.Windows.Forms.ToolStripStatusLabel();
            this.ts_user = new System.Windows.Forms.ToolStripStatusLabel();
            this.ts_hora = new System.Windows.Forms.ToolStripStatusLabel();
            this.pb_change = new System.Windows.Forms.PictureBox();
            this.pb_close = new System.Windows.Forms.PictureBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.ms_main.SuspendLayout();
            this.ts_main.SuspendLayout();
            this.ss_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_change)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_close)).BeginInit();
            this.SuspendLayout();
            // 
            // ms_main
            // 
            this.ms_main.BackColor = System.Drawing.SystemColors.Window;
            this.ms_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_ts_sistema,
            this.menu_ts_config,
            this.menu_ts_trans,
            this.menu_ts_consultas,
            this.menu_ts_janela,
            this.menu_ts_ajuda});
            this.ms_main.Location = new System.Drawing.Point(0, 0);
            this.ms_main.MdiWindowListItem = this.menu_ts_janela;
            this.ms_main.Name = "ms_main";
            this.ms_main.Size = new System.Drawing.Size(880, 24);
            this.ms_main.TabIndex = 0;
            this.ms_main.Text = "Menu";
            // 
            // menu_ts_sistema
            // 
            this.menu_ts_sistema.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_ts_licenca,
            this.toolStripMenuItem1,
            this.menu_ts_change_pass,
            this.menu_ts_logout,
            this.toolStripMenuItem4,
            this.menu_ts_sair});
            this.menu_ts_sistema.Name = "menu_ts_sistema";
            this.menu_ts_sistema.Size = new System.Drawing.Size(60, 20);
            this.menu_ts_sistema.Text = "Sistema";
            // 
            // menu_ts_licenca
            // 
            this.menu_ts_licenca.Name = "menu_ts_licenca";
            this.menu_ts_licenca.Size = new System.Drawing.Size(149, 22);
            this.menu_ts_licenca.Text = "Licença";
            this.menu_ts_licenca.Click += new System.EventHandler(this.menu_ts_licenca_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(146, 6);
            // 
            // menu_ts_change_pass
            // 
            this.menu_ts_change_pass.Name = "menu_ts_change_pass";
            this.menu_ts_change_pass.Size = new System.Drawing.Size(149, 22);
            this.menu_ts_change_pass.Text = "Alterar Senha";
            this.menu_ts_change_pass.Click += new System.EventHandler(this.menu_ts_change_pass_Click);
            // 
            // menu_ts_logout
            // 
            this.menu_ts_logout.Name = "menu_ts_logout";
            this.menu_ts_logout.Size = new System.Drawing.Size(149, 22);
            this.menu_ts_logout.Text = "Trocar Usuário";
            this.menu_ts_logout.Click += new System.EventHandler(this.menu_ts_logout_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(146, 6);
            // 
            // menu_ts_sair
            // 
            this.menu_ts_sair.Name = "menu_ts_sair";
            this.menu_ts_sair.Size = new System.Drawing.Size(149, 22);
            this.menu_ts_sair.Text = "Sair";
            this.menu_ts_sair.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // menu_ts_config
            // 
            this.menu_ts_config.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_ts_conn,
            this.menu_ts_file,
            this.menu_ts_ag,
            this.toolStripMenuItem3,
            this.usuariosToolStripMenuItem1});
            this.menu_ts_config.Name = "menu_ts_config";
            this.menu_ts_config.Size = new System.Drawing.Size(96, 20);
            this.menu_ts_config.Text = "Configurações";
            // 
            // menu_ts_conn
            // 
            this.menu_ts_conn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_ts_db,
            this.menu_ts_ftp});
            this.menu_ts_conn.Name = "menu_ts_conn";
            this.menu_ts_conn.Size = new System.Drawing.Size(150, 22);
            this.menu_ts_conn.Text = "Conexões";
            // 
            // menu_ts_db
            // 
            this.menu_ts_db.Name = "menu_ts_db";
            this.menu_ts_db.Size = new System.Drawing.Size(159, 22);
            this.menu_ts_db.Text = "Banco de Dados";
            this.menu_ts_db.Click += new System.EventHandler(this.bancoDeDadosToolStripMenuItem_Click);
            // 
            // menu_ts_ftp
            // 
            this.menu_ts_ftp.Name = "menu_ts_ftp";
            this.menu_ts_ftp.Size = new System.Drawing.Size(159, 22);
            this.menu_ts_ftp.Text = "FTP";
            this.menu_ts_ftp.Click += new System.EventHandler(this.fTPToolStripMenuItem_Click);
            // 
            // menu_ts_file
            // 
            this.menu_ts_file.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_ts_env_rec});
            this.menu_ts_file.Name = "menu_ts_file";
            this.menu_ts_file.Size = new System.Drawing.Size(150, 22);
            this.menu_ts_file.Text = "Arquivos";
            // 
            // menu_ts_env_rec
            // 
            this.menu_ts_env_rec.Name = "menu_ts_env_rec";
            this.menu_ts_env_rec.Size = new System.Drawing.Size(168, 22);
            this.menu_ts_env_rec.Text = " Envio / Recepção";
            this.menu_ts_env_rec.Click += new System.EventHandler(this.menu_ts_env_rec_Click);
            // 
            // menu_ts_ag
            // 
            this.menu_ts_ag.Name = "menu_ts_ag";
            this.menu_ts_ag.Size = new System.Drawing.Size(150, 22);
            this.menu_ts_ag.Text = "Agendamento";
            this.menu_ts_ag.Click += new System.EventHandler(this.ag_ts_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(147, 6);
            // 
            // usuariosToolStripMenuItem1
            // 
            this.usuariosToolStripMenuItem1.Name = "usuariosToolStripMenuItem1";
            this.usuariosToolStripMenuItem1.Size = new System.Drawing.Size(150, 22);
            this.usuariosToolStripMenuItem1.Text = " Usuários";
            this.usuariosToolStripMenuItem1.Click += new System.EventHandler(this.vendedoresToolStripMenuItem1_Click);
            // 
            // menu_ts_trans
            // 
            this.menu_ts_trans.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_ts_env,
            this.menu_ts_rec});
            this.menu_ts_trans.Name = "menu_ts_trans";
            this.menu_ts_trans.Size = new System.Drawing.Size(75, 20);
            this.menu_ts_trans.Text = "Integração";
            // 
            // menu_ts_env
            // 
            this.menu_ts_env.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gerar_site,
            this.gerar_carga});
            this.menu_ts_env.Name = "menu_ts_env";
            this.menu_ts_env.Size = new System.Drawing.Size(138, 22);
            this.menu_ts_env.Text = "Gerar";
            // 
            // gerar_site
            // 
            this.gerar_site.Name = "gerar_site";
            this.gerar_site.Size = new System.Drawing.Size(105, 22);
            this.gerar_site.Text = "Site";
            this.gerar_site.Click += new System.EventHandler(this.gerar_site_Click);
            // 
            // gerar_carga
            // 
            this.gerar_carga.Name = "gerar_carga";
            this.gerar_carga.Size = new System.Drawing.Size(105, 22);
            this.gerar_carga.Text = "Carga";
            this.gerar_carga.Click += new System.EventHandler(this.gerar_carga_Click);
            // 
            // menu_ts_rec
            // 
            this.menu_ts_rec.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_ts_enviar,
            this.menu_ts_receber});
            this.menu_ts_rec.Name = "menu_ts_rec";
            this.menu_ts_rec.Size = new System.Drawing.Size(138, 22);
            this.menu_ts_rec.Text = "Transmissão";
            // 
            // menu_ts_enviar
            // 
            this.menu_ts_enviar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_ts_enviar_site,
            this.menu_ts_enviar_carga,
            this.toolStripMenuItem5,
            this.menu_ts_enviar_imagens});
            this.menu_ts_enviar.Name = "menu_ts_enviar";
            this.menu_ts_enviar.Size = new System.Drawing.Size(116, 22);
            this.menu_ts_enviar.Text = "Enviar";
            // 
            // menu_ts_enviar_site
            // 
            this.menu_ts_enviar_site.Name = "menu_ts_enviar_site";
            this.menu_ts_enviar_site.Size = new System.Drawing.Size(119, 22);
            this.menu_ts_enviar_site.Text = "Site";
            this.menu_ts_enviar_site.Click += new System.EventHandler(this.menu_ts_enviar_site_Click);
            // 
            // menu_ts_enviar_carga
            // 
            this.menu_ts_enviar_carga.Name = "menu_ts_enviar_carga";
            this.menu_ts_enviar_carga.Size = new System.Drawing.Size(119, 22);
            this.menu_ts_enviar_carga.Text = "Carga";
            this.menu_ts_enviar_carga.Click += new System.EventHandler(this.menu_ts_enviar_carga_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(116, 6);
            // 
            // menu_ts_enviar_imagens
            // 
            this.menu_ts_enviar_imagens.Name = "menu_ts_enviar_imagens";
            this.menu_ts_enviar_imagens.Size = new System.Drawing.Size(119, 22);
            this.menu_ts_enviar_imagens.Text = "Imagens";
            this.menu_ts_enviar_imagens.Click += new System.EventHandler(this.menu_ts_enviar_imagens_Click);
            // 
            // menu_ts_receber
            // 
            this.menu_ts_receber.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_ts_receber_pedidos});
            this.menu_ts_receber.Name = "menu_ts_receber";
            this.menu_ts_receber.Size = new System.Drawing.Size(116, 22);
            this.menu_ts_receber.Text = "Receber";
            // 
            // menu_ts_receber_pedidos
            // 
            this.menu_ts_receber_pedidos.Name = "menu_ts_receber_pedidos";
            this.menu_ts_receber_pedidos.Size = new System.Drawing.Size(116, 22);
            this.menu_ts_receber_pedidos.Text = "Pedidos";
            // 
            // menu_ts_consultas
            // 
            this.menu_ts_consultas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.menu_ts_vend});
            this.menu_ts_consultas.Name = "menu_ts_consultas";
            this.menu_ts_consultas.Size = new System.Drawing.Size(71, 20);
            this.menu_ts_consultas.Text = "Consultas";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Visible = false;
            // 
            // menu_ts_vend
            // 
            this.menu_ts_vend.Name = "menu_ts_vend";
            this.menu_ts_vend.Size = new System.Drawing.Size(135, 22);
            this.menu_ts_vend.Text = "Vendedores";
            this.menu_ts_vend.Click += new System.EventHandler(this.menu_ts_vend_Click);
            // 
            // menu_ts_janela
            // 
            this.menu_ts_janela.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testesToolStripMenuItem});
            this.menu_ts_janela.Name = "menu_ts_janela";
            this.menu_ts_janela.Size = new System.Drawing.Size(56, 20);
            this.menu_ts_janela.Text = "Janelas";
            // 
            // testesToolStripMenuItem
            // 
            this.testesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dragAndDropToolStripMenuItem});
            this.testesToolStripMenuItem.Name = "testesToolStripMenuItem";
            this.testesToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.testesToolStripMenuItem.Text = "Testes";
            // 
            // dragAndDropToolStripMenuItem
            // 
            this.dragAndDropToolStripMenuItem.Name = "dragAndDropToolStripMenuItem";
            this.dragAndDropToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.dragAndDropToolStripMenuItem.Text = "Drag and Drop";
            this.dragAndDropToolStripMenuItem.Click += new System.EventHandler(this.dragAndDropToolStripMenuItem_Click);
            // 
            // menu_ts_ajuda
            // 
            this.menu_ts_ajuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajudaToolStripMenuItem,
            this.toolStripMenuItem2,
            this.menu_ts_sobre});
            this.menu_ts_ajuda.Name = "menu_ts_ajuda";
            this.menu_ts_ajuda.Size = new System.Drawing.Size(50, 20);
            this.menu_ts_ajuda.Text = "Ajuda";
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(102, 6);
            // 
            // menu_ts_sobre
            // 
            this.menu_ts_sobre.Name = "menu_ts_sobre";
            this.menu_ts_sobre.Size = new System.Drawing.Size(105, 22);
            this.menu_ts_sobre.Text = "Sobre";
            this.menu_ts_sobre.Click += new System.EventHandler(this.menu_ts_sobre_Click);
            // 
            // ts_main
            // 
            this.ts_main.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ts_main.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ts_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tool_home,
            this.tool_db,
            this.tool_ftp,
            this.tool_ag,
            this.tool_file,
            this.tool_query,
            this.toolStripSeparator1,
            this.tool_gerar_arquivos,
            this.toolStripSeparator2,
            this.tool_ajuda});
            this.ts_main.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.ts_main.Location = new System.Drawing.Point(0, 24);
            this.ts_main.Name = "ts_main";
            this.ts_main.Padding = new System.Windows.Forms.Padding(11);
            this.ts_main.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.ts_main.Size = new System.Drawing.Size(880, 45);
            this.ts_main.TabIndex = 3;
            this.ts_main.Tag = "Teste";
            this.ts_main.Text = "Barra de Ferramentas";
            // 
            // tool_home
            // 
            this.tool_home.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tool_home.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tool_home.Image = global::Integrador.Properties.Resources.house;
            this.tool_home.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_home.Name = "tool_home";
            this.tool_home.Size = new System.Drawing.Size(23, 20);
            this.tool_home.Text = "Início";
            this.tool_home.Click += new System.EventHandler(this.tool_home_Click);
            // 
            // tool_db
            // 
            this.tool_db.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tool_db.Image = global::Integrador.Properties.Resources.database;
            this.tool_db.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_db.Name = "tool_db";
            this.tool_db.Size = new System.Drawing.Size(23, 20);
            this.tool_db.Text = "Banco de Dados";
            this.tool_db.Click += new System.EventHandler(this.ts_db_Click);
            // 
            // tool_ftp
            // 
            this.tool_ftp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tool_ftp.Image = global::Integrador.Properties.Resources.connect;
            this.tool_ftp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_ftp.Name = "tool_ftp";
            this.tool_ftp.Size = new System.Drawing.Size(23, 20);
            this.tool_ftp.Text = "FTP";
            this.tool_ftp.Click += new System.EventHandler(this.ts_ftp_Click);
            // 
            // tool_ag
            // 
            this.tool_ag.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tool_ag.Image = global::Integrador.Properties.Resources.calendar;
            this.tool_ag.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_ag.Name = "tool_ag";
            this.tool_ag.Size = new System.Drawing.Size(23, 20);
            this.tool_ag.Text = "Agendamento";
            this.tool_ag.Click += new System.EventHandler(this.tool_ag_Click);
            // 
            // tool_file
            // 
            this.tool_file.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tool_file.Image = global::Integrador.Properties.Resources.folder;
            this.tool_file.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_file.Name = "tool_file";
            this.tool_file.Size = new System.Drawing.Size(23, 20);
            this.tool_file.Text = "Arquivos";
            this.tool_file.Click += new System.EventHandler(this.tool_file_Click);
            // 
            // tool_query
            // 
            this.tool_query.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tool_query.Image = global::Integrador.Properties.Resources.application_osx_terminal;
            this.tool_query.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_query.Name = "tool_query";
            this.tool_query.Size = new System.Drawing.Size(23, 20);
            this.tool_query.Text = "Query\'s";
            this.tool_query.Click += new System.EventHandler(this.tool_query_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 23);
            // 
            // tool_gerar_arquivos
            // 
            this.tool_gerar_arquivos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tool_gerar_arquivos.Image = global::Integrador.Properties.Resources.cog;
            this.tool_gerar_arquivos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_gerar_arquivos.Name = "tool_gerar_arquivos";
            this.tool_gerar_arquivos.Size = new System.Drawing.Size(23, 20);
            this.tool_gerar_arquivos.Text = "Gerar Arquivos";
            this.tool_gerar_arquivos.Click += new System.EventHandler(this.tool_gerar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 23);
            // 
            // tool_ajuda
            // 
            this.tool_ajuda.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tool_ajuda.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tool_ajuda.Image = global::Integrador.Properties.Resources.help;
            this.tool_ajuda.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_ajuda.Name = "tool_ajuda";
            this.tool_ajuda.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tool_ajuda.Size = new System.Drawing.Size(23, 20);
            this.tool_ajuda.Text = "Ajuda";
            this.tool_ajuda.Click += new System.EventHandler(this.tool_ajuda_Click);
            // 
            // ss_main
            // 
            this.ss_main.AutoSize = false;
            this.ss_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.img_tick,
            this.lb_progress,
            this.ts_user,
            this.ts_hora});
            this.ss_main.Location = new System.Drawing.Point(0, 427);
            this.ss_main.Name = "ss_main";
            this.ss_main.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ss_main.Size = new System.Drawing.Size(880, 30);
            this.ss_main.TabIndex = 1;
            this.ss_main.Text = "Status";
            // 
            // img_tick
            // 
            this.img_tick.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)(((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.img_tick.Image = global::Integrador.Properties.Resources.tick;
            this.img_tick.Name = "img_tick";
            this.img_tick.Padding = new System.Windows.Forms.Padding(5);
            this.img_tick.Size = new System.Drawing.Size(30, 25);
            this.img_tick.Visible = false;
            // 
            // lb_progress
            // 
            this.lb_progress.AutoSize = false;
            this.lb_progress.AutoToolTip = true;
            this.lb_progress.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)(((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.lb_progress.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.lb_progress.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.lb_progress.Name = "lb_progress";
            this.lb_progress.Size = new System.Drawing.Size(400, 25);
            this.lb_progress.Text = "Progresso";
            this.lb_progress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_progress.Visible = false;
            // 
            // ts_user
            // 
            this.ts_user.AutoSize = false;
            this.ts_user.AutoToolTip = true;
            this.ts_user.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)(((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.ts_user.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.ts_user.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ts_user.Name = "ts_user";
            this.ts_user.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.ts_user.Size = new System.Drawing.Size(200, 25);
            this.ts_user.ToolTipText = "Usuário";
            // 
            // ts_hora
            // 
            this.ts_hora.AutoSize = false;
            this.ts_hora.AutoToolTip = true;
            this.ts_hora.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.ts_hora.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.ts_hora.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ts_hora.Name = "ts_hora";
            this.ts_hora.Overflow = System.Windows.Forms.ToolStripItemOverflow.Always;
            this.ts_hora.Size = new System.Drawing.Size(100, 25);
            // 
            // pb_change
            // 
            this.pb_change.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_change.Image = ((System.Drawing.Image)(resources.GetObject("pb_change.Image")));
            this.pb_change.Location = new System.Drawing.Point(803, 30);
            this.pb_change.Name = "pb_change";
            this.pb_change.Size = new System.Drawing.Size(34, 34);
            this.pb_change.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_change.TabIndex = 7;
            this.pb_change.TabStop = false;
            this.pb_change.Click += new System.EventHandler(this.pb_change_Click);
            // 
            // pb_close
            // 
            this.pb_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_close.Image = ((System.Drawing.Image)(resources.GetObject("pb_close.Image")));
            this.pb_close.Location = new System.Drawing.Point(843, 30);
            this.pb_close.Name = "pb_close";
            this.pb_close.Size = new System.Drawing.Size(34, 34);
            this.pb_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_close.TabIndex = 5;
            this.pb_close.TabStop = false;
            this.pb_close.Click += new System.EventHandler(this.pb_cancel_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(880, 457);
            this.Controls.Add(this.pb_change);
            this.Controls.Add(this.pb_close);
            this.Controls.Add(this.ts_main);
            this.Controls.Add(this.ss_main);
            this.Controls.Add(this.ms_main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.ms_main;
            this.Name = "frm_main";
            this.Text = "TRACE - Integrador";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_main_Load);
            this.ms_main.ResumeLayout(false);
            this.ms_main.PerformLayout();
            this.ts_main.ResumeLayout(false);
            this.ts_main.PerformLayout();
            this.ss_main.ResumeLayout(false);
            this.ss_main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_change)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip ms_main;
        private System.Windows.Forms.ToolStripMenuItem menu_ts_sistema;
        private System.Windows.Forms.ToolStripMenuItem menu_ts_licenca;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menu_ts_sair;
        private System.Windows.Forms.ToolStripMenuItem menu_ts_config;
        private System.Windows.Forms.ToolStripMenuItem menu_ts_conn;
        private System.Windows.Forms.ToolStripMenuItem menu_ts_db;
        private System.Windows.Forms.ToolStripMenuItem menu_ts_ftp;
        private System.Windows.Forms.ToolStripMenuItem menu_ts_file;
        private System.Windows.Forms.ToolStripMenuItem menu_ts_env_rec;
        private System.Windows.Forms.ToolStripMenuItem menu_ts_trans;
        private System.Windows.Forms.ToolStripMenuItem menu_ts_ajuda;
        private System.Windows.Forms.ToolStripMenuItem menu_ts_sobre;
        private System.Windows.Forms.ToolStripMenuItem menu_ts_ag;
        private System.Windows.Forms.ToolStripMenuItem menu_ts_env;
        private System.Windows.Forms.ToolStripMenuItem menu_ts_rec;
        private System.Windows.Forms.ToolStripMenuItem menu_ts_janela;
        private System.Windows.Forms.ToolStrip ts_main;
        private System.Windows.Forms.ToolStripButton tool_db;
        private System.Windows.Forms.ToolStripButton tool_ftp;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tool_ajuda;
        private System.Windows.Forms.ToolStripButton tool_ag;
        private System.Windows.Forms.ToolStripButton tool_file;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.PictureBox pb_close;
        private System.Windows.Forms.ToolStripButton tool_home;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menu_ts_consultas;
        private System.Windows.Forms.ToolStripMenuItem menu_ts_vend;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        public System.Windows.Forms.StatusStrip ss_main;
        private System.Windows.Forms.ToolStripMenuItem gerar_site;
        private System.Windows.Forms.ToolStripMenuItem menu_ts_enviar;
        private System.Windows.Forms.ToolStripMenuItem menu_ts_receber;
        private System.Windows.Forms.ToolStripButton tool_gerar_arquivos;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem menu_ts_change_pass;
        private System.Windows.Forms.ToolStripMenuItem menu_ts_logout;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.PictureBox pb_change;
        private System.Windows.Forms.ToolStripMenuItem testesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dragAndDropToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerar_carga;
        public System.Windows.Forms.ToolStripStatusLabel img_tick;
        public System.Windows.Forms.ToolStripStatusLabel lb_progress;
        private System.Windows.Forms.ToolStripMenuItem menu_ts_enviar_site;
        private System.Windows.Forms.ToolStripMenuItem menu_ts_enviar_carga;
        private System.Windows.Forms.ToolStripMenuItem menu_ts_receber_pedidos;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem menu_ts_enviar_imagens;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ToolStripButton tool_query;
        private System.Windows.Forms.ToolStripStatusLabel ts_user;
        private System.Windows.Forms.ToolStripStatusLabel ts_hora;
    }
}

