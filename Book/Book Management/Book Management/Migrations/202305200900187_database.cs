namespace Book_Management.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class database : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BookName = c.String(nullable: false, maxLength: 50),
                        PublisherName = c.String(nullable: false, maxLength: 50),
                        PublisherAge = c.Int(nullable: false),
                        PageNo = c.Int(nullable: false),
                        PublishDate = c.DateTime(nullable: false),
                        BookType = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Books");
        }
    }
}
