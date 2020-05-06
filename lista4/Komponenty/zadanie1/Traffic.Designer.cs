namespace zadanie1
{
    partial class Traffic
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
            this.panelGreen = new System.Windows.Forms.Panel();
            this.panelYellow = new System.Windows.Forms.Panel();
            this.panelRed = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panelGreen
            // 
            this.panelGreen.Location = new System.Drawing.Point(12, 266);
            this.panelGreen.Name = "panelGreen";
            this.panelGreen.Size = new System.Drawing.Size(183, 121);
            this.panelGreen.TabIndex = 5;
            // 
            // panelYellow
            // 
            this.panelYellow.Location = new System.Drawing.Point(12, 139);
            this.panelYellow.Name = "panelYellow";
            this.panelYellow.Size = new System.Drawing.Size(183, 121);
            this.panelYellow.TabIndex = 4;
            // 
            // panelRed
            // 
            this.panelRed.Location = new System.Drawing.Point(12, 12);
            this.panelRed.Name = "panelRed";
            this.panelRed.Size = new System.Drawing.Size(183, 121);
            this.panelRed.TabIndex = 3;
            // 
            // Traffic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(206, 398);
            this.Controls.Add(this.panelGreen);
            this.Controls.Add(this.panelYellow);
            this.Controls.Add(this.panelRed);
            this.Name = "Traffic";
            this.Text = "Traffic";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelGreen;
        private System.Windows.Forms.Panel panelYellow;
        private System.Windows.Forms.Panel panelRed;
    }
}