namespace pagamento.Models
{
    public class Pedido
    {
        public int Id { get; set; }
        public Boolean ComDesconto { get; set; }
        public Double Desconto { get; set; }
        public DateOnly Data { get; set; }
        public Consumidor? Consumidor { get; set; }
        public virtual ICollection<Produto> Produto {get;set;}
        public Pagamento Pagamento {get;set;}
    }
}