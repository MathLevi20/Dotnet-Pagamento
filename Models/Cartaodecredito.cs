namespace pagamento.Models
{
    public class Cartaodecredito:Pagamento
    {
        public string Numero {get;set;}
        public int Parcelas {get;set;}
    }
}