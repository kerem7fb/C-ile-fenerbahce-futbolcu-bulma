using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fenerbahçe_Futbolcu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad = textBox1.Text;
            int bul = 0;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                if (listBox1.Items[i].ToString() == ad) 
                {
                    bul++;
                    MessageBox.Show(ad + " Adlı Futbolcu " + (i + 1) + " . Sırada Bulundu");
                    break;
                }
            }
            if (bul == 0) 
            {
                MessageBox.Show(ad + " Adlı Futbolcu Bulunamadı");
            }
        }
    }
}
