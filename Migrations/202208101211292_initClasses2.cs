namespace BookStore.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class initClasses2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Carts",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    BookId = c.Int(nullable: false),
                    UserId = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.Users",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Name = c.String(nullable: false),
                    Email = c.String(),
                    Address = c.String(),
                    PhoneNumber = c.String(),
                    Role = c.String(),
                    password = c.String(),
                })
                .PrimaryKey(t => t.Id);

        }

        public override void Down()
        {
            DropTable("dbo.Users");
            DropTable("dbo.Carts");
        }
    }
}
