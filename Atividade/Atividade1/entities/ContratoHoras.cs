namespace Atividade1.Entities
{
    // Classe que representa um contrato de horas trabalhadas
    public class ContratoHoras
    {
        public DateTime Data { get; private set; }
        public decimal ValorPorHora { get; private set; }
        public int Horas { get; private set; }

        public ContratoHoras(DateTime data, decimal valorHora, int horas)
        {
            Data = data;
            ValorPorHora = valorHora;
            Horas = horas;
        }

        public decimal ValorTotal()
        {
            return ValorPorHora * Horas;
        }

    }
}