namespace pagamento.Models
{
    public class Boleto:Pagamento
    {
        public string Codigo {get;set;} 
        public Boolean Confirmado {get;set;} 

        
    }
}