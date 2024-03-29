﻿using GiderTakipOtomasyonu.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiderTakipOtomasyonu.Forms
{
    public partial class HammadeSil : Form
    {
        public HammadeSil()
        {
            InitializeComponent();
        }
        gtoDbContext dbContext = new gtoDbContext();
        public int id = 0;
        public string adi = "";
        public float agirlik = 0,
            fiyat = 0,
            stokSayisi = 0;

        private void HammadeSil_Load(object sender, EventArgs e)
        {
            textBoxAdi.Text = adi;
            numericUpDownAgirlik.Value = Convert.ToDecimal(agirlik);
            numericUpDownFiyat.Value = Convert.ToDecimal(fiyat);
            numericUpDownStok.Value = Convert.ToDecimal(stokSayisi);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var deletehammadde = new HammaddeDbClass()
            {
                id = this.id,
                adi = textBoxAdi.Text,
                agirlik = float.Parse(numericUpDownAgirlik.Text),
                fiyat = float.Parse(numericUpDownFiyat.Text),
                stokSayisi = float.Parse(numericUpDownStok.Text)
            };
            dbContext.Hammaddeler.Remove(deletehammadde);
            int result = dbContext.SaveChanges();
            string message = result > 0 ? "Urun Silindi" : "Başarısız";
            MessageBox.Show(message);
        }
    }
}
