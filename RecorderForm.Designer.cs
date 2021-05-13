
namespace _09_Sound_interaction
{
    partial class RecorderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.record = new System.Windows.Forms.Button();
            this.errorMessage = new System.Windows.Forms.Label();
            this.stop = new System.Windows.Forms.Button();
            this.plot = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.newRecord = new System.Windows.Forms.Button();
            this.volumeSliderMeter = new NAudio.Gui.VolumeSlider();
            this.SuspendLayout();
            // 
            // record
            // 
            this.record.Location = new System.Drawing.Point(13, 13);
            this.record.Name = "record";
            this.record.Size = new System.Drawing.Size(198, 40);
            this.record.TabIndex = 0;
            this.record.Text = "Record!";
            this.record.UseVisualStyleBackColor = true;
            this.record.Click += new System.EventHandler(this.record_Click);
            // 
            // errorMessage
            // 
            this.errorMessage.AutoSize = true;
            this.errorMessage.Location = new System.Drawing.Point(13, 143);
            this.errorMessage.Name = "errorMessage";
            this.errorMessage.Size = new System.Drawing.Size(0, 15);
            this.errorMessage.TabIndex = 1;
            // 
            // stop
            // 
            this.stop.Enabled = false;
            this.stop.Location = new System.Drawing.Point(13, 60);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(198, 38);
            this.stop.TabIndex = 2;
            this.stop.Text = "Stop Recording";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // plot
            // 
            this.plot.Location = new System.Drawing.Point(13, 134);
            this.plot.Name = "plot";
            this.plot.Size = new System.Drawing.Size(198, 49);
            this.plot.TabIndex = 3;
            this.plot.Text = "Plot Recorded File";
            this.plot.UseVisualStyleBackColor = true;
            this.plot.Visible = false;
            this.plot.Click += new System.EventHandler(this.plot_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(136, 274);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 23);
            this.exit.TabIndex = 4;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(13, 274);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(45, 23);
            this.save.TabIndex = 5;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Visible = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // newRecord
            // 
            this.newRecord.Location = new System.Drawing.Point(75, 274);
            this.newRecord.Name = "newRecord";
            this.newRecord.Size = new System.Drawing.Size(45, 23);
            this.newRecord.TabIndex = 6;
            this.newRecord.Text = "New";
            this.newRecord.UseVisualStyleBackColor = true;
            this.newRecord.Visible = false;
            this.newRecord.Click += new System.EventHandler(this.newRecord_Click);
            // 
            // volumeSliderMeter
            // 
            this.volumeSliderMeter.Enabled = false;
            this.volumeSliderMeter.Location = new System.Drawing.Point(13, 104);
            this.volumeSliderMeter.Name = "volumeSliderMeter";
            this.volumeSliderMeter.Size = new System.Drawing.Size(198, 24);
            this.volumeSliderMeter.TabIndex = 7;
            this.volumeSliderMeter.Visible = false;
            this.volumeSliderMeter.Volume = 0F;
            // 
            // RecorderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 309);
            this.Controls.Add(this.volumeSliderMeter);
            this.Controls.Add(this.newRecord);
            this.Controls.Add(this.save);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.plot);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.errorMessage);
            this.Controls.Add(this.record);
            this.Name = "RecorderForm";
            this.Text = "RecorderForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RecorderForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button record;
        private System.Windows.Forms.Label errorMessage;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.Button plot;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button newRecord;
        private NAudio.Gui.VolumeSlider volumeSliderMeter;
    }
}