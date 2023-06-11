namespace Conference.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class firstMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Administrateurs",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        titre = c.String(),
                        userName = c.String(),
                        password = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Comites",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Nom = c.String(),
                        Congre_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Congres", t => t.Congre_Id)
                .Index(t => t.Congre_Id);
            
            CreateTable(
                "dbo.MembresComites",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Nom = c.String(),
                        Role = c.String(),
                        ComiteID = c.String(),
                        Comites_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Comites", t => t.Comites_Id)
                .Index(t => t.Comites_Id);
            
            CreateTable(
                "dbo.Conferenciers",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Nom = c.String(),
                        Role = c.String(),
                        ComiteID = c.String(),
                        Congre_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Congres", t => t.Congre_Id)
                .Index(t => t.Congre_Id);
            
            CreateTable(
                "dbo.Congres",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        titre = c.String(),
                        DateDebut = c.DateTime(nullable: false),
                        DateFin = c.DateTime(nullable: false),
                        Lieu_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Lieux", t => t.Lieu_Id)
                .Index(t => t.Lieu_Id);
            
            CreateTable(
                "dbo.Lieux",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Nom = c.String(),
                        Adresse = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Sessions",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        titre = c.String(),
                        CongrésId = c.Int(nullable: false),
                        Congres_Id = c.Guid(),
                        Responsable_Id = c.Guid(),
                        Participant_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Congres", t => t.Congres_Id)
                .ForeignKey("dbo.Responsables", t => t.Responsable_Id)
                .ForeignKey("dbo.Participants", t => t.Participant_Id)
                .Index(t => t.Congres_Id)
                .Index(t => t.Responsable_Id)
                .Index(t => t.Participant_Id);
            
            CreateTable(
                "dbo.Responsables",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Nom = c.String(),
                        Fonction = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Participants",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Nom = c.String(),
                        password = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Sessions", "Participant_Id", "dbo.Participants");
            DropForeignKey("dbo.Sessions", "Responsable_Id", "dbo.Responsables");
            DropForeignKey("dbo.Sessions", "Congres_Id", "dbo.Congres");
            DropForeignKey("dbo.Congres", "Lieu_Id", "dbo.Lieux");
            DropForeignKey("dbo.Conferenciers", "Congre_Id", "dbo.Congres");
            DropForeignKey("dbo.Comites", "Congre_Id", "dbo.Congres");
            DropForeignKey("dbo.MembresComites", "Comites_Id", "dbo.Comites");
            DropIndex("dbo.Sessions", new[] { "Participant_Id" });
            DropIndex("dbo.Sessions", new[] { "Responsable_Id" });
            DropIndex("dbo.Sessions", new[] { "Congres_Id" });
            DropIndex("dbo.Congres", new[] { "Lieu_Id" });
            DropIndex("dbo.Conferenciers", new[] { "Congre_Id" });
            DropIndex("dbo.MembresComites", new[] { "Comites_Id" });
            DropIndex("dbo.Comites", new[] { "Congre_Id" });
            DropTable("dbo.Participants");
            DropTable("dbo.Responsables");
            DropTable("dbo.Sessions");
            DropTable("dbo.Lieux");
            DropTable("dbo.Congres");
            DropTable("dbo.Conferenciers");
            DropTable("dbo.MembresComites");
            DropTable("dbo.Comites");
            DropTable("dbo.Administrateurs");
        }
    }
}
