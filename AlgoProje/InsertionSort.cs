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
 
    public partial class InsertionSort : Form
    {
        int adım;
        public InsertionSort()
        {
            InitializeComponent();
        }

        public int[] Insertion_Sort(int[] inputArray)
        {
            for (int i = 0; i < inputArray.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (inputArray[j - 1] > inputArray[j])
                    {
                        int temp = inputArray[j - 1];
                        inputArray[j - 1] = inputArray[j];
                        inputArray[j] = temp;
                        adım++;
                    }
                }
            }
            return inputArray;
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            adım = 0;
            Stopwatch stopWatch1 = new Stopwatch();
            var random = new Random();
            int[] number = new int[int.Parse(textBox1.Text)];
            for (int i = 0; i < int.Parse(textBox1.Text); i++)
            {
                number[i] = random.Next(0, 1000);
            }
            stopWatch1.Start();
            Sıralanmamış.Text = string.Join(" ", number);
            Insertion_Sort(number);
            Sıralanmış.Text = string.Join(" ", number);
            stopWatch1.Stop();
            adim.Text = string.Join(", ", adım);
            sure.Text = string.Join(", ", stopWatch1.ElapsedTicks);

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
