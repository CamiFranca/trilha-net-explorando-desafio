namespace DesafioProjetoHospedagem.Models
{
    public class Suite
    {
        public Suite() { }
        // contrutor. exige que a instancia receba sempre três parâmetros
        public Suite(string tipoSuite, int capacidade, decimal valorDiaria)
        {
            TipoSuite = tipoSuite;
            Capacidade = capacidade;
            ValorDiaria = valorDiaria;
        }
        //propriedades
        public string TipoSuite { get; set; }
        public int Capacidade { get; set; }
        public decimal ValorDiaria { get; set; }
    }
}