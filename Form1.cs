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
        int[] X;
        int[] Y;
        int[] R;
        int[] R2;
        int[] S;

        private int[,] H = { 
                           { 1, 1, 0, 1 }, 
                           { 1, 0, 1, 1 }, 
                           { 0, 1, 1, 1 } 
                           };
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = tbX.Text;
            X = new int[s.Length];
            for (int i = 0; i < X.Length; i++)
                X[i] = tbX.Text[i] - '0';

            int k = X.Length;
            int r = (int)Math.Ceiling(Math.Log(k ,2)) + 1;

            R = new int[r];
            
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < k; j++)
                    R[i] += H[i, j] * X[j];
                R[i] %= 2;

            }
            TabToTextBox(R, tbR);
        }

        private void TabToTextBox(int[] T, TextBox tbT)
        {
            string s = "";
            for (int i = 0; i < T.Length; i++)
            {
                s += T[i];
            }
            tbT.Text = s;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Y = (int[])X.Clone();
            Random r = new Random();
            int n = r.Next(Y.Length);

            Y[n] ^= 1;

            TabToTextBox(Y, tbY);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int k = Y.Length;
            int r = (int)Math.Ceiling(Math.Log(k, 2)) + 1;

            R2 = new int[r];

            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < k; j++)
                    R2[i] += H[i, j] * Y[j];
                R2[i] %= 2;

            }
            TabToTextBox(R2, tbR2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            S = new int[R.Length];
            for (int i = 0; i < 3; i++)
            {
                S[i] = (R[i] + R2[i]) % 2;
            }

            TabToTextBox(S, tbS);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int k = H.GetLength(1);

            for (int j = 0; j < k; j++)
            {
                if (SRownyA(j))
                {
                    MessageBox.Show("Błąd w kolumnie " + (j + 1));
                    return;
                }
            }
            MessageBox.Show("Brak błędu"); 
        }

        private bool SRownyA(int j)
        {
            for (int i = 0; i < S.Length; i++)
            {
                if (S[i] != H[i, j])
                    return false;
            }
            return true;
        }
    }
}
