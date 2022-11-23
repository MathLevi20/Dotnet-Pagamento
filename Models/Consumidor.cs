namespace pagamento.Models
{
    public class Consumidor
    {
        public int Id {get; set;}
        public string Nome {get; set;}
        public Pedido Pedido {get;set;}
    }
}