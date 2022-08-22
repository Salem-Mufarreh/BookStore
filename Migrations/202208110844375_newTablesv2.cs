namespace BookStore.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class newTablesv2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cart_Item",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Sessionid = c.Int(nullable: false),
                    BooksId = c.Int(nullable: false),
                    Created = c.DateTime(nullable: false),
                    LastUpdated = c.DateTime(nullable: false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Books", t => t.BooksId, cascadeDelete: true)
                .ForeignKey("dbo.Shoping_Session", t => t.Sessionid, cascadeDelete: true)
                .Index(t => t.Sessionid)
                .Index(t => t.BooksId);

            CreateTable(
                "dbo.Shoping_Session",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    UsersId = c.Int(nullable: false),
                    Total = c.Decimal(nullable: false, precision: 18, scale: 2),
                    CreatedDate = c.DateTime(nullable: false),
                    UpdatedDate = c.DateTime(nullable: false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UsersId, cascadeDelete: true)
                .Index(t => t.UsersId);

            CreateTable(
                "dbo.OrderDetails",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Bookid = c.Int(nullable: false),
                    Userid = c.Int(nullable: false),
                    Total = c.Int(nullable: false),
                    Created = c.DateTime(nullable: false),
                    Status = c.String(),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Books", t => t.Bookid, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.Userid, cascadeDelete: true)
                .Index(t => t.Bookid)
                .Index(t => t.Userid);

        }

        public override void Down()
        {
            DropForeignKey("dbo.OrderDetails", "Userid", "dbo.Users");
            DropForeignKey("dbo.OrderDetails", "Bookid", "dbo.Books");
            DropForeignKey("dbo.Cart_Item", "Sessionid", "dbo.Shoping_Session");
            DropForeignKey("dbo.Shoping_Session", "UsersId", "dbo.Users");
            DropForeignKey("dbo.Cart_Item", "BooksId", "dbo.Books");
            DropIndex("dbo.OrderDetails", new[] { "Userid" });
            DropIndex("dbo.OrderDetails", new[] { "Bookid" });
            DropIndex("dbo.Shoping_Session", new[] { "UsersId" });
            DropIndex("dbo.Cart_Item", new[] { "BooksId" });
            DropIndex("dbo.Cart_Item", new[] { "Sessionid" });
            DropTable("dbo.OrderDetails");
            DropTable("dbo.Shoping_Session");
            DropTable("dbo.Cart_Item");
        }
    }
}
