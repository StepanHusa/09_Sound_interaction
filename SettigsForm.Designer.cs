
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
            this.groupDebug = new System.Windows.Forms.GroupBox();
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
            this.volume = new NAudio.Gui.VolumeSlider();
            this.groupInput = new System.Windows.Forms.GroupBox();
            this.groupGenerator = new System.Windows.Forms.GroupBox();
            this.enter = new System.Windows.Forms.Button();
            this.bitDepth = new System.Windows.Forms.TextBox();
            this.sampleRate = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.toneSettingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generating = new System.Windows.Forms.ToolStripMenuItem();
            this.reading = new System.Windows.Forms.ToolStripMenuItem();
            this.debugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inputDevicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupRead = new System.Windows.Forms.GroupBox();
            this.enter2 = new System.Windows.Forms.Button();
            this.timeDivide = new System.Windows.Forms.TextBox();
            this.threshold = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupDebug.SuspendLayout();
            this.groupInput.SuspendLayout();
            this.groupGenerator.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.groupRead.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupDebug
            // 
            this.groupDebug.Controls.Add(this.label5);
            this.groupDebug.Controls.Add(this.label4);
            this.groupDebug.Controls.Add(this.label3);
            this.groupDebug.Controls.Add(this.refreshDebug);
            this.groupDebug.Controls.Add(this.label2);
            this.groupDebug.Controls.Add(this.label1);
            this.groupDebug.Location = new System.Drawing.Point(6, 27);
            this.groupDebug.Name = "groupDebug";
            this.groupDebug.Size = new System.Drawing.Size(400, 300);
            this.groupDebug.TabIndex = 1;
            this.groupDebug.TabStop = false;
            this.groupDebug.Text = "Debug";
            this.groupDebug.Visible = false;
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
            this.refreshDebug.Location = new System.Drawing.Point(319, 15);
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
            this.testoutput.Location = new System.Drawing.Point(172, 57);
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
            this.sourceList.Location = new System.Drawing.Point(7, 22);
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
            this.refresh.Location = new System.Drawing.Point(279, 23);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(104, 23);
            this.refresh.TabIndex = 4;
            this.refresh.Text = "Refresh";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // select
            // 
            this.select.Location = new System.Drawing.Point(279, 139);
            this.select.Name = "select";
            this.select.Size = new System.Drawing.Size(104, 23);
            this.select.TabIndex = 5;
            this.select.Text = "Select";
            this.select.UseVisualStyleBackColor = true;
            this.select.Click += new System.EventHandler(this.select_Click);
            // 
            // loopback
            // 
            this.loopback.Location = new System.Drawing.Point(279, 62);
            this.loopback.Name = "loopback";
            this.loopback.Size = new System.Drawing.Size(104, 23);
            this.loopback.TabIndex = 6;
            this.loopback.Text = "Loop to Output";
            this.loopback.UseVisualStyleBackColor = true;
            this.loopback.Click += new System.EventHandler(this.loopback_Click);
            // 
            // stopLoopback
            // 
            this.stopLoopback.Location = new System.Drawing.Point(279, 91);
            this.stopLoopback.Name = "stopLoopback";
            this.stopLoopback.Size = new System.Drawing.Size(104, 23);
            this.stopLoopback.TabIndex = 7;
            this.stopLoopback.Text = "Stop";
            this.stopLoopback.UseVisualStyleBackColor = true;
            this.stopLoopback.Click += new System.EventHandler(this.stopLoopback_Click);
            // 
            // freqTextBox
            // 
            this.freqTextBox.Location = new System.Drawing.Point(78, 57);
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
            this.labelAmp.Location = new System.Drawing.Point(5, 31);
            this.labelAmp.Name = "labelAmp";
            this.labelAmp.Size = new System.Drawing.Size(63, 15);
            this.labelAmp.TabIndex = 10;
            this.labelAmp.Text = "Amplitude";
            // 
            // labelFreq
            // 
            this.labelFreq.AutoSize = true;
            this.labelFreq.Location = new System.Drawing.Point(5, 61);
            this.labelFreq.Name = "labelFreq";
            this.labelFreq.Size = new System.Drawing.Size(62, 15);
            this.labelFreq.TabIndex = 11;
            this.labelFreq.Text = "Frequency";
            // 
            // volume
            // 
            this.volume.BackColor = System.Drawing.SystemColors.Control;
            this.volume.ForeColor = System.Drawing.SystemColors.ControlText;
            this.volume.Location = new System.Drawing.Point(78, 28);
            this.volume.Name = "volume";
            this.volume.Size = new System.Drawing.Size(88, 23);
            this.volume.TabIndex = 12;
            this.volume.VolumeChanged += new System.EventHandler(this.volume_VolumeChanged);
            // 
            // groupInput
            // 
            this.groupInput.Controls.Add(this.sourceList);
            this.groupInput.Controls.Add(this.refresh);
            this.groupInput.Controls.Add(this.select);
            this.groupInput.Controls.Add(this.loopback);
            this.groupInput.Controls.Add(this.stopLoopback);
            this.groupInput.Location = new System.Drawing.Point(6, 27);
            this.groupInput.Name = "groupInput";
            this.groupInput.Size = new System.Drawing.Size(400, 300);
            this.groupInput.TabIndex = 14;
            this.groupInput.TabStop = false;
            this.groupInput.Text = "Input Devices";
            this.groupInput.Visible = false;
            // 
            // groupGenerator
            // 
            this.groupGenerator.Controls.Add(this.enter);
            this.groupGenerator.Controls.Add(this.bitDepth);
            this.groupGenerator.Controls.Add(this.sampleRate);
            this.groupGenerator.Controls.Add(this.label8);
            this.groupGenerator.Controls.Add(this.label7);
            this.groupGenerator.Controls.Add(this.label6);
            this.groupGenerator.Controls.Add(this.labelAmp);
            this.groupGenerator.Controls.Add(this.testoutput);
            this.groupGenerator.Controls.Add(this.volume);
            this.groupGenerator.Controls.Add(this.freqTextBox);
            this.groupGenerator.Controls.Add(this.labelFreq);
            this.groupGenerator.Location = new System.Drawing.Point(6, 27);
            this.groupGenerator.Name = "groupGenerator";
            this.groupGenerator.Size = new System.Drawing.Size(400, 300);
            this.groupGenerator.TabIndex = 15;
            this.groupGenerator.TabStop = false;
            this.groupGenerator.Text = "Generate";
            this.groupGenerator.Visible = false;
            // 
            // enter
            // 
            this.enter.Location = new System.Drawing.Point(7, 229);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(241, 36);
            this.enter.TabIndex = 18;
            this.enter.Text = "Enter";
            this.enter.UseVisualStyleBackColor = true;
            // 
            // bitDepth
            // 
            this.bitDepth.Enabled = false;
            this.bitDepth.Location = new System.Drawing.Point(84, 168);
            this.bitDepth.Name = "bitDepth";
            this.bitDepth.Size = new System.Drawing.Size(83, 23);
            this.bitDepth.TabIndex = 17;
            this.bitDepth.Text = "32";
            this.bitDepth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bitDepth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.format_KeyPress);
            this.bitDepth.Leave += new System.EventHandler(this.format_Leave);
            // 
            // sampleRate
            // 
            this.sampleRate.Location = new System.Drawing.Point(84, 139);
            this.sampleRate.Name = "sampleRate";
            this.sampleRate.Size = new System.Drawing.Size(83, 23);
            this.sampleRate.TabIndex = 16;
            this.sampleRate.Text = "44100";
            this.sampleRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sampleRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.format_KeyPress);
            this.sampleRate.Leave += new System.EventHandler(this.format_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "Bit Depth";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "Sample Rate";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Wav Output File Format";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toneSettingToolStripMenuItem,
            this.debugToolStripMenuItem,
            this.inputDevicesToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(420, 24);
            this.menuStrip.TabIndex = 16;
            this.menuStrip.Text = "menuStrip1";
            this.menuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip_ItemClicked);
            // 
            // toneSettingToolStripMenuItem
            // 
            this.toneSettingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generating,
            this.reading});
            this.toneSettingToolStripMenuItem.Name = "toneSettingToolStripMenuItem";
            this.toneSettingToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.toneSettingToolStripMenuItem.Text = "Tone";
            this.toneSettingToolStripMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip_ItemClicked);
            // 
            // generating
            // 
            this.generating.Name = "generating";
            this.generating.Size = new System.Drawing.Size(138, 22);
            this.generating.Text = "Generateing";
            // 
            // reading
            // 
            this.reading.Name = "reading";
            this.reading.Size = new System.Drawing.Size(138, 22);
            this.reading.Text = "Reading";
            // 
            // debugToolStripMenuItem
            // 
            this.debugToolStripMenuItem.Name = "debugToolStripMenuItem";
            this.debugToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.debugToolStripMenuItem.Text = "Debug";
            // 
            // inputDevicesToolStripMenuItem
            // 
            this.inputDevicesToolStripMenuItem.Name = "inputDevicesToolStripMenuItem";
            this.inputDevicesToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.inputDevicesToolStripMenuItem.Text = "Input Devices";
            // 
            // groupRead
            // 
            this.groupRead.Controls.Add(this.enter2);
            this.groupRead.Controls.Add(this.timeDivide);
            this.groupRead.Controls.Add(this.threshold);
            this.groupRead.Controls.Add(this.label10);
            this.groupRead.Controls.Add(this.label9);
            this.groupRead.Location = new System.Drawing.Point(0, 26);
            this.groupRead.Name = "groupRead";
            this.groupRead.Size = new System.Drawing.Size(408, 300);
            this.groupRead.TabIndex = 19;
            this.groupRead.TabStop = false;
            this.groupRead.Text = "Audio Reading Settings";
            this.groupRead.Visible = false;
            // 
            // enter2
            // 
            this.enter2.Location = new System.Drawing.Point(36, 161);
            this.enter2.Name = "enter2";
            this.enter2.Size = new System.Drawing.Size(218, 45);
            this.enter2.TabIndex = 4;
            this.enter2.Text = "Enter";
            this.enter2.UseVisualStyleBackColor = true;
            this.enter2.Click += new System.EventHandler(this.enter2_Click);
            // 
            // timeDivide
            // 
            this.timeDivide.Location = new System.Drawing.Point(153, 78);
            this.timeDivide.Name = "timeDivide";
            this.timeDivide.Size = new System.Drawing.Size(196, 23);
            this.timeDivide.TabIndex = 3;
            this.timeDivide.Text = "250";
            this.timeDivide.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.boxInRead_KeyPress);
            this.timeDivide.Leave += new System.EventHandler(this.boxInRead_Leave);
            // 
            // threshold
            // 
            this.threshold.Location = new System.Drawing.Point(153, 40);
            this.threshold.Name = "threshold";
            this.threshold.Size = new System.Drawing.Size(196, 23);
            this.threshold.TabIndex = 2;
            this.threshold.Text = "0.5";
            this.threshold.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.threshold_KeyPress);
            this.threshold.Leave += new System.EventHandler(this.boxInRead_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 81);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 15);
            this.label10.TabIndex = 1;
            this.label10.Text = "Time Divide";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "Amplitude Threshold";
            // 
            // SettigsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 338);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.groupGenerator);
            this.Controls.Add(this.groupInput);
            this.Controls.Add(this.groupDebug);
            this.Controls.Add(this.groupRead);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "SettigsForm";
            this.Text = "SettigsForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettigsForm_FormClosing);
            this.Shown += new System.EventHandler(this.refresh_Click);
            this.groupDebug.ResumeLayout(false);
            this.groupDebug.PerformLayout();
            this.groupInput.ResumeLayout(false);
            this.groupGenerator.ResumeLayout(false);
            this.groupGenerator.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.groupRead.ResumeLayout(false);
            this.groupRead.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void ToneSettingToolStripMenuItem_DropDownItemClicked(object sender, System.Windows.Forms.ToolStripItemClickedEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.GroupBox groupDebug;
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
        private NAudio.Gui.VolumeSlider volume;
        private System.Windows.Forms.GroupBox groupInput;
        private System.Windows.Forms.GroupBox groupGenerator;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem toneSettingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem debugToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inputDevicesToolStripMenuItem;
        private System.Windows.Forms.Button enter;
        private System.Windows.Forms.TextBox bitDepth;
        private System.Windows.Forms.TextBox sampleRate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripMenuItem generating;
        private System.Windows.Forms.ToolStripMenuItem reading;
        private System.Windows.Forms.GroupBox groupRead;
        private System.Windows.Forms.TextBox timeDivide;
        private System.Windows.Forms.TextBox threshold;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button enter2;
    }
}