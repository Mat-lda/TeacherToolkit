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
    public partial class Form6 : Form
    {
        int[] classlist;
        int pointer = 0;
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox2.Text);
            textBox2.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            listBox2.Items.Clear();
            pointer = 0;
            while (listBox1.Items.Count != listBox2.Items.Count)
            {
                int rnum = rnd.Next(0, listBox1.Items.Count);
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    
                    if (listBox2.Items.Contains(listBox1.Items[rnum]))
                    {

                    }
                    else
                    {
                        listBox2.Items.Add(listBox1.Items[rnum]);
                    }
                    
                    
                }
            }
            for (int i = 0; i < listBox2.Items.Count; i++)
            {
                pointer++;
                listBox2.Items[i] = pointer + " - " + listBox2.Items[i]; 
            }
        }
    }
}
