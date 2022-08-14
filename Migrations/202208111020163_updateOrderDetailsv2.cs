namespace BookStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateOrderDetailsv2 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.OrderDetails", name: "Userid", newName: "Usersid");
            RenameIndex(table: "dbo.OrderDetails", name: "IX_Userid", newName: "IX_Usersid");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.OrderDetails", name: "IX_Usersid", newName: "IX_Userid");
            RenameColumn(table: "dbo.OrderDetails", name: "Usersid", newName: "Userid");
        }
    }
}
