using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace RFID_MDI
{
    public partial class CadastrarUsuario : Form
    {
        ConexaoBD conexao = new ConexaoBD();
        public CadastrarUsuario()
        {
            InitializeComponent();
        }   

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = conexao.Conectar();
            try
            {
                string data = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                string sql = "insert into associado (Nome, Cpf, Telefone, Endereco, DataCadastro, Tag_id  ) values ('" + txtNome.Text + "', '" + txtCpf.Text + "', '" + txtTelefone.Text + "', '" + txtEndereco.Text + "', '" + data + "','" + txtCpf.Text + "')";
                MySqlCommand comando = new MySqlCommand(sql, conn);
                MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                DataSet ds = new DataSet();
                adaptador.Fill(ds);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conexao.Desconectar();
            MessageBox.Show("Usuário criado com sucesso");
            Close();
        }

        private void CadastrarUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
