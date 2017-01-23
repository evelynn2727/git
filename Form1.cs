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
        int[] X;         //wektor X
        int[] Y;
        int[] R;        //wektor R (kod nadmiarowy)
        int[] R2;
        int[] S;
        int[,] H; //macierz Hemminga

    
        public void Macierz()
        {

            string s = tbx.Text;

            if (s.Length > 2)
            {
                
                int kolumny = s.Length;
                int wiersze = (int)Math.Ceiling(Math.Log(kolumny, 2)) + 1;
                H = new int[wiersze, kolumny];
                Random c = new Random();
                int licz;
                for (int i = 0; i < kolumny; i++)
                {
                    licz = 0;
                    for (int j = 0; j < wiersze; j++)
                    {
                        H[j, i] = c.Next(2)+0;
                        if (H[j, i] == 1)
                        {
                            licz++;
                        }
                    }
                    if (licz < 2)
                    {
                        i = i - 1;
                    }
                    else
                    {
                        int zlicz = 0;
                        if (i == 0)
                        {

                        }
                        else
                        {
                            for (int a = 0; a < i; a++)
                            {
                                zlicz = 0;
                                for (int b = 0; b < wiersze; b++)
                                {

                                    if (H[b, a] == H[b, i])
                                    {
                                        zlicz++;
                                    }
                                }
                                if (zlicz == wiersze)
                                {
                                    i = i - 1;
                                    break;
                                }


                            }

                        }

                    }

                }
            }



        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = tbx.Text;
            X=new int[s.Length];
            for (int i = 0; i < s.Length; i++)
            {
                X[i] = s[i]-'0'; 
            }

            int k = X.Length;
            int r = (int)Math.Ceiling(Math.Log(k, 2) + 1);


            Macierz();

        R = new int[r];

            for (int i = 0; i < r; i++)
            { 
                for (int j = 0; j < k; j++)
                {
                    R[i]+=H[i,j]*X[j];
                }
                R[i] = R[i] % 2;
            }

            TabToText(R,tbr);

        }

        private void TabToText(int[] R,TextBox TBR)
        {
            string s = "";
            for (int i = 0; i < R.Length; i++)
            {
                s += R[i];
            }
            TBR.Text = s;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //kopiowaie z tablicy do tablicy
            //sposob 1
            // Y = new int[X.Length];
            //for (int i = 0; i < Y.Length; i++)
            //{
            //    Y[i] = X[i];
            //}

            //sposob 2

            //Y = new int[X.Length];
            //Array.Copy(X, Y, X.Length);

           
            //sposob 3
            Y = (int[])X.Clone();
            Random rand = new Random();
            int n= rand.Next(Y.Length);
            Y[n]=Y[n]^1;
            TabToText(Y, tby);

        
        } 

        private void btnR2_Click(object sender, EventArgs e)
        {
            string s = tby.Text;
            X = new int[s.Length];
            for (int i = 0; i < s.Length; i++)
            {
                X[i] = s[i] - '0';
            }

            int k = X.Length;
            int r2 = (int)Math.Ceiling(Math.Log(k, 2) + 1);


            R2 = new int[r2];

            for (int i = 0; i < r2; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    R2[i] += H[i, j] * X[j];
                }
                R2[i] = R2[i] % 2;
            }

            TabToText(R2, tbr2);
        }

        private void btnS_Click(object sender, EventArgs e)
        {
            S = new int[R.Length];
            for (int i = 0; i < S.Length; i++)
            {
                S[i] = (R[i] + R2[i]) % 2;
            }

            TabToText(S, tbS);
        }

        private void btnZn_Click(object sender, EventArgs e)
        {
            int k = H.GetLength(1);
            int n = -1;
            for (int i = 0; i < k; i++)
            {
                if(SprawdzRownosc(i))
                {
                    n = i;
                    break;
                } 
            }
            MessageBox.Show(n.ToString());
        }

        private bool SprawdzRownosc(int k)
        {
            for (int i = 0; i < S.Length; i++)
            {
                if (S[i] != H[i, k])
                    return false;
            }
            return true;
        }   
    }
}
