namespace Shop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProductDataAnnotationFix : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Produkty", newName: "Products");
            RenameColumn(table: "dbo.Products", name: "Nazwa", newName: "Name");
        }
        
        public override void Down()
        {
            RenameColumn(table: "dbo.Products", name: "Name", newName: "Nazwa");
            RenameTable(name: "dbo.Products", newName: "Produkty");
        }
    }
}
