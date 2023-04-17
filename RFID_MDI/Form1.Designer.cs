using System.ComponentModel;

namespace RFID_MDI
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarUsuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarUsuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exibirUsuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tirarFotoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entradassaídasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pesquisarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verTodasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dispositivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarNovoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comunicaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monitorSerialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuarioToolStripMenuItem,
            this.entradassaídasToolStripMenuItem,
            this.dispositivosToolStripMenuItem,
            this.comunicaçãoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(783, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarUsuárioToolStripMenuItem,
            this.editarUsuárioToolStripMenuItem,
            this.exibirUsuáriosToolStripMenuItem,
            this.tirarFotoToolStripMenuItem});
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(59, 22);
            this.usuarioToolStripMenuItem.Text = "Usuário";
            // 
            // cadastrarUsuárioToolStripMenuItem
            // 
            this.cadastrarUsuárioToolStripMenuItem.Name = "cadastrarUsuárioToolStripMenuItem";
            this.cadastrarUsuárioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cadastrarUsuárioToolStripMenuItem.Text = "Cadastrar usuário";
            this.cadastrarUsuárioToolStripMenuItem.Click += new System.EventHandler(this.cadastrarUsuárioToolStripMenuItem_Click);
            // 
            // editarUsuárioToolStripMenuItem
            // 
            this.editarUsuárioToolStripMenuItem.Name = "editarUsuárioToolStripMenuItem";
            this.editarUsuárioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editarUsuárioToolStripMenuItem.Text = "Editar Usuário";
            this.editarUsuárioToolStripMenuItem.Click += new System.EventHandler(this.editarUsuárioToolStripMenuItem_Click);
            // 
            // exibirUsuáriosToolStripMenuItem
            // 
            this.exibirUsuáriosToolStripMenuItem.Name = "exibirUsuáriosToolStripMenuItem";
            this.exibirUsuáriosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exibirUsuáriosToolStripMenuItem.Text = "Exibir usuários";
            this.exibirUsuáriosToolStripMenuItem.Click += new System.EventHandler(this.exibirUsuáriosToolStripMenuItem_Click);
            // 
            // tirarFotoToolStripMenuItem
            // 
            this.tirarFotoToolStripMenuItem.Name = "tirarFotoToolStripMenuItem";
            this.tirarFotoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tirarFotoToolStripMenuItem.Text = "Tirar foto";
            this.tirarFotoToolStripMenuItem.Click += new System.EventHandler(this.tirarFotoToolStripMenuItem_Click);
            // 
            // entradassaídasToolStripMenuItem
            // 
            this.entradassaídasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pesquisarToolStripMenuItem,
            this.verTodasToolStripMenuItem});
            this.entradassaídasToolStripMenuItem.Name = "entradassaídasToolStripMenuItem";
            this.entradassaídasToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.entradassaídasToolStripMenuItem.Text = "Entradas/saídas";
            // 
            // pesquisarToolStripMenuItem
            // 
            this.pesquisarToolStripMenuItem.Name = "pesquisarToolStripMenuItem";
            this.pesquisarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pesquisarToolStripMenuItem.Text = "Pesquisar";
            this.pesquisarToolStripMenuItem.Click += new System.EventHandler(this.pesquisarToolStripMenuItem_Click);
            // 
            // verTodasToolStripMenuItem
            // 
            this.verTodasToolStripMenuItem.Name = "verTodasToolStripMenuItem";
            this.verTodasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.verTodasToolStripMenuItem.Text = "Ver todas";
            this.verTodasToolStripMenuItem.Click += new System.EventHandler(this.verTodasToolStripMenuItem_Click);
            // 
            // dispositivosToolStripMenuItem
            // 
            this.dispositivosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarNovoToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.excluirToolStripMenuItem});
            this.dispositivosToolStripMenuItem.Name = "dispositivosToolStripMenuItem";
            this.dispositivosToolStripMenuItem.Size = new System.Drawing.Size(82, 22);
            this.dispositivosToolStripMenuItem.Text = "Dispositivos";
            // 
            // cadastrarNovoToolStripMenuItem
            // 
            this.cadastrarNovoToolStripMenuItem.Name = "cadastrarNovoToolStripMenuItem";
            this.cadastrarNovoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cadastrarNovoToolStripMenuItem.Text = "Cadastrar";
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editarToolStripMenuItem.Text = "Editar";
            // 
            // excluirToolStripMenuItem
            // 
            this.excluirToolStripMenuItem.Name = "excluirToolStripMenuItem";
            this.excluirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.excluirToolStripMenuItem.Text = "Excluir";
            // 
            // comunicaçãoToolStripMenuItem
            // 
            this.comunicaçãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.monitorSerialToolStripMenuItem});
            this.comunicaçãoToolStripMenuItem.Name = "comunicaçãoToolStripMenuItem";
            this.comunicaçãoToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.comunicaçãoToolStripMenuItem.Text = "Comunicação";
            // 
            // monitorSerialToolStripMenuItem
            // 
            this.monitorSerialToolStripMenuItem.Name = "monitorSerialToolStripMenuItem";
            this.monitorSerialToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.monitorSerialToolStripMenuItem.Text = "Monitor serial";
            this.monitorSerialToolStripMenuItem.Click += new System.EventHandler(this.monitorSerialToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(559, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 67);
            this.button1.TabIndex = 4;
            this.button1.Text = "Liberar acesso";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(783, 399);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Sistema de Controle de Acesso";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarUsuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarUsuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tirarFotoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entradassaídasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pesquisarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verTodasToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem dispositivosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarNovoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exibirUsuáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comunicaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monitorSerialToolStripMenuItem;
        //private ISupportInitialize dataGridView1;
    }
}

