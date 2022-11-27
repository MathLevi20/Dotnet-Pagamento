using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace pagamento_prova.Models
{
    public class Boleto: Pagamento
    {
        public int Id {get;set;} 
        [Display(Name = "Código_de_barras")]
        public string Codigo {get;set;} 
        public bool Confirmado {get;set;} 
    }
}