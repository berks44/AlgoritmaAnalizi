using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgoProje
{
    public partial class RadixSort : Form
    {
        int adım;
        public RadixSort()
        {
            InitializeComponent();
        }
        public int getMax(int[] arr, int n)
        {
            adım++;
            int mx = arr[0];
            for (int i = 1; i < n; i++)
                if (arr[i] > mx)
                    mx = arr[i];
            return mx;
        }

        public void Count_Sort(int[] arr, int n, int exp)
        {
            int[] output = new int[n];
            int i;
            int[] count = new int[10];

            for (i = 0; i < 10; i++)
            {
                adım++;
                count[i] = 0;
            }

            for (i = 0; i < n; i++)
            {
                adım++;
                count[(arr[i] / exp) % 10]++;
            }


            for (i = 1; i < 10; i++)
            {
                adım++;
                count[i] += count[i - 1];
            }

            for (i = n - 1; i >= 0; i--)
            {
                output[count[(arr[i] / exp) % 10] - 1] = arr[i];
                count[(arr[i] / exp) % 10]--;
                adım++;
            }

            for (i = 0; i < n; i++)
            {
                adım++;
                arr[i] = output[i];
            }
        }

        public void Radix_Sort(int[] arr, int n)
        {
            adım++;
            int m = getMax(arr, n);

            for (int exp = 1; m / exp > 0; exp *= 10)
                Count_Sort(arr, n, exp);
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
            Radix_Sort(number, number.Length);
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

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
