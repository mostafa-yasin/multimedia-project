namespace WindowsFormsApplication1
{
    partial class Form5
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
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.decode_txt = new System.Windows.Forms.TextBox();
            this.btn_decode = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.rich_output_txt = new System.Windows.Forms.RichTextBox();
            this.list_output = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.list_code_result = new System.Windows.Forms.ListBox();
            this.list_symbole_result = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.list_code = new System.Windows.Forms.ListBox();
            this.list_symbole = new System.Windows.Forms.ListBox();
            this.btn_plus = new System.Windows.Forms.Button();
            this.btn_submit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_code = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_symbole = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_input = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label10.Location = new System.Drawing.Point(122, 327);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 24);
            this.label10.TabIndex = 45;
            this.label10.Text = "Initial Code";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label9.Location = new System.Drawing.Point(423, 363);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 24);
            this.label9.TabIndex = 44;
            this.label9.Text = "Decode String";
            // 
            // decode_txt
            // 
            this.decode_txt.Location = new System.Drawing.Point(363, 395);
            this.decode_txt.Name = "decode_txt";
            this.decode_txt.Size = new System.Drawing.Size(248, 20);
            this.decode_txt.TabIndex = 43;
            this.decode_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_decode
            // 
            this.btn_decode.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btn_decode.Location = new System.Drawing.Point(118, 474);
            this.btn_decode.Name = "btn_decode";
            this.btn_decode.Size = new System.Drawing.Size(100, 23);
            this.btn_decode.TabIndex = 42;
            this.btn_decode.Text = "Decode";
            this.btn_decode.UseVisualStyleBackColor = true;
            this.btn_decode.Click += new System.EventHandler(this.btn_decode_Click);
            // 
            // listBox2
            // 
            this.listBox2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Items.AddRange(new object[] {
            "0",
            "00001",
            "00010",
            "00011",
            "00100"});
            this.listBox2.Location = new System.Drawing.Point(193, 357);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(62, 100);
            this.listBox2.TabIndex = 41;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "new",
            "A",
            "B",
            "C",
            "D"});
            this.listBox1.Location = new System.Drawing.Point(80, 357);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(62, 100);
            this.listBox1.TabIndex = 40;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label8.Location = new System.Drawing.Point(685, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 24);
            this.label8.TabIndex = 39;
            this.label8.Text = "Trace";
            // 
            // rich_output_txt
            // 
            this.rich_output_txt.Location = new System.Drawing.Point(397, 13);
            this.rich_output_txt.Name = "rich_output_txt";
            this.rich_output_txt.Size = new System.Drawing.Size(363, 57);
            this.rich_output_txt.TabIndex = 38;
            this.rich_output_txt.Text = "";
            // 
            // list_output
            // 
            this.list_output.Font = new System.Drawing.Font("Tahoma", 10F);
            this.list_output.FormattingEnabled = true;
            this.list_output.ItemHeight = 16;
            this.list_output.Location = new System.Drawing.Point(674, 111);
            this.list_output.Name = "list_output";
            this.list_output.Size = new System.Drawing.Size(80, 196);
            this.list_output.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label7.Location = new System.Drawing.Point(457, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 24);
            this.label7.TabIndex = 37;
            this.label7.Text = "Result Table";
            // 
            // list_code_result
            // 
            this.list_code_result.Font = new System.Drawing.Font("Tahoma", 10F);
            this.list_code_result.FormattingEnabled = true;
            this.list_code_result.ItemHeight = 16;
            this.list_code_result.Location = new System.Drawing.Point(528, 111);
            this.list_code_result.Name = "list_code_result";
            this.list_code_result.Size = new System.Drawing.Size(104, 196);
            this.list_code_result.TabIndex = 35;
            // 
            // list_symbole_result
            // 
            this.list_symbole_result.Font = new System.Drawing.Font("Tahoma", 10F);
            this.list_symbole_result.FormattingEnabled = true;
            this.list_symbole_result.ItemHeight = 16;
            this.list_symbole_result.Location = new System.Drawing.Point(427, 111);
            this.list_symbole_result.Name = "list_symbole_result";
            this.list_symbole_result.Size = new System.Drawing.Size(95, 196);
            this.list_symbole_result.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label6.Location = new System.Drawing.Point(190, 310);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(388, 17);
            this.label6.TabIndex = 33;
            this.label6.Text = "----------------------------------------------------------------------------";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.button1.Location = new System.Drawing.Point(118, 187);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 28);
            this.button1.TabIndex = 29;
            this.button1.Text = "Empty Tables";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // list_code
            // 
            this.list_code.Font = new System.Drawing.Font("Tahoma", 10F);
            this.list_code.FormattingEnabled = true;
            this.list_code.ItemHeight = 16;
            this.list_code.Items.AddRange(new object[] {
            "0",
            "00001",
            "00010",
            "00011",
            "00100"});
            this.list_code.Location = new System.Drawing.Point(206, 93);
            this.list_code.Name = "list_code";
            this.list_code.Size = new System.Drawing.Size(62, 84);
            this.list_code.TabIndex = 27;
            // 
            // list_symbole
            // 
            this.list_symbole.Font = new System.Drawing.Font("Tahoma", 10F);
            this.list_symbole.FormattingEnabled = true;
            this.list_symbole.ItemHeight = 16;
            this.list_symbole.Items.AddRange(new object[] {
            "new",
            "A",
            "B",
            "C",
            "D"});
            this.list_symbole.Location = new System.Drawing.Point(80, 93);
            this.list_symbole.Name = "list_symbole";
            this.list_symbole.Size = new System.Drawing.Size(62, 84);
            this.list_symbole.TabIndex = 26;
            // 
            // btn_plus
            // 
            this.btn_plus.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btn_plus.Location = new System.Drawing.Point(281, 55);
            this.btn_plus.Name = "btn_plus";
            this.btn_plus.Size = new System.Drawing.Size(46, 23);
            this.btn_plus.TabIndex = 24;
            this.btn_plus.Text = "+";
            this.btn_plus.UseVisualStyleBackColor = true;
            this.btn_plus.Click += new System.EventHandler(this.btn_plus_Click);
            // 
            // btn_submit
            // 
            this.btn_submit.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btn_submit.Location = new System.Drawing.Point(273, 267);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(100, 23);
            this.btn_submit.TabIndex = 32;
            this.btn_submit.Text = "Encode";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label5.Location = new System.Drawing.Point(156, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 17);
            this.label5.TabIndex = 31;
            this.label5.Text = "Code";
            // 
            // txt_code
            // 
            this.txt_code.Location = new System.Drawing.Point(206, 57);
            this.txt_code.Name = "txt_code";
            this.txt_code.Size = new System.Drawing.Size(62, 20);
            this.txt_code.TabIndex = 21;
            this.txt_code.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label4.Location = new System.Drawing.Point(12, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 28;
            this.label4.Text = "Symbole";
            // 
            // txt_symbole
            // 
            this.txt_symbole.Location = new System.Drawing.Point(80, 56);
            this.txt_symbole.Name = "txt_symbole";
            this.txt_symbole.Size = new System.Drawing.Size(62, 20);
            this.txt_symbole.TabIndex = 20;
            this.txt_symbole.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label3.Location = new System.Drawing.Point(122, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 24);
            this.label3.TabIndex = 25;
            this.label3.Text = "Initial Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label2.Location = new System.Drawing.Point(3, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(388, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "----------------------------------------------------------------------------";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label1.Location = new System.Drawing.Point(90, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 24);
            this.label1.TabIndex = 22;
            this.label1.Text = "Enter Input String";
            // 
            // txt_input
            // 
            this.txt_input.Location = new System.Drawing.Point(10, 270);
            this.txt_input.Name = "txt_input";
            this.txt_input.Size = new System.Drawing.Size(248, 20);
            this.txt_input.TabIndex = 30;
            this.txt_input.Text = "AADCCDD";
            this.txt_input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 506);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.decode_txt);
            this.Controls.Add(this.btn_decode);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.rich_output_txt);
            this.Controls.Add(this.list_output);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.list_code_result);
            this.Controls.Add(this.list_symbole_result);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.list_code);
            this.Controls.Add(this.list_symbole);
            this.Controls.Add(this.btn_plus);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_code);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_symbole);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_input);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form5";
            this.Text = "Adaptive Huffman Coding";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox decode_txt;
        private System.Windows.Forms.Button btn_decode;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox rich_output_txt;
        private System.Windows.Forms.ListBox list_output;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox list_code_result;
        private System.Windows.Forms.ListBox list_symbole_result;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox list_code;
        private System.Windows.Forms.ListBox list_symbole;
        private System.Windows.Forms.Button btn_plus;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_code;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_symbole;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_input;
    }
}