namespace GoalDigger.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddHashField : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Wishes", "Hash", x => x.String());
        }
        
        public override void Down()
        {
        }
    }
}
