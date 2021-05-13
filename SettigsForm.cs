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
            volume.Volume =mother.amplitude;
            var a = mother.threshold;
            threshold.Text = a.ToString();
            var b = mother.timeDivide;
            timeDivide.Text = b.ToString();


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
                enter.Select();
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

        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem == toneSettingToolStripMenuItem)  return;

            groupDebug.Visible = false;
            groupInput.Visible = false;
            groupGenerator.Visible = false;
            groupRead.Visible = false;


            if (e.ClickedItem == reading) groupRead.Visible = true;

            if (e.ClickedItem == generating) groupGenerator.Visible = true;

            if (e.ClickedItem == debugToolStripMenuItem) groupDebug.Visible = true;

            if (e.ClickedItem == inputDevicesToolStripMenuItem) groupInput.Visible = true;

        }

        private void format_KeyPress(object sender, KeyPressEventArgs e)
        {
            var sen = (sender as TextBox);

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
                enter.Select();
                format_Leave(sen, e);
            }
        }

        private void format_Leave(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt16(bitDepth.Text) > 32)
                    bitDepth.Text = 32.ToString();
                if (Convert.ToInt16(bitDepth.Text) < 0)
                    (sender as TextBox).Undo();
                var a = new WaveFormat(Convert.ToInt32(sampleRate.Text), Convert.ToInt16(bitDepth.Text)/2, 1);
                mother.mainWaveFormat = a;
            }
            catch { MessageBox.Show("invalid format"); (sender as TextBox).Undo(); };

            

        }

        private void boxInRead_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)13)
            {
                enter2.Select();
                boxInRead_Leave(sender, e);
            }
        }

        private void boxInRead_Leave(object sender, EventArgs e)
        {
            if (Convert.ToInt16(timeDivide.Text) <= 0 || timeDivide.Text == "")
                (sender as TextBox).Undo();
            if (Convert.ToDecimal(threshold.Text) < 0 || threshold.Text == ""|| Convert.ToDecimal(threshold.Text)>1)
                (sender as TextBox).Undo();

            mother.threshold = (float)Convert.ToDecimal(threshold.Text);
            mother.timeDivide = Convert.ToInt16(timeDivide.Text);

        }

        private void enter2_Click(object sender, EventArgs e)
        {
            boxInRead_Leave(sender, e);
        }

        private void threshold_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
                enter2.Select();
                boxInRead_Leave(sender, e);
            }
        }
    }
}
