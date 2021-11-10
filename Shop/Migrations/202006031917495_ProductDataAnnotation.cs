namespace Shop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProductDataAnnotation : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Products", newName: "Produkty");
            RenameColumn(table: "dbo.Produkty", name: "Name", newName: "Nazwa");
            AlterColumn("dbo.Produkty", "Nazwa", c => c.String(nullable: false, maxLength: 60));
            AlterColumn("dbo.Produkty", "Description", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Produkty", "Description", c => c.String());
            AlterColumn("dbo.Produkty", "Nazwa", c => c.String());
            RenameColumn(table: "dbo.Produkty", name: "Nazwa", newName: "Name");
            RenameTable(name: "dbo.Produkty", newName: "Products");
        }
    }
}
