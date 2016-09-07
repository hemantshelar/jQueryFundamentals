namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedgenderdobcolumnstoUserInfo : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UserInfoes", "Gender", c => c.Int(nullable: false));
            AddColumn("dbo.UserInfoes", "DOB", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.UserInfoes", "DOB");
            DropColumn("dbo.UserInfoes", "Gender");
        }
    }
}
