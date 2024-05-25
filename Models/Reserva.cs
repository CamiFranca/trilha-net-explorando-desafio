using System.Threading.Tasks;
using System;

namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {

        //propriedades
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }
        // constructor
        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }
        //metodo que valida informações
        public string CadastrarHospedes(List<Pessoa> hospedes)
        {
            
            if (hospedes.Count <= Suite.Capacidade)
            {
                return "capacidade aderida";
            }
            else
            {
               
                throw new ArgumentException("O número de pessoas é maior que a capacidade da suíte");
            }
        }
        //metodo
        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }
        //metodo
        public int ObterQuantidadeHospedes(List<Pessoa> hospedes)
        {
      
            int numHospedes = hospedes.Count;
            return numHospedes;
        }
        //metodo
        public decimal CalcularValorDiaria(int diasReservados, Suite suite )
        {
         
            suite = Suite;
            decimal valor = diasReservados * suite.ValorDiaria ;

            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
            // *IMPLEMENTE AQUI*
            if (diasReservados >= 10)
            {
                decimal porcentagem = (valor * 10)/100;
                valor -= porcentagem;
            }

            return valor;
        }
    }
}