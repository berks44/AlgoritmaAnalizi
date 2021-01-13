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
    public partial class QuickSort : Form
    {
        int adım;
        public QuickSort()
        {
            InitializeComponent();
        }
        private void Quick_Sort(int[] arr, int left, int right)
        {
            adım++;
            if (left < right)
            {
                int pivot = Partition(arr, left, right);

                if (pivot > 1)
                {
                    Quick_Sort(arr, left, pivot - 1);
                }
                if (pivot + 1 < right)
                {
                    Quick_Sort(arr, pivot + 1, right);
                }
            }

        }

        private int Partition(int[] arr, int left, int right)
        {
            adım++;
            int pivot = arr[left];
            while (true)
            {

                while (arr[left] < pivot)
                {
                    left++;
                }

                while (arr[right] > pivot)
                {
                    right--;
                }

                if (left < right)
                {
                    if (arr[left] == arr[right]) return right;

                    int temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;


                }
                else
                {
                    return right;
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
            Quick_Sort(number, 0, number.Length - 1);
            Sıralanmış.Text = string.Join(" ", number);
            stopWatch1.Stop();
            sure.Text = string.Join(", ", stopWatch1.ElapsedTicks);
            adim.Text = string.Join(", ", adım);

        }

        private void label3_Click(object sender, EventArgs e)
        {

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
