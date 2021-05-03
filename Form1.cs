using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace _09_Sound_interaction
{
    public partial class Form1 : Form
    {
        //initialization
        public Form1()
        {
            InitializeComponent();
            errormessage.Text = Path.GetTempFileName();
        }
        //setup time
        public DateTime appinit = DateTime.Now;
        //temp directory
        public string temp = Path.GetTempPath();
        public string wavcopy = "tempwavefile.wav";

        //audio streem declaration
        private BlockAlignReductionStream audiopcmstream = null;
        private DirectSoundOut output = null;


        //audio actions
        public void PlayPause()
        {
            if (output != null)
            {
                if (output.PlaybackState == PlaybackState.Playing) output.Pause();
                else if (output.PlaybackState == PlaybackState.Paused | output.PlaybackState == PlaybackState.Stopped) output.Play();
            }
        }

        public void DisposeAudioFile()
        {
            if (output != null)
            {
                if(output.PlaybackState == PlaybackState.Playing) output.Stop();
                output.Dispose();
                output = null;
            }
            if (audiopcmstream != null)
            {
                audiopcmstream.Dispose();
                audiopcmstream = null;
            }
        }

        public void DeleteTemp()
        {
            if (!Directory.Exists(temp)) return;
            else if (Directory.GetCreationTime(temp) < appinit)
                File.Delete(temp + "\\" + wavcopy);
            else Directory.Delete(temp,true);
        }

        private void run_Click(object sender, EventArgs e)
        {
            PlayPause();

            int choice = 0;
            if (inputlattin.Text != "")
                if (inputmorse.Text == "" & label1.Text == "")
                {
                    choice = 1;
                    outputmorse.Text = ToMorse(inputlattin.Text);
                    outputlattin.Text = inputlattin.Text;
                }
                else choice = -1;
            if (inputmorse.Text != "")
                if (inputlattin.Text == "" & label1.Text == "")
                {
                    choice = 2;
                    outputlattin.Text = ToLattin(inputmorse.Text);
                    outputmorse.Text = inputmorse.Text;
                }
                else choice = -1;
            if (label1.Text != "")
                if (inputlattin.Text == "" & inputmorse.Text == "")
                    choice = 3;
                else choice = -1;
            if (choice == 0)
                errormessage.Text = "no input"; 
            else if (choice == 0)
                errormessage.Text = "more than one input";

            else groupoutput.Visible = true;



        }
        //translate
        public string ToLattin(string morse)
        {
            string inp = morse;
            string[] inplet = inp.Split('/');
            char[] outlet = new char[inplet.Length];
            char[] keyA = "ABCDEFGHIJKLMNOPQRSTUVWXYZ ".ToCharArray();
            string[] keyB = ".-/-.../-.-./-.././..-./--./..../../.---/-.-/.-../--/-./---/.--./--.-/.-./.../-/..-/...-/.--/-..-/-.--/--../".Split('/');
            for (int i = 0; i < inplet.Length; i++)
                for (int j = 0; j < keyB.Length; j++)
                {
                    if (inplet[i] == keyB[j])
                    {
                        outlet[i] = keyA[j];
                        break;

                    }
                    else outlet[i] = ' ';
                }


            var lattin = new string(outlet);
            return (lattin);
        }

        public string ToMorse(string lattin)
        {
            string inp = lattin.ToLower().ClearText().Trim(' ');
            char[] inplet = inp.ToCharArray();
            string[] outlet = new string[inplet.Length];
            char[] keyA = "ABCDEFGHIJKLMNOPQRSTUVWXYZ ".ToLower().ToCharArray();
            string[] keyB = ".-/-.../-.-./-.././..-./--./..../../.---/-.-/.-../--/-./---/.--./--.-/.-./.../-/..-/...-/.--/-..-/-.--/--../".Split('/');
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
        //click actions
        private void openaudiofile_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "audio file (*.wav;*.mp3)|*.wav;*.mp3;*.txt";
            open.Title = "Open Audio File";
            if (open.ShowDialog() != DialogResult.OK) return;
            var openinfo = new FileInfo(open.FileName);

            DisposeAudioFile();
            DeleteTemp();

            output = new DirectSoundOut();

            if (open.FileName.EndsWith(".mp3"))
            {
                //NAudio.Wave.WaveStream pcmstream = NAudio.Wave.WaveFormatConversionStream.CreatePcmStream(new NAudio.Wave.Mp3FileReader(open.FileName));
                //audiopcmstream = new BlockAlignReductionStream(WaveFormatConversionStream.CreatePcmStream(new Mp3FileReader(open.FileName)));
                open.FileName = open.FileName.ToNewWavFile(temp);
            }//convert mp3 to wav if necessery and set path
            else {
                if (!Directory.Exists(temp)) Directory.CreateDirectory(temp);
                File.Copy(open.FileName, temp + "\\" + wavcopy); }
            if (open.FileName.EndsWith(".wav"))
            {
                //NAudio.Wave.WaveStream pcmstream = new NAudio.Wave.WaveChannel32(new NAudio.Wave.WaveFileReader(open.FileName));
                audiopcmstream = new BlockAlignReductionStream(new WaveChannel32(new WaveFileReader(open.FileName)));
            }//set for playback
            else { errormessage.Text = "Not a correct file type"; return; }

            output.Init(audiopcmstream);
            play.Enabled = true;
            //play_Click(sender,e);

            label1.Text = openinfo.Name;
            return;
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
            DisposeAudioFile();
            var m = new Form1();
            m.Show();
            this.Hide();
        }

        private void savelattintxt_Click(object sender, EventArgs e)
        {
            outputlattin.Text.SaveAsTxtFile();
        }

        private void savemorsetxt_Click(object sender, EventArgs e)
        {
            outputmorse.Text.SaveAsTxtFile();
        }
        //form clocing
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DisposeAudioFile();
            DeleteTemp();
            Environment.Exit(0);
        }

        private void Testtone_Click(object sender, EventArgs e)
        {
            if (output != null)
                if (output.PlaybackState == PlaybackState.Playing){
                    PlayPause();
                    return;
                    }
                output = new DirectSoundOut();
                WaveTone tone = new WaveTone(500, 0.1);
                output.Init(tone);
            output.Play();
        }
    }

    static class StringExtensions
    {
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
        //audio convertor mp3 -> wav
        public static string ToNewWavFile(this string source, string filepath)
        {
            Directory.CreateDirectory(filepath);

            string filename = "tempwavefile.wav";
            string fullname = filepath + "\\" + filename;
            if(source.EndsWith(".mp3"))
            using (Mp3FileReader mp3r = new Mp3FileReader(source))
            {
                    using (WaveStream wav = WaveFormatConversionStream.CreatePcmStream(mp3r))
                    WaveFileWriter.CreateWaveFile(fullname, wav);
            }
            return (fullname);
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