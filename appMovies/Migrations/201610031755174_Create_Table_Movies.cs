namespace appMovies.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_Movies : DbMigration
    {
        public override void Up()
        {
            CreateTable(
               "dbo.Movies",
               c => new
               {
                   Id = c.Int(nullable: false, identity: true),
                   Title = c.String(),
                   Description = c.String(),
                   Year = c.String(),
                   Director = c.String(),
               })
               .PrimaryKey(t => t.Id);
        }
        
        public override void Down()
        {
            DropTable("dbo.Movies");
        }
    }
}
