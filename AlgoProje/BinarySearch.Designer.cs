namespace AlgoProje
{
    partial class BinarySearch
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.uret = new System.Windows.Forms.TextBox();
            this.Aranacak = new System.Windows.Forms.TextBox();
            this.Dizi = new System.Windows.Forms.TextBox();
            this.indeks = new System.Windows.Forms.TextBox();
            this.adim = new System.Windows.Forms.TextBox();
            this.sure = new System.Windows.Forms.TextBox();
            this.sonuc = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.button1.Location = new System.Drawing.Point(642, 348);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 25);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ara";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kaç tane sayı üretmek istediğinizi giriniz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dizide aradığınız elemanı giriniz";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 14);
            this.label3.TabIndex = 3;
            this.label3.Text = "Dizideki Elemanlar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(267, 14);
            this.label4.TabIndex = 4;
            this.label4.Text = "Arama sonucunda hangi indexde bulunduğu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(214, 14);
            this.label5.TabIndex = 5;
            this.label5.Text = "Aramanın kaç adımda gerçekleştiği";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 348);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(221, 14);
            this.label6.TabIndex = 6;
            this.label6.Text = "Aramanın kaç saniyede gerçekleştiği";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(57, 411);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 14);
            this.label7.TabIndex = 7;
            this.label7.Text = "Sonuç";
            // 
            // uret
            // 
            this.uret.Location = new System.Drawing.Point(383, 39);
            this.uret.Multiline = true;
            this.uret.Name = "uret";
            this.uret.Size = new System.Drawing.Size(116, 21);
            this.uret.TabIndex = 8;
            // 
            // Aranacak
            // 
            this.Aranacak.Location = new System.Drawing.Point(383, 97);
            this.Aranacak.Multiline = true;
            this.Aranacak.Name = "Aranacak";
            this.Aranacak.Size = new System.Drawing.Size(116, 21);
            this.Aranacak.TabIndex = 9;
            // 
            // Dizi
            // 
            this.Dizi.Location = new System.Drawing.Point(383, 148);
            this.Dizi.Multiline = true;
            this.Dizi.Name = "Dizi";
            this.Dizi.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Dizi.Size = new System.Drawing.Size(523, 72);
            this.Dizi.TabIndex = 10;
            // 
            // indeks
            // 
            this.indeks.Location = new System.Drawing.Point(383, 238);
            this.indeks.Multiline = true;
            this.indeks.Name = "indeks";
            this.indeks.Size = new System.Drawing.Size(116, 21);
            this.indeks.TabIndex = 11;
            // 
            // adim
            // 
            this.adim.Location = new System.Drawing.Point(383, 296);
            this.adim.Multiline = true;
            this.adim.Name = "adim";
            this.adim.Size = new System.Drawing.Size(116, 21);
            this.adim.TabIndex = 12;
            // 
            // sure
            // 
            this.sure.Location = new System.Drawing.Point(383, 351);
            this.sure.Multiline = true;
            this.sure.Name = "sure";
            this.sure.Size = new System.Drawing.Size(116, 21);
            this.sure.TabIndex = 13;
            // 
            // sonuc
            // 
            this.sonuc.Location = new System.Drawing.Point(383, 411);
            this.sonuc.Multiline = true;
            this.sonuc.Name = "sonuc";
            this.sonuc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.sonuc.Size = new System.Drawing.Size(258, 44);
            this.sonuc.TabIndex = 14;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.button2.Location = new System.Drawing.Point(797, 431);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 25);
            this.button2.TabIndex = 15;
            this.button2.Text = "ÇIKIŞ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.button3.Location = new System.Drawing.Point(733, 30);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(151, 59);
            this.button3.TabIndex = 16;
            this.button3.Text = "Arama Algoritmalarına Dönüş";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // BinarySearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ClientSize = new System.Drawing.Size(933, 485);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.sonuc);
            this.Controls.Add(this.sure);
            this.Controls.Add(this.adim);
            this.Controls.Add(this.indeks);
            this.Controls.Add(this.Dizi);
            this.Controls.Add(this.Aranacak);
            this.Controls.Add(this.uret);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.Red;
            this.Name = "BinarySearch";
            this.Text = "BinarySearch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox uret;
        private System.Windows.Forms.TextBox Aranacak;
        private System.Windows.Forms.TextBox Dizi;
        private System.Windows.Forms.TextBox indeks;
        private System.Windows.Forms.TextBox adim;
        private System.Windows.Forms.TextBox sure;
        private System.Windows.Forms.TextBox sonuc;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}