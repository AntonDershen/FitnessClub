namespace FitnessClub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class news : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.News",
                c => new
                    {
                        NewsId = c.Int(nullable: false, identity: true),
                        Header = c.String(),
                        Body = c.String(),
                        ImageUrl = c.String(),
                    })
                .PrimaryKey(t => t.NewsId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.News");
        }
    }
}
