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
using System.Windows.Forms.DataVisualization.Charting;

namespace RFID_MDI
{
    public partial class Grafico: Form
    {
        MySqlConnection Conexao;
        public Grafico()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
        int count;
        private void GerarGrafico()
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string data_source = "Server=localhost;Database=sistemacontroleacesso;Uid=root;Pwd=;";

            //criar conexão com MYSQL
            Conexao = new MySqlConnection(data_source);
            try
            {

                //Executar comando select
                string sql = "SELECT * FROM datasdeacesso WHERE Data = @Data";
                MySqlCommand comando = new MySqlCommand(sql, Conexao);


                Conexao.Open();
                count = Convert.ToInt32(comando.ExecuteScalar());

                GerarGrafico();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
