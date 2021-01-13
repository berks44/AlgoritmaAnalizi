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
    public partial class GirişEkranı : Form
    {
        public GirişEkranı()
        {
            InitializeComponent();
            
        }
        int kalan_hak = 3;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "" && textBox2.Text == "")
            {
                kalan_hak--;
                MessageBox.Show("Kullanıcı adı veya şifre boş! Kalan hakkınız = " + kalan_hak);

            }
            else if(textBox1.Text == "Berk44" && textBox2.Text == "1234")
            {
                AnaEkran anaEkran = new AnaEkran();
                anaEkran.Show();


                
            }
            else
            {
                kalan_hak--;
                MessageBox.Show("Kullanıcı adı veya şifre yanlış! Tekrar deneyiniz. Kalan hakkınız " + kalan_hak);
            }
            if(kalan_hak == 0)
            {
                MessageBox.Show("3 kere hatalı giriş yaptınız. Lütfen tekrar deneyiniz!");
                Application.Exit();
               
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yeniden Bekleriz");
            Application.Exit();
        }
    }
}
