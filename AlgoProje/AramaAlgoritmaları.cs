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
    public partial class AramaAlgoritmaları : Form
    {
        public AramaAlgoritmaları()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yeniden Bekleriz");
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LinearSearch linearSearch = new LinearSearch();
            linearSearch.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BinarySearch binarySearch = new BinarySearch();
            binarySearch.Show();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
