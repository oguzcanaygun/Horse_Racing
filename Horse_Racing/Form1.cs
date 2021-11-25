using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Horse_Racing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int leftdistancehorse1, leftdistancehorse2, leftdistancehorse3, leftdistancehorse4;

        private void Form1_Load(object sender, EventArgs e)
        {
            leftdistancehorse1 = pictureBox1.Left;
            leftdistancehorse2 = pictureBox2.Left;
            leftdistancehorse3 = pictureBox3.Left;
            leftdistancehorse4 = pictureBox4.Left;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int horse1width = pictureBox1.Width;
            int horse2width = pictureBox2.Width;
            int horse3width = pictureBox3.Width;
            int horse4width = pictureBox4.Width;

            int finishlenght = label6.Left;

            int sure = Convert.ToInt16(label8.Text);
            sure++;
            label8.Text = sure.ToString();

           

            pictureBox1.Left = pictureBox1.Left + rastgele.Next(5, 15);
            pictureBox2.Left = pictureBox2.Left + rastgele.Next(5, 15);
            pictureBox3.Left = pictureBox3.Left + rastgele.Next(5,15);
            pictureBox4.Left = pictureBox4.Left + rastgele.Next(5, 15);

            if(pictureBox1.Left>pictureBox2.Left+5 && pictureBox1.Left > pictureBox3.Left + 5 && pictureBox1.Left>pictureBox4.Left+5)
            {
                label7.BackColor = Color.Yellow;
                label7.Text = "1 IS AHEAD";
            }
            if(pictureBox2.Left>pictureBox1.Left+5 && pictureBox2.Left>pictureBox3.Left+5 && pictureBox2.Left > pictureBox4.Left + 5)
            {
                label7.BackColor = Color.Blue;
                label7.Text = "2 IS AHEAD";
            }
            if(pictureBox3.Left>pictureBox1.Left+5 && pictureBox3.Left>pictureBox2.Left+5 && pictureBox3.Left > pictureBox4.Left + 5)
            {
                label7.BackColor = Color.White;
                label7.Text = "3 IS AHEAD";
            }
            if(pictureBox4.Left>pictureBox1.Left+5 && pictureBox4.Left>pictureBox2.Left+5 && pictureBox4.Left > pictureBox3.Left + 5)
            {
                label7.BackColor = Color.Pink;
                label7.Text = "4 IS AHEAD";
            }
                   
            if (horse1width + pictureBox1.Left >= finishlenght)
            {
                timer1.Enabled = false;
                MessageBox.Show("Winner: 1 !!!!!!!!");   
            }
            if (horse2width + pictureBox2.Left >= finishlenght)
            {
                timer1.Enabled = false;
                MessageBox.Show("Winner: 2 !!!!!!!");
            }
            if (horse3width + pictureBox3.Left >= finishlenght)
            {
                timer1.Enabled = false;
                MessageBox.Show("Winner: 3 !!!!!!!");
            }
            if (horse4width + pictureBox4.Left >= finishlenght)
            {
                timer1.Enabled = false;
                MessageBox.Show("Winner: 4 !!!!!!!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Left = leftdistancehorse1;
            pictureBox2.Left = leftdistancehorse2;
            pictureBox3.Left = leftdistancehorse3;
            pictureBox4.Left = leftdistancehorse4;
            label8.Text = "0";
        }

        Random rastgele = new Random();

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
    }
}
