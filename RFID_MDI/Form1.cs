using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RFID_MDI
{
    public partial class Form1 : Form
    {
        ConexaoBD conexao = new ConexaoBD();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void cadastrarUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new CadastrarUsuario();
            frm.Show();
        }

        private void editarUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new SelecionarUsuario();
            frm.Show();
        }

        private void tirarFotoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new TirarFoto();
            frm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = conexao.Conectar();
            MySqlCommand comando = new MySqlCommand("SELECT DataHorario, Nome FROM datasdeacesso", conn);
            MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
            DataSet ds = new DataSet();
            DataTable tabelaUsuarios = new DataTable();
            adaptador.Fill(tabelaUsuarios);
            //dataGridView1.DataSource = tabelaUsuarios;
            //dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            //dataGridView1.Columns[dataGridView1.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            conexao.Desconectar(); 
        }

        private void exibirUsuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new ExibirUsuarios();
            frm.Show();
        }

        private void pesquisarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new PesquisarEntradasSaidas();
            frm.Show(); 
        }

        private void verTodasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new VerEntradasSaidas();
            frm.Show();
        }

        private void conexãoSerialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //var frm = new ConexãoSerial();
            //frm.Show();
        }

        private void monitorSerialToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
