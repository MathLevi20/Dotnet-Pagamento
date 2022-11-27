using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pagamento_prova.Models
{
    public class Pedido
    {
        public int Id { get; set; }
        public bool ComDesconto { get; set; }
        public double? Desconto { get; set; }
        public DateTime Data { get; set; }
        public int? IdConsumidor {get;set;}
        public virtual Consumidor? Consumidor { get; set; }
        public virtual ICollection<Produto> Produto {get;set;}
        public int? IdPagamento {get;set;}
        public virtual Pagamento? Pagamento {get;set;}
    }
}