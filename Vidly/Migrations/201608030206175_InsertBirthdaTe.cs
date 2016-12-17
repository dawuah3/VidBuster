namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InsertBirthdaTe : DbMigration
    {
        public override void Up()
        {
            Sql("Update Customers Set BirthDate = 09/14/06 where Id = 1");
        }
        
        public override void Down()
        {
        }
    }
}
