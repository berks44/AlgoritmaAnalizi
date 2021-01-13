using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgoProje
{
    public partial class MergeSort : Form
    {
        int adım;
        public MergeSort()
        {
            InitializeComponent();
        }
        void merge(int[] arr, int l, int m, int r)
        {
            adım++;
            int n1 = m - l + 1;
            int n2 = r - m;

            int[] L = new int[n1];
            int[] R = new int[n2];
            int i, j;

            for (i = 0; i < n1; ++i)
                L[i] = arr[l + i];
            for (j = 0; j < n2; ++j)
                R[j] = arr[m + 1 + j];

            i = 0;
            j = 0;

            int k = l;
            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                {
                    arr[k] = L[i];
                    i++;
                }
                else
                {
                    arr[k] = R[j];
                    j++;
                }
                k++;
            }

            while (i < n1)
            {
                arr[k] = L[i];
                i++;
                k++;
            }

            while (j < n2)
            {
                arr[k] = R[j];
                j++;
                k++;
            }
        }

        void Merge_Sort(int[] arr, int l, int r)
        {
            adım++;
            if (l < r)
            {
                int m = (l + r) / 2;

                Merge_Sort(arr, l, m);
                Merge_Sort(arr, m + 1, r);

                merge(arr, l, m, r);
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            adım = 0;
            Stopwatch stopWatch1 = new Stopwatch();
            var random = new Random();
            int[] number = new int[int.Parse(uret.Text)];
            for (int i = 0; i < int.Parse(uret.Text); i++)
            {
                number[i] = random.Next(0, 1000);
            }
            stopWatch1.Start();
            Sıralanmamış.Text = string.Join(", ", number);
            Merge_Sort(number, 0, number.Length - 1);
            Sıralanmış.Text = string.Join(" ", number);
            stopWatch1.Stop();
            sure.Text = string.Join(", ", stopWatch1.ElapsedTicks);
            adim.Text = string.Join(", ", adım);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yeniden Bekleriz");
            Application.Exit();
        }

        private void MergeSort_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
