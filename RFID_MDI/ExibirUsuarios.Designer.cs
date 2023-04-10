namespace RFID_MDI
{
    partial class ExibirUsuarios
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnEditarUsuario = new System.Windows.Forms.Button();
            this.btnApagarUsuario = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(766, 365);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnEditarUsuario
            // 
            this.btnEditarUsuario.Location = new System.Drawing.Point(129, 395);
            this.btnEditarUsuario.Name = "btnEditarUsuario";
            this.btnEditarUsuario.Size = new System.Drawing.Size(198, 43);
            this.btnEditarUsuario.TabIndex = 1;
            this.btnEditarUsuario.Text = "Editar usuário";
            this.btnEditarUsuario.UseVisualStyleBackColor = true;
            this.btnEditarUsuario.Click += new System.EventHandler(this.btnEditarUsuario_Click);
            // 
            // btnApagarUsuario
            // 
            this.btnApagarUsuario.Location = new System.Drawing.Point(432, 395);
            this.btnApagarUsuario.Name = "btnApagarUsuario";
            this.btnApagarUsuario.Size = new System.Drawing.Size(198, 43);
            this.btnApagarUsuario.TabIndex = 2;
            this.btnApagarUsuario.Text = "Apagar usuário";
            this.btnApagarUsuario.UseVisualStyleBackColor = true;
            this.btnApagarUsuario.Click += new System.EventHandler(this.btnApagarUsuario_Click);
            // 
            // ExibirUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnApagarUsuario);
            this.Controls.Add(this.btnEditarUsuario);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ExibirUsuarios";
            this.Text = "Exibir Usuarios";
            this.Load += new System.EventHandler(this.ExibirUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnEditarUsuario;
        private System.Windows.Forms.Button btnApagarUsuario;
    }
}