namespace _09_Sound_interaction
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openaudiofile = new System.Windows.Forms.Button();
            this.play = new System.Windows.Forms.Button();
            this.run = new System.Windows.Forms.Button();
            this.openlattintxt = new System.Windows.Forms.Button();
            this.openmorsetxt = new System.Windows.Forms.Button();
            this.inputlattin = new System.Windows.Forms.TextBox();
            this.inputmorse = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupoutput = new System.Windows.Forms.GroupBox();
            this.hideOutput = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.outputlattin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.savelattintxt = new System.Windows.Forms.Button();
            this.outputmorse = new System.Windows.Forms.TextBox();
            this.savemorsetxt = new System.Windows.Forms.Button();
            this.savewavfile = new System.Windows.Forms.Button();
            this.playthefile2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.errormessage = new System.Windows.Forms.Label();
            this.restart = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.settings = new System.Windows.Forms.Button();
            this.record = new System.Windows.Forms.Button();
            this.clr = new System.Windows.Forms.Button();
            this.clearAudio = new System.Windows.Forms.Button();
            this.groupoutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // openaudiofile
            // 
            this.openaudiofile.Location = new System.Drawing.Point(460, 133);
            this.openaudiofile.Name = "openaudiofile";
            this.openaudiofile.Size = new System.Drawing.Size(146, 23);
            this.openaudiofile.TabIndex = 0;
            this.openaudiofile.Text = "open audio file";
            this.openaudiofile.UseVisualStyleBackColor = true;
            this.openaudiofile.Click += new System.EventHandler(this.openaudiofile_Click);
            // 
            // play
            // 
            this.play.Enabled = false;
            this.play.Location = new System.Drawing.Point(612, 133);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(146, 23);
            this.play.TabIndex = 1;
            this.play.Text = "play pause";
            this.play.UseVisualStyleBackColor = true;
            this.play.Click += new System.EventHandler(this.play_Click);
            // 
            // run
            // 
            this.run.Location = new System.Drawing.Point(327, 261);
            this.run.Name = "run";
            this.run.Size = new System.Drawing.Size(146, 46);
            this.run.TabIndex = 3;
            this.run.Text = "RUN";
            this.run.UseVisualStyleBackColor = true;
            this.run.Click += new System.EventHandler(this.run_Click);
            // 
            // openlattintxt
            // 
            this.openlattintxt.Location = new System.Drawing.Point(460, 29);
            this.openlattintxt.Name = "openlattintxt";
            this.openlattintxt.Size = new System.Drawing.Size(146, 23);
            this.openlattintxt.TabIndex = 4;
            this.openlattintxt.Text = "open lattin txt";
            this.openlattintxt.UseVisualStyleBackColor = true;
            this.openlattintxt.Click += new System.EventHandler(this.openlattintxt_Click);
            // 
            // openmorsetxt
            // 
            this.openmorsetxt.Location = new System.Drawing.Point(460, 70);
            this.openmorsetxt.Name = "openmorsetxt";
            this.openmorsetxt.Size = new System.Drawing.Size(146, 23);
            this.openmorsetxt.TabIndex = 5;
            this.openmorsetxt.Text = "open morse txt";
            this.openmorsetxt.UseVisualStyleBackColor = true;
            this.openmorsetxt.Click += new System.EventHandler(this.openmorsetxt_Click);
            // 
            // inputlattin
            // 
            this.inputlattin.Location = new System.Drawing.Point(154, 28);
            this.inputlattin.Name = "inputlattin";
            this.inputlattin.Size = new System.Drawing.Size(279, 23);
            this.inputlattin.TabIndex = 6;
            // 
            // inputmorse
            // 
            this.inputmorse.Location = new System.Drawing.Point(154, 70);
            this.inputmorse.Name = "inputmorse";
            this.inputmorse.Size = new System.Drawing.Size(279, 23);
            this.inputmorse.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(163, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 8;
            // 
            // groupoutput
            // 
            this.groupoutput.Controls.Add(this.hideOutput);
            this.groupoutput.Controls.Add(this.label6);
            this.groupoutput.Controls.Add(this.label5);
            this.groupoutput.Controls.Add(this.label8);
            this.groupoutput.Controls.Add(this.outputlattin);
            this.groupoutput.Controls.Add(this.label2);
            this.groupoutput.Controls.Add(this.savelattintxt);
            this.groupoutput.Controls.Add(this.outputmorse);
            this.groupoutput.Controls.Add(this.savemorsetxt);
            this.groupoutput.Controls.Add(this.savewavfile);
            this.groupoutput.Controls.Add(this.playthefile2);
            this.groupoutput.Location = new System.Drawing.Point(13, 261);
            this.groupoutput.Name = "groupoutput";
            this.groupoutput.Size = new System.Drawing.Size(959, 288);
            this.groupoutput.TabIndex = 9;
            this.groupoutput.TabStop = false;
            this.groupoutput.Text = "output";
            this.groupoutput.Visible = false;
            // 
            // hideOutput
            // 
            this.hideOutput.Location = new System.Drawing.Point(858, 259);
            this.hideOutput.Name = "hideOutput";
            this.hideOutput.Size = new System.Drawing.Size(95, 23);
            this.hideOutput.TabIndex = 12;
            this.hideOutput.Text = "Close Output";
            this.hideOutput.UseVisualStyleBackColor = true;
            this.hideOutput.Click += new System.EventHandler(this.hideOutput_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "morse output";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "lattin output";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 154);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 15);
            this.label8.TabIndex = 11;
            this.label8.Text = "audio output";
            // 
            // outputlattin
            // 
            this.outputlattin.Location = new System.Drawing.Point(141, 41);
            this.outputlattin.Name = "outputlattin";
            this.outputlattin.ReadOnly = true;
            this.outputlattin.Size = new System.Drawing.Size(279, 23);
            this.outputlattin.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "label2";
            // 
            // savelattintxt
            // 
            this.savelattintxt.Location = new System.Drawing.Point(447, 42);
            this.savelattintxt.Name = "savelattintxt";
            this.savelattintxt.Size = new System.Drawing.Size(146, 23);
            this.savelattintxt.TabIndex = 4;
            this.savelattintxt.Text = "save lattin txt";
            this.savelattintxt.UseVisualStyleBackColor = true;
            this.savelattintxt.Click += new System.EventHandler(this.savelattintxt_Click);
            // 
            // outputmorse
            // 
            this.outputmorse.Location = new System.Drawing.Point(141, 83);
            this.outputmorse.Name = "outputmorse";
            this.outputmorse.ReadOnly = true;
            this.outputmorse.Size = new System.Drawing.Size(279, 23);
            this.outputmorse.TabIndex = 7;
            // 
            // savemorsetxt
            // 
            this.savemorsetxt.Location = new System.Drawing.Point(447, 83);
            this.savemorsetxt.Name = "savemorsetxt";
            this.savemorsetxt.Size = new System.Drawing.Size(146, 23);
            this.savemorsetxt.TabIndex = 5;
            this.savemorsetxt.Text = "save morse txt";
            this.savemorsetxt.UseVisualStyleBackColor = true;
            this.savemorsetxt.Click += new System.EventHandler(this.savemorsetxt_Click);
            // 
            // savewavfile
            // 
            this.savewavfile.Location = new System.Drawing.Point(447, 154);
            this.savewavfile.Name = "savewavfile";
            this.savewavfile.Size = new System.Drawing.Size(146, 23);
            this.savewavfile.TabIndex = 0;
            this.savewavfile.Text = "save wav file";
            this.savewavfile.UseVisualStyleBackColor = true;
            this.savewavfile.Click += new System.EventHandler(this.openaudiofile_Click);
            // 
            // playthefile2
            // 
            this.playthefile2.Enabled = false;
            this.playthefile2.Location = new System.Drawing.Point(599, 154);
            this.playthefile2.Name = "playthefile2";
            this.playthefile2.Size = new System.Drawing.Size(146, 23);
            this.playthefile2.TabIndex = 1;
            this.playthefile2.Text = "play the file";
            this.playthefile2.UseVisualStyleBackColor = true;
            this.playthefile2.Click += new System.EventHandler(this.play_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "lattin input";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "morse input";
            // 
            // errormessage
            // 
            this.errormessage.AutoSize = true;
            this.errormessage.ForeColor = System.Drawing.Color.DarkRed;
            this.errormessage.Location = new System.Drawing.Point(154, 196);
            this.errormessage.Name = "errormessage";
            this.errormessage.Size = new System.Drawing.Size(0, 15);
            this.errormessage.TabIndex = 12;
            // 
            // restart
            // 
            this.restart.Location = new System.Drawing.Point(897, 65);
            this.restart.Name = "restart";
            this.restart.Size = new System.Drawing.Size(75, 23);
            this.restart.TabIndex = 13;
            this.restart.Text = "restart";
            this.restart.UseVisualStyleBackColor = true;
            this.restart.Click += new System.EventHandler(this.restart_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "audio input";
            // 
            // settings
            // 
            this.settings.Location = new System.Drawing.Point(897, 12);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(75, 47);
            this.settings.TabIndex = 15;
            this.settings.Text = "settings and debug";
            this.settings.UseVisualStyleBackColor = true;
            this.settings.Click += new System.EventHandler(this.settings_Click);
            // 
            // record
            // 
            this.record.Location = new System.Drawing.Point(460, 163);
            this.record.Name = "record";
            this.record.Size = new System.Drawing.Size(146, 23);
            this.record.TabIndex = 16;
            this.record.Text = "Record Audio";
            this.record.UseVisualStyleBackColor = true;
            this.record.Click += new System.EventHandler(this.record_Click);
            // 
            // clr
            // 
            this.clr.Location = new System.Drawing.Point(683, 70);
            this.clr.Name = "clr";
            this.clr.Size = new System.Drawing.Size(75, 23);
            this.clr.TabIndex = 17;
            this.clr.Text = "Clear";
            this.clr.UseVisualStyleBackColor = true;
            this.clr.Click += new System.EventHandler(this.clr_Click);
            // 
            // clearAudio
            // 
            this.clearAudio.Location = new System.Drawing.Point(613, 163);
            this.clearAudio.Name = "clearAudio";
            this.clearAudio.Size = new System.Drawing.Size(145, 23);
            this.clearAudio.TabIndex = 18;
            this.clearAudio.Text = "Clear Audio";
            this.clearAudio.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.clearAudio);
            this.Controls.Add(this.clr);
            this.Controls.Add(this.record);
            this.Controls.Add(this.settings);
            this.Controls.Add(this.restart);
            this.Controls.Add(this.errormessage);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupoutput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputmorse);
            this.Controls.Add(this.run);
            this.Controls.Add(this.inputlattin);
            this.Controls.Add(this.openmorsetxt);
            this.Controls.Add(this.openlattintxt);
            this.Controls.Add(this.play);
            this.Controls.Add(this.openaudiofile);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 600);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "MainForm";
            this.Text = "Morse Translator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupoutput.ResumeLayout(false);
            this.groupoutput.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openaudiofile;
        private System.Windows.Forms.Button play;
        private System.Windows.Forms.Button run;
        private System.Windows.Forms.Button openlattintxt;
        private System.Windows.Forms.Button openmorsetxt;
        private System.Windows.Forms.TextBox inputlattin;
        private System.Windows.Forms.TextBox inputmorse;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupoutput;
        private System.Windows.Forms.TextBox outputlattin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button savelattintxt;
        private System.Windows.Forms.TextBox outputmorse;
        private System.Windows.Forms.Button savemorsetxt;
        private System.Windows.Forms.Button savewavfile;
        private System.Windows.Forms.Button playthefile2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label errormessage;
        private System.Windows.Forms.Button restart;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button settings;
        private System.Windows.Forms.Button record;
        private System.Windows.Forms.Button clr;
        private System.Windows.Forms.Button hideOutput;
        private System.Windows.Forms.Button clearAudio;
    }
}

