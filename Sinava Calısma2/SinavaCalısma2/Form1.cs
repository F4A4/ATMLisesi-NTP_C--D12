using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SinavaCalısma2
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
            try
            {
                int gun = Int32.Parse(textBox1.Text);
                textBox1.ForeColor = Color.Black;
                switch (gun)
                {
                    case 1:
                        label3.Text = "PAZARTESİ";
                        label3.ForeColor = Color.DarkGreen;
                        break;
                    case 2:
                        label3.Text = " SALI ";
                        label3.ForeColor = Color.DarkRed;
                        break;
                    case 3:
                        label3.Text = " ÇARŞAMBA ";
                        label3.ForeColor = Color.DarkOrange;
                        break;
                    case 4:
                        label3.Text = " PERŞEMBE ";
                        label3.ForeColor = Color.DarkViolet;
                        break;
                    case 5:
                        label3.Text = " CUMA ";
                        label3.ForeColor = Color.DeepPink;
                        break;
                    case 6:
                        label3.Text = " CUMARTESİ ";
                        label3.ForeColor = Color.Goldenrod;
                        break;
                    case 7:
                        label3.Text = " PAZAR ";
                        label3.ForeColor = Color.MediumAquamarine;
                        break;
                    default:
                        label3.Text = " HATALI GİRİŞ ";
                        label3.ForeColor = Color.MediumPurple;
                        break;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("LÜTFEN METİNSEL DEĞER DEĞİL,RAKAMSAL DEĞER GİRİNİZ");
                label3.ForeColor = Color.Coral;
            }
            finally
            {
                textBox1.Clear();
                textBox1.Focus();
 
            }
            
        }

       
    }
}
