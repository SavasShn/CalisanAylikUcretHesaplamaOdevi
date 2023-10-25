using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalisanAylikUcretHesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            personal prs1 = new personal();
            prs1.Adsoyad = adSoyadTxt.Text;
            prs1.Adres = adresTxt.Text;
            prs1.Yas = Convert.ToInt32(yasTxt.Text);
            prs1.Mesai = Convert.ToInt32(mesaiSaatiTxt.Text);
            MessageBox.Show("ad=" + prs1.Adsoyad + "\nAdres=" + prs1.Adres + "\nYaş=" + prs1.Yas);


            if (unvanTxt.Text == "İşçi")
            {
                MessageBox.Show(prs1.ucretHesapla().ToString());
            }
            else
            {
                prs1.ucretHesapla(1000);
            }
        }
    }
}
