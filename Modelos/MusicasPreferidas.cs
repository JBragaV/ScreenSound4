using System.Linq;
using System.Text.Json;

namespace ScreenSound4.Modelos;

internal class MusicasPreferidas
{
    public string Nome { get; set; }
    public List<Musica> ListaDeMusicaFavoritas { get; }

    public MusicasPreferidas(string nome)
    {
        Nome = nome;
        ListaDeMusicaFavoritas = new List<Musica>();
    }

    public void AdicionarMusicasFavoritas(Musica musica)
    {
        ListaDeMusicaFavoritas.Add(musica);
    }

    public void ExibirMusicasFavoritas()
    {
        Console.WriteLine($"Essas são as músicas favoritas de {Nome}:");
        foreach (var musica in ListaDeMusicaFavoritas)
        {
            Console.WriteLine("==========");
            musica.ExibirDetalhesMusica();
            Console.WriteLine("==========");
        }
        Console.WriteLine();
    }

    public void GerarArquivoJson()
    {
        //Contrução de um objeto anônimo!
        string json = JsonSerializer.Serialize(new
        {
            nome = Nome,
            musicas = ListaDeMusicaFavoritas,
        });
        string nomeDoArquivo = $"musicas_favoritas_{Nome}.json";
        File.WriteAllText(nomeDoArquivo, json);
        Console.WriteLine($"O arquivo Json foi criado com sucesso {Path.GetFullPath(nomeDoArquivo)}");
    }

    public void GerarDocumentoTXTComAsMusicasFavoritas()
    {
        string nomeDoArquivo = $"musica_favorita_{Nome}.txt";
        using (StreamWriter arquivo = new StreamWriter(nomeDoArquivo))
        {
            arquivo.WriteLine($"Música favoritas do {Nome}\n");
            foreach (var musica in ListaDeMusicaFavoritas)
            {
                arquivo.WriteLine(musica.RetornaExibirDetalhesMusica());
            }
        }
        Console.WriteLine("Txt gerado com sucesso!!!");
    }
}
