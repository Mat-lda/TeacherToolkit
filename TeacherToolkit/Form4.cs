using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeacherToolkit
{
    public partial class Form4 : Form
    {
        float countdown = 3000;
        public Form4()
        {
            InitializeComponent();
        }


        private void timer2_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            countdown -= timer2.Interval;
            if (textBox2.Text == "")
            {
                timer2.Enabled = false;
                MessageBox.Show("Please enter a number", "Error");

            }
            else
            {
                try
                {
                    label2.Text = rnd.Next(1, (Int32.Parse(textBox2.Text) + 1)).ToString();
                    if (countdown < 0)
                    {
                        label2.BackColor = Color.LightGreen;
                        countdown = 3000;
                        timer2.Enabled = false;
                    }
                }
                catch
                {
                    MessageBox.Show("Please enter a number", "Error");
                }


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.BackColor = Color.White;
            timer2.Enabled = true;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
