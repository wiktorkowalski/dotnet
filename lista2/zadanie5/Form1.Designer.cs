namespace zadanie5
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox1contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.listBox1DeleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox2contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.listBox2DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox1contextMenu.SuspendLayout();
            this.listBox2contextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.ContextMenuStrip = this.listBox1contextMenu;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 26);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(648, 95);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listBox1contextMenu
            // 
            this.listBox1contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listBox1DeleteToolStripMenuItem1});
            this.listBox1contextMenu.Name = "contextMenuStrip1";
            this.listBox1contextMenu.Size = new System.Drawing.Size(102, 26);
            // 
            // listBox1DeleteToolStripMenuItem1
            // 
            this.listBox1DeleteToolStripMenuItem1.Name = "listBox1DeleteToolStripMenuItem1";
            this.listBox1DeleteToolStripMenuItem1.Size = new System.Drawing.Size(101, 22);
            this.listBox1DeleteToolStripMenuItem1.Text = "Usuń";
            this.listBox1DeleteToolStripMenuItem1.Click += new System.EventHandler(this.listBox1DeleteToolStripMenuItem_Click);
            // 
            // listBox2
            // 
            this.listBox2.ContextMenuStrip = this.listBox2contextMenu;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(12, 129);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(147, 290);
            this.listBox2.TabIndex = 1;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            this.listBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBox2_MouseDown);
            // 
            // listBox2contextMenu
            // 
            this.listBox2contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listBox2DeleteToolStripMenuItem});
            this.listBox2contextMenu.Name = "listBox2contextMenu";
            this.listBox2contextMenu.Size = new System.Drawing.Size(102, 26);
            // 
            // listBox2DeleteToolStripMenuItem
            // 
            this.listBox2DeleteToolStripMenuItem.Name = "listBox2DeleteToolStripMenuItem";
            this.listBox2DeleteToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.listBox2DeleteToolStripMenuItem.Text = "Usuń";
            this.listBox2DeleteToolStripMenuItem.Click += new System.EventHandler(this.listBox2DeleteToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(686, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Wypełnij";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(686, 65);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Wyczyść";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(425, 184);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(235, 235);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(422, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Zaznaczone elementy";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Zaznaczony element";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(169, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.listBox1contextMenu.ResumeLayout(false);
            this.listBox2contextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ContextMenuStrip listBox2contextMenu;
        private System.Windows.Forms.ToolStripMenuItem listBox2DeleteToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip listBox1contextMenu;
        private System.Windows.Forms.ToolStripMenuItem listBox1DeleteToolStripMenuItem1;
    }
}

