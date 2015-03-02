namespace GoalDigger.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CategorizeSpending : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Wishes", "Category", c => c.String());
            AddColumn("dbo.Wishes", "Flow", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Wishes", "Flow");
            DropColumn("dbo.Wishes", "Category");
        }
    }
}
