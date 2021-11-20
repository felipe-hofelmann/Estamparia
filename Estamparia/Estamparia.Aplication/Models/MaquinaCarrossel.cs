using Estamparia.Aplication.Models.BaseModels;

namespace Estamparia.Aplication.Models
{
    public class MaquinaCarrossel : BaseModel
    {
        public string Nome { get; set; }
        public int QuantidadeChapas { get; set; }
        public string Marca { get; set; }
    }
}
