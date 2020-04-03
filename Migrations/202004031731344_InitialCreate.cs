namespace RecipeTracker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Direction",
                c => new
                    {
                        DirectionID = c.Guid(nullable: false),
                        StepNum = c.Int(nullable: false),
                        Instruction = c.String(),
                        RecipeID = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.DirectionID)
                .ForeignKey("dbo.Recipe", t => t.RecipeID, cascadeDelete: true)
                .Index(t => t.RecipeID);
            
            CreateTable(
                "dbo.Ingredient",
                c => new
                    {
                        IngredientID = c.Guid(nullable: false),
                        Name = c.String(),
                        Quantity = c.Double(nullable: false),
                        InPantry = c.Boolean(nullable: false),
                        RecipeID = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.IngredientID)
                .ForeignKey("dbo.Recipe", t => t.RecipeID, cascadeDelete: true)
                .Index(t => t.RecipeID);
            
            CreateTable(
                "dbo.Recipe",
                c => new
                    {
                        RecipeID = c.Guid(nullable: false),
                        Name = c.String(),
                        CuisineType = c.Int(nullable: false),
                        UserID = c.String(maxLength: 128),
                        URL = c.String(),
                        Rating = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.RecipeID)
                .ForeignKey("dbo.User", t => t.UserID)
                .Index(t => t.UserID);
            
            CreateTable(
                "dbo.User",
                c => new
                    {
                        UserID = c.String(nullable: false, maxLength: 128),
                        LastName = c.String(nullable: false, maxLength: 30),
                        FirstName = c.String(nullable: false, maxLength: 20),
                        Email = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.UserID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Recipe", "UserID", "dbo.User");
            DropForeignKey("dbo.Ingredient", "RecipeID", "dbo.Recipe");
            DropForeignKey("dbo.Direction", "RecipeID", "dbo.Recipe");
            DropIndex("dbo.Recipe", new[] { "UserID" });
            DropIndex("dbo.Ingredient", new[] { "RecipeID" });
            DropIndex("dbo.Direction", new[] { "RecipeID" });
            DropTable("dbo.User");
            DropTable("dbo.Recipe");
            DropTable("dbo.Ingredient");
            DropTable("dbo.Direction");
        }
    }
}
