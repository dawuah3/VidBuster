namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipTypes : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.MembershipTypes", "MemberShipTypeId", "dbo.MembershipTypes");
            DropIndex("dbo.MembershipTypes", new[] { "MemberShipTypeId" });
            DropColumn("dbo.MembershipTypes", "MemberShipTypeId");
            Sql("Insert into MembershipTypes (Id, SignUpFee, DurationInMonths, DiscountRate) Values (1,0,0,0)");
            Sql("Insert into MembershipTypes (Id, SignUpFee, DurationInMonths, DiscountRate) Values (2,30,1,0)");
            Sql("Insert into MembershipTypes (Id, SignUpFee, DurationInMonths, DiscountRate) Values (3,80,30,15)");
            Sql("Insert into MembershipTypes (Id, SignUpFee, DurationInMonths, DiscountRate) Values (4,300,12,15)");



        }

        public override void Down()
        {
            AddColumn("dbo.MembershipTypes", "MemberShipTypeId", c => c.Byte(nullable: false));
            CreateIndex("dbo.MembershipTypes", "MemberShipTypeId");
            AddForeignKey("dbo.MembershipTypes", "MemberShipTypeId", "dbo.MembershipTypes", "Id");
        }
    }
}
