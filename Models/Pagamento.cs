namespace pagamento.Models
{
    public class Pagamento
    {
        public int Id {get;set;}
        public Double Valor {get;set;}
        public string Status {get;set;}
        public Pedido? Pedido { get; set; }

        public string? Discriminator { get; }
    }
}