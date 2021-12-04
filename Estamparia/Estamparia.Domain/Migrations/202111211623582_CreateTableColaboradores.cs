namespace Estamparia.Infra.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTableColaboradores : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Colaboradors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Sobrenome = c.String(),
                        Idade = c.Int(nullable: false),
                        Sexo = c.Short(nullable: false),
                        DataAdimissao = c.DateTime(nullable: false),
                        DataDemissao = c.DateTime(nullable: false),
                        Funcao = c.Short(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Colaboradors");
        }
    }
}
