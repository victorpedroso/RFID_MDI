namespace RFID_MDI
{
    partial class ConexãoSerial
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
            this.tbMenus = new System.Windows.Forms.TabControl();
            this.tabMonitor = new System.Windows.Forms.TabPage();
            this.txtDadosRecebidos = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.lbMensagem = new System.Windows.Forms.Label();
            this.btSair = new System.Windows.Forms.Button();
            this.btDesconecta = new System.Windows.Forms.Button();
            this.btConecta = new System.Windows.Forms.Button();
            this.cbBoundRate = new System.Windows.Forms.ComboBox();
            this.cbPortaCom = new System.Windows.Forms.ComboBox();
            this.lbBoundRate = new System.Windows.Forms.Label();
            this.lbPortaCom = new System.Windows.Forms.Label();
            this.gbConfigura = new System.Windows.Forms.GroupBox();
            this.serialPort2 = new System.IO.Ports.SerialPort(this.components);
            this.tbMenus.SuspendLayout();
            this.tabMonitor.SuspendLayout();
            this.gbConfigura.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbMenus
            // 
            this.tbMenus.Controls.Add(this.tabMonitor);
            this.tbMenus.Location = new System.Drawing.Point(501, 32);
            this.tbMenus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbMenus.Name = "tbMenus";
            this.tbMenus.SelectedIndex = 0;
            this.tbMenus.Size = new System.Drawing.Size(483, 457);
            this.tbMenus.TabIndex = 5;
            // 
            // tabMonitor
            // 
            this.tabMonitor.Controls.Add(this.txtDadosRecebidos);
            this.tabMonitor.Location = new System.Drawing.Point(4, 29);
            this.tabMonitor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabMonitor.Name = "tabMonitor";
            this.tabMonitor.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabMonitor.Size = new System.Drawing.Size(475, 424);
            this.tabMonitor.TabIndex = 0;
            this.tabMonitor.Text = "MONITOR SERIAL";
            this.tabMonitor.UseVisualStyleBackColor = true;
            // 
            // txtDadosRecebidos
            // 
            this.txtDadosRecebidos.Location = new System.Drawing.Point(9, 9);
            this.txtDadosRecebidos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDadosRecebidos.Multiline = true;
            this.txtDadosRecebidos.Name = "txtDadosRecebidos";
            this.txtDadosRecebidos.Size = new System.Drawing.Size(458, 415);
            this.txtDadosRecebidos.TabIndex = 3;
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 115200;
            this.serialPort1.PortName = "COM3";
            this.serialPort1.ReadBufferSize = 115200;
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived_1);
            // 
            // lbMensagem
            // 
            this.lbMensagem.AutoSize = true;
            this.lbMensagem.ForeColor = System.Drawing.Color.Green;
            this.lbMensagem.Location = new System.Drawing.Point(4, 374);
            this.lbMensagem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMensagem.Name = "lbMensagem";
            this.lbMensagem.Size = new System.Drawing.Size(456, 29);
            this.lbMensagem.TabIndex = 7;
            this.lbMensagem.Text = "PORTA ABERTA PARA COMUNICAÇÃO";
            // 
            // btSair
            // 
            this.btSair.Location = new System.Drawing.Point(28, 296);
            this.btSair.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(417, 48);
            this.btSair.TabIndex = 6;
            this.btSair.Text = "SAIR";
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click_1);
            // 
            // btDesconecta
            // 
            this.btDesconecta.Location = new System.Drawing.Point(28, 238);
            this.btDesconecta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btDesconecta.Name = "btDesconecta";
            this.btDesconecta.Size = new System.Drawing.Size(417, 48);
            this.btDesconecta.TabIndex = 5;
            this.btDesconecta.Text = "DESCONECTAR";
            this.btDesconecta.UseVisualStyleBackColor = true;
            this.btDesconecta.Click += new System.EventHandler(this.btDesconecta_Click_1);
            // 
            // btConecta
            // 
            this.btConecta.Location = new System.Drawing.Point(28, 180);
            this.btConecta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btConecta.Name = "btConecta";
            this.btConecta.Size = new System.Drawing.Size(417, 48);
            this.btConecta.TabIndex = 4;
            this.btConecta.Text = "CONECTAR";
            this.btConecta.UseVisualStyleBackColor = true;
            this.btConecta.Click += new System.EventHandler(this.btConecta_Click);
            // 
            // cbBoundRate
            // 
            this.cbBoundRate.FormattingEnabled = true;
            this.cbBoundRate.Items.AddRange(new object[] {
            "9600"});
            this.cbBoundRate.Location = new System.Drawing.Point(231, 102);
            this.cbBoundRate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbBoundRate.Name = "cbBoundRate";
            this.cbBoundRate.Size = new System.Drawing.Size(193, 37);
            this.cbBoundRate.TabIndex = 3;
            this.cbBoundRate.Text = "9600";
            // 
            // cbPortaCom
            // 
            this.cbPortaCom.FormattingEnabled = true;
            this.cbPortaCom.Location = new System.Drawing.Point(231, 51);
            this.cbPortaCom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbPortaCom.Name = "cbPortaCom";
            this.cbPortaCom.Size = new System.Drawing.Size(193, 37);
            this.cbPortaCom.TabIndex = 2;
            // 
            // lbBoundRate
            // 
            this.lbBoundRate.AutoSize = true;
            this.lbBoundRate.Location = new System.Drawing.Point(39, 106);
            this.lbBoundRate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbBoundRate.Name = "lbBoundRate";
            this.lbBoundRate.Size = new System.Drawing.Size(176, 29);
            this.lbBoundRate.TabIndex = 1;
            this.lbBoundRate.Text = "BOUND RATE:";
            // 
            // lbPortaCom
            // 
            this.lbPortaCom.AutoSize = true;
            this.lbPortaCom.Location = new System.Drawing.Point(57, 63);
            this.lbPortaCom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPortaCom.Name = "lbPortaCom";
            this.lbPortaCom.Size = new System.Drawing.Size(163, 29);
            this.lbPortaCom.TabIndex = 0;
            this.lbPortaCom.Text = "PORTA COM:";
            // 
            // gbConfigura
            // 
            this.gbConfigura.BackColor = System.Drawing.Color.DarkGray;
            this.gbConfigura.Controls.Add(this.lbMensagem);
            this.gbConfigura.Controls.Add(this.btSair);
            this.gbConfigura.Controls.Add(this.btDesconecta);
            this.gbConfigura.Controls.Add(this.btConecta);
            this.gbConfigura.Controls.Add(this.cbBoundRate);
            this.gbConfigura.Controls.Add(this.cbPortaCom);
            this.gbConfigura.Controls.Add(this.lbBoundRate);
            this.gbConfigura.Controls.Add(this.lbPortaCom);
            this.gbConfigura.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbConfigura.Location = new System.Drawing.Point(13, 14);
            this.gbConfigura.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbConfigura.Name = "gbConfigura";
            this.gbConfigura.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbConfigura.Size = new System.Drawing.Size(480, 475);
            this.gbConfigura.TabIndex = 4;
            this.gbConfigura.TabStop = false;
            this.gbConfigura.Text = "CONEXÃO";
            // 
            // ConexãoSerial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 511);
            this.Controls.Add(this.tbMenus);
            this.Controls.Add(this.gbConfigura);
            this.Name = "ConexãoSerial";
            this.Text = "A";
            this.tbMenus.ResumeLayout(false);
            this.tabMonitor.ResumeLayout(false);
            this.tabMonitor.PerformLayout();
            this.gbConfigura.ResumeLayout(false);
            this.gbConfigura.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tbMenus;
        private System.Windows.Forms.TabPage tabMonitor;
        private System.Windows.Forms.TextBox txtDadosRecebidos;
        public System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label lbMensagem;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Button btDesconecta;
        private System.Windows.Forms.Button btConecta;
        private System.Windows.Forms.ComboBox cbBoundRate;
        private System.Windows.Forms.ComboBox cbPortaCom;
        private System.Windows.Forms.Label lbBoundRate;
        private System.Windows.Forms.Label lbPortaCom;
        private System.Windows.Forms.GroupBox gbConfigura;
        private System.IO.Ports.SerialPort serialPort2;
    }
}