namespace ControlInventario.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.productos",
                c => new
                    {
                        productId = c.Int(nullable: false, identity: true),
                        productCode = c.String(),
                        productName = c.String(),
                        description = c.String(),
                        quantity = c.Int(nullable: false),
                        precio = c.Decimal(nullable: false, precision: 18, scale: 2),
                        supplierId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.productId)
                .ForeignKey("dbo.proveedores", t => t.supplierId, cascadeDelete: true)
                .Index(t => t.supplierId);
            
            CreateTable(
                "dbo.proveedores",
                c => new
                    {
                        supplierId = c.Int(nullable: false, identity: true),
                        supplierCode = c.String(),
                        supplierName = c.String(),
                        Email = c.String(),
                        Phone = c.String(),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.supplierId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.productos", "supplierId", "dbo.proveedores");
            DropIndex("dbo.productos", new[] { "supplierId" });
            DropTable("dbo.proveedores");
            DropTable("dbo.productos");
        }
    }
}
