using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contacts
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(saveFileDialog1.FileName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.LoadFile(openFileDialog1.FileName);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText(textBox1.Text+" "+textBox2.Text+" "+textBox3.Text+Environment.NewLine);
        }

        private void button4_Click(object sender, EventArgs e)
        {
         
            richTextBox1.ReadOnly = false;
        }

        private void richTextBox1_Leave(object sender, EventArgs e)
        {
            richTextBox1.ReadOnly = true;
        }
    }
}
