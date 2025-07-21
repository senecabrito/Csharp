using System;

namespace Atividade4
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal? num1 = null; // '?' indica que o tipo é nullable
            decimal? num2 = 10.0m;

            Console.WriteLine(num1.GetValueOrDefault()); // Valor da Variável (Caso Exista) ou Padrão (0)
            Console.WriteLine(num2.GetValueOrDefault());

            Console.WriteLine(num1.HasValue); // Verifica se a variável tem valor
            Console.WriteLine(num2.HasValue);

            if (num1.HasValue)
            {
                Console.WriteLine(num1.Value); // Acessa o valor da variável se existir
            }
            else
            {
                Console.WriteLine("Essa variável não tem valor definido.");
            }

            decimal num3 = num1 ?? 0; // Se num1 for null, atribui valor ZERO a num3 

        }
    }
}