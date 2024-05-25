using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
//cira  uma lista de hospedes com o nome de ''hospedes'' do tipo Pessoa.
List<Pessoa> hospedes = new List<Pessoa>();
//instancia a classe Pessoa e passa o parametro nome
Pessoa p1 = new Pessoa(nome: "Hóspede 1");
Pessoa p2 = new Pessoa(nome: "Hóspede 2");
Pessoa p3 = new Pessoa(nome: "Hóspede 3");
Pessoa p4 = new Pessoa(nome: "Hóspede 4");
//aqui adiciona as duas pessoas instanciadas acima dentro da lista de pessoas do tipo Pessoa criada acima
hospedes.Add(p1);
hospedes.Add(p2);
hospedes.Add(p3);
hospedes.Add(p4);
// instancia a classe Suite e passa os parâmetros 
Suite suite = new Suite(tipoSuite: "Premium", capacidade: 4 , valorDiaria: 30);

// Cria uma nova reserva, passando a suíte e os hóspedes
Reserva reserva = new Reserva(diasReservados: 10);
// chama o metodo cadastrar suite e passa como parametro a instancia feito acima
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);
int dias = reserva.DiasReservados;

// Exibe a quantidade de hóspedes e o valor da diária
//chama a instancia de Reserva feito acima e chama os metodos, as instancia herdam todos os metodos.
Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes(hospedes)}");
Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria( dias, suite )}");
Console.WriteLine($"Cadastro: {reserva.CadastrarHospedes(hospedes )}");