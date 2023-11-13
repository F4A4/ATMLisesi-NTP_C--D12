using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SinavaCalısma3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //comboBox1.Items.Clear();
            comboBox1.Items.Add("PAZARTESİ");
            comboBox1.Items.Add("SALI");
            comboBox1.Items.Add("PERŞEMBE");
            comboBox1.Items.Add("ÇARŞAMBA");
            comboBox1.Items.Add("CUMA");
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(comboBox1.SelectedIndex.ToString());
            MessageBox.Show(comboBox1.SelectedItem.ToString());
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(comboBox1.SelectedIndex.ToString());
            MessageBox.Show(comboBox1.SelectedItem.ToString());
        }
    }
}
