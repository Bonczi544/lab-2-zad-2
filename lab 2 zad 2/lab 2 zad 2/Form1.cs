using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_2_zad_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        float currentSize;
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                textBox1.ForeColor = System.Drawing.Color.Red;
            }
            else if (radioButton2.Checked)
            {
                textBox1.ForeColor = System.Drawing.Color.Blue;
            }
            else if (radioButton3.Checked)
            {
                textBox1.ForeColor = System.Drawing.Color.Orange;
            }

            if (radioButton4.Checked)
            {
                textBox1.Font = new Font("Segoe UI", 8);

            }
            else if (radioButton5.Checked)
            {
                textBox1.Font = new Font("Segoe UI", 12);
            }
            else if (radioButton6.Checked)
            {
                textBox1.Font = new Font("Segoe UI", 20);
            }

            if (checkBox1.Checked)
            {
                textBox1.Font = new Font(textBox1.Font, FontStyle.Bold);
            }
            if (checkBox2.Checked)
            {
                textBox1.Font = new Font(textBox1.Font, FontStyle.Italic);
            }
            if (checkBox3.Checked)
            {
                textBox1.Font = new Font(textBox1.Font, FontStyle.Underline);
            }
            if (checkBox1.Checked && checkBox2.Checked)
            {
                textBox1.Font = new Font(textBox1.Font, FontStyle.Bold | FontStyle.Italic);
            }
            if (checkBox1.Checked && checkBox3.Checked)
            {
                textBox1.Font = new Font(textBox1.Font, FontStyle.Bold | FontStyle.Underline);
            }
            if (checkBox2.Checked && checkBox3.Checked)
            {
                textBox1.Font = new Font(textBox1.Font, FontStyle.Italic | FontStyle.Underline);
            }
            if (checkBox1.Checked && checkBox2.Checked && checkBox3.Checked)
            {
                textBox1.Font = new Font(textBox1.Font, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
            }
        }
    }
}
