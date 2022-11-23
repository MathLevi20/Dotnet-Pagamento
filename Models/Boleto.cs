namespace pagamento.Models
{
    public class Boleto:Pagamento
    {
        public int Id {get;set;} 
        public string Codigo {get;set;} 
        public Boolean Confirmado {get;set;} 

    }
}