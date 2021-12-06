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
    public partial class Form2 : Form
    {
        float timer = 0;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == false)
            {
                timer1.Enabled = true;
            }
            else
            {
                timer1.Enabled = false;
            }


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == false)
            {
                timer = 0;
                textBox1.Text = timer.ToString();
            }
            else
            {
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show("The Timer is stil running, are you sure you want to reset it?", "Stop", buttons);

                if (result == DialogResult.Yes)
                {
                    timer1.Enabled = false;
                    timer = 0;
                    textBox1.Text = timer.ToString();
                }
                else
                {

                }
            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            timer += timer1.Interval * 0.001f;
            textBox1.Text = timer.ToString("0.0");

        }
    }
}
