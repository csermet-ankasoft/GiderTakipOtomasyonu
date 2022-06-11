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
    public partial class Personeller : Form
    {
        private gtoDbContext dbContext;
        public Personeller()
        {
            InitializeComponent();
        }

        private void buttonduzenle_Click(object sender, EventArgs e)
        {
            Forms.PersonelDuzenle form = new Forms.PersonelDuzenle();
            
            form.ShowDialog();
            
        }

        private void Personeller_Load(object sender, EventArgs e)
        {
            refreshdatagridview();
        }
        public void refreshdatagridview()
        {
            dbContext = new gtoDbContext();
            DGV.DataSource = null;
            var personelListesi = dbContext.Personeller.ToList();
            DGV.DataSource = personelListesi;
        }


        private void buttonekle_Click(object sender, EventArgs e)
        {
            Forms.PersonelEkle form = new Forms.PersonelEkle();

            form.ShowDialog();
        }

        private void buttonsil_Click(object sender, EventArgs e)
        {
            Forms.PersonelSil form = new Forms.PersonelSil();

            form.ShowDialog();
        }
    }
}