namespace GoalDigger.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DateTimeSwitch : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Wishes", "Date", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Wishes", "Date", c => c.String());
        }
    }
}
