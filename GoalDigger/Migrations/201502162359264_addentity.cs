namespace GoalDigger.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addentity : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Wishes",
                c => new
                    {
                        WishId = c.Int(nullable: false, identity: true),
                        Date = c.String(),
                        Name = c.String(),
                        Price = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.WishId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Wishes");
        }
    }
}
