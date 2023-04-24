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
using System.IO.Ports;

namespace RFID_MDI
{
    public partial class CadastrarDispositivo : MetroFramework.Forms.MetroForm
    {
        ConexaoBD conexao = new ConexaoBD();
        private string tag;
        public CadastrarDispositivo()
        {
            InitializeComponent();
            //this.serialPort = serialPort;
        }
        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            // Lê os dados recebidos na porta serial
            //string dados = serialPort1.ReadExisting();

            // Atualiza a caixa de texto com os dados recebidos
            
        }

        private void Cadastrar_Dispositivo_Load(object sender, EventArgs e)
        {
            serialPort1.Open();
            serialPort1.Write("1");
            MessageBox.Show("Aproxime a tag do sensor...");
            tag = serialPort1.ReadLine();
            MessageBox.Show(tag);
            cmbDispositivos.SelectedIndex = 0;
            //serialPort.Close();
            //serialPort2.Open();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string cpf = txtCpf.Text;
            int dispostivo = cmbDispositivos.SelectedIndex;
            string tipo = "";
            if(dispostivo == 0)
            {
                tipo = "tag";
            }
            else
            {
                tipo = "cartao";
            }
            MySqlConnection conn = conexao.Conectar();
            try
            {
                Random rnd = new Random();
                string numeros = rnd.Next(1000, 9999).ToString();
                string letras = Guid.NewGuid().ToString("N").Substring(0, 2);
                string resultado = numeros + "x" + letras;
                MySqlCommand comando = new MySqlCommand("SELECT * FROM associado WHERE Cpf = @Cpf", conn);
                comando.Parameters.AddWithValue("@Cpf", cpf);
                MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                DataTable tabelaUsuarios = new DataTable();
                adaptador.Fill(tabelaUsuarios);
                if (serialPort1.IsOpen)
                {
                    serialPort1.Write("1");
                    string dados = serialPort1.ReadExisting();
                    MessageBox.Show(dados);
                    // Envia os dados digitados na caixa de texto
                    serialPort1.Write(resultado);
                }
                if (DialogResult.Yes == MessageBox.Show("Deseja cadastrar?", "Usuário já possui dispositivo cadastrado", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                {
                    int id = (int)tabelaUsuarios.Rows[0]["Id"];
                    comando = new MySqlCommand("INSERT INTO dispositivos (IdAssociado, NumeroTag, tipo) VALUES (@Id, @Numero, @tipo)", conn);
                    comando.Parameters.AddWithValue("@Id", id);
                    comando.Parameters.AddWithValue("@Numero", resultado);
                    comando.Parameters.AddWithValue("@tipo", tipo);
                    adaptador = new MySqlDataAdapter(comando);
                    DataTable tabelaUsuarios2 = new DataTable();
                    adaptador.Fill(tabelaUsuarios2);
                    conexao.Desconectar();
                    //MessageBox.Show("Dispositivo cadastrado com sucesso");
                    //Close();
                }
                else
                {
                    Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //SELECT associado.Nome, associado.Cpf, dispositivos.NumeroTag FROM associado JOIN dispositivos ON associado.Id = 7;

        }

        private void Cadastrar_Dispositivo_FormClosed(object sender, FormClosedEventArgs e)
        {
            serialPort1.Close();
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            this.Invoke(new EventHandler(recebeDados));

        }
        private void recebeDados(object o, EventArgs e)
        {
            string data = serialPort1.ReadLine().Replace("\r", "");
            MessageBox.Show(data);
        }

        private void Cadastrar_Dispositivo_FormClosing(object sender, FormClosingEventArgs e)
        {
            serialPort1.Close();
        }
    }
}
