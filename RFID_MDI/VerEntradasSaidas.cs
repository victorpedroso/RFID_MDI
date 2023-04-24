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
    public partial class VerEntradasSaidas : MetroFramework.Forms.MetroForm
    {
        ConexaoBD conexao = new ConexaoBD();
        public VerEntradasSaidas()
        {
            InitializeComponent();
        }

        private void VerEntradasSaidas_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = conexao.Conectar();
            MySqlCommand comando = new MySqlCommand("SELECT DataHorario, Nome FROM datasdeacesso", conn);
            MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
            DataSet ds = new DataSet();
            DataTable tabelaUsuarios = new DataTable();
            adaptador.Fill(tabelaUsuarios);
            dataGridView1.DataSource = tabelaUsuarios;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.Columns[dataGridView1.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            conexao.Desconectar();
        }
    }
}
