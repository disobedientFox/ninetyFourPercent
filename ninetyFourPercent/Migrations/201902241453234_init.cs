namespace ninetyFourPercent.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Levels",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Key = c.String(),
                        KeyType = c.Int(nullable: false),
                        Module = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Players",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Login = c.String(),
                        Password = c.String(),
                        Money = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PlayerProgresses",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Level_Id = c.Long(),
                        Player_Id = c.Long(),
                        Word_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Levels", t => t.Level_Id)
                .ForeignKey("dbo.Players", t => t.Player_Id)
                .ForeignKey("dbo.Words", t => t.Word_Id)
                .Index(t => t.Level_Id)
                .Index(t => t.Player_Id)
                .Index(t => t.Word_Id);
            
            CreateTable(
                "dbo.Words",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        SecretWord = c.String(),
                        Percent = c.Int(nullable: false),
                        Level_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Levels", t => t.Level_Id)
                .Index(t => t.Level_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PlayerProgresses", "Word_Id", "dbo.Words");
            DropForeignKey("dbo.Words", "Level_Id", "dbo.Levels");
            DropForeignKey("dbo.PlayerProgresses", "Player_Id", "dbo.Players");
            DropForeignKey("dbo.PlayerProgresses", "Level_Id", "dbo.Levels");
            DropIndex("dbo.Words", new[] { "Level_Id" });
            DropIndex("dbo.PlayerProgresses", new[] { "Word_Id" });
            DropIndex("dbo.PlayerProgresses", new[] { "Player_Id" });
            DropIndex("dbo.PlayerProgresses", new[] { "Level_Id" });
            DropTable("dbo.Words");
            DropTable("dbo.PlayerProgresses");
            DropTable("dbo.Players");
            DropTable("dbo.Levels");
        }
    }
}
