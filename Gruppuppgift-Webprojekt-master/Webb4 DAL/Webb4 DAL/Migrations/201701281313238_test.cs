namespace Webb4_DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Adresses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Street = c.String(),
                        PostalNr = c.Int(nullable: false),
                        City = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Appartments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Area = c.Int(nullable: false),
                        Rent = c.Int(nullable: false),
                        NrOfRooms = c.Int(nullable: false),
                        BuildinFloors = c.Int(nullable: false),
                        Floor = c.Int(nullable: false),
                        BuildYear = c.DateTime(nullable: false),
                        MoveInDate = c.DateTime(nullable: false),
                        LastAdmissionDate = c.DateTime(nullable: false),
                        PublicationDate = c.DateTime(nullable: false),
                        Avalible = c.Boolean(nullable: false),
                        Adress_Id = c.Int(),
                        District_Id = c.Int(),
                        Housing_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Adresses", t => t.Adress_Id)
                .ForeignKey("dbo.Districts", t => t.District_Id)
                .ForeignKey("dbo.HousingTypes", t => t.Housing_Id)
                .Index(t => t.Adress_Id)
                .Index(t => t.District_Id)
                .Index(t => t.Housing_Id);
            
            CreateTable(
                "dbo.Districts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Features",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.HousingTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AppartmentPhotoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.Guid(nullable: false),
                        URL = c.String(),
                        Description = c.String(),
                        Approved = c.Boolean(nullable: false),
                        AppartmentId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Appartments", t => t.AppartmentId, cascadeDelete: true)
                .Index(t => t.AppartmentId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        Fname = c.String(),
                        Lname = c.String(),
                        Email = c.String(),
                        Password = c.String(),
                        Adress_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Adresses", t => t.Adress_Id)
                .Index(t => t.Adress_Id);
            
            CreateTable(
                "dbo.Bookings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Appartment_Id = c.Int(),
                        booker_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Appartments", t => t.Appartment_Id)
                .ForeignKey("dbo.Users", t => t.booker_Id)
                .Index(t => t.Appartment_Id)
                .Index(t => t.booker_Id);
            
            CreateTable(
                "dbo.FeaturesAppartments",
                c => new
                    {
                        Features_Id = c.Int(nullable: false),
                        Appartment_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Features_Id, t.Appartment_Id })
                .ForeignKey("dbo.Features", t => t.Features_Id, cascadeDelete: true)
                .ForeignKey("dbo.Appartments", t => t.Appartment_Id, cascadeDelete: true)
                .Index(t => t.Features_Id)
                .Index(t => t.Appartment_Id);
            
            CreateTable(
                "dbo.UserAppartments",
                c => new
                    {
                        User_Id = c.Int(nullable: false),
                        Appartment_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.User_Id, t.Appartment_Id })
                .ForeignKey("dbo.Users", t => t.User_Id, cascadeDelete: true)
                .ForeignKey("dbo.Appartments", t => t.Appartment_Id, cascadeDelete: true)
                .Index(t => t.User_Id)
                .Index(t => t.Appartment_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Bookings", "booker_Id", "dbo.Users");
            DropForeignKey("dbo.Bookings", "Appartment_Id", "dbo.Appartments");
            DropForeignKey("dbo.UserAppartments", "Appartment_Id", "dbo.Appartments");
            DropForeignKey("dbo.UserAppartments", "User_Id", "dbo.Users");
            DropForeignKey("dbo.Users", "Adress_Id", "dbo.Adresses");
            DropForeignKey("dbo.AppartmentPhotoes", "AppartmentId", "dbo.Appartments");
            DropForeignKey("dbo.Appartments", "Housing_Id", "dbo.HousingTypes");
            DropForeignKey("dbo.FeaturesAppartments", "Appartment_Id", "dbo.Appartments");
            DropForeignKey("dbo.FeaturesAppartments", "Features_Id", "dbo.Features");
            DropForeignKey("dbo.Appartments", "District_Id", "dbo.Districts");
            DropForeignKey("dbo.Appartments", "Adress_Id", "dbo.Adresses");
            DropIndex("dbo.UserAppartments", new[] { "Appartment_Id" });
            DropIndex("dbo.UserAppartments", new[] { "User_Id" });
            DropIndex("dbo.FeaturesAppartments", new[] { "Appartment_Id" });
            DropIndex("dbo.FeaturesAppartments", new[] { "Features_Id" });
            DropIndex("dbo.Bookings", new[] { "booker_Id" });
            DropIndex("dbo.Bookings", new[] { "Appartment_Id" });
            DropIndex("dbo.Users", new[] { "Adress_Id" });
            DropIndex("dbo.AppartmentPhotoes", new[] { "AppartmentId" });
            DropIndex("dbo.Appartments", new[] { "Housing_Id" });
            DropIndex("dbo.Appartments", new[] { "District_Id" });
            DropIndex("dbo.Appartments", new[] { "Adress_Id" });
            DropTable("dbo.UserAppartments");
            DropTable("dbo.FeaturesAppartments");
            DropTable("dbo.Bookings");
            DropTable("dbo.Users");
            DropTable("dbo.AppartmentPhotoes");
            DropTable("dbo.HousingTypes");
            DropTable("dbo.Features");
            DropTable("dbo.Districts");
            DropTable("dbo.Appartments");
            DropTable("dbo.Adresses");
        }
    }
}
