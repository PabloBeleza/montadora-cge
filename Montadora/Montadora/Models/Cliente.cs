using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Montadora.Models
{
    public class Cliente
    {
        public DateTime dataNascimento { get; set; }
        public string endereco { get; set; }
        public string numero { get; set; }
        public string orgaoExpedidor { get; set; }
        public string rg { get; set; }

    }
}