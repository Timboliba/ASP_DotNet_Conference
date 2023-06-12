namespace Conference.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _1st : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Comites",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nom = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Conferenciers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nom = c.String(),
                        Role = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Congres",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        titre = c.String(),
                        DateDebut = c.DateTime(nullable: false),
                        DateFin = c.DateTime(nullable: false),
                        Details = c.String(),
                        Lieu = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MembresComites",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nom = c.String(),
                        Role = c.String(),
                        ComiteID = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Participants",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nom = c.String(),
                        Password = c.String(),
                        Role = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Responsables",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nom = c.String(),
                        Fonction = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Sessions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        titre = c.String(),
                        CongrésId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Sessions");
            DropTable("dbo.Responsables");
            DropTable("dbo.Participants");
            DropTable("dbo.MembresComites");
            DropTable("dbo.Congres");
            DropTable("dbo.Conferenciers");
            DropTable("dbo.Comites");
        }
    }
}
