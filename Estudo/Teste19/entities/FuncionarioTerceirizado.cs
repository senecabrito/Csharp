namespace Teste19.Entities;

public class FuncionarioTerceirizado : Funcionario
{
    public decimal Adicional { get; private protected set; }

    public FuncionarioTerceirizado()
    {
    }

    public FuncionarioTerceirizado(string nome, int horasTrabalhadas, decimal valorHora, decimal adicional)
        : base(nome, horasTrabalhadas, valorHora)
    {
        Adicional = adicional;
    }

    public override decimal CalcularSalario()
    {
        return base.CalcularSalario() + (Adicional * 1.1m);
    }

    public override string ToString()
    {
        return $"{Nome} (Terceirizado): {CalcularSalario():C}";
    }

}