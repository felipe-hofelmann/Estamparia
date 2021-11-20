using Estamparia.Aplication.Interfaces.IRepositorys;
using Estamparia.Aplication.Models;
using Estamparia.Domain.Repository.BaseRepositorys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estamparia.Infra.Repository
{
    public class ProducaoRepository : BaseRepository<Producao>, IProducaoRepository
    {
    }
}
