namespace DesafioProjetoHospedagem.Models;

public class Pessoa(string nome, string sobrenome)
{
    public string Nome { get; set; } = nome;
    public string Sobrenome { get; set; } = sobrenome;
    public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();
}