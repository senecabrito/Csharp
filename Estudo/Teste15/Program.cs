using System;

namespace Teste15
{
    class Program
    {
        static void Main(string[] args)
        {
            // DateTime representa uma data e hora específica
            DateTime d1 = DateTime.Now; // recebe hora e data atual
            DateTime d2 = DateTime.Today;
            long d3 = d1.Ticks; // recebe o número de ticks desde 1/1/0001 00:00:00
                                // ticks são unidades de tempo de 100 nanossegundos
            DateTime d4 = new DateTime(2019, 11, 23, 18, 17, 3); // cria uma data com horário
            DateTime d5 = DateTime.UtcNow; // recebe a data e hora atual em UTC (Tempo Universal Coordenado)

            DateTime d6 = DateTime.Parse("2019-11-23 18:17:03"); // converte uma string para DateTime, ideal ao lidar com Banco de Dados
            DateTime d7 = DateTime.ParseExact("2019-11-23 18:17:03", "yyyy-MM-dd HH:mm:ss", null); // converte uma string para DateTime com formato específico

            // Exibindo as propriedades de DateTime
            Console.WriteLine(d1.Year); // exibe o ano
            Console.WriteLine(d1.Month);
            Console.WriteLine(d1.Day);
            Console.WriteLine(d1.Hour);

            Console.WriteLine(d4.ToLongDateString()); // exibe a data em formato longo
            Console.WriteLine(d4.ToLongTimeString());

            d6.AddDays(1); // adiciona 1 dia à data
            d6.AddHours(1);
            d6.AddMinutes(1);
            d6.AddSeconds(1);

            DateTime d8 = new DateTime(2019, 11, 23);
            DateTime d9 = new DateTime(2019, 11, 25);
            TimeSpan diferenca = d9.Subtract(d8); // calcula a diferença entre duas datas

            // ---------------------------------------------------------------------------------------------------

            // TimeSpan representa um intervalo de tempo
            TimeSpan t1 = new TimeSpan();
            Console.WriteLine(t1); // exibe 00:00:00
            TimeSpan t2 = new TimeSpan(1, 2, 3); // cria um TimeSpan com 1 hora, 2 minutos e 3 segundos
            TimeSpan t3 = new TimeSpan(1, 2, 3, 4); // cria um TimeSpan com 1 dia, 2 horas, 3 minutos e 4 segundos

            TimeSpan t4 = TimeSpan.FromDays(1.5); // cria um TimeSpan de 1 dia e meio
            TimeSpan t5 = TimeSpan.FromHours(1.5);
            TimeSpan t6 = TimeSpan.FromMinutes(1.5);
            TimeSpan t7 = TimeSpan.FromSeconds(1.5);
            TimeSpan t8 = TimeSpan.FromMilliseconds(1.5);
            TimeSpan t9 = TimeSpan.FromTicks(30); // cria um TimeSpan de 1 tick (só pode inteiro)


            // Exibindo as propriedades de TimeSpan
            Console.WriteLine(t2.Days); // exibe o número de dias
            Console.WriteLine(t2.Hours); // exibe o número de horas
            Console.WriteLine(t2.Minutes); // exibe o número de minutos
            Console.WriteLine(t2.Seconds); // exibe o número de segundos

            Console.WriteLine(t2.TotalDays); // exibe o total de dias (incluindo frações)
            Console.WriteLine(t2.TotalHours); // exibe o total de horas (incluindo frações)
            Console.WriteLine(t2.TotalMinutes); // exibe o total de minutos (incluindo frações)
            Console.WriteLine(t2.TotalSeconds); // exibe o total de segundos (incluindo frações)

            TimeSpan t10 = TimeSpan.MaxValue; // representa o maior TimeSpan possível
            TimeSpan t11 = TimeSpan.MinValue;
            TimeSpan t12 = TimeSpan.Zero; // representa um TimeSpan de zero
            TimeSpan resultado = t10.Add(t11); // soma dois TimeSpans
            TimeSpan t13 = t10.Multiply(3.0); // multiplica um TimeSpan por um número
            TimeSpan t14 = t10.Divide(2.0);

        }
    }
}