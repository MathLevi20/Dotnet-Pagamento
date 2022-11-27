using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace pagamento_prova.Models
{
    public class Cartaodecredito: Pagamento
    {
        public int Id {get;set;}
        [Display(Name = "Nome no Cartão")]
        public string Nome {get;set;}
        public string Numero {get;set;}
        [Display(Name = "Digito Verificador")]
        public string Digito {get;set;}
        public int Parcelas {get;set;}
    }
}