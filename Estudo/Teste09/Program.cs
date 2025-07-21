using System;
using Teste9.Classes;

namespace Teste9
{
    class Program
    {
        static void Main(string[] args)
        {
            int resultadoAdicao = Calculadora.Somar(8, 2);
            int resultadoSubtracao = Calculadora.Subtrair(8, 2);

            Console.WriteLine($"A soma é: {resultadoAdicao}");
            Calculadora.Subtrair(10, 2, 3);
            Console.WriteLine($"A subtração é: {resultadoSubtracao}");

            int a = 10;
            int resultadoTriplicado;
            Calculadora.Triplicar(ref a); // ref exige que a variável seja inicializada
            Console.WriteLine($"O valor de 'A' após a multiplicação é: {a}");

            Calculadora.Triplicar(5, out resultadoTriplicado); // out não exige que a variável seja inicializada
            Console.WriteLine($"O resultado triplicado de 5 é: {resultadoTriplicado}");
        }
    }
}