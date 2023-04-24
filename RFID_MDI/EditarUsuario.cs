using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RFID_MDI
{
    public partial class EditarUsuario : MetroFramework.Forms.MetroForm
    {
        ConexaoBD conexao = new ConexaoBD();
        int idUsuario;
        public EditarUsuario(int id)
        {
            InitializeComponent();
            idUsuario = id;
            MySqlConnection conn = conexao.Conectar();
            MySqlCommand comando = new MySqlCommand("SELECT * FROM associado WHERE Id=@Id", conn);
            comando.Parameters.AddWithValue("@Id", idUsuario);
            MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
            DataTable tabelaUsuarios = new DataTable();
            adaptador.Fill(tabelaUsuarios);
            comando = new MySqlCommand("SELECT * FROM dispositivos WHERE IdAssociado=@IdA", conn);
            comando.Parameters.AddWithValue("@IdA", idUsuario);
            adaptador = new MySqlDataAdapter(comando);
            DataTable tabelaUsuarios2 = new DataTable();
            adaptador.Fill(tabelaUsuarios2);
            txtNome.Text = tabelaUsuarios.Rows[0]["Nome"].ToString();
            txtCpf.Text = tabelaUsuarios.Rows[0]["Cpf"].ToString();
            txtTelefone.Text = tabelaUsuarios.Rows[0]["Telefone"].ToString();
            txtEndereco.Text = tabelaUsuarios.Rows[0]["Endereco"].ToString();
            int tag = tabelaUsuarios2.Rows.Count;
            if(tag > 0)
            {
                txtTag.Text = tabelaUsuarios2.Rows[0]["NumeroTag"].ToString();
            }
            else
            {
                txtTag.Visible = false;
                label5.Visible = false;
            }
            conexao.Desconectar();
        }

        private void EditarUsuario_Load(object sender, EventArgs e)
        {

        }
        public delegate void FormClosedEventHandler(object sender, EventArgs e);

        public event FormClosedEventHandler FormClosedEvent;

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);

            FormClosedEvent?.Invoke(this, e);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = conexao.Conectar();
            MySqlCommand comando = new MySqlCommand("UPDATE associado JOIN dispositivos ON associado.Id = dispositivos.IdAssociado SET associado.Nome=@Nome, associado.Cpf=@Cpf, associado.Telefone=@Telefone, associado.Endereco=@Endereco, dispositivos.NumeroTag=@NumeroTag WHERE associado.Id = @Id;", conn);
            MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
            comando.Parameters.AddWithValue("@Nome", txtNome.Text);
            comando.Parameters.AddWithValue("@Cpf", txtCpf.Text);
            comando.Parameters.AddWithValue("@Telefone", txtTelefone.Text);
            comando.Parameters.AddWithValue("@Endereco", txtEndereco.Text);
            comando.Parameters.AddWithValue("@NumeroTag", txtTag.Text);
            comando.Parameters.AddWithValue("@Id", idUsuario);
            DataSet ds = new DataSet();
            adaptador.Fill(ds);
            MessageBox.Show("Usuário atualizado com sucesso.");
            conexao.Desconectar();
            this.Close();
        }
    }
}
