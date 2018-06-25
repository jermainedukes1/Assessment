namespace RazorMvcApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class firstM : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Owners",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        City = c.String(),
                        State = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Vehicles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Make = c.String(),
                        Year = c.Int(nullable: false),
                        Model = c.String(),
                        vin = c.String(),
                        Owner_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Owners", t => t.Owner_Id)
                .Index(t => t.Owner_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Vehicles", "Owner_Id", "dbo.Owners");
            DropIndex("dbo.Vehicles", new[] { "Owner_Id" });
            DropTable("dbo.Vehicles");
            DropTable("dbo.Owners");
        }
    }
}
