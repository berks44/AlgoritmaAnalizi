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
    public partial class BucketSort : Form
    {
        int adım;
        public BucketSort()
        {
            InitializeComponent();
        }
        public void Bucket_Sort(int[] input)
        {
            int minValue = input[0];
            int maxValue = input[0];
            int k = 0;

            for (int i = input.Length - 1; i >= 1; i--)
            {
                if (input[i] > maxValue) maxValue = input[i];
                if (input[i] < minValue) minValue = input[i];
                adım++;
            }

            List<int>[] bucket = new List<int>[maxValue - minValue + 1];

            for (int i = bucket.Length - 1; i >= 0; i--)
            {
                bucket[i] = new List<int>();
                adım++;
            }

            foreach (int i in input)
            {
                bucket[i - minValue].Add(i);
                adım++;
            }

            foreach (List<int> b in bucket)
            {
                if (b.Count > 0)
                {
                    foreach (int t in b)
                    {
                        input[k] = t;
                        k++;
                        adım++;
                    }
                }
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
            Bucket_Sort(number);
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
