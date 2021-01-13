namespace AlgoProje
{
    partial class InsertionSort
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
            this.Sıralanmamış = new System.Windows.Forms.TextBox();
            this.Sıralanmış = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.sure = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.adim = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.button1.Location = new System.Drawing.Point(470, 265);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 25);
            this.button1.TabIndex = 0;
            this.button1.Text = "Başlat";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Sıralanmamış
            // 
            this.Sıralanmamış.Location = new System.Drawing.Point(281, 107);
            this.Sıralanmamış.Multiline = true;
            this.Sıralanmamış.Name = "Sıralanmamış";
            this.Sıralanmamış.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Sıralanmamış.Size = new System.Drawing.Size(432, 70);
            this.Sıralanmamış.TabIndex = 1;
            // 
            // Sıralanmış
            // 
            this.Sıralanmış.Location = new System.Drawing.Point(281, 311);
            this.Sıralanmış.Multiline = true;
            this.Sıralanmış.Name = "Sıralanmış";
            this.Sıralanmış.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Sıralanmış.Size = new System.Drawing.Size(432, 108);
            this.Sıralanmış.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(281, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(116, 20);
            this.textBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 14);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kaç tane sayı üretmek istediğinizi giriniz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 14);
            this.label2.TabIndex = 5;
            this.label2.Text = "Sayıların sıralanmamış hali";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 311);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 14);
            this.label3.TabIndex = 6;
            this.label3.Text = "Sayıların sıralanmış hali";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.button2.Location = new System.Drawing.Point(30, 394);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 25);
            this.button2.TabIndex = 7;
            this.button2.Text = "ÇIKIŞ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.button3.Location = new System.Drawing.Point(696, 35);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(136, 54);
            this.button3.TabIndex = 8;
            this.button3.Text = "Sıralama Algoritmalarına Dönüş";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(234, 14);
            this.label4.TabIndex = 9;
            this.label4.Text = "Sıralamanın kaç saniyede gerçekleştiği";
            // 
            // sure
            // 
            this.sure.Location = new System.Drawing.Point(281, 210);
            this.sure.Name = "sure";
            this.sure.Size = new System.Drawing.Size(100, 20);
            this.sure.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(227, 14);
            this.label5.TabIndex = 11;
            this.label5.Text = "Sıralamanın kaç adımda gerçekleştiği";
            // 
            // adim
            // 
            this.adim.Location = new System.Drawing.Point(281, 270);
            this.adim.Name = "adim";
            this.adim.Size = new System.Drawing.Size(100, 20);
            this.adim.TabIndex = 12;
            // 
            // InsertionSort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ClientSize = new System.Drawing.Size(933, 485);
            this.Controls.Add(this.adim);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.sure);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Sıralanmış);
            this.Controls.Add(this.Sıralanmamış);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.Red;
            this.Name = "InsertionSort";
            this.Text = "InsertionSort";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Sıralanmamış;
        private System.Windows.Forms.TextBox Sıralanmış;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox sure;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox adim;
    }
}