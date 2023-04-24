using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFID_MDI
{
    public class TirarFotoEntrada
    {
        public void CapturarFoto()
        {
            FilterInfoCollection dispositivos = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            VideoCaptureDevice camera = new VideoCaptureDevice(dispositivos[0].MonikerString);
            camera.NewFrame += new NewFrameEventHandler(CapturarQuadro);
            camera.Start();
            System.Threading.Thread.Sleep(1000);
            camera.Stop();
        }
        public void CapturarQuadro(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap imagem = (Bitmap)eventArgs.Frame.Clone();
            string caminhoDaPasta = @"C:\Imagens";
            if (!Directory.Exists(caminhoDaPasta))
            {
                Directory.CreateDirectory(caminhoDaPasta);
            }
            string dataAtual = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            string data = dataAtual.Replace(":", "-");
            string nomeArquivo = "arquivo_" + data + ".jpg";
            string caminhoDoArquivo = @"C:\Imagens\" + nomeArquivo;
            imagem.Save(caminhoDoArquivo);
            VideoCaptureDevice camera = (VideoCaptureDevice)sender;
        }
    }
    
}
