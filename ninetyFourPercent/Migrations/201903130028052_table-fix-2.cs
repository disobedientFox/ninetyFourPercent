namespace ninetyFourPercent.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tablefix2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.PlayerProgresses", "Level_Id1", "dbo.Levels");
            DropForeignKey("dbo.PlayerProgresses", "Player_Id1", "dbo.Players");
            DropForeignKey("dbo.PlayerProgresses", "Word_Id1", "dbo.Words");
            DropIndex("dbo.PlayerProgresses", new[] { "Level_Id1" });
            DropIndex("dbo.PlayerProgresses", new[] { "Player_Id1" });
            DropIndex("dbo.PlayerProgresses", new[] { "Word_Id1" });
            DropColumn("dbo.PlayerProgresses", "Level_Id");
            DropColumn("dbo.PlayerProgresses", "Player_Id");
            DropColumn("dbo.PlayerProgresses", "Word_Id");
            RenameColumn(table: "dbo.PlayerProgresses", name: "Level_Id1", newName: "Level_Id");
            RenameColumn(table: "dbo.PlayerProgresses", name: "Player_Id1", newName: "Player_Id");
            RenameColumn(table: "dbo.PlayerProgresses", name: "Word_Id1", newName: "Word_Id");
            AlterColumn("dbo.PlayerProgresses", "Level_Id", c => c.Long(nullable: false));
            AlterColumn("dbo.PlayerProgresses", "Player_Id", c => c.Long(nullable: false));
            AlterColumn("dbo.PlayerProgresses", "Word_Id", c => c.Long(nullable: false));
            CreateIndex("dbo.PlayerProgresses", "Player_Id");
            CreateIndex("dbo.PlayerProgresses", "Level_Id");
            CreateIndex("dbo.PlayerProgresses", "Word_Id");
            AddForeignKey("dbo.PlayerProgresses", "Level_Id", "dbo.Levels", "Id", cascadeDelete: true);
            AddForeignKey("dbo.PlayerProgresses", "Player_Id", "dbo.Players", "Id", cascadeDelete: true);
            AddForeignKey("dbo.PlayerProgresses", "Word_Id", "dbo.Words", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PlayerProgresses", "Word_Id", "dbo.Words");
            DropForeignKey("dbo.PlayerProgresses", "Player_Id", "dbo.Players");
            DropForeignKey("dbo.PlayerProgresses", "Level_Id", "dbo.Levels");
            DropIndex("dbo.PlayerProgresses", new[] { "Word_Id" });
            DropIndex("dbo.PlayerProgresses", new[] { "Level_Id" });
            DropIndex("dbo.PlayerProgresses", new[] { "Player_Id" });
            AlterColumn("dbo.PlayerProgresses", "Word_Id", c => c.Long());
            AlterColumn("dbo.PlayerProgresses", "Player_Id", c => c.Long());
            AlterColumn("dbo.PlayerProgresses", "Level_Id", c => c.Long());
            RenameColumn(table: "dbo.PlayerProgresses", name: "Word_Id", newName: "Word_Id1");
            RenameColumn(table: "dbo.PlayerProgresses", name: "Player_Id", newName: "Player_Id1");
            RenameColumn(table: "dbo.PlayerProgresses", name: "Level_Id", newName: "Level_Id1");
            AddColumn("dbo.PlayerProgresses", "Word_Id", c => c.Long(nullable: false));
            AddColumn("dbo.PlayerProgresses", "Player_Id", c => c.Long(nullable: false));
            AddColumn("dbo.PlayerProgresses", "Level_Id", c => c.Long(nullable: false));
            CreateIndex("dbo.PlayerProgresses", "Word_Id1");
            CreateIndex("dbo.PlayerProgresses", "Player_Id1");
            CreateIndex("dbo.PlayerProgresses", "Level_Id1");
            AddForeignKey("dbo.PlayerProgresses", "Word_Id1", "dbo.Words", "Id");
            AddForeignKey("dbo.PlayerProgresses", "Player_Id1", "dbo.Players", "Id");
            AddForeignKey("dbo.PlayerProgresses", "Level_Id1", "dbo.Levels", "Id");
        }
    }
}
