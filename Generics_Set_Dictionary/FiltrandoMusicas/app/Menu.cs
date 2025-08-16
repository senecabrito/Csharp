using FiltrandoMusicas.Entities;
namespace FiltrandoMusicas.App;

internal class Menu
{
    public static void Show()
    {
        List<Song> songs = new List<Song>();
        int choice;

        do
        {
            Console.WriteLine("========== Menu de Opções ==========");
            Console.WriteLine("1. Adicionar Música");
            Console.WriteLine("2. Remover Música");
            Console.WriteLine("3. Filtrar por Artista");
            Console.WriteLine("4. Filtrar por Título");
            Console.WriteLine("5. Filtrar por Ano de Lançamento");
            Console.WriteLine("6. Filtrar por Mês de Lançamento");
            Console.WriteLine("7. Filtrar por Dia de Lançamento");
            Console.WriteLine("8. Filtrar por Gênero");
            Console.WriteLine("9. Listar Todas as Músicas");
            Console.WriteLine("0. Sair");

            Console.Write("Escolha uma opção: ");
            while (!int.TryParse(Console.ReadLine(), out choice) || choice < 0 || choice > 9)
            {
                Console.Write("Opção inválida. Por favor, escolha uma opção válida: ");
            }

            Console.WriteLine();
            switch (choice)
            {
                case 1:
                    Console.Write("Digite o título da música: ");
                    string title = Console.ReadLine();

                    Console.Write("Digite o nome do artista: ");
                    string artist = Console.ReadLine();

                    Console.Write("Digite a data de lançamento (dd/mm/aaaa): ");
                    DateTime releaseDate;
                    
                    while (!DateTime.TryParse(Console.ReadLine(), out releaseDate))
                    {
                        Console.Write("Data inválida. Por favor, digite a data no formato correto (dd/mm/aaaa): ");
                    }

                    Console.Write("Digite o gênero da música: ");
                    string genre = Console.ReadLine();

                    Song newSong = new Song(title, artist, releaseDate, genre);

                    try
                    {
                        Song.AddSong(songs, newSong);
                        Console.WriteLine("Música adicionada com sucesso!");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        continue; // Volta para o início do loop se houver erro ao adicionar a música
                    }
                    Console.WriteLine();
                    break;

                case 2:
                    Console.Write("Digite o título da música a ser removida: ");
                    string titleToRemove = Console.ReadLine();

                    try
                    {
                        Song.RemoveSong(songs, titleToRemove);
                        Console.WriteLine("Música removida com sucesso!");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    Console.WriteLine();
                    break;

                case 3:
                    Console.Write("Digite o nome do artista para filtrar: ");
                    string artistToFilter = Console.ReadLine();

                    try
                    {
                        Console.WriteLine($"Músicas do artista '{artistToFilter}':");
                        Song.FilterByArtist(songs, artistToFilter).ForEach(s => Console.WriteLine(s));
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    Console.WriteLine();
                    break;

                case 4:
                    Console.Write("Digite o título da música para filtrar: ");
                    string titleToFilter = Console.ReadLine();

                    try
                    {
                        Console.WriteLine($"Músicas com o título '{titleToFilter}':");
                        Song.FilterByTitle(songs, titleToFilter).ForEach(s => Console.WriteLine(s));
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    Console.WriteLine();
                    break;

                case 5:
                    Console.Write("Digite o ano de lançamento para filtrar (aaaa): ");
                    int year;
                    while (!int.TryParse(Console.ReadLine(), out year) || year < 1)
                    {
                        Console.Write("Ano inválido. Por favor, digite um ano válido (aaaa): ");
                    }
                    DateTime dateForYear = new DateTime(year, 1, 1);

                    try
                    {
                        Console.WriteLine($"Músicas lançadas no ano {year}:");
                        Song.FilterByYear(songs, dateForYear).ForEach(s => Console.WriteLine(s));
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    Console.WriteLine();
                    break;

                case 6:
                    Console.Write("Digite o mês de lançamento para filtrar (mm): ");
                    int month;
                    while (!int.TryParse(Console.ReadLine(), out month) || month < 1 || month > 12)
                    {
                        Console.Write("Mês inválido. Por favor, digite um mês válido (mm): ");
                    }
                    DateTime dateForMonth = new DateTime(DateTime.Now.Year, month, 1);

                    try
                    {
                        Console.WriteLine($"Músicas lançadas no mês {month}:");
                        Song.FilterByMonth(songs, dateForMonth).ForEach(s => Console.WriteLine(s));
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    Console.WriteLine();
                    break;

                case 7:
                    Console.Write("Digite o dia de lançamento para filtrar (dd): ");
                    int day;
                    while (!int.TryParse(Console.ReadLine(), out day) || day < 1 || day > 31)
                    {
                        Console.Write("Dia inválido. Por favor, digite um dia válido (dd): ");
                    }
                    DateTime dateForDay = new DateTime(DateTime.Now.Year, DateTime.Now.Month, day);

                    try
                    {
                        Console.WriteLine($"Músicas lançadas no dia {day}:");
                        Song.FilterByDay(songs, dateForDay).ForEach(s => Console.WriteLine(s));
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    Console.WriteLine();
                    break;

                case 8:
                    Console.Write("Digite o gênero para filtrar: ");
                    string genreToFilter = Console.ReadLine();

                    try
                    {
                        Console.WriteLine($"Músicas do gênero '{genreToFilter}':");
                        Song.FilterByGenre(songs, genreToFilter).ForEach(s => Console.WriteLine(s));
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    Console.WriteLine();
                    break;

                case 9:
                    if (songs.Count == 0)
                    {
                        Console.WriteLine("Nenhuma música cadastrada.");
                    }
                    else
                    {
                        Console.WriteLine("Lista de Músicas:");
                        songs.ForEach(s => Console.WriteLine(s));
                    }
                    Console.WriteLine();
                    break;

                case 0:
                    Console.WriteLine("Saindo do programa...");
                    break;

                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }

        } while (choice != 0);
    }
}