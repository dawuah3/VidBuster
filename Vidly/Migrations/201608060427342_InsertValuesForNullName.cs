namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InsertValuesForNullName : DbMigration
    {
        public override void Up()
        {
            Sql("Update Movies Set Name = 'Empty' Where Name = NULL");
            AlterColumn("dbo.Movies", "Name", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "Name", c => c.String());
        }
    }
}
