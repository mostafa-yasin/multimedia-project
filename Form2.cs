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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            
        }

        string origin = " ";// = txtOriginal.Text;
        List<string> dict = new List<string>();
        List<double> probabilities = new List<double>();
        double prob = 0;
        List<double> rangeLow = new List<double>();
        List<double> rangeHigh = new List<double>();
        StringBuilder k = new StringBuilder("1");
  
        int countprobsAddbtnClicks = 0;
        private void btnArithmetic_Click(object sender, EventArgs e)
        {
                double low = 0, high = 0, range = 1;

                int x = 0, index = 0;
                double lowCummulativeProbabilities = 0, highCummulativeProbabilities = 0;

                //   encoder
                while (x != origin.Length)
                {
                    string symbol = Convert.ToString(origin[x]);
                    index = dict.IndexOf(symbol);
                    for (int i = 0; i < index; i++)
                    {
                        lowCummulativeProbabilities += probabilities[i];
                    }
                    highCummulativeProbabilities = lowCummulativeProbabilities + probabilities[index];
                    high = low + range * highCummulativeProbabilities;
                    low = low + range * lowCummulativeProbabilities;

                    rangeLow.Add(lowCummulativeProbabilities);
                    rangeHigh.Add(highCummulativeProbabilities);

                    range = high - low;
                    lowCummulativeProbabilities = highCummulativeProbabilities = 0;
                    x++;

                }

                txtLow.Text = low.ToString();
                txtHigh.Text = high.ToString();

                double code = 0;
                int power = -1;
                while (code < low)
                {
                    for (int i = 0; i < k.Length; i++)
                    {
                        if (Convert.ToInt32(Convert.ToString(k[i])) != 0)
                            code += Math.Pow(2 * Convert.ToInt32(Convert.ToString(k[i])), power);

                        power--;
                    }

                    if (code > high)
                        k[(k.Length - 1)] = '0';

                    if (code > low && code < high)
                        break;

                    k = new StringBuilder(k + "1");

                    code = 0;
                    power = -1;

                }

                txtCodeword.Text = k.ToString();
                power = -1;
                double value = 0;
                
                //decoding
                for (int i = 0; i < k.Length; i++)
                {
                    if (Convert.ToInt32(Convert.ToString(k[i])) != 0)
                        value += Math.Pow(2 * Convert.ToInt32(Convert.ToString(k[i])), power);
                    power--;
                }
 
                x = 0;
                while (x != origin.Length)
                {

                    if (rangeLow[x] <= value && value < rangeHigh[x])
                    {
                        //Console.Write(Convert.ToString(value).Substring(0, 7) + "      " + origin[x] + "         ");
                        lstValue.Items.Add(Convert.ToString(value).Substring(0, 7));
                        lstOutputSymbol.Items.Add(origin[x]);
                    }
                    low = rangeLow[origin.IndexOf(origin[x])];
                    high = rangeHigh[origin.IndexOf(origin[x])];
                    range = high - low;
                    //Console.WriteLine("         " + low + "         " + high + "        " + range);
                    lstLow.Items.Add(low.ToString());
                    lstHigh.Items.Add(high.ToString());
                    lstRange.Items.Add(range.ToString());
                    value = (value - low) / range;
                    x++;
                }
            

        }
        private void btnAddProbs_Click(object sender, EventArgs e)
        {
            prob = Convert.ToDouble(txtProbs.Text);
            probabilities.Add(prob);
            txtProbs.Clear();
            
            countprobsAddbtnClicks++;

            if (countprobsAddbtnClicks == dict.Count)
                btnArithmetic.Enabled = true;
        }

        private void btnEnterText_Click(object sender, EventArgs e)
        {
            origin = txtOriginal.Text;
            byte[] asciiOrigin = Encoding.ASCII.GetBytes(origin);

            //sorting
            for (int i = 1; i < asciiOrigin.Length; i++)
            {
                for (int j = 0; j < asciiOrigin.Length - 1; j++)
                {
                    if (asciiOrigin[j + 1] < asciiOrigin[j])
                    {
                        byte temp = asciiOrigin[j];
                        asciiOrigin[j] = asciiOrigin[j + 1];
                        asciiOrigin[j + 1] = temp;
                    }
                }
            }

            string encodeOrigin = Encoding.ASCII.GetString(asciiOrigin, 0, asciiOrigin.Length);

            for (int i = 0; i < encodeOrigin.Length; i++)
            {
                if (!dict.Contains(Convert.ToString(encodeOrigin[i])))
                    dict.Add(Convert.ToString(encodeOrigin[i]));
            }

            btnClear.Enabled = true;
            btnAddProbs.Enabled = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtOriginal.Clear();
            txtLow.Clear();
            txtHigh.Clear();
            txtProbs.Clear();
            txtCodeword.Clear();
            lstHigh.Items.Clear();
            lstLow.Items.Clear();
            lstOutputSymbol.Items.Clear();
            lstRange.Items.Clear();
            lstValue.Items.Clear();
            dict.Clear();
            rangeLow.Clear();
            rangeHigh.Clear();
            k = new StringBuilder("1");
        }

        

        
    }
}
