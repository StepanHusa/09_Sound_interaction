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
        public PlotForm(string temp)
        {
            InitializeComponent();
            if (temp == null) Return();
            var m = new FileInfo(temp);
            if (!m.Exists) Return();
            if (m.Length < 1000) Return();
        }

        private void Return()
        {
            MessageBox.Show("invalid file to plot");
            this.Close();
        }
    }
}
