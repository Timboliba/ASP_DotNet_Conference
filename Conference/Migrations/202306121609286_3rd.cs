namespace Conference.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _3rd : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Congres", "Strings", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Congres", "Strings");
        }
    }
}
