namespace WindowsFormsApplication1
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
            this.btnGoTOArithmetic = new System.Windows.Forms.Button();
            this.btnLZW = new System.Windows.Forms.Button();
            this.btnVRLC = new System.Windows.Forms.Button();
            this.btnRLC = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lstS = new System.Windows.Forms.ListBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtLZWDecompressed = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lstString = new System.Windows.Forms.ListBox();
            this.lstLZWCode = new System.Windows.Forms.ListBox();
            this.lstOutput = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lstElement = new System.Windows.Forms.ListBox();
            this.lstCode = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtVRLCDecompressed = new System.Windows.Forms.TextBox();
            this.txtVRLCCompressed = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRLCDecompressed = new System.Windows.Forms.TextBox();
            this.txtRLCCompressed = new System.Windows.Forms.TextBox();
            this.txtOriginal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnGotoHuffman = new System.Windows.Forms.Button();
            this.btnGoTODCT = new System.Windows.Forms.Button();
            this.btnGoTOAdptiveHuffman = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGoTOArithmetic
            // 
            this.btnGoTOArithmetic.Location = new System.Drawing.Point(403, 380);
            this.btnGoTOArithmetic.Name = "btnGoTOArithmetic";
            this.btnGoTOArithmetic.Size = new System.Drawing.Size(141, 23);
            this.btnGoTOArithmetic.TabIndex = 19;
            this.btnGoTOArithmetic.Text = "go to Arithmetic";
            this.btnGoTOArithmetic.UseVisualStyleBackColor = true;
            this.btnGoTOArithmetic.Click += new System.EventHandler(this.btnGoTOArithmetic_Click);
            // 
            // btnLZW
            // 
            this.btnLZW.Location = new System.Drawing.Point(623, 22);
            this.btnLZW.Name = "btnLZW";
            this.btnLZW.Size = new System.Drawing.Size(75, 23);
            this.btnLZW.TabIndex = 18;
            this.btnLZW.Text = "LZW";
            this.btnLZW.UseVisualStyleBackColor = true;
            this.btnLZW.Click += new System.EventHandler(this.btnLZW_Click);
            // 
            // btnVRLC
            // 
            this.btnVRLC.Location = new System.Drawing.Point(515, 22);
            this.btnVRLC.Name = "btnVRLC";
            this.btnVRLC.Size = new System.Drawing.Size(75, 23);
            this.btnVRLC.TabIndex = 17;
            this.btnVRLC.Text = "VRLC";
            this.btnVRLC.UseVisualStyleBackColor = true;
            this.btnVRLC.Click += new System.EventHandler(this.btnVRLC_Click);
            // 
            // btnRLC
            // 
            this.btnRLC.Location = new System.Drawing.Point(403, 22);
            this.btnRLC.Name = "btnRLC";
            this.btnRLC.Size = new System.Drawing.Size(75, 23);
            this.btnRLC.TabIndex = 16;
            this.btnRLC.Text = "RLC";
            this.btnRLC.UseVisualStyleBackColor = true;
            this.btnRLC.Click += new System.EventHandler(this.btnRLC_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.lstS);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txtLZWDecompressed);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.lstString);
            this.groupBox3.Controls.Add(this.lstLZWCode);
            this.groupBox3.Controls.Add(this.lstOutput);
            this.groupBox3.Location = new System.Drawing.Point(31, 184);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(357, 299);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "LZW coding";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(66, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(14, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "S";
            // 
            // lstS
            // 
            this.lstS.FormattingEnabled = true;
            this.lstS.Location = new System.Drawing.Point(60, 36);
            this.lstS.Name = "lstS";
            this.lstS.Size = new System.Drawing.Size(42, 212);
            this.lstS.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 256);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "decompressed text";
            // 
            // txtLZWDecompressed
            // 
            this.txtLZWDecompressed.Location = new System.Drawing.Point(108, 256);
            this.txtLZWDecompressed.Name = "txtLZWDecompressed";
            this.txtLZWDecompressed.Size = new System.Drawing.Size(243, 20);
            this.txtLZWDecompressed.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(265, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "string";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(195, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "code";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(121, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "output";
            // 
            // lstString
            // 
            this.lstString.FormattingEnabled = true;
            this.lstString.Location = new System.Drawing.Point(255, 38);
            this.lstString.Name = "lstString";
            this.lstString.Size = new System.Drawing.Size(42, 212);
            this.lstString.TabIndex = 18;
            // 
            // lstLZWCode
            // 
            this.lstLZWCode.FormattingEnabled = true;
            this.lstLZWCode.Location = new System.Drawing.Point(198, 36);
            this.lstLZWCode.Name = "lstLZWCode";
            this.lstLZWCode.Size = new System.Drawing.Size(42, 212);
            this.lstLZWCode.TabIndex = 17;
            // 
            // lstOutput
            // 
            this.lstOutput.FormattingEnabled = true;
            this.lstOutput.Location = new System.Drawing.Point(124, 36);
            this.lstOutput.Name = "lstOutput";
            this.lstOutput.Size = new System.Drawing.Size(42, 212);
            this.lstOutput.TabIndex = 16;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.lstElement);
            this.groupBox2.Controls.Add(this.lstCode);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtVRLCDecompressed);
            this.groupBox2.Controls.Add(this.txtVRLCCompressed);
            this.groupBox2.Location = new System.Drawing.Point(394, 64);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(417, 297);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Variable Run Length Coding";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(357, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "element";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(308, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Code";
            // 
            // lstElement
            // 
            this.lstElement.FormattingEnabled = true;
            this.lstElement.Location = new System.Drawing.Point(359, 32);
            this.lstElement.Name = "lstElement";
            this.lstElement.Size = new System.Drawing.Size(42, 238);
            this.lstElement.TabIndex = 13;
            // 
            // lstCode
            // 
            this.lstCode.FormattingEnabled = true;
            this.lstCode.Location = new System.Drawing.Point(312, 32);
            this.lstCode.Name = "lstCode";
            this.lstCode.Size = new System.Drawing.Size(42, 238);
            this.lstCode.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "decompressed text";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "compressed text";
            // 
            // txtVRLCDecompressed
            // 
            this.txtVRLCDecompressed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVRLCDecompressed.Location = new System.Drawing.Point(106, 82);
            this.txtVRLCDecompressed.Name = "txtVRLCDecompressed";
            this.txtVRLCDecompressed.Size = new System.Drawing.Size(200, 20);
            this.txtVRLCDecompressed.TabIndex = 9;
            // 
            // txtVRLCCompressed
            // 
            this.txtVRLCCompressed.Location = new System.Drawing.Point(106, 41);
            this.txtVRLCCompressed.Name = "txtVRLCCompressed";
            this.txtVRLCCompressed.Size = new System.Drawing.Size(198, 20);
            this.txtVRLCCompressed.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtRLCDecompressed);
            this.groupBox1.Controls.Add(this.txtRLCCompressed);
            this.groupBox1.Location = new System.Drawing.Point(31, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(357, 101);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Run Length Coding";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "decompressed text";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "compressed text";
            // 
            // txtRLCDecompressed
            // 
            this.txtRLCDecompressed.Location = new System.Drawing.Point(108, 60);
            this.txtRLCDecompressed.Name = "txtRLCDecompressed";
            this.txtRLCDecompressed.Size = new System.Drawing.Size(243, 20);
            this.txtRLCDecompressed.TabIndex = 7;
            // 
            // txtRLCCompressed
            // 
            this.txtRLCCompressed.Location = new System.Drawing.Point(108, 19);
            this.txtRLCCompressed.Name = "txtRLCCompressed";
            this.txtRLCCompressed.Size = new System.Drawing.Size(243, 20);
            this.txtRLCCompressed.TabIndex = 6;
            // 
            // txtOriginal
            // 
            this.txtOriginal.Location = new System.Drawing.Point(139, 22);
            this.txtOriginal.Name = "txtOriginal";
            this.txtOriginal.Size = new System.Drawing.Size(243, 20);
            this.txtOriginal.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Original text: ";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(139, 48);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 20;
            this.btnClear.Text = "clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnGotoHuffman
            // 
            this.btnGotoHuffman.Location = new System.Drawing.Point(623, 380);
            this.btnGotoHuffman.Name = "btnGotoHuffman";
            this.btnGotoHuffman.Size = new System.Drawing.Size(141, 23);
            this.btnGotoHuffman.TabIndex = 21;
            this.btnGotoHuffman.Text = "go to Huffman";
            this.btnGotoHuffman.UseVisualStyleBackColor = true;
            this.btnGotoHuffman.Click += new System.EventHandler(this.btnGotoHuffman_Click);
            // 
            // btnGoTODCT
            // 
            this.btnGoTODCT.Location = new System.Drawing.Point(403, 430);
            this.btnGoTODCT.Name = "btnGoTODCT";
            this.btnGoTODCT.Size = new System.Drawing.Size(141, 23);
            this.btnGoTODCT.TabIndex = 22;
            this.btnGoTODCT.Text = "go to DCT";
            this.btnGoTODCT.UseVisualStyleBackColor = true;
            this.btnGoTODCT.Click += new System.EventHandler(this.btnGoTODCT_Click);
            // 
            // btnGoTOAdptiveHuffman
            // 
            this.btnGoTOAdptiveHuffman.Location = new System.Drawing.Point(623, 430);
            this.btnGoTOAdptiveHuffman.Name = "btnGoTOAdptiveHuffman";
            this.btnGoTOAdptiveHuffman.Size = new System.Drawing.Size(141, 23);
            this.btnGoTOAdptiveHuffman.TabIndex = 23;
            this.btnGoTOAdptiveHuffman.Text = "go to Adaptive Huffman";
            this.btnGoTOAdptiveHuffman.UseVisualStyleBackColor = true;
            this.btnGoTOAdptiveHuffman.Click += new System.EventHandler(this.btnGoTOAdptiveHuffman_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 485);
            this.Controls.Add(this.btnGoTOAdptiveHuffman);
            this.Controls.Add(this.btnGoTODCT);
            this.Controls.Add(this.btnGotoHuffman);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnGoTOArithmetic);
            this.Controls.Add(this.btnLZW);
            this.Controls.Add(this.btnVRLC);
            this.Controls.Add(this.btnRLC);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtOriginal);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "RLC & VRLC & LZW";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGoTOArithmetic;
        private System.Windows.Forms.Button btnLZW;
        private System.Windows.Forms.Button btnVRLC;
        private System.Windows.Forms.Button btnRLC;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtVRLCDecompressed;
        private System.Windows.Forms.TextBox txtVRLCCompressed;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRLCDecompressed;
        private System.Windows.Forms.TextBox txtRLCCompressed;
        private System.Windows.Forms.TextBox txtOriginal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lstElement;
        private System.Windows.Forms.ListBox lstCode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ListBox lstOutput;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox lstString;
        private System.Windows.Forms.ListBox lstLZWCode;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtLZWDecompressed;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ListBox lstS;
        private System.Windows.Forms.Button btnGotoHuffman;
        private System.Windows.Forms.Button btnGoTODCT;
        private System.Windows.Forms.Button btnGoTOAdptiveHuffman;
    }
}

