using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineSinavSistemi.Dal.Migrations
{
    public partial class version10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Brans",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SilindiMi = table.Column<bool>(nullable: false),
                    KayitTarihi = table.Column<DateTime>(nullable: false),
                    GuncellemeTarihi = table.Column<DateTime>(nullable: true),
                    UstBransId = table.Column<int>(nullable: true),
                    Ad = table.Column<string>(nullable: true),
                    LogoUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brans", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Brans_Brans_UstBransId",
                        column: x => x.UstBransId,
                        principalTable: "Brans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Kullanici",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SilindiMi = table.Column<bool>(nullable: false),
                    KayitTarihi = table.Column<DateTime>(nullable: false),
                    GuncellemeTarihi = table.Column<DateTime>(nullable: true),
                    Ad = table.Column<string>(nullable: true),
                    Soyad = table.Column<string>(nullable: true),
                    Tc = table.Column<long>(nullable: false),
                    DogumTarihi = table.Column<DateTime>(nullable: false),
                    EMail = table.Column<string>(nullable: true),
                    Sifre = table.Column<string>(nullable: true),
                    FotoUrl = table.Column<string>(nullable: true),
                    Discriminator = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kullanici", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KursMerkezi",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SilindiMi = table.Column<bool>(nullable: false),
                    KayitTarihi = table.Column<DateTime>(nullable: false),
                    GuncellemeTarihi = table.Column<DateTime>(nullable: true),
                    Ad = table.Column<string>(nullable: true),
                    Adres = table.Column<string>(nullable: true),
                    TelefonNumarasi = table.Column<short>(nullable: false),
                    Ilce = table.Column<string>(nullable: true),
                    Il = table.Column<string>(nullable: true),
                    LocationUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KursMerkezi", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rol",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SilindiMi = table.Column<bool>(nullable: false),
                    KayitTarihi = table.Column<DateTime>(nullable: false),
                    GuncellemeTarihi = table.Column<DateTime>(nullable: true),
                    Ad = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rol", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Soru",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SilindiMi = table.Column<bool>(nullable: false),
                    KayitTarihi = table.Column<DateTime>(nullable: false),
                    GuncellemeTarihi = table.Column<DateTime>(nullable: true),
                    SoruMetni = table.Column<string>(nullable: true),
                    Cevap = table.Column<string>(nullable: true),
                    ZorlukSeviyesi = table.Column<int>(nullable: false),
                    BransId = table.Column<int>(nullable: false),
                    Aciklama = table.Column<string>(nullable: true),
                    KullaniciId = table.Column<int>(nullable: false),
                    OnaylandiMi = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Soru", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KullaniciDetay",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SilindiMi = table.Column<bool>(nullable: false),
                    KayitTarihi = table.Column<DateTime>(nullable: false),
                    GuncellemeTarihi = table.Column<DateTime>(nullable: true),
                    KullaniciId = table.Column<int>(nullable: false),
                    Mezuniyet = table.Column<string>(nullable: true),
                    Adres = table.Column<string>(nullable: true),
                    Telefon = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KullaniciDetay", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KullaniciDetay_Kullanici_KullaniciId",
                        column: x => x.KullaniciId,
                        principalTable: "Kullanici",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sikayet",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SilindiMi = table.Column<bool>(nullable: false),
                    KayitTarihi = table.Column<DateTime>(nullable: false),
                    GuncellemeTarihi = table.Column<DateTime>(nullable: true),
                    KullaniciId = table.Column<int>(nullable: false),
                    DersId = table.Column<int>(nullable: false),
                    Aciklama = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sikayet", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sikayet_Kullanici_KullaniciId",
                        column: x => x.KullaniciId,
                        principalTable: "Kullanici",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sinav",
                columns: table => new
                {
                    OgretmenId = table.Column<int>(nullable: false),
                    KaydedenKullaniciId = table.Column<int>(nullable: false),
                    Id = table.Column<int>(nullable: false),
                    SilindiMi = table.Column<bool>(nullable: false),
                    KayitTarihi = table.Column<DateTime>(nullable: false),
                    GuncellemeTarihi = table.Column<DateTime>(nullable: true),
                    KursMerkeziId = table.Column<int>(nullable: false),
                    SinavTarihi = table.Column<DateTime>(nullable: false),
                    SinavSaati = table.Column<DateTime>(nullable: false),
                    Suresi = table.Column<int>(nullable: false),
                    SoruSayisi = table.Column<byte>(nullable: false),
                    Sinif = table.Column<string>(nullable: true),
                    BransId = table.Column<int>(nullable: false),
                    Kontenjan = table.Column<byte>(nullable: false),
                    OturumBittiMi = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sinav", x => new { x.OgretmenId, x.KaydedenKullaniciId });
                    table.UniqueConstraint("AK_Sinav_Id", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sinav_Brans_BransId",
                        column: x => x.BransId,
                        principalTable: "Brans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Sinav_Kullanici_KaydedenKullaniciId",
                        column: x => x.KaydedenKullaniciId,
                        principalTable: "Kullanici",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Sinav_KursMerkezi_KursMerkeziId",
                        column: x => x.KursMerkeziId,
                        principalTable: "KursMerkezi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Sinav_Kullanici_OgretmenId",
                        column: x => x.OgretmenId,
                        principalTable: "Kullanici",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "KullaniciRol",
                columns: table => new
                {
                    KullaniciId = table.Column<int>(nullable: false),
                    RolId = table.Column<int>(nullable: false),
                    Id = table.Column<int>(nullable: false),
                    SilindiMi = table.Column<bool>(nullable: false),
                    KayitTarihi = table.Column<DateTime>(nullable: false),
                    GuncellemeTarihi = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KullaniciRol", x => new { x.KullaniciId, x.RolId });
                    table.UniqueConstraint("AK_KullaniciRol_Id", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KullaniciRol_Kullanici_KullaniciId",
                        column: x => x.KullaniciId,
                        principalTable: "Kullanici",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KullaniciRol_Rol_RolId",
                        column: x => x.RolId,
                        principalTable: "Rol",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KullaniciSinav",
                columns: table => new
                {
                    KullaniciId = table.Column<int>(nullable: false),
                    SinavId = table.Column<int>(nullable: false),
                    Id = table.Column<int>(nullable: false),
                    SilindiMi = table.Column<bool>(nullable: false),
                    KayitTarihi = table.Column<DateTime>(nullable: false),
                    GuncellemeTarihi = table.Column<DateTime>(nullable: true),
                    SinavBittiMi = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KullaniciSinav", x => new { x.SinavId, x.KullaniciId });
                    table.UniqueConstraint("AK_KullaniciSinav_Id", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KullaniciSinav_Kullanici_KullaniciId",
                        column: x => x.KullaniciId,
                        principalTable: "Kullanici",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KullaniciSinav_Sinav_SinavId",
                        column: x => x.SinavId,
                        principalTable: "Sinav",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Kurs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SilindiMi = table.Column<bool>(nullable: false),
                    KayitTarihi = table.Column<DateTime>(nullable: false),
                    GuncellemeTarihi = table.Column<DateTime>(nullable: true),
                    BaslamaTarihi = table.Column<DateTime>(nullable: false),
                    BitisTarihi = table.Column<DateTime>(nullable: false),
                    BittiMi = table.Column<bool>(nullable: false),
                    SinavId = table.Column<int>(nullable: false),
                    HaftalikCalisma = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kurs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Kurs_Sinav_SinavId",
                        column: x => x.SinavId,
                        principalTable: "Sinav",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SinavSoru",
                columns: table => new
                {
                    SinavId = table.Column<int>(nullable: false),
                    SoruId = table.Column<int>(nullable: false),
                    Id = table.Column<int>(nullable: false),
                    SilindiMi = table.Column<bool>(nullable: false),
                    KayitTarihi = table.Column<DateTime>(nullable: false),
                    GuncellemeTarihi = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SinavSoru", x => new { x.SinavId, x.SoruId });
                    table.UniqueConstraint("AK_SinavSoru_Id", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SinavSoru_Sinav_SinavId",
                        column: x => x.SinavId,
                        principalTable: "Sinav",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SinavSoru_Soru_SoruId",
                        column: x => x.SoruId,
                        principalTable: "Soru",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KullaniciCevap",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SilindiMi = table.Column<bool>(nullable: false),
                    KayitTarihi = table.Column<DateTime>(nullable: false),
                    GuncellemeTarihi = table.Column<DateTime>(nullable: true),
                    KullaniciSinavId = table.Column<int>(nullable: false),
                    SoruId = table.Column<int>(nullable: false),
                    Cevap = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KullaniciCevap", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KullaniciCevap_KullaniciSinav_KullaniciSinavId",
                        column: x => x.KullaniciSinavId,
                        principalTable: "KullaniciSinav",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_KullaniciCevap_Soru_SoruId",
                        column: x => x.SoruId,
                        principalTable: "Soru",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SilindiMi = table.Column<bool>(nullable: false),
                    KayitTarihi = table.Column<DateTime>(nullable: false),
                    GuncellemeTarihi = table.Column<DateTime>(nullable: true),
                    KursId = table.Column<int>(nullable: false),
                    Baslik = table.Column<string>(nullable: true),
                    Icerik = table.Column<string>(nullable: true),
                    VideoUrl = table.Column<string>(nullable: true),
                    DokumanUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ders_Kurs_KursId",
                        column: x => x.KursId,
                        principalTable: "Kurs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KullaniciKurs",
                columns: table => new
                {
                    KursId = table.Column<int>(nullable: false),
                    KullaniciId = table.Column<int>(nullable: false),
                    Id = table.Column<int>(nullable: false),
                    SilindiMi = table.Column<bool>(nullable: false),
                    KayitTarihi = table.Column<DateTime>(nullable: false),
                    GuncellemeTarihi = table.Column<DateTime>(nullable: true),
                    Durum = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KullaniciKurs", x => new { x.KullaniciId, x.KursId });
                    table.UniqueConstraint("AK_KullaniciKurs_Id", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KullaniciKurs_Kullanici_KullaniciId",
                        column: x => x.KullaniciId,
                        principalTable: "Kullanici",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KullaniciKurs_Kurs_KursId",
                        column: x => x.KursId,
                        principalTable: "Kurs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KursDers",
                columns: table => new
                {
                    KullaniciId = table.Column<int>(nullable: false),
                    DersId = table.Column<int>(nullable: false),
                    Id = table.Column<int>(nullable: false),
                    SilindiMi = table.Column<bool>(nullable: false),
                    KayitTarihi = table.Column<DateTime>(nullable: false),
                    GuncellemeTarihi = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KursDers", x => new { x.KullaniciId, x.DersId });
                    table.UniqueConstraint("AK_KursDers_Id", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KursDers_Ders_DersId",
                        column: x => x.DersId,
                        principalTable: "Ders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KursDers_Kullanici_KullaniciId",
                        column: x => x.KullaniciId,
                        principalTable: "Kullanici",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Yorum",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SilindiMi = table.Column<bool>(nullable: false),
                    KayitTarihi = table.Column<DateTime>(nullable: false),
                    GuncellemeTarihi = table.Column<DateTime>(nullable: true),
                    DersId = table.Column<int>(nullable: false),
                    KullaniciId = table.Column<int>(nullable: false),
                    Aciklama = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yorum", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Yorum_Ders_DersId",
                        column: x => x.DersId,
                        principalTable: "Ders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Yorum_Kullanici_KullaniciId",
                        column: x => x.KullaniciId,
                        principalTable: "Kullanici",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Brans_UstBransId",
                table: "Brans",
                column: "UstBransId");

            migrationBuilder.CreateIndex(
                name: "IX_Ders_KursId",
                table: "Ders",
                column: "KursId");

            migrationBuilder.CreateIndex(
                name: "IX_KullaniciCevap_KullaniciSinavId",
                table: "KullaniciCevap",
                column: "KullaniciSinavId");

            migrationBuilder.CreateIndex(
                name: "IX_KullaniciCevap_SoruId",
                table: "KullaniciCevap",
                column: "SoruId");

            migrationBuilder.CreateIndex(
                name: "IX_KullaniciDetay_KullaniciId",
                table: "KullaniciDetay",
                column: "KullaniciId");

            migrationBuilder.CreateIndex(
                name: "IX_KullaniciKurs_KursId",
                table: "KullaniciKurs",
                column: "KursId");

            migrationBuilder.CreateIndex(
                name: "IX_KullaniciRol_RolId",
                table: "KullaniciRol",
                column: "RolId");

            migrationBuilder.CreateIndex(
                name: "IX_KullaniciSinav_KullaniciId",
                table: "KullaniciSinav",
                column: "KullaniciId");

            migrationBuilder.CreateIndex(
                name: "IX_Kurs_SinavId",
                table: "Kurs",
                column: "SinavId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_KursDers_DersId",
                table: "KursDers",
                column: "DersId");

            migrationBuilder.CreateIndex(
                name: "IX_Sikayet_KullaniciId",
                table: "Sikayet",
                column: "KullaniciId");

            migrationBuilder.CreateIndex(
                name: "IX_Sinav_BransId",
                table: "Sinav",
                column: "BransId");

            migrationBuilder.CreateIndex(
                name: "IX_Sinav_KaydedenKullaniciId",
                table: "Sinav",
                column: "KaydedenKullaniciId");

            migrationBuilder.CreateIndex(
                name: "IX_Sinav_KursMerkeziId",
                table: "Sinav",
                column: "KursMerkeziId");

            migrationBuilder.CreateIndex(
                name: "IX_SinavSoru_SoruId",
                table: "SinavSoru",
                column: "SoruId");

            migrationBuilder.CreateIndex(
                name: "IX_Yorum_DersId",
                table: "Yorum",
                column: "DersId");

            migrationBuilder.CreateIndex(
                name: "IX_Yorum_KullaniciId",
                table: "Yorum",
                column: "KullaniciId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KullaniciCevap");

            migrationBuilder.DropTable(
                name: "KullaniciDetay");

            migrationBuilder.DropTable(
                name: "KullaniciKurs");

            migrationBuilder.DropTable(
                name: "KullaniciRol");

            migrationBuilder.DropTable(
                name: "KursDers");

            migrationBuilder.DropTable(
                name: "Sikayet");

            migrationBuilder.DropTable(
                name: "SinavSoru");

            migrationBuilder.DropTable(
                name: "Yorum");

            migrationBuilder.DropTable(
                name: "KullaniciSinav");

            migrationBuilder.DropTable(
                name: "Rol");

            migrationBuilder.DropTable(
                name: "Soru");

            migrationBuilder.DropTable(
                name: "Ders");

            migrationBuilder.DropTable(
                name: "Kurs");

            migrationBuilder.DropTable(
                name: "Sinav");

            migrationBuilder.DropTable(
                name: "Brans");

            migrationBuilder.DropTable(
                name: "Kullanici");

            migrationBuilder.DropTable(
                name: "KursMerkezi");
        }
    }
}
