namespace LastPractice_B4_Test_allFrameworks.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class WaitersTableMig : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Waiters",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Birthday = c.Int(nullable: false),
                        WorkHours = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Waiters");
        }
    }
}
