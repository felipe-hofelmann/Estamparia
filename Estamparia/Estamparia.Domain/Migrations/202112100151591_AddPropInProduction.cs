namespace Estamparia.Infra.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPropInProduction : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Producaos", "QuantidadePecas", c => c.Int(nullable: false));
            AddColumn("dbo.Producaos", "ValorUnitario", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Producaos", "ValorUnitario");
            DropColumn("dbo.Producaos", "QuantidadePecas");
        }
    }
}
