namespace Todo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Todos : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Todos",
                c => new
                    {
                        Order = c.Int(nullable: false),
                        ID = c.Int(nullable: false, identity: true),
                        CreateDate = c.DateTimeOffset(precision: 7),
                        isActive = c.Boolean(nullable: false),
                        Title = c.String(nullable: false, maxLength: 50),
                        Description = c.String(nullable: false, maxLength: 100),
                        PhoneNumber = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Todos");
        }
    }
}
