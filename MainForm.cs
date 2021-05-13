using NAudio;
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
            InitializeMoreThings();
        }
        //temp directory
        public string temp = null;
        private string temp2 = null;
        //Audio device
        public int audioDeviceSelected=-1;
        internal double frequency = 440;
        internal double amplitude=0.2;


        //audio streem declaration
        public WaveIn mainWaveIn = null;
        public BlockAlignReductionStream mainBARStream = null;
        public DirectSoundOut mainDirectSoundOut = null;

        private void InitializeMoreThings()
        {
            SetTemp();
            this.Size = new Size(900, 400);
            audioDeviceSelected = -1;
            frequency = 440;

            if (f != null)
                f.Dispose();
            f = new SettigsForm(this);
        }
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
                if (mainDirectSoundOut.PlaybackState != PlaybackState.Stopped) mainDirectSoundOut.Stop();
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
            errormessage.Text = "The audio was disposed";
        }

        public void SetTemp()
        {
            DeleteTemp();
            temp = Path.GetTempFileName();
        }
        public void DeleteTemp()
        {
            if(temp!=null)
                if(File.Exists(temp))
                    File.Delete(temp);
        }
        public void DeleteTemp2()
        {
            if (temp2 != null)
                if (File.Exists(temp2))
                    File.Delete(temp2);
        }


        //form clocing
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DisposeAudioOutput();
            DeleteTemp();
            DeleteTemp2();
            f.Close();
        }

        public void PrepareToPlayTempedAudio()
        {
            if (temp == null) { errormessage.Text = "no file tempted"; }
            var m = new FileInfo(temp);
            if (!m.Exists) { errormessage.Text = "invalid file to read"; return; }
            if (m.Length < 10) { errormessage.Text = "invalid file to read"; return; }
            mainDirectSoundOut = new DirectSoundOut();
            mainBARStream = new BlockAlignReductionStream(new WaveChannel32(new WaveFileReader(temp)));
            mainDirectSoundOut.Init(mainBARStream);
            play.Enabled = true;
            errormessage.Text = "Audio prepared";
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
                    label2.Text = "converted audio";
                    temp2 = outputmorse.Text.MorseToTempAudio();
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
                {
                    choice = 3;
                }
                else choice = -1;
            if (choice == 0) {
                errormessage.Text = "no input";
                return;
            }
            if (choice == -1) {
                errormessage.Text = "more than one input (try clearing textboxes or restart the app)";
                return;
            }

            DisposeAudioOutput();
            DeleteTemp();
            temp = temp2;
            PrepareToPlayTempedAudio();

            this.Size = new Size(900, 600);
            groupoutput.Visible = true;
        }
        private void openaudiofile_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog {Filter = "audio file (*.wav;*.mp3)|*.wav;*.mp3;*.txt", Title = "Open Audio File"};
            if (open.ShowDialog() != DialogResult.OK) return;
            var openinfo = new FileInfo(open.FileName);

            DisposeAudioOutput();
            open.FileName.ToNewTempWavFile(temp);

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
            DisposeAudioOutput();

            Controls.Clear();
            InitializeComponent();
            InitializeMoreThings();
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
            DeleteTemp2();
            label2.Text = null;
            outputlattin.Clear();
            outputlattin.Clear();
            groupoutput.Hide();
            this.Size = new Size(900, 400);
        }
        private void savelattintxt_Click(object sender, EventArgs e)
        {
            outputlattin.Text.SaveAsTxtFile();
        }
        private void savemorsetxt_Click(object sender, EventArgs e)
        {
            outputmorse.Text.SaveAsTxtFile();
        }
        private void clearAudio_click(object sender, EventArgs e)
        {
            DisposeAudioOutput();
            label1.Text = "";
        }

        public void Testtone()
        {
            if (mainDirectSoundOut != null)
            {
                DisposeAudioOutput();
                return;
            }
            mainDirectSoundOut = new DirectSoundOut();
            WaveTone tone = new WaveTone(frequency, amplitude);
            mainDirectSoundOut.Init(tone);
            mainDirectSoundOut.Play();
        }

        private void settings_Click(object sender, EventArgs e)
        {
            f.refreshDebug_Click();
            f.Show();
        }
        //audio convertor mp3 -> wav
        //translate
        private void plotInput_Click(object sender, EventArgs e)
        {
            var p = new PlotForm(temp);
            if (!p.IsDisposed) p.Show();
        }

        private void savewavfile_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog { Filter = "audio file (*.wav)|*.wav;", Title = "Save Audio File" };
            if (save.ShowDialog() != DialogResult.OK) return;
            File.Copy(temp2, save.FileName,true);
        }

        private void replay_Click(object sender, EventArgs e)
        {
            
            if (mainBARStream != null)
            {
                mainBARStream.Position = 0;
            }
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
    static class AudioExtensions
    {
        public static string ToNewTempWavFile(this string source,string temp)
        {
            if (source.EndsWith(".mp3"))
            {
                using (Mp3FileReader mp3r = new Mp3FileReader(source))
                {
                    using (WaveStream wav = WaveFormatConversionStream.CreatePcmStream(mp3r))
                        WaveFileWriter.CreateWaveFile(temp, wav);
                }
            }
            else if (source.EndsWith(".wav"))
            {
                File.Copy(source, temp, true);
            }
            else MessageBox.Show("not a correct file type to convert");

                
            return (temp);
        }

        public static string MorseToTempAudio(this string input, WaveFormat outFormat = null, 
                                              float amplitude =1, float frequency=1000, int length1=100, int length2=400,
                                              int lengthSilentShort=100, int lengthSilentLong = 600)
        {

            string temp2 = Path.GetTempFileName();
            if(outFormat==null)
                outFormat = new WaveFormat(44100, 16, 1);

            var shorttt = SineForfMiliseconds(length1, outFormat, amplitude, frequency);
            var longgg = SineForfMiliseconds(length2, outFormat, amplitude, frequency);
            var silent = SineForfMiliseconds(lengthSilentShort, outFormat, 0, frequency);
            var silentLong = SineForfMiliseconds(lengthSilentLong, outFormat, 0, frequency);

            WaveFileWriter wr = new WaveFileWriter(temp2, outFormat);

            var characters = input.ToCharArray();
            for (int i = 0; i < characters.Length; i++)
            {
                wr.Write(silent, 0, silent.Length);

                if(characters[i]=='.')
                    wr.Write(shorttt, 0, shorttt.Length);
                else if(characters[i]=='-')
                    wr.Write(longgg, 0, longgg.Length);
                else if(characters[i]=='/')
                    wr.Write(silentLong, 0, silent.Length);
            }
            wr.Dispose();
            return temp2;
        }
        static byte[] SineForfMiliseconds(int time, WaveFormat format, float amplitude = 1, float frequency = 1000)
        {
            int samples = (format.SampleRate*time/1000);
            int count = samples * 2;
            double position = 0;
            byte[] buffer = new byte[count];
            int cooloff = 2 * format.SampleRate / (int) frequency;
            if (cooloff > samples) cooloff = 0;


            for (int i = 0; i < samples- cooloff; i++)
            {
                double sine = amplitude * Math.Sin(Math.PI * 2 * frequency * position);
                short truncated = (short)Math.Round(sine * (Math.Pow(2, 15) - 1));
                buffer[i * 2] = (byte)(truncated & 0x00ff);
                buffer[i * 2 + 1] = (byte)((truncated & 0xff00) >> 8);
                position += 1.0 / format.SampleRate;
            }
            //fancy stuff, so the sound doesen`t click in the end
            double end = 1;
            for (int i = samples- cooloff; i < samples; i++)
            {
                double sine = amplitude * Math.Sin(Math.PI * 2 * frequency * position);
                sine *= end;
                short truncated = (short)Math.Round(sine * (Math.Pow(2, 15) - 1));
                buffer[i * 2] = (byte)(truncated & 0x00ff);
                buffer[i * 2 + 1] = (byte)((truncated & 0xff00) >> 8);

                end -= 1.0 / cooloff;
                position += 1.0 / format.SampleRate;
            }


            return buffer;
        }


        public static string AudioToMorse(this string input,float trashold=(float)0.2)
        {

            WaveChannel32 wave = new WaveChannel32(new WaveFileReader(input));
            int l = 16384;
            int length =(int) wave.Length / l;
            byte[] buffer = new byte[l];
            int read = 0;
            float max;
            float[] list = new float[length];
            for (int j = 0; j < length; j++)
            {
                read = wave.Read(buffer, 0, l);
                for (int i = 0; i < read-1; i++)
                {
                    max = BitConverter.ToSingle(buffer, i * 4);
                    if (max < 0) max = -max;
                    if (max > list[j]) list[j] = max;
                }
            }


            return input;
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