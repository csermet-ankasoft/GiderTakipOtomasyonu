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
    public partial class TicariMalSil : Form
    {
        gtoDbContext dbContext = new gtoDbContext();
        public int id;
        public string urunAdi;
        public float stokSayisi;
        public float fiyat;
        public TicariMalSil()
        {
            InitializeComponent();
        }

        private void TicariMalSil_Load(object sender, EventArgs e)
        {
            textBoxAdi.Text = urunAdi;
            numericStokSayisi.Value = (decimal)stokSayisi;
            numericFiyat.Value = (decimal)fiyat;
        }
    }
}
