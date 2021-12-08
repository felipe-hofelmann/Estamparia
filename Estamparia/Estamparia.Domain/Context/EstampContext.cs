
using Estamparia.Aplication.Models;
using System.Data.Entity;

namespace Estamparia.Domain.Context
{
    public class EstampContext : DbContext
    {
        public DbSet<Colaborador> Colaboradores { get; set; }
        public DbSet<MaquinaCarrossel> Maquinas { get; set; }
        public DbSet<Producao> Producoes { get; set; }

        public EstampContext() : base(@"Data Source=LAPTOP-0HMNEP5V\SQLEXPRESS;Initial Catalog=Estamparia;Persist Security Info=True;User ID=sa;Password=sa123")
        {

        }
    }
}
