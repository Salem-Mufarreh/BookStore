namespace BookStore.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class addUsers : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "Active", c => c.String());
        }

        public override void Down()
        {
            DropColumn("dbo.Users", "Active");
        }
    }
}
