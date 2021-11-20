using Estamparia.Aplication.Enums;
using Estamparia.Aplication.Models.BaseModels;
using System;

namespace Estamparia.Aplication.Models
{
    public class Colaborador : BaseModel
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public int Idade { get; set; }
        public EnumSexo Sexo { get; set; }
        public DateTime DataAdimissao { get; set; }
        public DateTime DataDemissao { get; set; }
        public EnumFuncao Funcao { get; set; }
    }
}
