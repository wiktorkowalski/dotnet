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
            this.multiSelectListBox = new System.Windows.Forms.ListBox();
            this.listBox1contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.listBox1DeleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.singleSelectListBox = new System.Windows.Forms.ListBox();
            this.listBox2contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.listBox2DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.populateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.selectedItemsTextBox = new System.Windows.Forms.RichTextBox();
            this.selectedItemLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.newItemTextBox = new System.Windows.Forms.TextBox();
            this.addToListBoxButton = new System.Windows.Forms.Button();
            this.listBox1contextMenu.SuspendLayout();
            this.listBox2contextMenu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // multiSelectListBox
            // 
            this.multiSelectListBox.ContextMenuStrip = this.listBox1contextMenu;
            this.multiSelectListBox.FormattingEnabled = true;
            this.multiSelectListBox.Location = new System.Drawing.Point(6, 22);
            this.multiSelectListBox.Name = "multiSelectListBox";
            this.multiSelectListBox.Size = new System.Drawing.Size(172, 277);
            this.multiSelectListBox.TabIndex = 0;
            this.multiSelectListBox.SelectedIndexChanged += new System.EventHandler(this.multiSelectListBox_SelectedIndexChanged);
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
            this.listBox1DeleteToolStripMenuItem1.Click += new System.EventHandler(this.multiSelectListBoxDeleteToolStripMenuItem_Click);
            // 
            // singleSelectListBox
            // 
            this.singleSelectListBox.AllowDrop = true;
            this.singleSelectListBox.ContextMenuStrip = this.listBox2contextMenu;
            this.singleSelectListBox.FormattingEnabled = true;
            this.singleSelectListBox.Location = new System.Drawing.Point(6, 19);
            this.singleSelectListBox.Name = "singleSelectListBox";
            this.singleSelectListBox.Size = new System.Drawing.Size(173, 290);
            this.singleSelectListBox.TabIndex = 1;
            this.singleSelectListBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.singleSelectListBox_DragDrop);
            this.singleSelectListBox.DragOver += new System.Windows.Forms.DragEventHandler(this.singleSelectListBox_DragOver);
            this.singleSelectListBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBox2_MouseDown);
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
            // populateButton
            // 
            this.populateButton.Location = new System.Drawing.Point(12, 12);
            this.populateButton.Name = "populateButton";
            this.populateButton.Size = new System.Drawing.Size(75, 23);
            this.populateButton.TabIndex = 3;
            this.populateButton.Text = "Wypełnij";
            this.populateButton.UseVisualStyleBackColor = true;
            this.populateButton.Click += new System.EventHandler(this.populateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(12, 41);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "Wyczyść";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // selectedItemsTextBox
            // 
            this.selectedItemsTextBox.Location = new System.Drawing.Point(184, 38);
            this.selectedItemsTextBox.Name = "selectedItemsTextBox";
            this.selectedItemsTextBox.ReadOnly = true;
            this.selectedItemsTextBox.Size = new System.Drawing.Size(163, 261);
            this.selectedItemsTextBox.TabIndex = 6;
            this.selectedItemsTextBox.Text = "";
            // 
            // selectedItemLabel
            // 
            this.selectedItemLabel.AutoSize = true;
            this.selectedItemLabel.Location = new System.Drawing.Point(185, 29);
            this.selectedItemLabel.Name = "selectedItemLabel";
            this.selectedItemLabel.Size = new System.Drawing.Size(101, 13);
            this.selectedItemLabel.TabIndex = 9;
            this.selectedItemLabel.Text = "<Wybrany element>";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.multiSelectListBox);
            this.groupBox1.Controls.Add(this.selectedItemsTextBox);
            this.groupBox1.Location = new System.Drawing.Point(435, 132);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 306);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ListBox wielokrotny wybór";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(184, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Zazaczone elementy";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.singleSelectListBox);
            this.groupBox2.Controls.Add(this.selectedItemLabel);
            this.groupBox2.Location = new System.Drawing.Point(12, 132);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(320, 316);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ListBox pojedynczy wybór";
            // 
            // newItemTextBox
            // 
            this.newItemTextBox.Location = new System.Drawing.Point(185, 17);
            this.newItemTextBox.Name = "newItemTextBox";
            this.newItemTextBox.Size = new System.Drawing.Size(215, 20);
            this.newItemTextBox.TabIndex = 12;
            // 
            // addToListBoxButton
            // 
            this.addToListBoxButton.Location = new System.Drawing.Point(406, 15);
            this.addToListBoxButton.Name = "addToListBoxButton";
            this.addToListBoxButton.Size = new System.Drawing.Size(133, 23);
            this.addToListBoxButton.TabIndex = 13;
            this.addToListBoxButton.Text = "Dodaj do list";
            this.addToListBoxButton.UseVisualStyleBackColor = true;
            this.addToListBoxButton.Click += new System.EventHandler(this.addToListBoxButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addToListBoxButton);
            this.Controls.Add(this.newItemTextBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.populateButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.listBox1contextMenu.ResumeLayout(false);
            this.listBox2contextMenu.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox multiSelectListBox;
        private System.Windows.Forms.ListBox singleSelectListBox;
        private System.Windows.Forms.Button populateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.RichTextBox selectedItemsTextBox;
        private System.Windows.Forms.Label selectedItemLabel;
        private System.Windows.Forms.ContextMenuStrip listBox2contextMenu;
        private System.Windows.Forms.ToolStripMenuItem listBox2DeleteToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip listBox1contextMenu;
        private System.Windows.Forms.ToolStripMenuItem listBox1DeleteToolStripMenuItem1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox newItemTextBox;
        private System.Windows.Forms.Button addToListBoxButton;
    }
}

