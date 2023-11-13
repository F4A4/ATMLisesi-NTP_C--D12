using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SinavaCalısma;

namespace SinavaCalısma
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
            //SinavaCalısma.Deneme.Islem();
            Deneme.Islem();
            SinavaCalısma2.Deneme2.Islem();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 F2=new Form2();
            F2.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 f3=new Form3();
            f3.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 f4 =new Form3();
            f4.metin = "nasıl bi deneme bu arkadaş";
            f4.Show();

        }
    }
}
