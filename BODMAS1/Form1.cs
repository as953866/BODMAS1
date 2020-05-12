using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BODMAS1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(textBox1.Text);
            int num2 = Convert.ToInt32(textBox2.Text);
            label1.Text = (num1 / num2).ToString();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(textBox3.Text);
            int num2 = Convert.ToInt32(textBox4.Text);
            label1.Text = (num1 * num2).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(textBox5.Text);
            int num2 = Convert.ToInt32(textBox6.Text);
            label1.Text = (num1 + num2).ToString();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(textBox7.Text);
            int num2 = Convert.ToInt32(textBox8.Text);
            label1.Text = (num1 - num2).ToString();
        }
    }
}
