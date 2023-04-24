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
    public partial class ExibirUsuarios : Form
    {
        ConexaoBD conexao = new ConexaoBD();
        public ExibirUsuarios()
        {
            InitializeComponent();
        }

        private void ExibirUsuarios_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = conexao.Conectar();
            MySqlDataAdapter adaptador = new MySqlDataAdapter("SELECT * FROM associado", conn);
            DataTable tabelaUsuarios = new DataTable();
            adaptador.Fill(tabelaUsuarios);
            dataGridView1.DataSource = tabelaUsuarios;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.Columns[dataGridView1.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            conexao.Desconectar();
        }

        private void btnEditarUsuario_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                int idUsuario = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);
                EditarUsuario formEditar = new EditarUsuario(idUsuario);
                formEditar.ShowDialog();
                MySqlConnection conn = conexao.Conectar();
                MySqlDataAdapter adaptador = new MySqlDataAdapter("SELECT * FROM associado", conn);
                DataTable tabelaUsuarios = new DataTable();
                adaptador.Fill(tabelaUsuarios);
                dataGridView1.DataSource = tabelaUsuarios;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridView1.Columns[dataGridView1.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                conexao.Desconectar();
            }
            else
            {
                MessageBox.Show("Selecione um usuário para editar.");
            }
        }

        private void btnApagarUsuario_Click(object sender, EventArgs e)
        {
            int idUsuario = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);
            MySqlConnection conn = conexao.Conectar();
            DialogResult resultado = MessageBox.Show("Tem certeza que deseja apagar o usuário selecionado?", "Apagar Usuário", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                MySqlCommand comando = new MySqlCommand("DELETE FROM associado WHERE Id=@Id", conn);
                MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                comando.Parameters.AddWithValue("@ID", idUsuario);
                DataSet ds = new DataSet();
                adaptador.Fill(ds);
                MessageBox.Show("Usuário apagado com sucesso.");
                adaptador = new MySqlDataAdapter("SELECT * FROM associado", conn);
                DataTable tabelaUsuarios = new DataTable();
                adaptador.Fill(tabelaUsuarios);
                dataGridView1.DataSource = tabelaUsuarios;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridView1.Columns[dataGridView1.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                conexao.Desconectar();
            }
            else
            {
                MessageBox.Show("Selecione um usuário para apagar.");
            }
            
        }
    }
}
