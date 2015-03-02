namespace GoalDigger.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BudgetCategories : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BudgetCategories",
                c => new
                    {
                        CategoryId = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(),
                        BudgetFlow = c.String(),
                    })
                .PrimaryKey(t => t.CategoryId);
            
            DropTable("dbo.Housings");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Housings",
                c => new
                    {
                        HousingID = c.Int(nullable: false, identity: true),
                        Date = c.String(),
                        Category = c.String(),
                        Flow = c.String(),
                        Amount = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.HousingID);
            
            DropTable("dbo.BudgetCategories");
        }
    }
}
