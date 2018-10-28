using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRLC_Click(object sender, EventArgs e)
        {
            string origin = "";
            //Console.Write("enter the string code: ");
            origin = txtOriginal.Text;

            //convert string to array of bytes
            byte[] asciiOrigin = Encoding.ASCII.GetBytes(origin);

            byte counter = 1;
            byte j = 1;
            List<byte> encode = new List<byte>();

            encode.Add(counter);
            encode.Add(asciiOrigin[0]);

            for (int i = 1; i < asciiOrigin.Length; i++)
            {
                if (asciiOrigin[i] == encode[j])
                    encode[j - 1] = ++counter;

                else
                {
                    counter = 1;
                    encode.Add(counter);
                    encode.Add(asciiOrigin[i]);
                    j += 2;
                }

            }
            for (int i = 0; i < encode.Count; i++)
            {
                if (encode[i] == 32)
                    //Console.WriteLine("SPACE");
                    txtRLCCompressed.Text += "space ";
                if (encode[i] < 65 && encode[i] != 32 && (encode[i] >= 57 || encode[i] <= 48))
                    //Console.Write(encode[i]);
                    txtRLCCompressed.Text += encode[i];
                else
                    txtRLCCompressed.Text += (Convert.ToChar(encode[i])).ToString() + " ";
                    //Console.Write(Convert.ToChar(encode[i]) + "   ");
            }

           // double CR = (Convert.ToDouble(encode.Count * 8) / Convert.ToDouble(asciiOrigin.Length * 8));

            //Console.WriteLine("the CR = #bits after comp./#bits before comp. = {0} * 8/{1} * 8",
                //encode.Count, asciiOrigin.Length);
            //Console.WriteLine("then, CR = " + CR);
            //Console.ReadLine();

            //Console.WriteLine("-----------\n    decoding    \n--------------");
            // decoding
            for (int i = 0; i < encode.Count; i++)
            {
                for (int y = 0; y < encode[i]; y++)
                {
                    txtRLCDecompressed.Text += (Convert.ToChar(encode[i + 1])).ToString();
                    //Console.Write(Convert.ToChar(encode[i + 1]));
                }
                i++;
            }
        }

        private void btnVRLC_Click(object sender, EventArgs e)
        {
            string origin = "";
            //Console.Write("enter the string code: ");
            origin = txtOriginal.Text;

            byte[] asciiOrigin = Encoding.ASCII.GetBytes(origin);

            List<byte> encode = new List<byte>();

            // sorting the asciiOrigin array descending 
            for (int i = 1; i < asciiOrigin.Length; i++)
            {
                for (int j = 0; j < asciiOrigin.Length - 1; j++)
                {
                    if (asciiOrigin[j + 1] > asciiOrigin[j])
                    {
                        byte temp = asciiOrigin[j];
                        asciiOrigin[j] = asciiOrigin[j + 1];
                        asciiOrigin[j + 1] = temp;
                    }
                }
            }


            int counter = 0;
            byte c = 1;// code 

            List<byte> asciiList = new List<byte>();
            List<byte> counterList = new List<byte>();

            //calculate each element with the number of its appearing in the text
            for (int i = 1; i < asciiOrigin.Length; i++)
            {

                if (asciiOrigin[counter] == asciiOrigin[i])
                    c++;
                else
                {
                    asciiList.Add(asciiOrigin[counter]);
                    counterList.Add(c);

                    c = 2;
                    counter = i + 1;

                    if (i != asciiOrigin.Length - 1)
                        i++;
                }
                if (i == asciiOrigin.Length - 1)
                {
                    asciiList.Add(asciiOrigin[counter - 1]);
                    counterList.Add(c);
                }
            }


            //sorting descending for the counter list
            for (int i = 0; i < counterList.Count; i++)
            {
                for (int j = i + 1; j < counterList.Count - 1; j++)
                {
                    if (counterList[j] > counterList[j + 1])
                    {
                        byte temp = counterList[j + 1];
                        counterList[j + 1] = counterList[j];
                        counterList[j] = temp;
                    }
                }
            }


            string[] arr = new string[counterList.Count];
            arr[0] = "0";

            for (int i = 1; i < counterList.Count; i++)
            {
                // if this is the last element its code should be ones without zeros
                if (i == counterList.Count - 1)
                {

                    arr[i] = "";
                    int count = arr[i - 1].Length;
                    for (int j = 0; j < count; j++)
                    {
                        arr[i] += "1";
                    }
                }
                // add one to the code
                else
                    arr[i] = "1" + arr[i - 1];
            }

            // cast from array of ascii to array of chars
            byte[] castingArr = new byte[asciiList.Count];
            for (int i = 0; i < asciiList.Count; i++)
                castingArr[i] = asciiList[i];
            char[] chars = Encoding.ASCII.GetChars(castingArr);


            // add the charachter as value & its code as it key to the dictionary
            Dictionary<string, char> dict = new Dictionary<string, char>();
            for (int i = 0; i < chars.Length; i++)
            {
                // starting chars from the last element because it is sorting descending, unlike arr which is sorted ascending
                dict.Add(arr[i], chars[(chars.Length - 1) - i]);
            }

            //output the dictionary===> each character and its code
            foreach (KeyValuePair<string, char> KV in dict)
            {
                lstCode.Items.Add(KV.Key);
                lstElement.Items.Add(KV.Value);
                
              //  Console.WriteLine("{0} => {1}", KV.Key, KV.Value);
            }

            // printing the code string
            List<string> codeString = new List<string>();

            int index = chars.Length - 1;
            for (int i = 0; i < origin.Length; i++)
            {
                foreach (KeyValuePair<string, char> pair in dict)
                {
                    if (origin[i] == pair.Value)
                    {
                        codeString.Add(pair.Key);
                        txtVRLCCompressed.Text += pair.Key + " ";
                        //Console.Write(pair.Key + "   ");
                        break;
                    }
                }
            }

            //int sumCodes = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    sumCodes += arr[i].Length * counterList[(arr.Length - 1) - i];
            //}
           // Console.WriteLine("the length = {0}", sumCodes);
           // Console.WriteLine("The CR = {0}", (double)(sumCodes) / origin.Length);
           // Console.ReadLine();


            //decoding
            Console.WriteLine("-------------\ndecoding\n------------------");
            for (int i = 0; i < codeString.Count; i++)
            {
                foreach (KeyValuePair<string, char> pair in dict)
                {
                    if (codeString[i] == pair.Key)
                    {
                        txtVRLCDecompressed.Text += pair.Value + " ";
                        //Console.Write(pair.Value + "   ");
                        break;
                    }
                }
            }

            asciiList.Clear();
            counterList.Clear();
            codeString.Clear();
            dict.Clear();
            counter = 0;
            c = 1;

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtOriginal.Clear();
            txtRLCCompressed.Clear();
            txtRLCDecompressed.Clear();
            txtVRLCCompressed.Clear();
            txtVRLCDecompressed.Clear();
            txtLZWDecompressed.Clear();

            lstCode.Items.Clear();
            lstElement.Items.Clear();
            lstS.Items.Clear();
            lstLZWCode.Items.Clear();
            lstOutput.Items.Clear();
            lstString.Items.Clear();
            
            LZWdict.Clear();
            
        }

        List<string> LZWdict = new List<string>();
        List<string> LZWOutput = new List<string>();
        List<string> LzwDecode = new List<string>();
           
                      
        private void btnLZW_Click(object sender, EventArgs e)
        {
            string origin = "";
            //Console.Write("enter the code: ");
            origin = txtOriginal.Text;
            int lastDictIndex = -1;

            for (int i = 0; i < origin.Length; i++)
            {
                if (!LZWdict.Contains(Convert.ToString(origin[i])))
                {
                    LZWdict.Add(Convert.ToString(origin[i]));
                    lastDictIndex++;
                }
            }
            //Console.WriteLine("\n-------\nDictionary\n---------------------------\ncode\t\tString");

            for (int i = 0; i < LZWdict.Count; i++)
            {
                lstLZWCode.Items.Add(i);
                lstString.Items.Add(LZWdict[i]);
                lstOutput.Items.Add("  ");
                lstS.Items.Add("  ");
                //Console.WriteLine(i + " \t==>\t" + dict[i]);
            }

            lstString.Items.Add("__");
            lstLZWCode.Items.Add("__");
            lstOutput.Items.Add("__");
            lstS.Items.Add("__");
            
            //Console.WriteLine("\n-------\nOutPut  \tS\n---------------------------");
            string s = origin[0].ToString();
            int counter = 0;
            byte x = 1;
            while (x < origin.Length)
            {
                string c = origin[x].ToString();

                if (LZWdict.Contains(s + c))
                    s = s + c;
                else
                {
                    for (int i = 0; i < LZWdict.Count; i++)
                        if (s == LZWdict[i])
                        {
                            lstOutput.Items.Add(i);
                            lstS.Items.Add(LZWdict[i]);
                            //Console.WriteLine(i + " \t==>\t" + dict[i]);
                            LZWOutput.Add(LZWdict[i]);
                        }
                    counter++;//for output number
                    LZWdict.Add(s + c);
                    s = c;

                }
                x++;
            }
            for (int i = 0; i < LZWdict.Count; i++)
                if (s == LZWdict[i])
                {
                    lstOutput.Items.Add(i);
                    lstS.Items.Add(LZWdict[i]);
                    //Console.WriteLine(i + " \t==>\t" + dict[i]);
                    LZWOutput.Add(LZWdict[i]);

                }
            counter++;
            //Console.WriteLine("------------------");
            //Console.WriteLine(lastDictIndex);
            //Console.WriteLine("the CR = {0}", Convert.ToDouble(counter) / Convert.ToDouble(origin.Length));

            Console.WriteLine("------------------");
            // decoding
            s = null;
            counter = 0;
            x = 0;
            int k = 0;
            string entry = null;
            //Console.WriteLine(entry);
            while (x < LZWOutput.Count)
            {
                k = LZWOutput.IndexOf(LZWOutput[x]);
                entry = LZWOutput[x];
                if (entry == null)
                    entry = s + s[0];

                // Console.Write(entry + " ");
                txtLZWDecompressed.Text += entry + " ";

                if (s != null)
                    LzwDecode.Add(s + entry[0]);
                s = entry;
                x++;
            }

            //for a new calculation to a new string back variables to their initial values
            entry = null;
            s = null;
            x = 0;
            k = 0;
            
        }

        private void btnGoTOArithmetic_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();

        }

        private void btnGotoHuffman_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void btnGoTODCT_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
        }

        private void btnGoTOAdptiveHuffman_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
        }

       
        

      
    }
}
