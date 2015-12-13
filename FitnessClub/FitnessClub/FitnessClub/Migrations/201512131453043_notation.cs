namespace FitnessClub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class notation : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Notations",
                c => new
                    {
                        NotationId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        PhoneNumber = c.String(),
                    })
                .PrimaryKey(t => t.NotationId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Notations");
        }
    }
}
