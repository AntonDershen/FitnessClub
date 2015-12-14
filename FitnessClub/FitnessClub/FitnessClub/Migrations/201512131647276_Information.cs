namespace FitnessClub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Information : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Information",
                c => new
                    {
                        InformationId = c.Int(nullable: false, identity: true),
                        Header = c.String(),
                        Body = c.String(),
                    })
                .PrimaryKey(t => t.InformationId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Information");
        }
    }
}
