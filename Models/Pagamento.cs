using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace pagamento_prova.Models
{
    public class Pagamento
    {
        public int Id {get;set;}
        public Double Valor {get;set;}
        public string Status {get;set;}
        [ForeignKey("IdPedido")]
        public Pedido? Pedido {get;set;}
    }
}