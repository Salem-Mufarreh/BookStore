namespace BookStore.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class frst : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Books",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Title = c.String(nullable: false),
                    Author = c.String(),
                    Description = c.String(),
                    Quantity = c.Int(nullable: false),
                    Status = c.String(),
                    Price = c.Double(nullable: false),
                })
                .PrimaryKey(t => t.Id);

        }

        public override void Down()
        {
            DropTable("dbo.Books");
        }
    }
}
