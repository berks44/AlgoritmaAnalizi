using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgoProje
{
    public partial class LinearSearch : Form
    {
        public LinearSearch()
        {
            InitializeComponent();
        }
        int index, adım;
        public bool Linear_Search(int[] numberArray, int wantedNumber)
        {
            for (int i = 0; i < numberArray.Length; i++)
            {
                if (numberArray[i] == wantedNumber)
                {
                    adım = i;
                    index = i;
                    return true;
                }
                adım = i;
            }
            return false;
        }

        private void Dizi_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Yeniden Bekleriz");
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
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
            if (Linear_Search(number, int.Parse(Aranacak.Text)))
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
                sonuc.Text = "Ardığınız sayı dizinin içinde bulunamadı.";
                indeks.Text = "";
                adim.Text = string.Join(", ", adım + 1);
                sure.Text = string.Join(", ", stopWatch1.ElapsedTicks);
            }

        }
    }
}
