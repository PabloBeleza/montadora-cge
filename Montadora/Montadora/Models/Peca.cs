using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Montadora.Models
{
    public class Peca
    {
        public DateTime dataFabricacao { get; set; }
        public string descricao { get; set; }
        public string numeroSerie { get; set; }
        public int pecaId { get; set; }
        public decimal valor { get; set; }
    }
}