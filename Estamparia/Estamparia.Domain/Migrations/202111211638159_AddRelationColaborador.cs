namespace Estamparia.Infra.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRelationColaborador : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Colaboradors", "Producao_Id", c => c.Int());
            CreateIndex("dbo.Colaboradors", "Producao_Id");
            AddForeignKey("dbo.Colaboradors", "Producao_Id", "dbo.Producaos", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Colaboradors", "Producao_Id", "dbo.Producaos");
            DropIndex("dbo.Colaboradors", new[] { "Producao_Id" });
            DropColumn("dbo.Colaboradors", "Producao_Id");
        }
    }
}
