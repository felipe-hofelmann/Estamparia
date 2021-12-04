namespace Estamparia.Infra.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTableMaquinaCarrossel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MaquinaCarrossels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        QuantidadeChapas = c.Int(nullable: false),
                        Marca = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.MaquinaCarrossels");
        }
    }
}
