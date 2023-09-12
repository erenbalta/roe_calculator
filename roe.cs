using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ratio_calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Text = "Calculate";
            label2.Text = "First Price";
            label1.Text = "Last Price";
            label3.Text = "%Roe";
            

        }

        public int num2;
        public int num1;

        private void Button1_Click(object sender, EventArgs e)

        {
            button1.Click += new EventHandler(Sonuc);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(Console.ReadLine());
        }

        public void textBox2_TextChanged(object sender, EventArgs e)
        {
            int num2 = Convert.ToInt32(Console.ReadLine());

        }

        private void Sonuc(object sender, EventArgs e)
        {
            int x = (num2 - num1) / num1 * 100;
            label4.Text = x.ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }
    }
}
