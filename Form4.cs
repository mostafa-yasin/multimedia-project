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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        int[,] DCT = new int[2, 2];
        private void btnDCT_Click(object sender, EventArgs e)
        {
            int m = 2, n = 2;
            int[,] num = new int[m, n];
            num[0, 0] = Convert.ToInt32(txtFirstElement.Text);
            num[0, 1] = Convert.ToInt32(txtSecondElement.Text);
            num[1, 0] = Convert.ToInt32(txtThirdElement.Text);
            num[1, 1] = Convert.ToInt32(txtFourthElement.Text);

            double Cu = 1, Cv = 1;
            double calc = 0;

            for (int u = 0; u < m; u++)
            {
                for (int v = 0; v < n; v++)
                {
                    if (u == 0)
                        Cu = Math.Sqrt(2) / 2;
                    else
                        Cu = 1;

                    if (v == 0)
                        Cv = Math.Sqrt(2) / 2;
                    else
                        Cv = 1;

                    calc = (2 * Cu * Cv) / Math.Sqrt(4);

                    double[,] sum = new double[m, n];
                    double cosin1 = 0;
                    double cosin2 = 0;

                    for (int i = 0; i < 2; i++)
                    {
                        for (int j = 0; j < 2; j++)
                        {
                            cosin1 = Math.Cos((2 * i + 1) * u * (Math.PI) / (2 * m));
                            cosin2 = Math.Cos((2 * j + 1) * v * (Math.PI) / (2 * n));
                            sum[i, j] = cosin1 * cosin2 * num[i, j];
                        }
                    }
                    double s = 0;
                    for (int x = 0; x < m; x++)
                    {
                        for (int y = 0; y < n; y++)
                        {
                            s += sum[x, y];
                        }
                    }
                    DCT[u, v] = Convert.ToInt32((calc * s));
                    s = 0;
                }
            }
            txtDCTFirstElement.Text = DCT[0, 0].ToString();
            txtDCTSecondElement.Text = DCT[0, 1].ToString();
            txtDCTThirdElement.Text = DCT[1, 0].ToString();
            txtDCTFourthElement.Text = DCT[1, 1].ToString();
        }

        private void btnIDCT_Click(object sender, EventArgs e)
        {
            int m = 2, n = 2;
            int[,] num = new int[m, n];
            
            num = DCT;
            
            double Cu = 1, Cv = 1;
            int[,] IDCT = new int[2, 2];
            double calc = 0;
            double cosin1 = 0;
            double cosin2 = 0;
            int u = 0, v = 0;

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {

                    double[,] sum = new double[m, n];

                    for (u = 0; u < m; u++)
                    {
                        for (v = 0; v < n; v++)
                        {
                            if (u == 0)
                                Cu = Math.Sqrt(2) / 2;
                            else
                                Cu = 1;

                            if (v == 0)
                                Cv = Math.Sqrt(2) / 2;
                            else
                                Cv = 1;

                            calc = (2 * Cu * Cv) / Math.Sqrt(4);

                            cosin1 = Math.Cos((2 * i + 1) * u * (Math.PI) / (2 * m));
                            cosin2 = Math.Cos((2 * j + 1) * v * (Math.PI) / (2 * n));
                            sum[u, v] = calc * cosin1 * cosin2 * num[u, v];
                        }
                        //sum[i, j] = calc * cosin1 * cosin2 * num[u, v];
                    }
                    double s = 0;
                    for (int x = 0; x < m; x++)
                    {
                        for (int y = 0; y < n; y++)
                        {
                            s += sum[x, y];
                        }
                    }
                    IDCT[i, j] = Convert.ToInt32(s);
                    s = 0;
                }
            }

            txtIDCTFirstElement.Text = IDCT[0, 0].ToString();
            txtIDCTSecondElement.Text = IDCT[0, 1].ToString();
            txtIDCTThirdElement.Text = IDCT[1, 0].ToString();
            txtIDCTFourthElement.Text = IDCT[1, 1].ToString();
        }
    }
}
