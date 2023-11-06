using System.Text.Json.Serialization;

namespace ScreenSound4.Modelos;

internal class Musica
{
    private string[] Tonalidades = { "C", "C#", "D", "Eb", "E", "F", "F#", "G", "Ab", "A", "Bb", "B" };

    // O interrogação depois do tipo indica que o atributo pode ser nulo
    [JsonPropertyName("song")]
    public string? Nome { get; set; }
    [JsonPropertyName("artist")]
    public string Artista { get; set; }
    [JsonPropertyName("genre")]
    public string? Genero { get; set; }
    [JsonPropertyName("duration_ms")]
    public int Duracao { get; set; }
    [JsonPropertyName("year")]
    public string AnoString { get; set; }
    [JsonPropertyName("key")]
    public int Key { get; set; }
    
    public string Tonalidade {
        get
        {
            return Tonalidades[Key];
        }
    }

    public int Ano {
        get
        { 
            return int.Parse(AnoString);
        }
             
    }

    public void ExibirDetalhesMusica()
    {
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Música: {Nome}");
        Console.WriteLine($"Duração: {Duracao/1000}");
        Console.WriteLine($"Genero: {Genero}");
        Console.WriteLine($"Ano: {Ano}");
        Console.WriteLine($"tonalidade: {Tonalidade}");
    }

    public string RetornaExibirDetalhesMusica()
    {
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Música: {Nome}");
        Console.WriteLine($"Duração: {Duracao / 1000}");
        Console.WriteLine($"Genero: {Genero}");
        Console.WriteLine($"Ano: {Ano}");
        return $"\nArtista: {Artista}\nMúsica: {Nome}\nDuração: {Duracao / 1000}\nGenero: {Genero}\nAno: {Ano}\ntonalidade: {Tonalidade}\n";
    }

}
