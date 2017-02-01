namespace Webb4_DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class addimgurl : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Appartments", "MainImgUrl", c => c.String());
        }

        public override void Down()
        {
            DropColumn("dbo.Appartments", "MainImgUrl");
        }
    }
}
