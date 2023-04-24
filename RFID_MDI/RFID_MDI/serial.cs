using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RFID_MDI
{
    public partial class serial : Form
    {
        MySqlConnection Conexao;

        public MySqlCommand MySqlCommand { get; private set; }

        public serial()
        {
            InitializeComponent();
        }

        private void gbConfigura_Enter(object sender, EventArgs e)
        {

        }

        private void btConecta_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen) serialPort1.Close();
                else
                {
                    serialPort1.PortName = cbPortaCom.Text;
                    serialPort1.BaudRate = Int16.Parse(cbBoundRate.Text);
                }

                serialPort1.Open();
                btConecta.Enabled = false;
                btSair.Enabled = false;
                btDesconecta.Enabled = true;
                cbPortaCom.Enabled = false;
                cbBoundRate.Enabled = false;
                lbMensagem.Text = "PORTA FECHADA PARA COMUNICAÇÃO";
                lbMensagem.ForeColor = Color.Red;

            }
            catch
            {
                MessageBox.Show("ERRO AO SE CONECTAR");
                btConecta.Enabled = true;
                btSair.Enabled = true;
                btDesconecta.Enabled = false;
                cbPortaCom.Enabled = true;
                cbBoundRate.Enabled = true;
            }
        }

        private void btDesconecta_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Close();
                btConecta.Enabled = true;
                btSair.Enabled = true;
                btDesconecta.Enabled = false;
                cbPortaCom.Enabled = true;
                cbBoundRate.Enabled = true;
                lbMensagem.Text = "PORTA ABERTA PARA COMUNICAÇÃO";
                lbMensagem.ForeColor = Color.Green;
            }
            catch
            {

                btConecta.Enabled = false;
                btSair.Enabled = false;
                btDesconecta.Enabled = true;
                cbPortaCom.Enabled = false;
                cbBoundRate.Enabled = false;
            }
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void serial_Load(object sender, EventArgs e)
        {
            PortaCom();
        }

        private void PortaCom()
        {
            cbPortaCom.Items.Clear();
            foreach (string Portas in SerialPort.GetPortNames())
            {
                cbPortaCom.Items.Add(Portas);
            }
            cbPortaCom.SelectedIndex = 0;
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            BeginInvoke((MethodInvoker)(() => { txtDadosRecebidos.Text += serialPort1.ReadExisting(); })); ;
            string dadosRecebidos = serialPort1.ReadExisting();

            string data_source = "Server=localhost;Database=sistemacontroleacesso;Uid=root;Pwd=;";

            //criar conexão com MYSQL
            Conexao = new MySqlConnection(data_source);
            try
            {

                    string sql = "SELECT" + dadosRecebidos + "FROM minhaTabela";
                    MySqlCommand comando = new MySqlCommand(sql, Conexao);
                    Conexao.Open();
       
                    MySqlDataReader reader = comando.ExecuteReader();

                if (reader.HasRows)
                    {
                        //serialPort1.Write("liberar");
                    }

                    reader.Close();
                    Conexao.Close();
            }
            catch
            {
                MessageBox.Show("Usuario não cadastrado");
                Conexao.Close();

            }
        }
    }
}
