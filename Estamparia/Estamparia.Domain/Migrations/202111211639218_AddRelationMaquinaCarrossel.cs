namespace Estamparia.Infra.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRelationMaquinaCarrossel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Producaos", "Maquina_Id", c => c.Int());
            CreateIndex("dbo.Producaos", "Maquina_Id");
            AddForeignKey("dbo.Producaos", "Maquina_Id", "dbo.MaquinaCarrossels", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Producaos", "Maquina_Id", "dbo.MaquinaCarrossels");
            DropIndex("dbo.Producaos", new[] { "Maquina_Id" });
            DropColumn("dbo.Producaos", "Maquina_Id");
        }
    }
}
