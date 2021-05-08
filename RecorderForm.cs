using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace _09_Sound_interaction
{
    public partial class RecorderForm : Form
    {
        MainForm mother = null;
        WaveFileWriter recWaveWriter = null;

        public RecorderForm(MainForm m)
        {
            InitializeComponent();
            mother = m;
        }

        private void record_Click(object sender, EventArgs e)
        {
            mother.DisposeAudioOutput();
            int deviceIndex = mother.audioDeviceSelected;
            if (deviceIndex == 0) { errorMessage.Text = "no oudio device selected,\nselect one in the settings"; return; }
            mother.mainWaveIn = new WaveIn
            {
                DeviceNumber = deviceIndex,
                WaveFormat = new WaveFormat(44100, WaveIn.GetCapabilities(deviceIndex).Channels)
            };
            mother.mainWaveIn.DataAvailable += new EventHandler<WaveInEventArgs>(mainWaveIn_DataAvailable);
            recWaveWriter = new WaveFileWriter(mother.temp, mother.mainWaveIn.WaveFormat);
            mother.mainWaveIn.StartRecording();

            stop.Enabled = true;
            record.Enabled = false;
        }
        private void mainWaveIn_DataAvailable(object sender, WaveInEventArgs e)
        {
            if (recWaveWriter == null) return;
            recWaveWriter.Write(e.Buffer, 0, e.BytesRecorded);
            recWaveWriter.Flush();
        }

        private void stop_Click(object sender, EventArgs e)
        {
            if (recWaveWriter == null) { MessageBox.Show("recording wosn`t running"); return; }
            recWaveWriter.Dispose();
            recWaveWriter = null;
            mother.PrepareToPlayTempedAudio();
            mother.label1.Text = "Recorded Audio";
            plot.Visible = true;
            save.Visible = true;
            newRecord.Visible = true;
        }

        private void plot_Click(object sender, EventArgs e)
        {
            var m = new PlotForm(mother.temp);
            try { m.Show(); }
            catch { }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newRecord_Click(object sender, EventArgs e)
        {
            
        }

        private void save_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = ".wav (*.wav)|*.wav;";
            if (save.ShowDialog() != DialogResult.OK) return;
            File.Copy(mother.temp, save.FileName);
        }
    }
}
