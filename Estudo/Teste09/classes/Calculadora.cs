namespace Teste9.Classes

{
    public class Calculadora
    {
        public static int Somar(params int[] numeros)
        {
            int resultado = 0;
            foreach (int n in numeros)
            {
                resultado += n;
            }

            return resultado;
        }

        public static int Subtrair(params int[] numeros)
        {
            if (numeros.Length == 0)
            {
                throw new ArgumentException("Pelo menos um número deve ser fornecido para subtração.");
            }

            int resultado = numeros[0];
            for (int i = 1; i < numeros.Length; i++)
            {
                resultado -= numeros[i];
            }

            return resultado;
        }

        public static void Triplicar(ref int num) // Método estático para triplicar o número da variável passada por referência
        {
            num *= 3;
        }

        public static void Triplicar(int num, out int result)
        {
            result = num * 3; // Método estático para triplicar o número da variável passada por valor e retornar o resultado
        }

    }
}