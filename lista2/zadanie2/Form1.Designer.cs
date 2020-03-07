namespace zadanie2
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
            this.textArg1 = new System.Windows.Forms.TextBox();
            this.textArg2 = new System.Windows.Forms.TextBox();
            this.radioAdd = new System.Windows.Forms.RadioButton();
            this.radioSub = new System.Windows.Forms.RadioButton();
            this.radioDiv = new System.Windows.Forms.RadioButton();
            this.radioMul = new System.Windows.Forms.RadioButton();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.operatorBox = new System.Windows.Forms.GroupBox();
            this.operatorBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // textArg1
            // 
            this.textArg1.Location = new System.Drawing.Point(12, 12);
            this.textArg1.Name = "textArg1";
            this.textArg1.Size = new System.Drawing.Size(100, 20);
            this.textArg1.TabIndex = 0;
            // 
            // textArg2
            // 
            this.textArg2.Location = new System.Drawing.Point(12, 103);
            this.textArg2.Name = "textArg2";
            this.textArg2.Size = new System.Drawing.Size(100, 20);
            this.textArg2.TabIndex = 1;
            // 
            // radioAdd
            // 
            this.radioAdd.AutoSize = true;
            this.radioAdd.Location = new System.Drawing.Point(9, 19);
            this.radioAdd.Name = "radioAdd";
            this.radioAdd.Size = new System.Drawing.Size(31, 17);
            this.radioAdd.TabIndex = 2;
            this.radioAdd.TabStop = true;
            this.radioAdd.Text = "+";
            this.radioAdd.UseVisualStyleBackColor = true;
            this.radioAdd.CheckedChanged += new System.EventHandler(this.radioAdd_CheckedChanged);
            // 
            // radioSub
            // 
            this.radioSub.AutoSize = true;
            this.radioSub.Location = new System.Drawing.Point(46, 19);
            this.radioSub.Name = "radioSub";
            this.radioSub.Size = new System.Drawing.Size(28, 17);
            this.radioSub.TabIndex = 3;
            this.radioSub.TabStop = true;
            this.radioSub.Text = "-";
            this.radioSub.UseVisualStyleBackColor = true;
            this.radioSub.CheckedChanged += new System.EventHandler(this.radioSub_CheckedChanged);
            // 
            // radioDiv
            // 
            this.radioDiv.AutoSize = true;
            this.radioDiv.Location = new System.Drawing.Point(44, 42);
            this.radioDiv.Name = "radioDiv";
            this.radioDiv.Size = new System.Drawing.Size(30, 17);
            this.radioDiv.TabIndex = 5;
            this.radioDiv.TabStop = true;
            this.radioDiv.Text = "/";
            this.radioDiv.UseVisualStyleBackColor = true;
            this.radioDiv.CheckedChanged += new System.EventHandler(this.radioDiv_CheckedChanged);
            // 
            // radioMul
            // 
            this.radioMul.AutoSize = true;
            this.radioMul.Location = new System.Drawing.Point(9, 42);
            this.radioMul.Name = "radioMul";
            this.radioMul.Size = new System.Drawing.Size(29, 17);
            this.radioMul.TabIndex = 4;
            this.radioMul.TabStop = true;
            this.radioMul.Text = "*";
            this.radioMul.UseVisualStyleBackColor = true;
            this.radioMul.CheckedChanged += new System.EventHandler(this.radioMul_CheckedChanged);
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(12, 129);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(75, 23);
            this.buttonCalculate.TabIndex = 6;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelResult.Location = new System.Drawing.Point(12, 155);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(55, 20);
            this.labelResult.TabIndex = 7;
            this.labelResult.Text = "Result";
            // 
            // operatorBox
            // 
            this.operatorBox.Controls.Add(this.radioDiv);
            this.operatorBox.Controls.Add(this.radioAdd);
            this.operatorBox.Controls.Add(this.radioSub);
            this.operatorBox.Controls.Add(this.radioMul);
            this.operatorBox.Location = new System.Drawing.Point(12, 38);
            this.operatorBox.Name = "operatorBox";
            this.operatorBox.Size = new System.Drawing.Size(78, 64);
            this.operatorBox.TabIndex = 8;
            this.operatorBox.TabStop = false;
            this.operatorBox.Text = "Operator";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(192, 191);
            this.Controls.Add(this.operatorBox);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.textArg2);
            this.Controls.Add(this.textArg1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.operatorBox.ResumeLayout(false);
            this.operatorBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textArg1;
        private System.Windows.Forms.TextBox textArg2;
        private System.Windows.Forms.RadioButton radioAdd;
        private System.Windows.Forms.RadioButton radioSub;
        private System.Windows.Forms.RadioButton radioDiv;
        private System.Windows.Forms.RadioButton radioMul;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.GroupBox operatorBox;
    }
}

