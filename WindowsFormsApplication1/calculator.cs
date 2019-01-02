using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Sumbutton3_Click(object sender, EventArgs e)
        {
            try
            {
                var num1 = int.Parse(textBox1.Text);
                var num2 = int.Parse(textBox2.Text);
                int result = num1 + num2;
                textBox3.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var num1 = int.Parse(textBox1.Text);
                var num2 = int.Parse(textBox2.Text);
            }
            catch (Exception ex)
            {

            }
        }


        private void Multiplictionbutton5_Click(object sender, EventArgs e)
        {
            try
            {
                var num1 = int.Parse(textBox1.Text);
                var num2 = int.Parse(textBox2.Text);
                int result = num1 * num2;
                textBox5.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var num1 = int.Parse(textBox1.Text);
                var num2 = int.Parse(textBox2.Text);
            }
            catch (Exception ex)
            {
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Minesbutton4_Click(object sender, EventArgs e)
        {
            try
            {
                var num1 = int.Parse(textBox1.Text);
                var num2 = int.Parse(textBox2.Text);
                int result = num1 - num2;
                textBox4.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Dividedbutton6_Click(object sender, EventArgs e)
        {
            try
            {
                var num1 = float.Parse(textBox1.Text);
                var num2 = float.Parse(textBox2.Text);
                float result = num1 / num2;
                textBox6.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
