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
    public partial class HeapSort : Form
    {
        int adım;
        
        public HeapSort()
        {
            InitializeComponent();
        }
        private void Heap_Sort<T>(T[] array) where T : IComparable<T>
        {

            adım++;
            int heapSize = array.Length;

            buildMaxHeap(array);

            for (int i = heapSize - 1; i >= 1; i--)
            {
                swap(array, i, 0);
                heapSize--;
                sink(array, heapSize, 0);
            }
        }

        private void buildMaxHeap<T>(T[] array) where T : IComparable<T>
        {
            adım++;
            int heapSize = array.Length;

            for (int i = (heapSize / 2) - 1; i >= 0; i--)
            {
                sink(array, heapSize, i);
            }
        }

        private void sink<T>(T[] array, int heapSize, int toSinkPos) where T : IComparable<T>
        {
            adım++;
            if (getLeftKidPos(toSinkPos) >= heapSize)
            {
                // No left kid => no kid at all
                return;
            }


            int largestKidPos;
            bool leftIsLargest;

            if (getRightKidPos(toSinkPos) >= heapSize || array[getRightKidPos(toSinkPos)].CompareTo(array[getLeftKidPos(toSinkPos)]) < 0)
            {
                largestKidPos = getLeftKidPos(toSinkPos);
                leftIsLargest = true;
            }
            else
            {
                largestKidPos = getRightKidPos(toSinkPos);
                leftIsLargest = false;
            }



            if (array[largestKidPos].CompareTo(array[toSinkPos]) > 0)
            {
                swap(array, toSinkPos, largestKidPos);

                if (leftIsLargest)
                {
                    sink(array, heapSize, getLeftKidPos(toSinkPos));

                }
                else
                {
                    sink(array, heapSize, getRightKidPos(toSinkPos));
                }
            }

        }

        private static void swap<T>(T[] array, int pos0, int pos1)
        {
            T tmpVal = array[pos0];
            array[pos0] = array[pos1];
            array[pos1] = tmpVal;
        }

        private static int getLeftKidPos(int parentPos)
        {
            return (2 * (parentPos + 1)) - 1;
        }

        private static int getRightKidPos(int parentPos)
        {
            return 2 * (parentPos + 1);
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
            Heap_Sort(number);
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
