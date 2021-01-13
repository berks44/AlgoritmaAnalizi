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
    public partial class CountingSort : Form
    {
        int adım;
        public CountingSort()
        {
            InitializeComponent();
        }
        public int[] Counting_Sort(int[] array)
        {
            int[] sortedArray = new int[array.Length];

            int minVal = array[0];
            int maxVal = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                adım++;
                if (array[i] < minVal) minVal = array[i];
                else if (array[i] > maxVal) maxVal = array[i];
            }

            int[] counts = new int[maxVal - minVal + 1];

            for (int i = 0; i < array.Length; i++)
            {
                counts[array[i] - minVal]++;
                adım++;
            }

            counts[0]--;
            for (int i = 1; i < counts.Length; i++)
            {
                counts[i] = counts[i] + counts[i - 1];
                adım++;
            }

            for (int i = array.Length - 1; i >= 0; i--)
            {
                sortedArray[counts[array[i] - minVal]--] = array[i];
                adım++;
            }

            return sortedArray;
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
            var sortedArray = Counting_Sort(number);
            Sıralanmış.Text = string.Join(" ", sortedArray);
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
