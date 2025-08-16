namespace ComparandoProdutos.Services;

public class CalculationService
{
    public T Max<T>(List<T> list) where T : IComparable // método genérico onde T deve implementar IComparable
    {
        if (list == null || list.Count == 0)
        {
            throw new ArgumentException("Erro: A lista não pode estar vazia.");
        }

        T max = list[0];
        for (int i = 1; i < list.Count; i++)
        {
            if (list[i].CompareTo(max) > 0)
            {
                max = list[i];
            }
        }
        return max;
    }
    
}