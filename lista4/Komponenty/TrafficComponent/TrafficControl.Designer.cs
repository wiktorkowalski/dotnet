namespace TrafficComponent
{
    partial class TrafficControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelRed = new System.Windows.Forms.Panel();
            this.panelYellow = new System.Windows.Forms.Panel();
            this.panelGreen = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panelRed
            // 
            this.panelRed.Location = new System.Drawing.Point(4, 4);
            this.panelRed.Name = "panelRed";
            this.panelRed.Size = new System.Drawing.Size(100, 100);
            this.panelRed.TabIndex = 0;
            // 
            // panelYellow
            // 
            this.panelYellow.Location = new System.Drawing.Point(4, 110);
            this.panelYellow.Name = "panelYellow";
            this.panelYellow.Size = new System.Drawing.Size(100, 100);
            this.panelYellow.TabIndex = 1;
            // 
            // panelGreen
            // 
            this.panelGreen.Location = new System.Drawing.Point(5, 216);
            this.panelGreen.Name = "panelGreen";
            this.panelGreen.Size = new System.Drawing.Size(100, 100);
            this.panelGreen.TabIndex = 2;
            // 
            // TrafficControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelGreen);
            this.Controls.Add(this.panelYellow);
            this.Controls.Add(this.panelRed);
            this.Name = "TrafficControl";
            this.Size = new System.Drawing.Size(108, 324);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelRed;
        private System.Windows.Forms.Panel panelYellow;
        private System.Windows.Forms.Panel panelGreen;
    }
}
