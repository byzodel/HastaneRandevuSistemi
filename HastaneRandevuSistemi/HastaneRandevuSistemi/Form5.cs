using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneRandevuSistemi
{
    public partial class Form5: Form
    {
        public Form5(string doktor,string tarih, string saat )
        {
            InitializeComponent();
            Label2.Text = "Seçilen Doktor: " + doktor;// Label2 üzerinde seçilen doktor bilgisini gösterir
            label4.Text = "Randevu Tarihi: " + tarih; // label4 üzerinde randevu tarihini gösterir
            Label3.Text = "Randevu Saati: " + saat;// Label3 üzerinde randevu saatini gösterir
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Randevunuz başarıyla kaydedilmiştir. Geçmiş olsun!");
            Application.Exit(); // Tüm programı kapatır
        }
    }
}
