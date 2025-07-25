using System;

namespace Teste21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // bloco que pode gerar a exceção
            try
            {
                Console.Write("Digite o primeiro número: ");
                decimal num1 = decimal.Parse(Console.ReadLine());

                Console.Write("Digite o segundo número: ");
                decimal num2 = decimal.Parse(Console.ReadLine());

                Console.WriteLine("Resultado: " + num1 / num2);
            }
            // tratamento da exceção
            catch (DivideByZeroException e) // Exceção para divisões por zero
            {
                Console.WriteLine("Error: " + e.Message);
            }
            catch (FormatException e) // Exceções para uso de string
            {
                Console.WriteLine("Formatting Error: " + e.Message);
            }
            
        }
    }
}