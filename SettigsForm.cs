using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace _09_Sound_interaction
{
    public partial class SettigsForm : Form
    {
        MainForm mother = null;

        public SettigsForm(MainForm m)
        {
            InitializeComponent();
            mother = m;
            refreshDebug_Click();            
        }

        private void SettigsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            mother.DisposeAudioOutput();
            this.Hide();
        }

        private void testoutput_Click(object sender, EventArgs e)
        {
            mother.Testtone();
        }

        private void loopback_Click(object sender, EventArgs e)
        {
            if (sourceList.SelectedItems.Count == 0) return;

            int deviceIndex = sourceList.SelectedItems[0].Index;

            mother.mainWaveIn = new WaveIn
            {
                DeviceNumber = deviceIndex,
                WaveFormat = new WaveFormat(44100, WaveIn.GetCapabilities(deviceIndex).Channels)
            };

            WaveInProvider waveIn = new WaveInProvider(mother.mainWaveIn);

            mother.mainDirectSoundOut = new DirectSoundOut();
            mother.mainDirectSoundOut.Init(waveIn);

            mother.mainWaveIn.StartRecording();
            mother.mainDirectSoundOut.Play();
        }

        private void refresh_Click(object sender=null, EventArgs e=null)
        {
            List<WaveInCapabilities> sources = new List<WaveInCapabilities>();

            for (int i = 0; i < WaveIn.DeviceCount; i++)
            {
                sources.Add(WaveIn.GetCapabilities(i));
            }

            sourceList.Items.Clear();
            foreach (var i in sources)
            {
                ListViewItem item = new ListViewItem(i.ProductName);
                item.SubItems.Add(new ListViewItem.ListViewSubItem(item, i.Channels.ToString()));
                sourceList.Items.Add(item);
            }

            var freq = mother.frequency;
            freqTextBox.Text = freq.ToString();
            var amp = mother.amplitude*100;
            amplitude.Text = amp.ToString();
        }

        private void stopLoopback_Click(object sender, EventArgs e)
        {
            mother.DisposeAudioOutput(); 
        }

        private void select_Click(object sender, EventArgs e)
        {
            if (sourceList.SelectedItems.Count == 0) return;

            mother.audioDeviceSelected = sourceList.SelectedItems[0].Index;
        }

        public void refreshDebug_Click(object sender=null, EventArgs e=null)
        {
            label1.Text = "temp file:  " + mother.temp;
            label2.Text = "selected device: " + mother.audioDeviceSelected;
            if (File.ReadAllBytes(mother.temp).Length > 0)
                using (var afr = new AudioFileReader(mother.temp))
                    label3.Text = "selected file duration: " + afr.TotalTime;
            else label3.Text = "selected file duration: no input";



            label5.Text=new FileInfo(mother.temp).Length.ToString();
        }

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            var sen = (sender as TextBox);

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && (sen.Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
                testoutput.Select();
                freqTextBox_Leave(sen,e);
            }
        }

        private void freqTextBox_Leave(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDecimal(freqTextBox.Text) > 20000)
                    freqTextBox.Text = 20000.ToString();
                if (Convert.ToDecimal(freqTextBox.Text) <= 0 || freqTextBox.Text == "")
                    (sender as TextBox).Undo();
            }
            catch { MessageBox.Show("NaN"); (sender as TextBox).Undo(); };

            try
            {
                mother.frequency = Convert.ToDouble(freqTextBox.Text);
            }
            catch { MessageBox.Show("not convertable input"); }
            refresh_Click();

        }


        private void volume_VolumeChanged(object sender, EventArgs e)
        {
            mother.amplitude = volume.Volume;
        }

    }
}
