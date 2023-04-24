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
using System.Windows.Forms.DataVisualization.Charting;
using MySql.Data.MySqlClient;

namespace RFID_MDI
{
    public partial class ConexãoSerial : Form
    {
        MySqlConnection Conexao;
        public ConexãoSerial()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lbBoundRate_Click(object sender, EventArgs e)
        {

        }

        private void lbConexao_Click(object sender, EventArgs e)
        {

        }

        private void btSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
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


        int count;
        private void btnGrafico_Click(object sender, EventArgs e)
        {
            Buscar();
            //GerarGrafico();
        }

        private void txtGrafico_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {
        }

        /*private void GerarGrafico()
        {
            Title title = new Title();
            title.Font = new Font("Ariel", 14, FontStyle.Bold);
            title.ForeColor = Color.Black;
            title.Text = "CONROLE DE ACESSO";
            chart1.Titles.Add(title);


            chart1.Series.Add("Acessos");
            chart1.Series["Acessos"].LegendText = "Acessos";

            chart1.Series["Acessos"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            chart1.Series["Acessos"].BorderWidth = 4;

            chart1.Series["Acessos"].Points.AddXY("Numero de acessos", count);
        }*/

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                string data_source = "datasource=localhost;username=root;password=;database=rfid";

                //criar conexão com MYSQL
                Conexao = new MySqlConnection(data_source);


                //Executar comando select
                string sql = "SELECT Nome, DataAcesso, Tag_id FROM tb_pessoas";
                MySqlCommand comando = new MySqlCommand(sql, Conexao);


                Conexao.Open();
                count = Convert.ToInt32(comando.ExecuteScalar());



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string data_source = "datasource=localhost;username=root;password=;database=rfid";

                //criar conexão com MYSQL
                Conexao = new MySqlConnection(data_source);


                //Executar comando insert
                string sql = "insert into tb_pessoas (Nome, Cpf, Telefone, Endereço, DataCadastro, Tag_id ) values ('" + txtNome.Text + "', '" + txtNome.Text + "', '" + txtNome.Text + "', '" + txtNome.Text + "', '" + txtNome.Text + "','" + txtNome.Text + "')";
                MySqlCommand comando = new MySqlCommand(sql, Conexao);



                Conexao.Open();
                comando.ExecuteReader();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Buscar()
        {
            try
            {
                string data_source = "datasource=localhost;username=root;password=;database=rfid";

                //criar conexão com MYSQL
                Conexao = new MySqlConnection(data_source);


                //Executar comando select
                string sql = "SELECT COUNT(id) FROM tb_pessoas";
                MySqlCommand comando = new MySqlCommand(sql, Conexao);


                Conexao.Open();
                count = Convert.ToInt32(comando.ExecuteScalar());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void serialPort1_DataReceived_1(object sender, SerialDataReceivedEventArgs e)
        {

                BeginInvoke((MethodInvoker)(() => { txtDadosRecebidos.Text += serialPort1.ReadExisting(); Buscar(); })); ;
        }

        private void btDesconecta_Click_1(object sender, EventArgs e)
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

        private void btSair_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}

