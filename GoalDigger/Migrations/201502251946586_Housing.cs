namespace GoalDigger.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Housing : DbMigration
    {
        public override void Up()
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
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Housings");
        }
    }
}
