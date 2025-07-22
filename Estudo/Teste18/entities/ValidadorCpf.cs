namespace Teste18.Entities;

internal sealed class ValidadorCpf
{
    public static bool EhValido(string cpf)
    {
        if (string.IsNullOrWhiteSpace(cpf))
            return false;

        // Remove caracteres não numéricos
        cpf = new string(cpf.Where(char.IsDigit).ToArray());

        // Verifica se tem 11 dígitos
        if (cpf.Length != 11)
            return false;

        // Verifica se todos os dígitos são iguais (CPF inválido)
        if (cpf.Distinct().Count() == 1)
            return false;

        // Calcula os dígitos verificadores
        var cpfNumeros = cpf.Select(c => int.Parse(c.ToString())).ToArray();

        int soma1 = 0;
        for (int i = 0; i < 9; i++)
            soma1 += cpfNumeros[i] * (10 - i);

        int digito1 = soma1 % 11;
        digito1 = digito1 < 2 ? 0 : 11 - digito1;

        int soma2 = 0;
        for (int i = 0; i < 10; i++)
            soma2 += cpfNumeros[i] * (11 - i);

        int digito2 = soma2 % 11;
        digito2 = digito2 < 2 ? 0 : 11 - digito2;

        // Verifica se os dígitos calculados batem com os do CPF informado
        return cpfNumeros[9] == digito1 && cpfNumeros[10] == digito2;
    }
}