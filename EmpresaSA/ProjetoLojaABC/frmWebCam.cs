using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;

namespace ProjetoLojaABC
{
    public partial class frmWebCam : Form
    {
        private bool DeviceExist = false;
        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSource = null;

        public frmWebCam()
        {
            InitializeComponent();
        }

       private void video_NewFrame(Object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap img = (Bitmap)eventArgs.Frame.Clone();
            pctCapturarImagem.Image = img;
        }

        private void frmWebCam_Load(object sender, EventArgs e)
        {
            try
            {
                videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                cbbDispositivo.Items.Clear();
                if (videoDevices.Count == 0)
                    throw new ApplicationException();

                DeviceExist = true;
                foreach(FilterInfo device in videoDevices)
                {
                    cbbDispositivo.Items.Add(device.Name);
                }
                cbbDispositivo.SelectedIndex = 0;
            }
            catch (ApplicationException)
            {
                DeviceExist = false;
                cbbDispositivo.Items.Add("Nenhum Dispositivo encontrado!");
            }
        }

        private void btnCapturar_Click(object sender, EventArgs e)
        {
            if (btnCapturar.Text == "Capturar")
            {
                if (DeviceExist)
                {
                    videoSource = new VideoCaptureDevice(videoDevices[cbbDispositivo.SelectedIndex].MonikerString);
                    videoSource.NewFrame += new NewFrameEventHandler(video_NewFrame);

                    // Encerra o sinal da câmera.
                    if (!(videoSource == null))
                        if (videoSource.IsRunning)
                        {
                            videoSource.SignalToStop();
                            videoSource = null;
                        }
                    videoSource.DesiredFrameSize = new Size(1920, 1080);
                    videoSource.DesiredFrameRate = 10;
                    videoSource.Start();

                    btnCapturar.Text = "Gravar";
                }
                else
                {
                    MessageBox.Show("Nenhum dispositivo encontrado!");
                }
            }
            else
            {
                if (videoSource.IsRunning)
                {
                    //Encerra o sinal da câmera.
                    // Note que este bloco de código se repetiu, você pode criar um método para ele.
                    if (!(videoSource == null))
                        if (videoSource.IsRunning)
                        {
                            videoSource.SignalToStop();
                            videoSource = null;

                            // Salva a imagem.
                            sfdSalvarImagem.Filter = "JPEG (*.jpg;*.jpeg;*jpeg;*.jfif)|*.jpg;*.jpeg;*jpeg;*jfif";
                            DialogResult res = sfdSalvarImagem.ShowDialog();
                            if (res == DialogResult.OK)
                            {
                                pctCapturarImagem.Image.Save(sfdSalvarImagem.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                            }
                        }
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            pctCapturarImagem.Image = null;
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog BuscarIMG = new OpenFileDialog();
            BuscarIMG.InitialDirectory = ("C:\\Users\\rodrigo.pfigueiredo1\\Pictures");
            BuscarIMG.FileName = "Imagem";
            BuscarIMG.Title = "Procurar Imagem";
            BuscarIMG.Filter = ("*jpg|*.jpg|*jfif|*.jfif|*png|*.png|*bmp|*.bmp|*tif|*.tif|Todos os Aqruivos|*");
            BuscarIMG.ShowDialog();
            pctCapturarImagem.ImageLocation = (BuscarIMG.FileName);
        }
    }
}
