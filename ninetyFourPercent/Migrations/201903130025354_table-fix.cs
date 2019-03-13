namespace ninetyFourPercent.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tablefix : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.PlayerProgresses", "Level_Id", "dbo.Levels");
            DropForeignKey("dbo.PlayerProgresses", "Player_Id", "dbo.Players");
            DropForeignKey("dbo.PlayerProgresses", "Word_Id", "dbo.Words");
            DropIndex("dbo.PlayerProgresses", new[] { "Level_Id" });
            DropIndex("dbo.PlayerProgresses", new[] { "Player_Id" });
            DropIndex("dbo.PlayerProgresses", new[] { "Word_Id" });
            AddColumn("dbo.PlayerProgresses", "Level_Id1", c => c.Long());
            AddColumn("dbo.PlayerProgresses", "Player_Id1", c => c.Long());
            AddColumn("dbo.PlayerProgresses", "Word_Id1", c => c.Long());
            AlterColumn("dbo.PlayerProgresses", "Level_Id", c => c.Long(nullable: false));
            AlterColumn("dbo.PlayerProgresses", "Player_Id", c => c.Long(nullable: false));
            AlterColumn("dbo.PlayerProgresses", "Word_Id", c => c.Long(nullable: false));
            CreateIndex("dbo.PlayerProgresses", "Level_Id1");
            CreateIndex("dbo.PlayerProgresses", "Player_Id1");
            CreateIndex("dbo.PlayerProgresses", "Word_Id1");
            AddForeignKey("dbo.PlayerProgresses", "Level_Id1", "dbo.Levels", "Id");
            AddForeignKey("dbo.PlayerProgresses", "Player_Id1", "dbo.Players", "Id");
            AddForeignKey("dbo.PlayerProgresses", "Word_Id1", "dbo.Words", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PlayerProgresses", "Word_Id1", "dbo.Words");
            DropForeignKey("dbo.PlayerProgresses", "Player_Id1", "dbo.Players");
            DropForeignKey("dbo.PlayerProgresses", "Level_Id1", "dbo.Levels");
            DropIndex("dbo.PlayerProgresses", new[] { "Word_Id1" });
            DropIndex("dbo.PlayerProgresses", new[] { "Player_Id1" });
            DropIndex("dbo.PlayerProgresses", new[] { "Level_Id1" });
            AlterColumn("dbo.PlayerProgresses", "Word_Id", c => c.Long());
            AlterColumn("dbo.PlayerProgresses", "Player_Id", c => c.Long());
            AlterColumn("dbo.PlayerProgresses", "Level_Id", c => c.Long());
            DropColumn("dbo.PlayerProgresses", "Word_Id1");
            DropColumn("dbo.PlayerProgresses", "Player_Id1");
            DropColumn("dbo.PlayerProgresses", "Level_Id1");
            CreateIndex("dbo.PlayerProgresses", "Word_Id");
            CreateIndex("dbo.PlayerProgresses", "Player_Id");
            CreateIndex("dbo.PlayerProgresses", "Level_Id");
            AddForeignKey("dbo.PlayerProgresses", "Word_Id", "dbo.Words", "Id");
            AddForeignKey("dbo.PlayerProgresses", "Player_Id", "dbo.Players", "Id");
            AddForeignKey("dbo.PlayerProgresses", "Level_Id", "dbo.Levels", "Id");
        }
    }
}
