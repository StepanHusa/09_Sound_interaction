using NAudio.Wave;
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

namespace _09_Sound_interaction
{
    public partial class PlotForm : Form
    {
        private string glTemp = null;
        public PlotForm(string temp)
        {
            InitializeComponent();
            glTemp = temp;
            if (glTemp == null) { Return(); return; }
            else Plot();
        }

        private void Return()
        {
            MessageBox.Show("invalid file to plot");
            this.Close();
        }

        private void Plot()
        {
            

            var m = new FileInfo(glTemp);
            if (!m.Exists) { Return(); return; }
            if (m.Length < 10) { Return(); return; }

            waveViewer1.Size = pictureBox1.Size;
            var wfr = new WaveFileReader(glTemp);
            int w = waveViewer1.Size.Width;
            waveViewer1.SamplesPerPixel = (int)Math.Ceiling(Convert.ToDouble(wfr.SampleCount) / w);
            waveViewer1.WaveStream = wfr;

            var bmp = new Bitmap(waveViewer1.Size.Width, waveViewer1.Size.Height);
            Rectangle r = new Rectangle(pictureBox1.Location, pictureBox1.Size);
            waveViewer1.DrawToBitmap(bmp, r);
            pictureBox1.Image = bmp;

            waveViewer1.WaveStream = null;
            wfr.Dispose();
        }


        private void PlotForm_ResizeEnd(object sender, EventArgs e)
        {
            if (glTemp == null) return;
            var m = new FileInfo(glTemp);
            if (!m.Exists) return;
            if (m.Length < 10) return;
            Plot();
        }
    }
}
