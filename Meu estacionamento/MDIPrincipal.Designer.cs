namespace Meu_estacionamento
{
    partial class MDIPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDIPrincipal));
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.btnClientesAtalho = new System.Windows.Forms.ToolStripButton();
            this.btnEntradaSaidaAtalho = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnEstacionadosAtalho = new System.Windows.Forms.ToolStripButton();
            this.btnReceitaDiariaAtalho = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMovimentacoes = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.btnConfigurarPreco = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSobre = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.receitaDiáriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veículosEstacionadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnClientesAtalho,
            this.btnEntradaSaidaAtalho,
            this.toolStripSeparator1,
            this.btnEstacionadosAtalho,
            this.btnReceitaDiariaAtalho,
            this.toolStripSeparator2});
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(632, 25);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "ToolStrip";
            // 
            // btnClientesAtalho
            // 
            this.btnClientesAtalho.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnClientesAtalho.Image = ((System.Drawing.Image)(resources.GetObject("btnClientesAtalho.Image")));
            this.btnClientesAtalho.ImageTransparentColor = System.Drawing.Color.Black;
            this.btnClientesAtalho.Name = "btnClientesAtalho";
            this.btnClientesAtalho.Size = new System.Drawing.Size(23, 22);
            this.btnClientesAtalho.Text = "Clientes";
            this.btnClientesAtalho.Click += new System.EventHandler(this.openFormClientes);
            // 
            // btnEntradaSaidaAtalho
            // 
            this.btnEntradaSaidaAtalho.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEntradaSaidaAtalho.Image = ((System.Drawing.Image)(resources.GetObject("btnEntradaSaidaAtalho.Image")));
            this.btnEntradaSaidaAtalho.ImageTransparentColor = System.Drawing.Color.Black;
            this.btnEntradaSaidaAtalho.Name = "btnEntradaSaidaAtalho";
            this.btnEntradaSaidaAtalho.Size = new System.Drawing.Size(23, 22);
            this.btnEntradaSaidaAtalho.Text = "Entrada/Saída de Veículos";
            this.btnEntradaSaidaAtalho.Click += new System.EventHandler(this.openFormEntradaSaida);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnEstacionadosAtalho
            // 
            this.btnEstacionadosAtalho.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEstacionadosAtalho.Image = ((System.Drawing.Image)(resources.GetObject("btnEstacionadosAtalho.Image")));
            this.btnEstacionadosAtalho.ImageTransparentColor = System.Drawing.Color.Black;
            this.btnEstacionadosAtalho.Name = "btnEstacionadosAtalho";
            this.btnEstacionadosAtalho.Size = new System.Drawing.Size(23, 22);
            this.btnEstacionadosAtalho.Text = "Veículos Estacionados";
            this.btnEstacionadosAtalho.Click += new System.EventHandler(this.btnEstacionadosAtalho_Click);
            // 
            // btnReceitaDiariaAtalho
            // 
            this.btnReceitaDiariaAtalho.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnReceitaDiariaAtalho.Image = ((System.Drawing.Image)(resources.GetObject("btnReceitaDiariaAtalho.Image")));
            this.btnReceitaDiariaAtalho.ImageTransparentColor = System.Drawing.Color.Black;
            this.btnReceitaDiariaAtalho.Name = "btnReceitaDiariaAtalho";
            this.btnReceitaDiariaAtalho.Size = new System.Drawing.Size(23, 22);
            this.btnReceitaDiariaAtalho.Text = "Receita Diária";
            this.btnReceitaDiariaAtalho.Click += new System.EventHandler(this.btnReceitaDiariaAtalho_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 431);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(632, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnClientes,
            this.btnMovimentacoes,
            this.toolStripSeparator3,
            this.exitToolStripMenuItem});
            this.fileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(71, 20);
            this.fileMenu.Text = "&Cadastros";
            // 
            // btnClientes
            // 
            this.btnClientes.Image = ((System.Drawing.Image)(resources.GetObject("btnClientes.Image")));
            this.btnClientes.ImageTransparentColor = System.Drawing.Color.Black;
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.btnClientes.Size = new System.Drawing.Size(264, 22);
            this.btnClientes.Text = "&Clientes";
            this.btnClientes.Click += new System.EventHandler(this.openFormClientes);
            // 
            // btnMovimentacoes
            // 
            this.btnMovimentacoes.Image = ((System.Drawing.Image)(resources.GetObject("btnMovimentacoes.Image")));
            this.btnMovimentacoes.ImageTransparentColor = System.Drawing.Color.Black;
            this.btnMovimentacoes.Name = "btnMovimentacoes";
            this.btnMovimentacoes.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.btnMovimentacoes.Size = new System.Drawing.Size(264, 22);
            this.btnMovimentacoes.Text = "&Movimentações de Véiculos";
            this.btnMovimentacoes.Click += new System.EventHandler(this.openFormEntradaSaida);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(261, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(264, 22);
            this.exitToolStripMenuItem.Text = "Sai&r";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolsStripMenuItem_Click);
            // 
            // toolsMenu
            // 
            this.toolsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnConfigurarPreco});
            this.toolsMenu.Name = "toolsMenu";
            this.toolsMenu.Size = new System.Drawing.Size(96, 20);
            this.toolsMenu.Text = "&Configurações";
            // 
            // btnConfigurarPreco
            // 
            this.btnConfigurarPreco.Name = "btnConfigurarPreco";
            this.btnConfigurarPreco.Size = new System.Drawing.Size(180, 22);
            this.btnConfigurarPreco.Text = "Configurar preço";
            this.btnConfigurarPreco.Click += new System.EventHandler(this.btnConfigurarPreco_Click);
            // 
            // helpMenu
            // 
            this.helpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSobre});
            this.helpMenu.Name = "helpMenu";
            this.helpMenu.Size = new System.Drawing.Size(50, 20);
            this.helpMenu.Text = "&Ajuda";
            // 
            // btnSobre
            // 
            this.btnSobre.Name = "btnSobre";
            this.btnSobre.Size = new System.Drawing.Size(180, 22);
            this.btnSobre.Text = "&Sobre ...";
            this.btnSobre.Click += new System.EventHandler(this.btnSobre_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.relatóriosToolStripMenuItem,
            this.toolsMenu,
            this.helpMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(632, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.receitaDiáriaToolStripMenuItem,
            this.veículosEstacionadosToolStripMenuItem});
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // receitaDiáriaToolStripMenuItem
            // 
            this.receitaDiáriaToolStripMenuItem.Name = "receitaDiáriaToolStripMenuItem";
            this.receitaDiáriaToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.receitaDiáriaToolStripMenuItem.Text = "Receita Diária";
            this.receitaDiáriaToolStripMenuItem.Click += new System.EventHandler(this.btnReceitaDiariaAtalho_Click);
            // 
            // veículosEstacionadosToolStripMenuItem
            // 
            this.veículosEstacionadosToolStripMenuItem.Name = "veículosEstacionadosToolStripMenuItem";
            this.veículosEstacionadosToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.veículosEstacionadosToolStripMenuItem.Text = "Veículos Estacionados";
            this.veículosEstacionadosToolStripMenuItem.Click += new System.EventHandler(this.btnEstacionadosAtalho_Click);
            // 
            // MDIPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MDIPrincipal";
            this.Text = "Meu Estacionamento - William Cleisson de Carvalho";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MDIPrincipal_Load);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripButton btnClientesAtalho;
        private System.Windows.Forms.ToolStripButton btnEntradaSaidaAtalho;
        private System.Windows.Forms.ToolStripButton btnReceitaDiariaAtalho;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem btnClientes;
        private System.Windows.Forms.ToolStripMenuItem btnMovimentacoes;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsMenu;
        private System.Windows.Forms.ToolStripMenuItem helpMenu;
        private System.Windows.Forms.ToolStripMenuItem btnSobre;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem btnConfigurarPreco;
        private System.Windows.Forms.ToolStripButton btnEstacionadosAtalho;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem receitaDiáriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem veículosEstacionadosToolStripMenuItem;
    }
}



