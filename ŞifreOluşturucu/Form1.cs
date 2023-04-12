using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ŞifreOluşturucu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int timerim = 0;
        int rn1, rn2, rn3, rn4;
        int buttonfix = 0;
        Random randomkeyim = new Random();
        void şifremrandom()
        {

            timer1.Start();


            rn1 = randomkeyim.Next(1, 10);
            rn2 = randomkeyim.Next(5, 10);
            rn3 = randomkeyim.Next(6, 10);
            rn4 = randomkeyim.Next(3, 10);



        }


        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            buttonfix++;


            if (buttonfix == 1)
            {
                şifremrandom();
            }
            else
            {
                şifremrandom();
            }

   
        }


        private void timer1_Tick(object sender, EventArgs e)
        {

            timerim++;
       

            if (timerim > 2)
            {
                progressBar1.Value = 25;
                label1.Text = rn1.ToString();
                label1.BackColor = Color.Yellow;
            }
            if (timerim > 4)
            {
                progressBar1.Value += 25;
                label2.Text = rn2.ToString();
                label2.BackColor = Color.Yellow;
            }
            if (timerim > 6)
            {
                progressBar1.Value += 25;
                label3.Text = rn3.ToString();
                label3.BackColor = Color.Yellow;
            }
            if (timerim > 8)
            {
                progressBar1.Value += 25;
                label4.Text = rn4.ToString();
                label4.BackColor = Color.Yellow;
            }

           if (progressBar1.Value == 100)
            {
                textBox1.Text = rn1.ToString() + rn2.ToString() + rn3.ToString() + rn4.ToString();
                timer1.Enabled = false;
                MessageBox.Show("Key Oluşturuldu !", "Key Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.BackColor = Color.GreenYellow;
                
            }
     


        }
    }
}
