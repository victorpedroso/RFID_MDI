using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using AForge.Video;
using AForge.Video.DirectShow;
using System.IO;


namespace RFID_MDI
{
    public partial class TirarFoto : Form
    {
        public TirarFoto()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
           
        }
        private void ExecutarFuncao()
        {
            MessageBox.Show("Executei a função");
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        static void CapturarFoto()
        {
            // Obter uma lista de dispositivos de câmera conectados
            FilterInfoCollection dispositivos = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            // Selecionar o primeiro dispositivo da lista
            VideoCaptureDevice camera = new VideoCaptureDevice(dispositivos[0].MonikerString);

            // Evento disparado quando um novo quadro de vídeo é recebido
            camera.NewFrame += new NewFrameEventHandler(CapturarQuadro);

            // Iniciar a captura de vídeo
            camera.Start();

            // Aguardar alguns segundos para que a câmera capture a imagem
            System.Threading.Thread.Sleep(1000);

            // Parar a captura de vídeo
            camera.Stop();
        }

        static void CapturarQuadro(object sender, NewFrameEventArgs eventArgs)
        {
            // Converter o quadro de vídeo em um objeto Bitmap
            Bitmap imagem = (Bitmap)eventArgs.Frame.Clone();

            // Salvar a imagem em uma pasta no C:\
            string caminhoDaPasta = @"C:\Imagens";
            if (!Directory.Exists(caminhoDaPasta))
            {
                Directory.CreateDirectory(caminhoDaPasta);
            }
            string dataAtual = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            string data = dataAtual.Replace(":", "-");
            string nomeArquivo = "arquivo_" + data + ".jpg";
            string caminhoDoArquivo = @"C:\Imagens\" + nomeArquivo;

            //string nomeArquivo = semChar + "webcam.jpg";
            //string caminhoDoArquivo = Path.Combine(caminhoDaPasta, nomeArquivo);
            imagem.Save(caminhoDoArquivo);

            // Parar a captura de vídeo após salvar a imagem
            VideoCaptureDevice camera = (VideoCaptureDevice)sender;
            //camera.Stop();

        }
    }
}

