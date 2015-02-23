namespace GoalDigger.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StringWishPrice : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Wishes", "Price", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Wishes", "Price", c => c.Int(nullable: false));
        }
    }
}
