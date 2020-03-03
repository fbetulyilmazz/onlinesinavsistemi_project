﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OnlineSinavSistemi.Dal.Concrete;

namespace OnlineSinavSistemi.Dal.Migrations
{
    [DbContext(typeof(OnlineSinavSistemiContext))]
    partial class OnlineSinavSistemiContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("OnlineSinavSistemi.Model.Data.Brans", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ad");

                    b.Property<DateTime?>("GuncellemeTarihi");

                    b.Property<DateTime>("KayitTarihi");

                    b.Property<string>("LogoUrl");

                    b.Property<bool>("SilindiMi");

                    b.Property<int?>("UstBransId");

                    b.HasKey("Id");

                    b.HasIndex("UstBransId");

                    b.ToTable("Brans");
                });

            modelBuilder.Entity("OnlineSinavSistemi.Model.Data.Ders", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Baslik");

                    b.Property<string>("DokumanUrl");

                    b.Property<DateTime?>("GuncellemeTarihi");

                    b.Property<string>("Icerik");

                    b.Property<DateTime>("KayitTarihi");

                    b.Property<int>("KursId");

                    b.Property<bool>("SilindiMi");

                    b.Property<string>("VideoUrl");

                    b.HasKey("Id");

                    b.HasIndex("KursId");

                    b.ToTable("Ders");
                });

            modelBuilder.Entity("OnlineSinavSistemi.Model.Data.Kullanici", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ad");

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<DateTime>("DogumTarihi");

                    b.Property<string>("EMail");

                    b.Property<string>("FotoUrl");

                    b.Property<DateTime?>("GuncellemeTarihi");

                    b.Property<DateTime>("KayitTarihi");

                    b.Property<string>("Sifre");

                    b.Property<bool>("SilindiMi");

                    b.Property<string>("Soyad");

                    b.Property<long>("Tc");

                    b.HasKey("Id");

                    b.ToTable("Kullanici");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Kullanici");
                });

            modelBuilder.Entity("OnlineSinavSistemi.Model.Data.KullaniciCevap", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cevap")
                        .IsRequired()
                        .HasConversion(new ValueConverter<string, string>(v => default(string), v => default(string), new ConverterMappingHints(size: 1)));

                    b.Property<DateTime?>("GuncellemeTarihi");

                    b.Property<DateTime>("KayitTarihi");

                    b.Property<int>("KullaniciSinavId");

                    b.Property<bool>("SilindiMi");

                    b.Property<int>("SoruId");

                    b.HasKey("Id");

                    b.HasIndex("KullaniciSinavId");

                    b.HasIndex("SoruId");

                    b.ToTable("KullaniciCevap");
                });

            modelBuilder.Entity("OnlineSinavSistemi.Model.Data.KullaniciDetay", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adres");

                    b.Property<DateTime?>("GuncellemeTarihi");

                    b.Property<DateTime>("KayitTarihi");

                    b.Property<int>("KullaniciId");

                    b.Property<string>("Mezuniyet");

                    b.Property<bool>("SilindiMi");

                    b.Property<string>("Telefon");

                    b.HasKey("Id");

                    b.HasIndex("KullaniciId");

                    b.ToTable("KullaniciDetay");
                });

            modelBuilder.Entity("OnlineSinavSistemi.Model.Data.KullaniciKurs", b =>
                {
                    b.Property<int>("KullaniciId");

                    b.Property<int>("KursId");

                    b.Property<string>("Durum");

                    b.Property<DateTime?>("GuncellemeTarihi");

                    b.Property<int>("Id");

                    b.Property<DateTime>("KayitTarihi");

                    b.Property<bool>("SilindiMi");

                    b.HasKey("KullaniciId", "KursId");

                    b.HasAlternateKey("Id");

                    b.HasIndex("KursId");

                    b.ToTable("KullaniciKurs");
                });

            modelBuilder.Entity("OnlineSinavSistemi.Model.Data.KullaniciRol", b =>
                {
                    b.Property<int>("KullaniciId");

                    b.Property<int>("RolId");

                    b.Property<DateTime?>("GuncellemeTarihi");

                    b.Property<int>("Id");

                    b.Property<DateTime>("KayitTarihi");

                    b.Property<bool>("SilindiMi");

                    b.HasKey("KullaniciId", "RolId");

                    b.HasAlternateKey("Id");

                    b.HasIndex("RolId");

                    b.ToTable("KullaniciRol");
                });

            modelBuilder.Entity("OnlineSinavSistemi.Model.Data.KullaniciSinav", b =>
                {
                    b.Property<int>("SinavId");

                    b.Property<int>("KullaniciId");

                    b.Property<DateTime?>("GuncellemeTarihi");

                    b.Property<int>("Id");

                    b.Property<DateTime>("KayitTarihi");

                    b.Property<bool>("SilindiMi");

                    b.Property<bool>("SinavBittiMi");

                    b.HasKey("SinavId", "KullaniciId");

                    b.HasIndex("KullaniciId");

                    b.ToTable("KullaniciSinav");
                });

            modelBuilder.Entity("OnlineSinavSistemi.Model.Data.Kurs", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BaslamaTarihi");

                    b.Property<DateTime>("BitisTarihi");

                    b.Property<bool>("BittiMi");

                    b.Property<DateTime?>("GuncellemeTarihi");

                    b.Property<string>("HaftalikCalisma");

                    b.Property<DateTime>("KayitTarihi");

                    b.Property<bool>("SilindiMi");

                    b.Property<int>("SinavId");

                    b.HasKey("Id");

                    b.HasIndex("SinavId")
                        .IsUnique();

                    b.ToTable("Kurs");
                });

            modelBuilder.Entity("OnlineSinavSistemi.Model.Data.KursDers", b =>
                {
                    b.Property<int>("KullaniciId");

                    b.Property<int>("DersId");

                    b.Property<DateTime?>("GuncellemeTarihi");

                    b.Property<int>("Id");

                    b.Property<DateTime>("KayitTarihi");

                    b.Property<bool>("SilindiMi");

                    b.HasKey("KullaniciId", "DersId");

                    b.HasAlternateKey("Id");

                    b.HasIndex("DersId");

                    b.ToTable("KursDers");
                });

            modelBuilder.Entity("OnlineSinavSistemi.Model.Data.KursMerkezi", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ad");

                    b.Property<string>("Adres");

                    b.Property<DateTime?>("GuncellemeTarihi");

                    b.Property<string>("Il");

                    b.Property<string>("Ilce");

                    b.Property<DateTime>("KayitTarihi");

                    b.Property<string>("LocationUrl");

                    b.Property<bool>("SilindiMi");

                    b.Property<short>("TelefonNumarasi");

                    b.HasKey("Id");

                    b.ToTable("KursMerkezi");
                });

            modelBuilder.Entity("OnlineSinavSistemi.Model.Data.Rol", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ad");

                    b.Property<DateTime?>("GuncellemeTarihi");

                    b.Property<DateTime>("KayitTarihi");

                    b.Property<bool>("SilindiMi");

                    b.HasKey("Id");

                    b.ToTable("Rol");
                });

            modelBuilder.Entity("OnlineSinavSistemi.Model.Data.Sikayet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Aciklama");

                    b.Property<int>("DersId");

                    b.Property<DateTime?>("GuncellemeTarihi");

                    b.Property<DateTime>("KayitTarihi");

                    b.Property<int>("KullaniciId");

                    b.Property<bool>("SilindiMi");

                    b.HasKey("Id");

                    b.HasIndex("KullaniciId");

                    b.ToTable("Sikayet");
                });

            modelBuilder.Entity("OnlineSinavSistemi.Model.Data.Sinav", b =>
                {
                    b.Property<int>("OgretmenId");

                    b.Property<int>("KaydedenKullaniciId");

                    b.Property<int>("BransId");

                    b.Property<DateTime?>("GuncellemeTarihi");

                    b.Property<int>("Id");

                    b.Property<DateTime>("KayitTarihi");

                    b.Property<byte>("Kontenjan");

                    b.Property<int>("KursMerkeziId");

                    b.Property<bool>("OturumBittiMi");

                    b.Property<bool>("SilindiMi");

                    b.Property<DateTime>("SinavSaati");

                    b.Property<DateTime>("SinavTarihi");

                    b.Property<string>("Sinif");

                    b.Property<byte>("SoruSayisi");

                    b.Property<int>("Suresi");

                    b.HasKey("OgretmenId", "KaydedenKullaniciId");

                    b.HasIndex("BransId");

                    b.HasIndex("KaydedenKullaniciId");

                    b.HasIndex("KursMerkeziId");

                    b.ToTable("Sinav");
                });

            modelBuilder.Entity("OnlineSinavSistemi.Model.Data.SinavSoru", b =>
                {
                    b.Property<int>("SinavId");

                    b.Property<int>("SoruId");

                    b.Property<DateTime?>("GuncellemeTarihi");

                    b.Property<int>("Id");

                    b.Property<DateTime>("KayitTarihi");

                    b.Property<bool>("SilindiMi");

                    b.HasKey("SinavId", "SoruId");

                    b.HasAlternateKey("Id");

                    b.HasIndex("SoruId");

                    b.ToTable("SinavSoru");
                });

            modelBuilder.Entity("OnlineSinavSistemi.Model.Data.Soru", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Aciklama");

                    b.Property<int>("BransId");

                    b.Property<string>("Cevap");

                    b.Property<DateTime?>("GuncellemeTarihi");

                    b.Property<DateTime>("KayitTarihi");

                    b.Property<int>("KullaniciId");

                    b.Property<bool>("OnaylandiMi");

                    b.Property<bool>("SilindiMi");

                    b.Property<string>("SoruMetni");

                    b.Property<int>("ZorlukSeviyesi");

                    b.HasKey("Id");

                    b.ToTable("Soru");
                });

            modelBuilder.Entity("OnlineSinavSistemi.Model.Data.Yorum", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Aciklama");

                    b.Property<int>("DersId");

                    b.Property<DateTime?>("GuncellemeTarihi");

                    b.Property<DateTime>("KayitTarihi");

                    b.Property<int>("KullaniciId");

                    b.Property<bool>("SilindiMi");

                    b.HasKey("Id");

                    b.HasIndex("DersId");

                    b.HasIndex("KullaniciId");

                    b.ToTable("Yorum");
                });

            modelBuilder.Entity("OnlineSinavSistemi.Model.Data.Ogretmen", b =>
                {
                    b.HasBaseType("OnlineSinavSistemi.Model.Data.Kullanici");

                    b.HasDiscriminator().HasValue("Ogretmen");
                });

            modelBuilder.Entity("OnlineSinavSistemi.Model.Data.Yonetici", b =>
                {
                    b.HasBaseType("OnlineSinavSistemi.Model.Data.Kullanici");

                    b.HasDiscriminator().HasValue("Yonetici");
                });

            modelBuilder.Entity("OnlineSinavSistemi.Model.Data.Brans", b =>
                {
                    b.HasOne("OnlineSinavSistemi.Model.Data.Brans", "UstBransi")
                        .WithMany()
                        .HasForeignKey("UstBransId");
                });

            modelBuilder.Entity("OnlineSinavSistemi.Model.Data.Ders", b =>
                {
                    b.HasOne("OnlineSinavSistemi.Model.Data.Kurs", "Kurs")
                        .WithMany("Ders")
                        .HasForeignKey("KursId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("OnlineSinavSistemi.Model.Data.KullaniciCevap", b =>
                {
                    b.HasOne("OnlineSinavSistemi.Model.Data.KullaniciSinav", "KullaniciSinav")
                        .WithMany("KullaniciSinavCevaplari")
                        .HasForeignKey("KullaniciSinavId")
                        .HasPrincipalKey("Id")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("OnlineSinavSistemi.Model.Data.Soru", "Soru")
                        .WithMany()
                        .HasForeignKey("SoruId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("OnlineSinavSistemi.Model.Data.KullaniciDetay", b =>
                {
                    b.HasOne("OnlineSinavSistemi.Model.Data.Kullanici", "Kullanici")
                        .WithMany()
                        .HasForeignKey("KullaniciId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("OnlineSinavSistemi.Model.Data.KullaniciKurs", b =>
                {
                    b.HasOne("OnlineSinavSistemi.Model.Data.Kullanici", "Kullanici")
                        .WithMany("KullaniciKurs")
                        .HasForeignKey("KullaniciId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("OnlineSinavSistemi.Model.Data.Kurs", "Kurs")
                        .WithMany("KullaniciKurs")
                        .HasForeignKey("KursId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("OnlineSinavSistemi.Model.Data.KullaniciRol", b =>
                {
                    b.HasOne("OnlineSinavSistemi.Model.Data.Kullanici", "Kullanici")
                        .WithMany("KullaniciRoller")
                        .HasForeignKey("KullaniciId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("OnlineSinavSistemi.Model.Data.Rol", "Rol")
                        .WithMany("KullaniciRoller")
                        .HasForeignKey("RolId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("OnlineSinavSistemi.Model.Data.KullaniciSinav", b =>
                {
                    b.HasOne("OnlineSinavSistemi.Model.Data.Kullanici", "Kullanici")
                        .WithMany("KullaniciSinavlari")
                        .HasForeignKey("KullaniciId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("OnlineSinavSistemi.Model.Data.Sinav", "Sinav")
                        .WithMany("KullaniciSinav")
                        .HasForeignKey("SinavId")
                        .HasPrincipalKey("Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("OnlineSinavSistemi.Model.Data.Kurs", b =>
                {
                    b.HasOne("OnlineSinavSistemi.Model.Data.Sinav", "Sinav")
                        .WithOne("Kurs")
                        .HasForeignKey("OnlineSinavSistemi.Model.Data.Kurs", "SinavId")
                        .HasPrincipalKey("OnlineSinavSistemi.Model.Data.Sinav", "Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("OnlineSinavSistemi.Model.Data.KursDers", b =>
                {
                    b.HasOne("OnlineSinavSistemi.Model.Data.Ders", "Ders")
                        .WithMany("KullanicininDersleri")
                        .HasForeignKey("DersId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("OnlineSinavSistemi.Model.Data.Kullanici", "Kullanici")
                        .WithMany("KullanicininDersleri")
                        .HasForeignKey("KullaniciId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("OnlineSinavSistemi.Model.Data.Sikayet", b =>
                {
                    b.HasOne("OnlineSinavSistemi.Model.Data.Kullanici", "Kullanicisi")
                        .WithMany()
                        .HasForeignKey("KullaniciId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("OnlineSinavSistemi.Model.Data.Sinav", b =>
                {
                    b.HasOne("OnlineSinavSistemi.Model.Data.Brans", "Brans")
                        .WithMany()
                        .HasForeignKey("BransId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("OnlineSinavSistemi.Model.Data.Yonetici", "KaydedenKullanici")
                        .WithMany("KaydedilenSinavlar")
                        .HasForeignKey("KaydedenKullaniciId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("OnlineSinavSistemi.Model.Data.KursMerkezi", "KursMerkezi")
                        .WithMany()
                        .HasForeignKey("KursMerkeziId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("OnlineSinavSistemi.Model.Data.Ogretmen", "Ogretmen")
                        .WithMany("OgretmeniOlunanSinavlar")
                        .HasForeignKey("OgretmenId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("OnlineSinavSistemi.Model.Data.SinavSoru", b =>
                {
                    b.HasOne("OnlineSinavSistemi.Model.Data.Sinav", "Sinav")
                        .WithMany("SinavSorulari")
                        .HasForeignKey("SinavId")
                        .HasPrincipalKey("Id")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("OnlineSinavSistemi.Model.Data.Soru", "Soru")
                        .WithMany("SinavSorulari")
                        .HasForeignKey("SoruId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("OnlineSinavSistemi.Model.Data.Yorum", b =>
                {
                    b.HasOne("OnlineSinavSistemi.Model.Data.Ders", "Ders")
                        .WithMany()
                        .HasForeignKey("DersId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("OnlineSinavSistemi.Model.Data.Kullanici", "Kullanici")
                        .WithMany()
                        .HasForeignKey("KullaniciId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}