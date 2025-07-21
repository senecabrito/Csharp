namespace Teste13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor a ser pago: ");
            decimal valorPendente = decimal.Parse(Console.ReadLine());

            decimal desconto = (valorPendente < 20) ? valorPendente * 0.1m : valorPendente * 0.05m; // Aplicando condicional ternária
            decimal valorPago = valorPendente - desconto;

            Console.WriteLine($"Valor pago com desconto de {desconto:C}: {valorPago:C}");
        }
    }
}