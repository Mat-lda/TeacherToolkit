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
    public partial class Form5 : Form
    {
        float time = 0;
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                time = float.Parse(textBox1.Text);
                
                timer1.Enabled = true;
            
            }
            catch
            {
                MessageBox.Show("error", "please input time only in seconds");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (time <= 0.1)
            {
                
                timer1.Enabled = false;

            }
            else
            {
                time = (float)(time - 0.1);
                textBox1.Text = time.ToString("0.0");
               
            }
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            timer1.Enabled = false;
        }
    }
}
