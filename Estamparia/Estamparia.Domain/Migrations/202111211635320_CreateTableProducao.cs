namespace Estamparia.Infra.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTableProducao : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Producaos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        HoraInicio = c.String(),
                        HoraFim = c.String(),
                        QuantidadeHora = c.Int(nullable: false),
                        MediaFinal = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Producaos");
        }
    }
}
