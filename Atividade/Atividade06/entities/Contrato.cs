namespace Atividade06.Entities;

internal class Contrato
{
    public int ID { get; private set; }
    public DateTime Data { get; private set; }
    public decimal ValorTotal { get; private set; }
    public List<Parcela> Parcelas { get; private set; }

    public Contrato()
    {
        Parcelas = new List<Parcela>();
    }

    public Contrato(int id, DateTime data, decimal valorTotal)
    {
        ID = id;
        Data = data;
        ValorTotal = valorTotal;
        Parcelas = new List<Parcela>();
    }

    public void AddParcela(Parcela parcela)
    {
        Parcelas.Add(parcela);
    }

}