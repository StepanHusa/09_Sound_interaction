using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace _09_Sound_interaction
{
    public partial class MainForm : Form
    {
        SettigsForm f = null;
        //initialization
        public MainForm()
        {
            InitializeComponent();
            SetTemp();
            if (f != null)
                f.Dispose();               
            f = new SettigsForm(this);
            
        }
        //temp directory
        public string temp = null;
        //Audio device
        public int audioDeviceSelected=0;

        //audio streem declaration
        public WaveIn mainWaveIn = null;
        public BlockAlignReductionStream mainBARStream = null;
        public DirectSoundOut mainDirectSoundOut = null;


        //audio actions
        public void PlayPause()
        {
            if (mainDirectSoundOut != null)
            {
                if (mainDirectSoundOut.PlaybackState == PlaybackState.Playing) mainDirectSoundOut.Pause();
                else if (mainDirectSoundOut.PlaybackState == PlaybackState.Paused | mainDirectSoundOut.PlaybackState == PlaybackState.Stopped) mainDirectSoundOut.Play();
            }
            else errormessage.Text = "no playing sound";
        }
        public void DisposeAudioOutput()
        {
            if (mainDirectSoundOut != null)
            {
                if(mainDirectSoundOut.PlaybackState == PlaybackState.Playing) mainDirectSoundOut.Stop();
                mainDirectSoundOut.Dispose();
                mainDirectSoundOut = null;
            }
            if (mainBARStream != null)
            {
                mainBARStream.Dispose();
                mainBARStream = null;
            }
            if (mainWaveIn != null)
            {
                mainWaveIn.StopRecording();
                mainWaveIn.Dispose();
                mainWaveIn = null;
            }
            SetTemp();
            label1.Text = "";
            errormessage.Text = "The audio was disposed succesfully";
        }

        public void SetTemp()
        {
            if (temp != null)
                if (File.Exists(temp))
                    File.Delete(temp);
            temp = Path.GetTempFileName();
        }
        public void DeleteTemp()
        {
            if(temp!=null)
                if(File.Exists(temp))
                    File.Delete(temp);
        }

        //form clocing
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DisposeAudioOutput();
            DeleteTemp();
            f.Close();
        }

        public void PrepareToPlayTempedAudio()
        {
            mainDirectSoundOut = new DirectSoundOut();
            mainBARStream = new BlockAlignReductionStream(new WaveChannel32(new WaveFileReader(temp)));
            mainDirectSoundOut.Init(mainBARStream);
            play.Enabled = true;
        }

        //click actions
        private void run_Click(object sender, EventArgs e)
        {
            int choice = 0;
            if (inputlattin.Text != "")
                if (inputmorse.Text == "" & label1.Text == "")
                {
                    choice = 1;
                    outputmorse.Text = inputlattin.Text.ToMorse();
                }
                else choice = -1;
            if (inputmorse.Text != "")
                if (inputlattin.Text == "" & label1.Text == "")
                {
                    choice = 2;
                    outputlattin.Text = inputmorse.Text.ToLattin();
                }
                else choice = -1;
            if (label1.Text != "")
                if (inputlattin.Text == "" & inputmorse.Text == "")
                    choice = 3;
                else choice = -1;
            if (choice == 0) {
                errormessage.Text = "no input";
                return;
            }
            if (choice == -1) {
                errormessage.Text = "more than one input (try clearing textboxes or restart the app)";
                return;
            }

            else groupoutput.Visible = true;

            float[] a = null;
            if (choice == 3)
            {
                a = Buffer(temp);
                errormessage.Text = a.ToString();
                Console.WriteLine(a.Max());
            }
        }
        private void openaudiofile_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog {Filter = "audio file (*.wav;*.mp3)|*.wav;*.mp3;*.txt", Title = "Open Audio File"};
            if (open.ShowDialog() != DialogResult.OK) return;
            var openinfo = new FileInfo(open.FileName);

            DisposeAudioOutput();


            if (open.FileName.EndsWith(".mp3"))
            {
                ToNewTempWavFile(open.FileName);//creates .tmp file with characteristics of wave
            }//convert mp3 to wav and store in temp
            else if (open.FileName.EndsWith(".wav"))
            {
                if (!File.Exists(temp)) SetTemp();
                File.Copy(open.FileName, temp); 
            }            
            else {MessageBox.Show("Not a correct file type"); return; }

            PrepareToPlayTempedAudio();

            label1.Text = openinfo.Name;
        }
        private void play_Click(object sender, EventArgs e)
        {
            PlayPause();
        }
        private void openlattintxt_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "txt file (*.txt)|*.txt";
            if (open.ShowDialog() != DialogResult.OK) return;

            
            inputlattin.Text = File.ReadAllText(open.FileName);
        }
        private void openmorsetxt_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "txt file (*.txt)|*.txt";
            if (open.ShowDialog() != DialogResult.OK) return;

            inputmorse.Text = File.ReadAllText(open.FileName);
        }
        private void restart_Click(object sender, EventArgs e)
        {
        }
        private void record_Click(object sender, EventArgs e)
        {
            var r = new RecorderForm(this);
            r.Show();
        }
        private void clr_Click(object sender, EventArgs e)
        {
            inputlattin.Clear();
            inputmorse.Clear();
            outputlattin.Clear();
            outputlattin.Clear();
        }
        private void hideOutput_Click(object sender, EventArgs e)
        {
            outputlattin.Clear();
            outputlattin.Clear();
            groupoutput.Hide();
        }
        private void savelattintxt_Click(object sender, EventArgs e)
        {
            outputlattin.Text.SaveAsTxtFile();
        }
        private void savemorsetxt_Click(object sender, EventArgs e)
        {
            outputmorse.Text.SaveAsTxtFile();
        }

        public void Testtone()
        {
            if (mainDirectSoundOut != null)
            {
                Dispose();
                return;
            }
            mainDirectSoundOut = new DirectSoundOut();
            WaveTone tone = new WaveTone(500, 0.1);
            mainDirectSoundOut.Init(tone);
            mainDirectSoundOut.Play();
        }

        private void settings_Click(object sender, EventArgs e)
        {            
            f.Show();
        }
        //audio convertor mp3 -> wav
        public string ToNewTempWavFile(string source)
        {
            if (source.EndsWith(".mp3"))
                using (Mp3FileReader mp3r = new Mp3FileReader(source))
                {
                    using (WaveStream wav = WaveFormatConversionStream.CreatePcmStream(mp3r))
                        WaveFileWriter.CreateWaveFile(temp, wav);
                }
            return (temp);
        }
        //translate

        public float[] Buffer(string wavfile)
        {
            float max = 0;
            float[] buffer = null;
            using (var reader = new AudioFileReader(wavfile))
            {
                // find the max peak
                buffer = new float[reader.WaveFormat.SampleRate];
                int read;
                do
                {
                    read = reader.Read(buffer, 0, buffer.Length);
                    for (int n = 0; n < read; n++)
                    {
                        var abs = Math.Abs(buffer[n]);
                        if (abs > max) max = abs;
                    }
                } while (read > 0);
                Console.WriteLine($"Max sample value: {max}");
            }
            return buffer;
        }
    }

    static class StringExtensions
    {
        public static string morseAlpha = ".- -... -.-. -.. . ..-. --. .... .. .--- -.- .-.. -- -. --- .--. --.- .-. ... - ..- ...- .-- -..- -.-- --.. ----- .---- ..--- ...-- ....- ..... -.... --... ---.. ----. .-.-.- --..-- ..--.. .----. -.-.-- -..-. -.--. -.--.- .-... ---... -.-.-. -...- .-.-. -....- ..--.-";
        public static string lattinAlpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789.,?'!/()&:;=+-_".ToLower();
        public static string ClearTextSlow(this string a)
        {
            char[] ch = a.ToCharArray();
            for (int i = 0; i < ch.Length; i++)
            {
                if (":,0123456789".Contains(ch[i]))
                {
                    for (int j = i; j < ch.Length - 1; j++)
                        ch[j] = ch[j + 1];
                    Array.Resize<char>(ref ch, ch.Length - 1);
                    i--;
                }
            }
            a = new string(ch);
            return a;
        }
        public static string ClearText(this string a)
        {
            char[] ch = a.ToCharArray();
            List<string> b = new List<string>();

            for (int i = 0; i < ch.Length; i++)
                if (!":,0123456789".Contains(ch[i]))
                    b.Add(ch[i].ToString());
            a = string.Join("", b);
            return a;
        }

        public static string ToLattin(this string morse)
        {
            string inp = morse;
            string[] inplet = inp.Split('/');
            char[] outlet = new char[inplet.Length];
            char[] keyA = lattinAlpha.ToCharArray();
            string[] keyB = morseAlpha.Split(' ');
            for (int i = 0; i < inplet.Length; i++)
            {
                outlet[i] = '#';
                for (int j = 0; j < keyB.Length; j++)
                {
                    if (inplet[i] == keyB[j])
                    {
                        outlet[i] = keyA[j];
                        break;
                    }
                }
            }
            var lattin = new string(outlet);
            return (lattin);
        }

        public static string ToMorse(this string lattin)
        {
            string inp = lattin.ToLower().ClearText().Trim(' ');
            char[] inplet = inp.ToCharArray();
            string[] outlet = new string[inplet.Length];
            char[] keyA = lattinAlpha.ToCharArray();
            string[] keyB = morseAlpha.Split(' ');
            for (int i = 0; i < inplet.Length; i++)
                for (int j = 0; j < keyB.Length; j++)
                {
                    if (inplet[i] == keyA[j])
                    {
                        outlet[i] = keyB[j];
                        break;
                    }
                }


            string morse = String.Join("/", outlet);
            return (morse);
        }


        public static void SaveAsTxtFile(this string a)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "TXT file (*.txt)|*.txt;";
            if (save.ShowDialog() != DialogResult.OK) return;
            File.WriteAllText(save.FileName, a);            
        }
    }
    public class WaveTone : WaveStream
    {
        private double frequency;
        private double amplitude = 1;
        private double time = 0;

        public WaveTone(double f, double a)
        {
            this.time = 0;
            this.frequency = f;
            this.amplitude = a;
        }

        public override long Position { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override long Length { get { return long.MaxValue; } }
        public override WaveFormat WaveFormat { get { return new WaveFormat(44100, 16, 1); } }
        public override int Read(byte[] buffer, int offset, int count)
        {
            int samples = count / 2;
            for (int i = 0; i < samples; i++)
            {
                double sine = amplitude * Math.Sin(Math.PI * 2 * frequency * time);
                time += 1.0 / 44100;
                short truncated = (short)Math.Round(sine * (Math.Pow(2, 15) - 1));
                buffer[i * 2] = (byte)(truncated & 0x00ff);
                buffer[i * 2 + 1] = (byte)((truncated & 0xff00) >> 8);
            }
            return count;
        }        
    }
}