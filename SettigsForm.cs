using NAudio.Wave;
using System;
using System.Collections.Generic;
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
            DebugFillIn();            
        }

        public void DebugFillIn()
        {
            label1.Text = "temp file:  " + mother.temp;
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
    }
}
