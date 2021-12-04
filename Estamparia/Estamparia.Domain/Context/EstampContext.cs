
using Estamparia.Aplication.Models;
using System.Data.Entity;

namespace Estamparia.Domain.Context
{
    public class EstampContext : DbContext
    {
        public DbSet<Colaborador> Colaboradores { get; set; }
        public DbSet<MaquinaCarrossel> Maquinas { get; set; }
        public DbSet<Producao> Producoes { get; set; }

        public EstampContext() : base(@"Data Source=DESKTOP-NGKOVQ9\SQLEXPRESS;Initial Catalog=EstampariaMvc;Integrated Security=True")
        {

        }
    }
}
