namespace WindowsFormsApplication1
{
    partial class Form3
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
            this.txt_decode = new System.Windows.Forms.TextBox();
            this.btn_decode = new System.Windows.Forms.Button();
            this.txt_encode = new System.Windows.Forms.TextBox();
            this.btn_encode = new System.Windows.Forms.Button();
            this.screen_text = new System.Windows.Forms.RichTextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.screen2 = new System.Windows.Forms.RichTextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_decode
            // 
            this.txt_decode.Location = new System.Drawing.Point(9, 211);
            this.txt_decode.Name = "txt_decode";
            this.txt_decode.Size = new System.Drawing.Size(242, 20);
            this.txt_decode.TabIndex = 9;
            this.txt_decode.Text = "11010111";
            this.txt_decode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_decode
            // 
            this.btn_decode.Location = new System.Drawing.Point(93, 243);
            this.btn_decode.Name = "btn_decode";
            this.btn_decode.Size = new System.Drawing.Size(75, 23);
            this.btn_decode.TabIndex = 8;
            this.btn_decode.Text = "Decode";
            this.btn_decode.UseVisualStyleBackColor = true;
            this.btn_decode.Click += new System.EventHandler(this.btn_decode_Click);
            // 
            // txt_encode
            // 
            this.txt_encode.Location = new System.Drawing.Point(9, 144);
            this.txt_encode.Name = "txt_encode";
            this.txt_encode.Size = new System.Drawing.Size(242, 20);
            this.txt_encode.TabIndex = 7;
            this.txt_encode.Text = "eebbeecdebeeebecceeeddebbbeceedebeeddeeeecceeeedeeedeeebeedeceedebeeedeceeedebee";
            this.txt_encode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_encode
            // 
            this.btn_encode.Location = new System.Drawing.Point(93, 176);
            this.btn_encode.Name = "btn_encode";
            this.btn_encode.Size = new System.Drawing.Size(75, 23);
            this.btn_encode.TabIndex = 6;
            this.btn_encode.Text = "Encode";
            this.btn_encode.UseVisualStyleBackColor = true;
            this.btn_encode.Click += new System.EventHandler(this.btn_encode_Click);
            // 
            // screen_text
            // 
            this.screen_text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.screen_text.Location = new System.Drawing.Point(3, 3);
            this.screen_text.Name = "screen_text";
            this.screen_text.Size = new System.Drawing.Size(615, 407);
            this.screen_text.TabIndex = 4;
            this.screen_text.Text = "";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(257, -2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(629, 439);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.screen_text);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(621, 413);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Encode";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.screen2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(621, 413);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Decode";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // screen2
            // 
            this.screen2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.screen2.Location = new System.Drawing.Point(3, 3);
            this.screen2.Name = "screen2";
            this.screen2.Size = new System.Drawing.Size(615, 407);
            this.screen2.TabIndex = 5;
            this.screen2.Text = "";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 435);
            this.Controls.Add(this.txt_decode);
            this.Controls.Add(this.btn_decode);
            this.Controls.Add(this.txt_encode);
            this.Controls.Add(this.btn_encode);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form3";
            this.Text = "Huffman coding";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_decode;
        private System.Windows.Forms.Button btn_decode;
        private System.Windows.Forms.TextBox txt_encode;
        private System.Windows.Forms.Button btn_encode;
        private System.Windows.Forms.RichTextBox screen_text;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox screen2;
    }
}