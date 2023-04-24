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
    public partial class SelecionarUsuario : MetroFramework.Forms.MetroForm
    {
        MySqlConnection Conexao = new MySqlConnection("Server=localhost;Database=sistemacontroleacesso;Uid=root;Pwd=;");
        public SelecionarUsuario()
        {
            InitializeComponent();
        }

        private void SelecionarUsuario_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string cpf = txtCpf.Text;
            MySqlCommand comando = new MySqlCommand("SELECT * FROM associado WHERE Cpf=@Cpf", Conexao);
            comando.Parameters.AddWithValue("@Cpf", cpf);
            MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
            DataTable tabelaUsuario = new DataTable();
            adaptador.Fill(tabelaUsuario);
            String id = tabelaUsuario.Rows[0]["Id"].ToString();
            int idInt = Int32.Parse(id);
            EditarUsuario formEditar = new EditarUsuario(idInt);
            formEditar.ShowDialog();

        }
    }
}
