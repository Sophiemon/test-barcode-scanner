using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using ZXing.Common;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing.QrCode;

namespace test_barcode_scanner
{
    public partial class BarcodeScanner : Form
    {
        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSource;
        private BarcodeReader barcodeReader;
        private Bitmap currentFrame;

        public BarcodeScannerForm()
        {
            InitializeComponent();
        }


        private void BarcodeScannerForm_Load(object sender, EventArgs e)
        {
            // Inicializar el lector de códigos de barras
            barcodeReader = new BarcodeReader();

            // Obtener las cámaras disponibles
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            if (videoDevices.Count == 0)
            {
                MessageBox.Show("No se encontraron cámaras disponibles.");
                return;
            }

            // Agregar las cámaras al ComboBox
            foreach (FilterInfo device in videoDevices)
            {
                cboCamera.Items.Add(device.Name);
            }

            // Seleccionar la primera cámara por defecto
            cboCamera.SelectedIndex = 0;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // Detener la captura de video actual si está en progreso
            if (videoSource != null && videoSource.IsRunning)
            {
                videoSource.SignalToStop();
                videoSource.WaitForStop();
                videoSource = null;
            }

            // Seleccionar la cámara elegida en el ComboBox
            int selectedIndex = cboCamera.SelectedIndex;
            if (selectedIndex >= 0 && selectedIndex < videoDevices.Count)
            {
                // Inicializar la cámara seleccionada
                videoSource = new VideoCaptureDevice(videoDevices[selectedIndex].MonikerString);
                videoSource.NewFrame += new NewFrameEventHandler(videoSource_NewFrame);
                videoSource.Start();
            }
        }

        private void videoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            // Actualizar el PictureBox con el nuevo fotograma de la cámara
            currentFrame = (Bitmap)eventArgs.Frame.Clone();
            pictureBox.Image = currentFrame;
        }

        private void BarcodeScannerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Detener la captura de video y liberar los recursos al cerrar el formulario
            if (videoSource != null && videoSource.IsRunning)
            {
                videoSource.SignalToStop();
                videoSource.WaitForStop();
                videoSource = null;
            }
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            // Escanear el código de barras en el fotograma actual
            if (currentFrame != null)
            {
                Result result = barcodeReader.Decode(currentFrame);

                if (result != null)
                {
                    // Mostrar el código de barras en el TextBox
                    txtBarcode.Text = result.Text;
                }
                else
                {
                    MessageBox.Show("No se pudo leer el código de barras.");
                }
            }
        }

    }
}
