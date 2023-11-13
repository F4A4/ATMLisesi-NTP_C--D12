using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SinavaCalısma
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        public string metin;

        private void button1_Click(object sender, EventArgs e)
        {
            
            string a=textBox1.Text;
            label1.Text = a.ToString();

            //----farklı deneme--------

            label2.Text = metin;

        }
    }
}
