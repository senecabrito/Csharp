namespace FiltrandoMusicas.Entities;

public class Song
{
    public int Id { get; private set; }
    public string Title { get; private set; }
    public string Artist { get; private set; }
    public DateTime ReleaseDate { get; private set; }
    public string Genre { get; private set; }

    public Song(string title, string artist, DateTime releaseDate, string genre)
    {
        Title = title;
        Artist = artist;
        ReleaseDate = releaseDate;
        Genre = genre;
    }

    public override string ToString()
    {
        return $"ID: {Id}\nMúsica: {Title}\nArtista: {Artist}\nData de Lançamento: {ReleaseDate.ToShortDateString()}\nGênero: {Genre}";
    }

    public static void AddSong(List<Song> songs, Song s)
    {
        if (songs.Any(song => song.Title.Equals(s.Title, StringComparison.OrdinalIgnoreCase))) // verifica se já existe uma música com o mesmo título
        {
            throw new Exception("Erro: Já existe uma música com este título.");
        }

        s.Id = songs.Count > 0 ? songs.Max(song => song.Id) + 1 : 1; // atribui um novo ID
        songs.Add(s);
    }

    public static void RemoveSong(List<Song> songs, string title)
    {
        var songToRemove = songs.FirstOrDefault(songs => songs.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
        
        if (songToRemove != null)
        {
            songs.Remove(songToRemove);
        }
        else
        {
            throw new Exception("Erro: Música não encontrada.");
        }
    }

    public static List<Song> FilterByArtist(List<Song> songs, string artist)
    {
        var result = songs
        .Where(songs => songs.Artist.Equals(artist, StringComparison.OrdinalIgnoreCase)) // Ignorar maiúsculas/minúsculas
        .ToList();

        if (result.Count == 0)
        {
            throw new Exception("Erro: Nenhuma música encontrada para o artista especificado.");
        }
        else
        {
            return result;
        }
    }

    public static List<Song> FilterByTitle(List<Song> songs, string title)
    {
        var result = songs
        .Where(songs => songs.Title.Equals(title, StringComparison.OrdinalIgnoreCase)) // Ignorar maiúsculas/minúsculas
        .ToList();

        if (result.Count == 0)
        {
            throw new Exception("Erro: Nenhuma música encontrada com o título especificado.");
        }
        else
        {
            return result;
        }
    }

    public static List<Song> FilterByYear(List<Song> songs, DateTime date)
    {
        var result = songs
        .Where(songs => songs.ReleaseDate.Year == date.Year)
        .ToList();

        if (result.Count == 0)
        {
            throw new Exception("Erro: Nenhuma música encontrada para o ano especificado.");
        }
        else
        {
            return result;
        }
    }

    public static List<Song> FilterByMonth(List<Song> songs, DateTime date)
    {
        var result = songs
        .Where(s => s.ReleaseDate.Month == date.Month)
        .ToList();

        if (result.Count == 0)
        {
            throw new Exception("Erro: Nenhuma música encontrada para o mês especificado.");
        }
        else
        {
            return result;
        }
    }

    public static List<Song> FilterByDay(List<Song> songs, DateTime date)
    {
        var result = songs
        .Where(s => s.ReleaseDate.Day == date.Day)
        .ToList();

        if (result.Count == 0)
        {
            throw new Exception("Erro: Nenhuma música encontrada para o dia especificado.");
        }
        else
        {
            return result;
        }
    }

    public static List<Song> FilterByGenre(List<Song> songs, string genre)
    {
        var result = songs
        .Where(s => s.Genre.Equals(genre, StringComparison.OrdinalIgnoreCase)) // Ignorar maiúsculas/minúsculas
        .ToList();

        if (result.Count == 0)
        {
            throw new Exception("Erro: Nenhuma música encontrada para o gênero especificado.");
        }
        else
        {
            return result;
        }
    }

}