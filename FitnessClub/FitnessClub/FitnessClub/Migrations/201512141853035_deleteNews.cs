namespace FitnessClub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deleteNews : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.News");
        }
        
        public override void Down()
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
    }
}
