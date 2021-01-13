using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgoProje
{
    public partial class SıralamaAlgoritmaları : Form
    {
        public SıralamaAlgoritmaları()
        {
            InitializeComponent();
        }

       

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yeniden Bekleriz");
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            RadixSort radixSort = new RadixSort();
            radixSort.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MergeSort mergeSort = new MergeSort();
            mergeSort.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HeapSort heapSort = new HeapSort();
            heapSort.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            QuickSort quickSort = new QuickSort();
            quickSort.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CountingSort countingSort = new CountingSort();
            countingSort.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            BucketSort bucketSort = new BucketSort();
            bucketSort.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InsertionSort ınsertionSort = new InsertionSort();
            ınsertionSort.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
