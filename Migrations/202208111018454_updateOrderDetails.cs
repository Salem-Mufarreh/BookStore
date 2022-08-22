namespace BookStore.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class updateOrderDetails : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.OrderDetails", name: "Bookid", newName: "Booksid");
            RenameIndex(table: "dbo.OrderDetails", name: "IX_Bookid", newName: "IX_Booksid");
        }

        public override void Down()
        {
            RenameIndex(table: "dbo.OrderDetails", name: "IX_Booksid", newName: "IX_Bookid");
            RenameColumn(table: "dbo.OrderDetails", name: "Booksid", newName: "Bookid");
        }
    }
}
