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
using System.IO.Ports;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RFID_MDI
{
    public partial class Principal : MetroFramework.Forms.MetroForm
    {
        private SerialPort conexaoEsp;
        private StreamReader streamReader;
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
            frm.MdiParent = this;
            frm.Show();
        }

        private void editarUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new SelecionarUsuario();
            frm.MdiParent = this;
            frm.Show();
        }

        private void tirarFotoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new TirarFoto();
            frm.MdiParent = this;
            frm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                conexaoSerial();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro " + ex.Message);
            }
        }
        private void conexaoSerial()
        {
            conexaoEsp = new SerialPort("COM3", 9600);
            conexaoEsp.Open();
            streamReader = new StreamReader(conexaoEsp.BaseStream);
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

                    if (txtSerial.InvokeRequired)
                    {
                        txtSerial.Invoke(new Action(() =>
                        {
                            txtSerial.AppendText(data + Environment.NewLine);
                        }));
                    }
                    else
                    {
                        txtSerial.AppendText(data + Environment.NewLine);
                    }
                }
            }
        }

        private void exibirUsuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new ExibirUsuarios();
            frm.MdiParent = this;
            frm.Show();
        }

        private void pesquisarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new PesquisarEntradasSaidas();
            frm.MdiParent = this;
            frm.Show(); 
        }

        private void verTodasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new VerEntradasSaidas();
            frm.MdiParent = this;
            frm.Show();
        }

        private void conexãoSerialToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            conexaoEsp.Write("0");
        }

        private void cadastrarNovoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastrarDispositivo cad = new CadastrarDispositivo();
            conexaoEsp.Close();
            cad.ShowDialog();
            if (!conexaoEsp.IsOpen)
            {
                conexaoEsp.Open();
            }

        }

        private void tirarFotoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TirarFotoEntrada tirarFoto = new TirarFotoEntrada();
            tirarFoto.CapturarFoto();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            //if (!conexaoEsp.IsOpen)
            //{
            //    conexaoEsp.Open();
            //}
        }

        private void conexaoEsp_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            this.Invoke(new EventHandler(recebeDados));
        }
        private void recebeDados(object o, EventArgs e)
        {
            string data = conexaoEsp.ReadLine().Replace("\r", "");
            MessageBox.Show(data);
            if (data.Length == 8)
            {
            }
            else
            {
                //o cadastro da tag será em nova tela
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            conexaoEsp.Close();
        }
    }
}
