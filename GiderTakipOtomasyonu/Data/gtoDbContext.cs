﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace GiderTakipOtomasyonu.Data
{
    public class gtoDbContext : DbContext
    {
        public static string staticdbname = "";
        public DbSet<KisiDbClass> Kisiler { get; set; }
        public DbSet<CuzdanDbClass> Cuzdanlar { get; set; }
        public DbSet<KategoriDbClass> Kategoriler { get; set; }
        public DbSet<KartlarımDbClass> Kartlarım { get; set; }
        public DbSet<OdemeTuruDbClass> ÖdemeTürleri { get; set; }
        public DbSet<HammaddeDbClass> Hammaddeler { get; set; }
        public DbSet<TemaDbClass> Temalar { get; set; }
        public DbSet<TicariMallarDbClass> TicariMallar { get; set; }
        public DbSet<GiderlerDbClass> Giderler { get; set; }
        public DbSet<GelirlerDbClass> Gelirler { get; set; }
        public DbSet<PersonelDbClass> Personeller { get; set; }
        public DbSet<KullaniciDetayDbClass> KullaniciDetay { get; set; }
        public DbSet<AyarlarDbClass> Ayarlar { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=.; Database="+"GTODB"+ staticdbname + "; Integrated Security=yes");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //******************** KisiDbClass Tablo Oluşturma İşlemleri ********************

            modelBuilder.Entity<KisiDbClass>().Property(x => x.bilgi)
                                              .HasColumnName("Bilgi")
                                              .HasMaxLength(300);
            modelBuilder.Entity<KisiDbClass>().Property(x => x.adres)
                                              .HasColumnName("Adres")
                                              .IsRequired()
                                              .HasMaxLength(150);
            modelBuilder.Entity<KisiDbClass>().Property(x => x.faksNo)
                                              .HasColumnName("Faks No")
                                              .HasMaxLength(11);
            modelBuilder.Entity<KisiDbClass>().Property(x => x.telNo)
                                              .IsRequired()
                                              .HasColumnName("Telefon No")
                                              .HasMaxLength(11);
            modelBuilder.Entity<KisiDbClass>().Property(x => x.adi)
                                              .IsRequired()
                                              .HasColumnName("Adı")
                                              .HasMaxLength(25);
            modelBuilder.Entity<KisiDbClass>().Property(x => x.borc)
                                              .HasColumnName("Borc");
            modelBuilder.Entity<KisiDbClass>().Property(x => x.alacak)
                                              .HasColumnName("Alacak");

            //******************** KisiDbClass Tablo Oluşturma İşlemleri Bitişi ********************

            //******************** KisiDbClass Tablo Test Verisi Ekleme İşlemleri ********************

            modelBuilder.Entity<KisiDbClass>().HasData(new KisiDbClass { id = 1, borc = 501, alacak = 15100, bilgi = "Dürüst Biri", adres = "Elazığ Merkez", faksNo = "06665555555", telNo = "01472536980", adi = "Durmuş Kahraman" });
            modelBuilder.Entity<KisiDbClass>().HasData(new KisiDbClass { id = 2, borc = 540, alacak = 10560, bilgi = "İyi Biri", adres = "Ankara Kızılay", faksNo = "04565555555", telNo = "03255698547", adi = "Dilek Yılmaz" });
            modelBuilder.Entity<KisiDbClass>().HasData(new KisiDbClass { id = 3, borc = 589, alacak = 10651, bilgi = "Güvenilmez Biri", adres = "Elazığ Maden", faksNo = "02585555555", telNo = "01231471558", adi = "Caner Olmuş" });
            modelBuilder.Entity<KisiDbClass>().HasData(new KisiDbClass { id = 4, borc = 50, alacak = 5416, bilgi = "Borç Verilmez Biri", adres = "İstanbul Gaziosmanpaşa", faksNo = "02125555555", telNo = "02582695847", adi = "Emre Durhan" });
            modelBuilder.Entity<KisiDbClass>().HasData(new KisiDbClass { id = 5, borc = 500, alacak = 5510, bilgi = "Herhangi Biri", adres = "İstanbul Aksaray", faksNo = "07895555555", telNo = "04568524568", adi = "Merve Kum" });
            //******************** KisiDbClass Tablo Test Verisi Ekleme İşlemleri Bitişi ********************

            //******************** CuzdanDbClass Tablo Oluşturma İşlemleri ********************

            modelBuilder.Entity<CuzdanDbClass>().Property(x => x.bakiyeDolar)
                                              .HasColumnName("Dolar");
            modelBuilder.Entity<CuzdanDbClass>().Property(x => x.bakiyeEURO)
                                              .HasColumnName("EURO");
            modelBuilder.Entity<CuzdanDbClass>().Property(x => x.bakiyeTL)
                                              .HasColumnName("TL");

            //******************** CuzdanDbClass Tablo Oluşturma İşlemleri Bitişi ********************

            //******************** CuzdanDbClass Tablo Test Verisi Ekleme İşlemleri ********************

            modelBuilder.Entity<CuzdanDbClass>().HasData(new CuzdanDbClass { id = 1, bakiyeTL = 100, bakiyeEURO = 1000, bakiyeDolar = 10000 });

            //********** CuzdanDbClass Tablo Test Verisi Ekleme İşlemleri Bitişi **************

            //******************** KategoriDbClass Tablo Oluşturma İşlemleri ********************

            modelBuilder.Entity<KategoriDbClass>().Property(x => x.adi)
                                                  .IsRequired()
                                                  .HasColumnName("Adı")
                                                  .HasMaxLength(25);

            //******************** KategoriDbClass Tablo Oluşturma İşlemleri Bitişi ********************

            //******************** KategoriDbClass Tablo Test Verisi Ekleme İşlemleri ********************

            modelBuilder.Entity<KategoriDbClass>().HasData(new KategoriDbClass { id = 1, adi = "Mutfak" });
            modelBuilder.Entity<KategoriDbClass>().HasData(new KategoriDbClass { id = 2, adi = "Elektronik" });
            modelBuilder.Entity<KategoriDbClass>().HasData(new KategoriDbClass { id = 3, adi = "Kişisel Eşya" });
            modelBuilder.Entity<KategoriDbClass>().HasData(new KategoriDbClass { id = 4, adi = "Kırtasiye" });
            modelBuilder.Entity<KategoriDbClass>().HasData(new KategoriDbClass { id = 5, adi = "Fatura" });
            modelBuilder.Entity<KategoriDbClass>().HasData(new KategoriDbClass { id = 6, adi = "Temizlik Malzemesi" });
            modelBuilder.Entity<KategoriDbClass>().HasData(new KategoriDbClass { id = 7, adi = "Ticari Mal Satışı" });
            modelBuilder.Entity<KategoriDbClass>().HasData(new KategoriDbClass { id = 8, adi = "Diğer" });


            //******************** KategoriDbClass Tablo Test Verisi Ekleme İşlemleri Bitişi ********************

            //******************** OdemeTuruDbClass Tablo Oluşturma İşlemleri ********************

            modelBuilder.Entity<OdemeTuruDbClass>().Property(x => x.adi)
                                                   .IsRequired()
                                                   .HasColumnName("Adı")
                                                   .HasMaxLength(25);

            //******************** OdemeTuruDbClass Tablo Oluşturma İşlemleri Bitişi ********************

            //******************** OdemeTuruDbClass Tablo Test Verisi Ekleme İşlemleri ********************

            modelBuilder.Entity<OdemeTuruDbClass>().HasData(new OdemeTuruDbClass { id = 1, adi = "Nakit" });
            modelBuilder.Entity<OdemeTuruDbClass>().HasData(new OdemeTuruDbClass { id = 2, adi = "Kredi Kartı" });
            modelBuilder.Entity<OdemeTuruDbClass>().HasData(new OdemeTuruDbClass { id = 3, adi = "Diğer" });

            //******************** OdemeTuruDbClass Tablo Test Verisi Ekleme İşlemleri Bitişi ********************

            //******************** HammaddeDbClass Tablo Oluşturma İşlemleri ********************

            modelBuilder.Entity<HammaddeDbClass>().Property(x => x.adi)
                                                  .IsRequired()
                                                  .HasColumnName("Ürün Adı")
                                                  .HasMaxLength(40);
            modelBuilder.Entity<HammaddeDbClass>().Property(x => x.agirlik)
                                                  .HasColumnName("Ürün Ağırlığı ");
            modelBuilder.Entity<HammaddeDbClass>().Property(x => x.fiyat)
                                                  .HasColumnName("Ürün Fiyatı ");
            modelBuilder.Entity<HammaddeDbClass>().Property(x => x.stokSayisi)
                                                  .IsRequired()
                                                  .HasColumnName("Stok Sayisi");

            //******************** HammaddeDbClass Tablo Oluşturma İşlemleri Bitişi ********************

            //******************** HammaddeDbClass Tablo Test Verisi Ekleme İşlemleri ********************

            modelBuilder.Entity<HammaddeDbClass>().HasData(new HammaddeDbClass { id = 1, adi = "Un", agirlik = 50, fiyat = 540, stokSayisi = 100 });
            modelBuilder.Entity<HammaddeDbClass>().HasData(new HammaddeDbClass { id = 2, adi = "Sıvıyağ", agirlik = 20, fiyat = 600, stokSayisi = 50 });
            modelBuilder.Entity<HammaddeDbClass>().HasData(new HammaddeDbClass { id = 3, adi = "Şeker", agirlik = 50, fiyat = 300, stokSayisi = 150 });
            modelBuilder.Entity<HammaddeDbClass>().HasData(new HammaddeDbClass { id = 4, adi = "Tuz", agirlik = 5, fiyat = 15, stokSayisi = 20 });
            modelBuilder.Entity<HammaddeDbClass>().HasData(new HammaddeDbClass { id = 5, adi = "Maya", agirlik = 1, fiyat = 5, stokSayisi = 10 });
            modelBuilder.Entity<HammaddeDbClass>().HasData(new HammaddeDbClass { id = 6, adi = "Süt", agirlik = 1, fiyat = 12, stokSayisi = 20 });

            //******************** HammaddeDbClass Tablo Test Verisi Ekleme İşlemleri Bitişi ********************

            //******************** TemaDbClass Tablo Oluşturma İşlemleri ********************

            modelBuilder.Entity<TemaDbClass>().Property(x => x.adi)
                                              .IsRequired()
                                              .HasColumnName("Adı")
                                              .HasMaxLength(15);

            //******************** TemaDbClass Tablo Oluşturma İşlemleri Bitişi ********************

            //******************** TemaDbClass Tablo Test Verisi Ekleme İşlemleri ********************

            modelBuilder.Entity<TemaDbClass>().HasData(new TemaDbClass { id = 1, adi = "Koyu" });
            modelBuilder.Entity<TemaDbClass>().HasData(new TemaDbClass { id = 2, adi = "Acik" });
            modelBuilder.Entity<TemaDbClass>().HasData(new TemaDbClass { id = 3, adi = "Renkli" });

            //******************** TemaDbClass Tablo Test Verisi Ekleme İşlemleri Bitişi ********************

            //******************** TicariMallarDbClass Tablo Oluşturma İşlemleri ********************

            modelBuilder.Entity<TicariMallarDbClass>().Property(x => x.urunAdi)
                                                      .IsRequired()
                                                      .HasColumnName("Ürün Adı")
                                                      .HasMaxLength(40);
            modelBuilder.Entity<TicariMallarDbClass>().Property(x => x.stokSayisi)
                                                      .IsRequired()
                                                      .HasColumnName("Stok Sayısı");
            modelBuilder.Entity<TicariMallarDbClass>().Property(x => x.fiyat)
                                                      .IsRequired()
                                                      .HasColumnName("Ürün Fiyatı ");

            //******************** TicariMallarDbClass Tablo Oluşturma İşlemleri Bitişi ********************

            //******************** TicariMallarDbClass Tablo Test Verisi Ekleme İşlemleri ********************

            modelBuilder.Entity<TicariMallarDbClass>().HasData(new TicariMallarDbClass { id = 1, urunAdi = "Kola", stokSayisi = 15, fiyat = 15 });
            modelBuilder.Entity<TicariMallarDbClass>().HasData(new TicariMallarDbClass { id = 2, urunAdi = "Fanta", stokSayisi = 10, fiyat = 15 });
            modelBuilder.Entity<TicariMallarDbClass>().HasData(new TicariMallarDbClass { id = 3, urunAdi = "Poğaça", stokSayisi = 50, fiyat = 4 });
            modelBuilder.Entity<TicariMallarDbClass>().HasData(new TicariMallarDbClass { id = 4, urunAdi = "Simit", stokSayisi = 70, fiyat = 5 });
            modelBuilder.Entity<TicariMallarDbClass>().HasData(new TicariMallarDbClass { id = 5, urunAdi = "Ayran", stokSayisi = 30, fiyat = 3 });
            modelBuilder.Entity<TicariMallarDbClass>().HasData(new TicariMallarDbClass { id = 6, urunAdi = "Pasta", stokSayisi = 15, fiyat = 75 });


            //******************** TicariMallarDbClass Tablo Test Verisi Ekleme İşlemleri Bitişi ********************

            //******************** GiderlerDbClass Tablo Oluşturma İşlemleri ********************

            modelBuilder.Entity<GiderlerDbClass>().Property(x => x.aciklamasi)
                                                  .IsRequired()
                                                  .HasColumnName("Ürün Açıklaması")
                                                  .HasMaxLength(400);
            modelBuilder.Entity<GiderlerDbClass>().Property(x => x.kime)
                                                  .IsRequired()
                                                  .HasColumnName("Kime");
            modelBuilder.Entity<GiderlerDbClass>().Property(x => x.tutar)
                                                  .IsRequired()
                                                  .HasColumnName(" Giderin Tutarı ");
            modelBuilder.Entity<GiderlerDbClass>().Property(x => x.tarih)
                                                  .IsRequired();
            modelBuilder.Entity<GiderlerDbClass>().HasOne(x => x.Kategori)
                                                  .WithMany(Kategori => Kategori.Giderler)
                                                  .HasForeignKey(f => f.kategoriId)
                                                  .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<GiderlerDbClass>().HasOne(x => x.odemeTuru)
                                                  .WithMany(odemeTuru => odemeTuru.Giderler)
                                                  .HasForeignKey(f => f.odemeTuruId)
                                                  .OnDelete(DeleteBehavior.NoAction);


            //******************** GiderlerDbClass Tablo Oluşturma İşlemleri Bitişi ********************

            //******************** GiderlerDbClass Tablo Test Verisi Ekleme İşlemleri ********************
            DateTime dt = new DateTime(2022, 06, 10);

            modelBuilder.Entity<GiderlerDbClass>().HasData(new GiderlerDbClass { id = 1, aciklamasi = "Açıklama1", kime = "Ali", tutar = 10, odemeTuruId = 1, kategoriId = 1, tarih = dt });
            modelBuilder.Entity<GiderlerDbClass>().HasData(new GiderlerDbClass { id = 2, aciklamasi = "Açıklama2", kime = "Veli", tutar = 50, odemeTuruId = 1, kategoriId = 2 , tarih = dt });
            modelBuilder.Entity<GiderlerDbClass>().HasData(new GiderlerDbClass { id = 3, aciklamasi = "Açıklama3", kime = "Ayşe", tutar = 15, odemeTuruId = 2, kategoriId = 3, tarih = dt });
            modelBuilder.Entity<GiderlerDbClass>().HasData(new GiderlerDbClass { id = 4, aciklamasi = "Açıklama4", kime = "Orkun", tutar = 600, odemeTuruId = 3, kategoriId = 4, tarih = dt });
            modelBuilder.Entity<GiderlerDbClass>().HasData(new GiderlerDbClass { id = 5, aciklamasi = "Açıklama5", kime = "Tamer", tutar = 54, odemeTuruId = 2, kategoriId = 5, tarih = dt });
            modelBuilder.Entity<GiderlerDbClass>().HasData(new GiderlerDbClass { id = 6, aciklamasi = "Açıklama6", kime = "Tuncay", tutar = 51, odemeTuruId = 1, kategoriId = 6, tarih = dt });
            modelBuilder.Entity<GiderlerDbClass>().HasData(new GiderlerDbClass { id = 7, aciklamasi = "Açıklama7", kime = "Fatma", tutar = 90, odemeTuruId = 2, kategoriId = 7, tarih = dt });
            modelBuilder.Entity<GiderlerDbClass>().HasData(new GiderlerDbClass { id = 8, aciklamasi = "Açıklama8", kime = "Karaca", tutar = 100, odemeTuruId = 1, kategoriId = 8, tarih = dt });


            //******************** GiderlerDbClass Tablo Test Verisi Ekleme İşlemleri Bitişi ********************

            //******************** GelirlerDbClass Tablo Oluşturma İşlemleri ********************

            modelBuilder.Entity<GelirlerDbClass>().Property(x => x.aciklamasi)
                                                  .IsRequired()
                                                  .HasColumnName("Ürün Açıklaması")
                                                  .HasMaxLength(400);
            modelBuilder.Entity<GelirlerDbClass>().Property(x => x.kimden)
                                                  .IsRequired()
                                                  .HasColumnName("Kimden");
            modelBuilder.Entity<GelirlerDbClass>().Property(x => x.tutar)
                                                  .IsRequired()
                                                  .HasColumnName("Gelirin Tutarı");
            modelBuilder.Entity<GelirlerDbClass>().Property(x => x.tarih)
                                                  .IsRequired();
            modelBuilder.Entity<GiderlerDbClass>().Property(x => x.odemeTuruId)
                                                  .HasColumnName("Ödeme Türü Id");
            modelBuilder.Entity<GelirlerDbClass>().HasOne(x => x.odemeTuru)
                                                  .WithMany(odemeTuru => odemeTuru.Gelirler)
                                                  .HasForeignKey(f => f.odemeTuruId)
                                                  .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<GiderlerDbClass>().Property(x => x.kategoriId)
                                                  .HasColumnName("Kategori Id");
            modelBuilder.Entity<GelirlerDbClass>().HasOne(x => x.Kategori)
                                                  .WithMany(Kategori => Kategori.Gelirler)
                                                  .HasForeignKey(f => f.kategoriId)
                                                  .OnDelete(DeleteBehavior.NoAction);

            //******************** GelirlerDbClass Tablo Oluşturma İşlemleri Bitişi ********************

            //******************** GelirlerDbClass Tablo Test Verisi Ekleme İşlemleri ********************

            DateTime dtt = new DateTime(2022, 06, 11);

            modelBuilder.Entity<GelirlerDbClass>().HasData(new GelirlerDbClass { id = 1, aciklamasi = "Açıklama1", kimden = "Osman", tutar = 50, odemeTuruId = 1, kategoriId = 7, tarih = dtt });
            modelBuilder.Entity<GelirlerDbClass>().HasData(new GelirlerDbClass { id = 2, aciklamasi = "Açıklama2", kimden = "Mehmet", tutar = 10, odemeTuruId = 2, kategoriId = 7, tarih = dtt });
            modelBuilder.Entity<GelirlerDbClass>().HasData(new GelirlerDbClass { id = 3, aciklamasi = "Açıklama3", kimden = "Ali Olmuş", tutar = 100, odemeTuruId = 3, kategoriId = 7, tarih = dtt });
            modelBuilder.Entity<GelirlerDbClass>().HasData(new GelirlerDbClass { id = 4, aciklamasi = "Açıklama4", kimden = "Muhammed", tutar = 1050, odemeTuruId = 2, kategoriId = 7, tarih = dtt });
            modelBuilder.Entity<GelirlerDbClass>().HasData(new GelirlerDbClass { id = 5, aciklamasi = "Açıklama5", kimden = "Johny", tutar = 510, odemeTuruId = 1, kategoriId = 7, tarih = dtt });
            modelBuilder.Entity<GelirlerDbClass>().HasData(new GelirlerDbClass { id = 6, aciklamasi = "Açıklama6", kimden = "Adem", tutar = 20, odemeTuruId = 3, kategoriId = 7, tarih = dtt });
            modelBuilder.Entity<GelirlerDbClass>().HasData(new GelirlerDbClass { id = 7, aciklamasi = "Açıklama7", kimden = "Muzaffer", tutar = 5, odemeTuruId = 2, kategoriId = 7, tarih = dtt });


            //******************** GelirlerDbClass Tablo Test Verisi Ekleme İşlemleri Bitişi ********************

            //******************** PersonelDbClass Tablo Oluşturma İşlemleri ********************

            modelBuilder.Entity<PersonelDbClass>().Property(x => x.adi)
                                                  .IsRequired()
                                                  .HasColumnName("Personelin Adı")
                                                  .HasMaxLength(20);
            modelBuilder.Entity<PersonelDbClass>().Property(x => x.soyAdi)
                                                  .IsRequired()
                                                  .HasColumnName("Personelin Soyadı")
                                                  .HasMaxLength(20);
            modelBuilder.Entity<PersonelDbClass>().Property(x => x.görevi)
                                                  .IsRequired()
                                                  .HasColumnName("Görevi")
                                                  .HasMaxLength(20);
            modelBuilder.Entity<PersonelDbClass>().Property(x => x.maasi)
                                                  .IsRequired()
                                                  .HasColumnName("Personelin Maaşı");
            modelBuilder.Entity<PersonelDbClass>().Property(x => x.iseBaslamaTarihi)
                                                  .IsRequired();
            modelBuilder.Entity<PersonelDbClass>().Property(x => x.tatilGunu)
                                                  .IsRequired()
                                                  .HasColumnName("Tatil Günü")
                                                  .HasMaxLength(15);

            //******************** PersonelDbClass Tablo Oluşturma İşlemleri Bitişi ********************

            //******************** PersonelDbClass Tablo Test Verisi Ekleme İşlemleri ********************

            modelBuilder.Entity<PersonelDbClass>().HasData(new PersonelDbClass { id = 1, adi = "Ali Osman", soyAdi = "Karayel", görevi = "Kasiyer", maasi = 4200, tatilGunu = "Pazartesi" });
            modelBuilder.Entity<PersonelDbClass>().HasData(new PersonelDbClass { id = 2, adi = "Mehmet", soyAdi = "Küçük", görevi = "Temizlikçi", maasi = 4200, tatilGunu = "Salı" });
            modelBuilder.Entity<PersonelDbClass>().HasData(new PersonelDbClass { id = 3, adi = "Leyla", soyAdi = "Son", görevi = "Güvenlik", maasi = 5000, tatilGunu = "Çarşamba" });
            modelBuilder.Entity<PersonelDbClass>().HasData(new PersonelDbClass { id = 4, adi = "Merve", soyAdi = "Durmaz", görevi = "Sekreter", maasi = 4500, tatilGunu = "Perşembe" });


            //******************** PersonelDbClass Tablo Test Verisi Ekleme İşlemleri Bitişi ********************

            //******************** KullaniciDetayDbClass Tablo Oluşturma İşlemleri ********************

            modelBuilder.Entity<KullaniciDetayDbClass>().Property(x => x.adi)
                                                      .IsRequired()
                                                      .HasColumnName("Adı")
                                                      .HasMaxLength(40);
            modelBuilder.Entity<KullaniciDetayDbClass>().Property(x => x.vergiDairesi)
                                                      .IsRequired()
                                                      .HasColumnName("Vergi Dairesi");
            modelBuilder.Entity<KullaniciDetayDbClass>().Property(x => x.vergiDairesiNo)
                                                      .IsRequired()
                                                      .HasColumnName("Vergi Dairesi No");

            //******************** KullaniciDetayDbClass Tablo Oluşturma İşlemleri Bitişi ********************

            //******************** KullaniciDetayDbClass Tablo Test Verisi Ekleme İşlemleri ********************

            modelBuilder.Entity<KullaniciDetayDbClass>().HasData(new KullaniciDetayDbClass { id = 1, adi = "admin", vergiDairesi = "admin VD", vergiDairesiNo = "adminvdNo" });
            modelBuilder.Entity<KullaniciDetayDbClass>().HasData(new KullaniciDetayDbClass { id = 2, adi = "test", vergiDairesi = "test VD", vergiDairesiNo = "testvdno" });
            modelBuilder.Entity<KullaniciDetayDbClass>().HasData(new KullaniciDetayDbClass { id = 3, adi = "caner", vergiDairesi = "caner VD", vergiDairesiNo = "000000" });

            //******************** KullaniciDetayDbClass Tablo Test Verisi Ekleme İşlemleri Bitişi ********************

            //******************** AyarlarDbClass Tablo Oluşturma İşlemleri ********************

            modelBuilder.Entity<AyarlarDbClass>().Property(x => x.alarm)
                                                      .IsRequired()
                                                      .HasColumnName("Alarm")
                                                      .HasMaxLength(40);
            modelBuilder.Entity<AyarlarDbClass>().Property(x => x.bildirim)
                                                      .IsRequired()
                                                      .HasColumnName("Bildirim");
            modelBuilder.Entity<AyarlarDbClass>().Property(x => x.tema)
                                                      .IsRequired()
                                                      .HasColumnName("Tema");


            //******************** AyarlarDbClass Tablo Oluşturma İşlemleri Bitişi ********************

            //******************** TicaAyarlarDbClassriMallarDbClass Tablo Test Verisi Ekleme İşlemleri ********************

            modelBuilder.Entity<AyarlarDbClass>().HasData(new AyarlarDbClass { id = 1 });

            //******************** AyarlarDbClass Tablo Test Verisi Ekleme İşlemleri Bitişi ********************

            //******************** KartlarımDbClass Tablo Oluşturma İşlemleri ********************

            modelBuilder.Entity<KartlarımDbClass>().Property(x => x.kartAdi)
                                              .HasColumnName("Kart Adı")
                                              .IsRequired()
                                              .HasMaxLength(30);
            modelBuilder.Entity<KartlarımDbClass>().Property(x => x.kartNo)
                                              .HasColumnName("Kart Numarası")
                                              .IsRequired();                                              
            modelBuilder.Entity<KartlarımDbClass>().Property(x => x.sonKullanmaTarihi)
                                              .HasColumnName("Kartın Son Kullanma Tarihi")
                                              .IsRequired()
                                              .HasMaxLength(5);
            modelBuilder.Entity<KartlarımDbClass>().Property(x => x.CVCKodu)
                                              .HasColumnName("Kart CVC")
                                              .IsRequired()
                                              .HasMaxLength(3);
            modelBuilder.Entity<KartlarımDbClass>().Property(x => x.islemSınırı)
                                              .HasColumnName("islem Sınırı")
                                              .IsRequired();



            //******************** KartlarımDbClass Tablo Oluşturma İşlemleri Bitişi ********************
            modelBuilder.Entity<KartlarımDbClass>().HasData(new KartlarımDbClass { id =1,kartAdi="Ziraat Bankkart",kartNo="1234567891231234",sonKullanmaTarihi="06/28",islemSınırı=1000,CVCKodu="123"});


        }

    }
}
