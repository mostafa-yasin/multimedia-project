namespace WindowsFormsApplication1
{
    partial class Form2
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
            this.btnClear = new System.Windows.Forms.Button();
            this.txtOriginal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnArithmetic = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProbs = new System.Windows.Forms.TextBox();
            this.btnAddProbs = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCodeword = new System.Windows.Forms.TextBox();
            this.txtLow = new System.Windows.Forms.TextBox();
            this.txtHigh = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lstRange = new System.Windows.Forms.ListBox();
            this.lstHigh = new System.Windows.Forms.ListBox();
            this.lstLow = new System.Windows.Forms.ListBox();
            this.lstOutputSymbol = new System.Windows.Forms.ListBox();
            this.lstValue = new System.Windows.Forms.ListBox();
            this.btnEnterText = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.Enabled = false;
            this.btnClear.Location = new System.Drawing.Point(123, 47);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 23;
            this.btnClear.Text = "clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtOriginal
            // 
            this.txtOriginal.Location = new System.Drawing.Point(123, 21);
            this.txtOriginal.Name = "txtOriginal";
            this.txtOriginal.Size = new System.Drawing.Size(243, 20);
            this.txtOriginal.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Original text: ";
            // 
            // btnArithmetic
            // 
            this.btnArithmetic.Enabled = false;
            this.btnArithmetic.Location = new System.Drawing.Point(187, 107);
            this.btnArithmetic.Name = "btnArithmetic";
            this.btnArithmetic.Size = new System.Drawing.Size(75, 23);
            this.btnArithmetic.TabIndex = 24;
            this.btnArithmetic.Text = "Arithmetic";
            this.btnArithmetic.UseVisualStyleBackColor = true;
            this.btnArithmetic.Click += new System.EventHandler(this.btnArithmetic_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "probabilities";
            // 
            // txtProbs
            // 
            this.txtProbs.Location = new System.Drawing.Point(123, 80);
            this.txtProbs.Name = "txtProbs";
            this.txtProbs.Size = new System.Drawing.Size(37, 20);
            this.txtProbs.TabIndex = 26;
            // 
            // btnAddProbs
            // 
            this.btnAddProbs.Enabled = false;
            this.btnAddProbs.Location = new System.Drawing.Point(187, 78);
            this.btnAddProbs.Name = "btnAddProbs";
            this.btnAddProbs.Size = new System.Drawing.Size(75, 23);
            this.btnAddProbs.TabIndex = 27;
            this.btnAddProbs.Text = "Add";
            this.btnAddProbs.UseVisualStyleBackColor = true;
            this.btnAddProbs.Click += new System.EventHandler(this.btnAddProbs_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtCodeword);
            this.groupBox1.Controls.Add(this.txtLow);
            this.groupBox1.Controls.Add(this.txtHigh);
            this.groupBox1.Location = new System.Drawing.Point(15, 134);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 167);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Encoding";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "low";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(139, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "high";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Codeword";
            // 
            // txtCodeword
            // 
            this.txtCodeword.Location = new System.Drawing.Point(20, 112);
            this.txtCodeword.Name = "txtCodeword";
            this.txtCodeword.Size = new System.Drawing.Size(229, 20);
            this.txtCodeword.TabIndex = 29;
            // 
            // txtLow
            // 
            this.txtLow.Location = new System.Drawing.Point(35, 44);
            this.txtLow.Name = "txtLow";
            this.txtLow.Size = new System.Drawing.Size(98, 20);
            this.txtLow.TabIndex = 29;
            // 
            // txtHigh
            // 
            this.txtHigh.Location = new System.Drawing.Point(166, 44);
            this.txtHigh.Name = "txtHigh";
            this.txtHigh.Size = new System.Drawing.Size(98, 20);
            this.txtHigh.TabIndex = 30;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.lstRange);
            this.groupBox2.Controls.Add(this.lstHigh);
            this.groupBox2.Controls.Add(this.lstLow);
            this.groupBox2.Controls.Add(this.lstOutputSymbol);
            this.groupBox2.Controls.Add(this.lstValue);
            this.groupBox2.Location = new System.Drawing.Point(322, 134);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(423, 167);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Decoding";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(140, 37);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 13);
            this.label11.TabIndex = 47;
            this.label11.Text = "symbol";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 46;
            this.label10.Text = "Value";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(140, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 45;
            this.label9.Text = "output";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(358, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 44;
            this.label8.Text = "range";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(278, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 42;
            this.label7.Text = "high";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(208, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 43;
            this.label6.Text = "low";
            // 
            // lstRange
            // 
            this.lstRange.FormattingEnabled = true;
            this.lstRange.Location = new System.Drawing.Point(361, 51);
            this.lstRange.Name = "lstRange";
            this.lstRange.Size = new System.Drawing.Size(48, 95);
            this.lstRange.TabIndex = 41;
            // 
            // lstHigh
            // 
            this.lstHigh.FormattingEnabled = true;
            this.lstHigh.Location = new System.Drawing.Point(281, 51);
            this.lstHigh.Name = "lstHigh";
            this.lstHigh.Size = new System.Drawing.Size(48, 95);
            this.lstHigh.TabIndex = 40;
            // 
            // lstLow
            // 
            this.lstLow.FormattingEnabled = true;
            this.lstLow.Location = new System.Drawing.Point(211, 51);
            this.lstLow.Name = "lstLow";
            this.lstLow.Size = new System.Drawing.Size(48, 95);
            this.lstLow.TabIndex = 39;
            // 
            // lstOutputSymbol
            // 
            this.lstOutputSymbol.FormattingEnabled = true;
            this.lstOutputSymbol.Location = new System.Drawing.Point(143, 51);
            this.lstOutputSymbol.Name = "lstOutputSymbol";
            this.lstOutputSymbol.Size = new System.Drawing.Size(48, 95);
            this.lstOutputSymbol.TabIndex = 38;
            // 
            // lstValue
            // 
            this.lstValue.FormattingEnabled = true;
            this.lstValue.Location = new System.Drawing.Point(16, 51);
            this.lstValue.Name = "lstValue";
            this.lstValue.Size = new System.Drawing.Size(111, 95);
            this.lstValue.TabIndex = 37;
            // 
            // btnEnterText
            // 
            this.btnEnterText.Location = new System.Drawing.Point(383, 19);
            this.btnEnterText.Name = "btnEnterText";
            this.btnEnterText.Size = new System.Drawing.Size(75, 23);
            this.btnEnterText.TabIndex = 30;
            this.btnEnterText.Text = "enter text";
            this.btnEnterText.UseVisualStyleBackColor = true;
            this.btnEnterText.Click += new System.EventHandler(this.btnEnterText_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 319);
            this.Controls.Add(this.btnEnterText);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAddProbs);
            this.Controls.Add(this.txtProbs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnArithmetic);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtOriginal);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form2";
            this.Text = "Arithmetic coding";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtOriginal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnArithmetic;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProbs;
        private System.Windows.Forms.Button btnAddProbs;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCodeword;
        private System.Windows.Forms.TextBox txtLow;
        private System.Windows.Forms.TextBox txtHigh;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lstRange;
        private System.Windows.Forms.ListBox lstHigh;
        private System.Windows.Forms.ListBox lstLow;
        private System.Windows.Forms.ListBox lstOutputSymbol;
        private System.Windows.Forms.ListBox lstValue;
        private System.Windows.Forms.Button btnEnterText;
    }
}