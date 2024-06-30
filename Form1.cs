using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Change_Background_color_radio_button
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                textBox1.BackColor = Color.Red;
                textBox1.ForeColor = Color.WhiteSmoke;
            }
            else if (radioButton2.Checked == true)
            {
                textBox1.BackColor = Color.Green;
                textBox1.ForeColor = Color.WhiteSmoke;
            }
            else if (radioButton3.Checked == true)
            {
                textBox1.BackColor = Color.Blue;
                textBox1.ForeColor = Color.WhiteSmoke;
            }
            else if (radioButton4.Checked == true)
            {
                textBox1.BackColor = Color.Purple;
                textBox1.ForeColor = Color.WhiteSmoke;
            }

        }
    }
}
