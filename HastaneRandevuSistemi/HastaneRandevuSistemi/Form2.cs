using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneRandevuSistemi
{
    public partial class Form2: Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnBeyin_Click(object sender, EventArgs e)
        {
            Form3 doktorSayfasi = new Form3("Beyin Cerrahisi");
            doktorSayfasi.Show(); // Form3 gösterilir
            this.Hide();// Mevcut Form2 gizlenir
        }

        private void btnKadın_Click(object sender, EventArgs e)
        {
            Form3 doktorSayfasi = new Form3("Kadın Doğum");
            doktorSayfasi.Show();
            this.Hide();
        }

        private void btnAile_Click(object sender, EventArgs e)
        {
            Form3 doktorSayfasi = new Form3("Aile Hekimliği");
            doktorSayfasi.Show();
            this.Hide();
        }

        private void btnNöroloji_Click(object sender, EventArgs e)
        {
            Form3 doktorSayfasi = new Form3("Nöroloji");
            doktorSayfasi.Show();
            this.Hide();
        }

        private void btnKBB_Click(object sender, EventArgs e)
        {
            Form3 doktorSayfasi = new Form3("Kulak Burun Boğaz");
            doktorSayfasi.Show();
            this.Hide();
        }

        private void btnPsikiyatri_Click(object sender, EventArgs e)
        {
            Form3 doktorSayfasi = new Form3("Psikiyatri");
            doktorSayfasi.Show();
            this.Hide();
        }

        private void btnGöz_Click(object sender, EventArgs e)
        {
            Form3 doktorSayfasi = new Form3("Göz Kliniği");
            doktorSayfasi.Show();
            this.Hide();
        }

        private void btnOnkoloji_Click(object sender, EventArgs e)
        {
            Form3 doktorSayfasi = new Form3("Onkoloji");
            doktorSayfasi.Show();
            this.Hide();
        }

        private void btnKardiyoloji_Click(object sender, EventArgs e)
        {
            Form3 doktorSayfasi = new Form3("Kardiyoloji");
            doktorSayfasi.Show();
            this.Hide();
        }
    }
}
