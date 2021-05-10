
namespace _09_Sound_interaction
{
    partial class SettigsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.refreshDebug = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.testoutput = new System.Windows.Forms.Button();
            this.sourceList = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.refresh = new System.Windows.Forms.Button();
            this.select = new System.Windows.Forms.Button();
            this.loopback = new System.Windows.Forms.Button();
            this.stopLoopback = new System.Windows.Forms.Button();
            this.freqTextBox = new System.Windows.Forms.TextBox();
            this.labelAmp = new System.Windows.Forms.Label();
            this.labelFreq = new System.Windows.Forms.Label();
            this.amplitude = new System.Windows.Forms.TextBox();
            this.volume = new NAudio.Gui.VolumeSlider();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.refreshDebug);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(28, 308);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(470, 182);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Debug";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "label3";
            // 
            // refreshDebug
            // 
            this.refreshDebug.Location = new System.Drawing.Point(389, 153);
            this.refreshDebug.Name = "refreshDebug";
            this.refreshDebug.Size = new System.Drawing.Size(75, 23);
            this.refreshDebug.TabIndex = 2;
            this.refreshDebug.Text = "refresh";
            this.refreshDebug.UseVisualStyleBackColor = true;
            this.refreshDebug.Click += new System.EventHandler(this.refreshDebug_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // testoutput
            // 
            this.testoutput.Location = new System.Drawing.Point(179, 268);
            this.testoutput.Name = "testoutput";
            this.testoutput.Size = new System.Drawing.Size(75, 23);
            this.testoutput.TabIndex = 2;
            this.testoutput.Text = "Test Output Tone";
            this.testoutput.UseVisualStyleBackColor = true;
            this.testoutput.Click += new System.EventHandler(this.testoutput_Click);
            // 
            // sourceList
            // 
            this.sourceList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.sourceList.HideSelection = false;
            this.sourceList.Location = new System.Drawing.Point(12, 12);
            this.sourceList.MultiSelect = false;
            this.sourceList.Name = "sourceList";
            this.sourceList.Size = new System.Drawing.Size(266, 140);
            this.sourceList.TabIndex = 3;
            this.sourceList.UseCompatibleStateImageBehavior = false;
            this.sourceList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Input Device";
            this.columnHeader1.Width = 160;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Channels";
            this.columnHeader2.Width = 100;
            // 
            // refresh
            // 
            this.refresh.Location = new System.Drawing.Point(284, 13);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(104, 23);
            this.refresh.TabIndex = 4;
            this.refresh.Text = "Refresh";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // select
            // 
            this.select.Location = new System.Drawing.Point(284, 129);
            this.select.Name = "select";
            this.select.Size = new System.Drawing.Size(104, 23);
            this.select.TabIndex = 5;
            this.select.Text = "Select";
            this.select.UseVisualStyleBackColor = true;
            this.select.Click += new System.EventHandler(this.select_Click);
            // 
            // loopback
            // 
            this.loopback.Location = new System.Drawing.Point(284, 52);
            this.loopback.Name = "loopback";
            this.loopback.Size = new System.Drawing.Size(104, 23);
            this.loopback.TabIndex = 6;
            this.loopback.Text = "Loop to Output";
            this.loopback.UseVisualStyleBackColor = true;
            this.loopback.Click += new System.EventHandler(this.loopback_Click);
            // 
            // stopLoopback
            // 
            this.stopLoopback.Location = new System.Drawing.Point(284, 81);
            this.stopLoopback.Name = "stopLoopback";
            this.stopLoopback.Size = new System.Drawing.Size(104, 23);
            this.stopLoopback.TabIndex = 7;
            this.stopLoopback.Text = "Stop";
            this.stopLoopback.UseVisualStyleBackColor = true;
            this.stopLoopback.Click += new System.EventHandler(this.stopLoopback_Click);
            // 
            // freqTextBox
            // 
            this.freqTextBox.Location = new System.Drawing.Point(85, 268);
            this.freqTextBox.MaxLength = 10;
            this.freqTextBox.Name = "freqTextBox";
            this.freqTextBox.Size = new System.Drawing.Size(88, 23);
            this.freqTextBox.TabIndex = 8;
            this.freqTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            this.freqTextBox.Leave += new System.EventHandler(this.freqTextBox_Leave);
            // 
            // labelAmp
            // 
            this.labelAmp.AutoSize = true;
            this.labelAmp.Location = new System.Drawing.Point(12, 242);
            this.labelAmp.Name = "labelAmp";
            this.labelAmp.Size = new System.Drawing.Size(63, 15);
            this.labelAmp.TabIndex = 10;
            this.labelAmp.Text = "Amplitude";
            // 
            // labelFreq
            // 
            this.labelFreq.AutoSize = true;
            this.labelFreq.Location = new System.Drawing.Point(12, 272);
            this.labelFreq.Name = "labelFreq";
            this.labelFreq.Size = new System.Drawing.Size(62, 15);
            this.labelFreq.TabIndex = 11;
            this.labelFreq.Text = "Frequency";
            // 
            // amplitude
            // 
            this.amplitude.Location = new System.Drawing.Point(85, 202);
            this.amplitude.MaxLength = 10;
            this.amplitude.Name = "amplitude";
            this.amplitude.Size = new System.Drawing.Size(88, 23);
            this.amplitude.TabIndex = 9;
            this.amplitude.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // volume
            // 
            this.volume.Enabled = false;
            this.volume.Location = new System.Drawing.Point(85, 239);
            this.volume.Name = "volume";
            this.volume.Size = new System.Drawing.Size(88, 23);
            this.volume.TabIndex = 12;
            this.volume.VolumeChanged += new System.EventHandler(this.volume_VolumeChanged);
            // 
            // SettigsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 502);
            this.Controls.Add(this.volume);
            this.Controls.Add(this.labelFreq);
            this.Controls.Add(this.labelAmp);
            this.Controls.Add(this.amplitude);
            this.Controls.Add(this.freqTextBox);
            this.Controls.Add(this.stopLoopback);
            this.Controls.Add(this.loopback);
            this.Controls.Add(this.select);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.sourceList);
            this.Controls.Add(this.testoutput);
            this.Controls.Add(this.groupBox1);
            this.Name = "SettigsForm";
            this.Text = "SettigsForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettigsForm_FormClosing);
            this.Shown += new System.EventHandler(this.refresh_Click);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button testoutput;
        private System.Windows.Forms.ListView sourceList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.Button select;
        private System.Windows.Forms.Button loopback;
        private System.Windows.Forms.Button stopLoopback;
        private System.Windows.Forms.Button refreshDebug;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox freqTextBox;
        private System.Windows.Forms.Label labelAmp;
        private System.Windows.Forms.Label labelFreq;
        private System.Windows.Forms.TextBox amplitude;
        private NAudio.Gui.VolumeSlider volume;
    }
}