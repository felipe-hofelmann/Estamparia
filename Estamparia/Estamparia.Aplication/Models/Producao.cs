using Estamparia.Aplication.Models.BaseModels;
using System;
using System.Collections.Generic;

namespace Estamparia.Aplication.Models
{
    public class Producao : BaseModel
    {
        public DateTime Date { get; set; }
        public string HoraInicio { get; set; }
        public string HoraFim { get; set; }
        public int QuantidadeHora { get; set; }
        public float MediaFinal { get; set; }
        public List<Colaborador> Colaborador { get; set; }
        public MaquinaCarrossel Maquina { get; set; }
    }
}
