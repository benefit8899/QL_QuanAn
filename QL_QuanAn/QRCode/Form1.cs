using QROCode;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            if (op.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                label1.Text = op.FileName;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Image logo = null;
            if (label1.Text.Length > 0)
            {
                try
                {
                    logo = Image.FromFile(label1.Text);
                }
                catch { }
            }
            QREncoder encoder = new QREncoder(logo, textBox1.Text);
            pictureBox1.Image = encoder.Encode();
        }
    }
}
