using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace pagamento_prova.Models
{
    [Table("Consumidor")]
    public class Consumidor
    {
        [Key]
        public int Id {get; set;}
        public string Nome {get; set;}
        public string Email {get; set;}
        public string Senha {get; set;}
        public string Documento {get; set;}
        public virtual ICollection<Pedido>? Pedido{get;set;}
    }
}