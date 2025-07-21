namespace Teste14
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = "Sêneca   ";

            string n1 = nome.ToUpper(); // Converte para maiúsculas
            string n2 = nome.ToLower(); // Converte para minúsculas

            string n3 = nome.Trim(); // Remove espaços em branco no início e no final
            string n4 = nome.TrimStart(); // Remove espaços em branco no início
            string n5 = nome.TrimEnd(); // Remove espaços em branco no final

            string n6 = nome.Substring(0, 5); // Extrai os primeiros 5 caracteres
            string n7 = nome.Substring(6); // Extrai a partir do 7º caractere até o final

            string n8 = nome.Replace("ê", "e"); // Substitui 'ê' por 'e'

            int n9 = nome.IndexOf("c"); // Encontra o índice da primeira ocorrência de 'c'
            int n10 = nome.LastIndexOf("e"); // Encontra o índice da última ocorrência de 'e'
            
            string n11 = nome.Insert(6, " de "); // Insere " de " após o 6º caractere

            bool b1 = string.IsNullOrEmpty(nome); // Verifica se a string é nula ou vazia
            bool b2 = string.IsNullOrWhiteSpace(nome); // Verifica se a string é nula, vazia ou contém apenas espaços em branco


        }
    }
}