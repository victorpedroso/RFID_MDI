using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.IO;
using System.IO.Ports;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RFID_MDI
{
    public partial class Principal : Form
    {
        private SerialPort serialPort;
        private StreamReader streamReader;
        ConexaoBD conexao = new ConexaoBD();
        public Principal()
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
            conectaSerial();
            //serialPort1.Open();
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
        private void conectaSerial()
        {
            serialPort = new SerialPort("COM3", 115200);
            serialPort.Open();
            streamReader = new StreamReader(serialPort.BaseStream);
            Task.Run(async () => await ReadSerialDataAsync());
        }
        private async Task ReadSerialDataAsync()
        {
            while (true)
            {
                // Aguarda a leitura de uma linha de texto da porta serial
                string data = await streamReader.ReadLineAsync();
                if (data == "1")
                {
                    MessageBox.Show(data);
                }
                else
                {

                    /*if (textBox1.InvokeRequired)
                    {
                        textBox1.Invoke(new Action(() =>
                        {
                            textBox1.AppendText(data + Environment.NewLine);
                        }));
                    }
                    else
                    {
                        textBox1.AppendText(data + Environment.NewLine);
                    }*/
                }
            }
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

        private void monitorSerialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new serial();
            frm.Show();

        }

        private void cadastrarNovoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            serialPort.Close();
            var frm = new CadastrarDispositivo();
            frm.Show();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            serialPort1.Write("1");
        }

        private void graficoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Grafico();
            frm.Show();
        }
    }
}
