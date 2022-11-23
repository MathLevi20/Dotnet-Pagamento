namespace pagamento.Models
{
    public class Cartaodecredito:Pagamento
    {
        public int Id {get;set;}
        public string Numero {get;set;}
        public int Parcelas {get;set;}
    }
}