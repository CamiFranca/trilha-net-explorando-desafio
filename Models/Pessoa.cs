namespace DesafioProjetoHospedagem.Models;

public class Pessoa
{
    public Pessoa() { }
    //constructor
    public Pessoa(string nome)
    {
        Nome = nome;
    }
    //contructor
    public Pessoa(string nome, string sobrenome)
    {
        Nome = nome;
        Sobrenome = sobrenome;
    }
    // propriedades
    public string Nome { get; set; }
    public string Sobrenome { get; set; }
    public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();
}