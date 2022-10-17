namespace PlakDukkaniYoneticiModulu.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ilk : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        YoneticiId = c.Int(nullable: false, identity: true),
                        KullaniciAdi = c.String(nullable: false, maxLength: 32),
                        Sifre = c.String(nullable: false),
                        AdSoyad = c.String(nullable: false, maxLength: 64),
                        KayitTarihi = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => new { t.YoneticiId, t.KullaniciAdi });
            
            CreateTable(
                "dbo.Albums",
                c => new
                    {
                        AlbumId = c.Int(nullable: false, identity: true),
                        AlbumAdi = c.String(nullable: false, maxLength: 32),
                        SanatciGrup = c.String(nullable: false, maxLength: 64),
                        CikisTarihi = c.DateTime(nullable: false),
                        Fiyati = c.Decimal(nullable: false, precision: 18, scale: 2),
                        IndirimOrani = c.Decimal(nullable: false, precision: 18, scale: 2),
                        IndirimliMi = c.Boolean(nullable: false),
                        SatistaMi = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.AlbumId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Albums");
            DropTable("dbo.Admins");
        }
    }
}
