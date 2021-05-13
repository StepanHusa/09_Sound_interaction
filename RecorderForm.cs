using NAudio.CoreAudioApi;
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
        private MainForm mother = null;
        private WaveFileWriter recWaveWriter = null;

        public RecorderForm(MainForm m)
        {
            InitializeComponent();
            mother = m;
        }

        private void mainWaveIn_DataAvailable(object sender, WaveInEventArgs e)
        {
            if (recWaveWriter == null) return;
            recWaveWriter.Write(e.Buffer, 0, e.BytesRecorded);
            recWaveWriter.Flush();

            float max = 0;
            var buffer = new WaveBuffer(e.Buffer);
            // interpret as 32 bit floating point audio
            for (int index = 0; index < e.BytesRecorded / 4; index++)
            {
                var sample = buffer.FloatBuffer[index];

                // absolute value 
                if (sample < 0) sample = -sample;
                // is this the max value?
                if (sample > max) max = sample;
            }
            volumeSliderMeter.Volume =max;

        }

        private void record_Click(object sender, EventArgs e)
        {
            mother.DisposeAudioOutput();
            int deviceIndex = mother.audioDeviceSelected;
            if (deviceIndex == -1) { errorMessage.Text = "no oudio device selected,\nselect one in the settings"; return; }
            mother.mainWaveIn = new WaveIn
            {
                DeviceNumber = deviceIndex,
                WaveFormat = new WaveFormat(44100, WaveIn.GetCapabilities(deviceIndex).Channels)
            };
            mother.mainWaveIn.DataAvailable += new EventHandler<WaveInEventArgs>(mainWaveIn_DataAvailable);
            recWaveWriter = new WaveFileWriter(mother.temp, mother.mainWaveIn.WaveFormat);
            mother.mainWaveIn.StartRecording();

            mother.errormessage.Text = "recording";

            stop.Enabled = true;
            record.Enabled = false;
            volumeSliderMeter.Visible = true;
        }

        private void stop_Click(object sender, EventArgs e)
        {
            if (recWaveWriter == null) { MessageBox.Show("recording didn`t start"); return; }
            recWaveWriter.Dispose();
            recWaveWriter = null;
            mother.PrepareToPlayTempedAudio();
            mother.label1.Text = "Recorded Audio";
            plot.Visible = true;
            save.Visible = true;
            newRecord.Visible = true;
            stop.Enabled = false;
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
            this.Controls.Clear();
            this.InitializeComponent();

        }

        private void save_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = ".wav (*.wav)|*.wav;";
            if (save.ShowDialog() != DialogResult.OK) return;
            File.Copy(mother.temp, save.FileName);
        }

        private void RecorderForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(recWaveWriter!=null)
                stop_Click(sender, e);
        }

    }
}
