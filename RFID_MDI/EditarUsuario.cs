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
    public partial class EditarUsuario : Form
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
            txtNome.Text = tabelaUsuarios.Rows[0]["Nome"].ToString();
            txtCpf.Text = tabelaUsuarios.Rows[0]["Cpf"].ToString();
            txtTelefone.Text = tabelaUsuarios.Rows[0]["Telefone"].ToString();
            txtEndereco.Text = tabelaUsuarios.Rows[0]["Endereco"].ToString();
            txtTag.Text = tabelaUsuarios.Rows[0]["Tag_id"].ToString();
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
            MySqlCommand comando = new MySqlCommand("UPDATE associado SET Nome=@Nome, Cpf=@Cpf, Telefone=@Telefone, Endereco=@Endereco WHERE ID=@ID", conn);
            MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
            comando.Parameters.AddWithValue("@Nome", txtNome.Text);
            comando.Parameters.AddWithValue("@Cpf", txtCpf.Text);
            comando.Parameters.AddWithValue("@Telefone", txtTelefone.Text);
            comando.Parameters.AddWithValue("@Endereco", txtEndereco.Text);
            comando.Parameters.AddWithValue("@ID", idUsuario);
            DataSet ds = new DataSet();
            adaptador.Fill(ds);
            MessageBox.Show("Usuário atualizado com sucesso.");
            conexao.Desconectar();
            this.Close();
        }
    }
}
