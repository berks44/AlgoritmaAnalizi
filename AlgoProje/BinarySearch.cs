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
    public partial class BinarySearch : Form
    {
        public BinarySearch()
        {
            InitializeComponent();
        }
        int index, adım;
        public bool Binary_Search(int[] numberArray, int wantedNumber)
        {
            BubbleSort(numberArray);
            int first = 0, last = numberArray.Length - 1;
            int middle = (last / 2) + 1;
            int max = 0;
            while (first < last)
            {
                index = middle;
                adım = max + 1;
                if (numberArray[middle] == wantedNumber)
                {
                    return true;
                }
                if (numberArray[middle] < wantedNumber)
                {
                    first = middle;
                    middle = (middle + last) / 2;
                }
                else
                {
                    last = middle;
                    middle = (first + middle) / 2;
                }
                max++;
                if (max == 5000)
                    break;
            }
            return false;
        }
        public void BubbleSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }
        private void Dizi_TextChanged(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            Stopwatch stopWatch1 = new Stopwatch();
            var random = new Random();
            int[] number = new int[int.Parse(uret.Text)];
            for (int i = 0; i < int.Parse(uret.Text); i++)
            {
                number[i] = random.Next(0, 1000);
            }
            Dizi.Text = string.Join(", ", number);
            stopWatch1.Start();
            if (Binary_Search(number, int.Parse(Aranacak.Text)))
            {
                stopWatch1.Stop();
                sonuc.Text = "Aradığınız sayı dizinin içinde bulunuyor.";
                indeks.Text = string.Join(", ", index);
                adim.Text = string.Join(", ", adım + 1);
                sure.Text = string.Join(", ", stopWatch1.ElapsedTicks);
            }
            else
            {
                stopWatch1.Stop();
                sonuc.Text = "Aradığınız sayı dizinin içinde bulunmuyor.";
                indeks.Text = "";
                adim.Text = string.Join(", ", adım + 1);
                sure.Text = string.Join(", ", stopWatch1.ElapsedTicks);
            }

        }
    }
}
