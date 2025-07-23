namespace Teste19.Entities;

public class Funcionario
{
    public string Nome { get; private protected set; }
    public int HorasTrabalhadas { get; private protected set; }
    public decimal ValorHora { get; private protected set; }

    public Funcionario()
    {
    }

    public Funcionario(string nome, int horasTrabalhadas, decimal valorHora) : this()
    {
        Nome = nome;
        HorasTrabalhadas = horasTrabalhadas;
        ValorHora = valorHora;
    }

    public virtual decimal CalcularSalario()
    {
        return HorasTrabalhadas * ValorHora;
    }

    public override string ToString()
    {
        return $"{Nome}: {CalcularSalario():C}";
    }

}