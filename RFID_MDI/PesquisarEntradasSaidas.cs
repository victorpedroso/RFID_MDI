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
    public partial class PesquisarEntradasSaidas : Form
    {
        ConexaoBD conexao = new ConexaoBD();
        DataTable tabelaAcesso = new DataTable();
        public PesquisarEntradasSaidas()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            MonthCalendar calendario = this.Controls["calendario"] as MonthCalendar;
            DateTime dataSelecionada = calendario.SelectionStart;
            string dataHorario = dataSelecionada.ToString();
            string[] arrayData = dataHorario.Split(' ');
            string data = arrayData[0];
            txtData.Text = data;
            MySqlConnection conn = conexao.Conectar();
            MySqlCommand comando = new MySqlCommand("SELECT * FROM datasdeacesso WHERE Data=@Data", conn);
            comando.Parameters.AddWithValue("@Data", data);
            MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
            DataTable tabelaData = new DataTable();
            adaptador.Fill(tabelaData);
            dataGridView1.DataSource = tabelaData;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.Columns[dataGridView1.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void PesquisarEntradasSaidas_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = conexao.Conectar();
            MySqlDataAdapter adaptador = new MySqlDataAdapter("SELECT * FROM datasdeacesso", conn);
            adaptador.Fill(tabelaAcesso);
            dataGridView1.DataSource = tabelaAcesso;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.Columns[dataGridView1.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            conexao.Desconectar();
        }
    }
}
