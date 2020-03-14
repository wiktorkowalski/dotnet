namespace zadanie1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.clockLabel = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.dateLabel = new System.Windows.Forms.Label();
            this.alarmButton = new System.Windows.Forms.Button();
            this.alarmPicker = new System.Windows.Forms.DateTimePicker();
            this.alarmLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // clockLabel
            // 
            this.clockLabel.AutoSize = true;
            this.clockLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.clockLabel.Location = new System.Drawing.Point(12, 9);
            this.clockLabel.Name = "clockLabel";
            this.clockLabel.Size = new System.Drawing.Size(54, 26);
            this.clockLabel.TabIndex = 0;
            this.clockLabel.Text = "time";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateLabel.Location = new System.Drawing.Point(12, 54);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(54, 26);
            this.dateLabel.TabIndex = 1;
            this.dateLabel.Text = "date";
            // 
            // alarmButton
            // 
            this.alarmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.alarmButton.Location = new System.Drawing.Point(12, 271);
            this.alarmButton.Name = "alarmButton";
            this.alarmButton.Size = new System.Drawing.Size(130, 35);
            this.alarmButton.TabIndex = 2;
            this.alarmButton.Text = "Add alarm";
            this.alarmButton.UseVisualStyleBackColor = true;
            this.alarmButton.Click += new System.EventHandler(this.alarmButton_Click);
            // 
            // alarmPicker
            // 
            this.alarmPicker.Location = new System.Drawing.Point(17, 245);
            this.alarmPicker.Name = "alarmPicker";
            this.alarmPicker.Size = new System.Drawing.Size(200, 20);
            this.alarmPicker.TabIndex = 3;
            // 
            // alarmLabel
            // 
            this.alarmLabel.AutoSize = true;
            this.alarmLabel.Location = new System.Drawing.Point(13, 313);
            this.alarmLabel.Name = "alarmLabel";
            this.alarmLabel.Size = new System.Drawing.Size(0, 13);
            this.alarmLabel.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 450);
            this.Controls.Add(this.alarmLabel);
            this.Controls.Add(this.alarmPicker);
            this.Controls.Add(this.alarmButton);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.clockLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label clockLabel;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Button alarmButton;
        private System.Windows.Forms.DateTimePicker alarmPicker;
        private System.Windows.Forms.Label alarmLabel;
    }
}

