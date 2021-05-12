using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.Util;
using Emgu.CV.UI;
using System.Drawing.Imaging;

namespace Proiect
{
    public partial class Form1 : Form
    {
     

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_incarca_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image File(*.jpg;*.jpeg;*.bmp;)|*.jpg;*jpeg;*.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = open.FileName;
                pictureBox1.Image = Image.FromFile(open.FileName);
                
            }
        }


        private void btn_salveaza_Click(object sender, EventArgs e)
        {
            File.Copy(textBox1.Text, Path.Combine(@"D:\pni\Proiect\Save Images", Path.GetFileName(textBox1.Text)), true);
            label2.Text = "Image saved";

        }

        private void btn_hist_Click(object sender, EventArgs e)
        {

            try
            {
                if (pictureBox1.Image == null)
                {
                    return;
                }

                var img = new Bitmap(pictureBox1.Image)
                       .ToImage<Gray, byte>();

                Mat hist = new Mat();
                float[] ranges = new float[] { 0, 255 };
                int[] channel = { 0 };
                int[] histSize = { 256 };

                VectorOfMat ms = new VectorOfMat();
                ms.Push(img);

                CvInvoke.CalcHist(ms, channel, null, hist, histSize, ranges, false);

                HistogramViewer viewer = new HistogramViewer();
                viewer.Text = "Image Histogram";
                viewer.ShowIcon = false;
                viewer.HistogramCtrl.GenerateHistogram("Image Histogram", Color.Blue, hist,
                    histSize[0], ranges);
                viewer.HistogramCtrl.Refresh();
                viewer.Show();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
