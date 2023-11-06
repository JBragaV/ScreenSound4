using System.Linq;
using ScreenSound4.Modelos;

namespace ScreenSound4.Filtros;

internal class LinqFilter
{
    public static void FiltrarTodosOsGenerosMusicais(List<Musica> musicas)
    {
        var todosOsGenerosMusicais = musicas.Select(generos => generos.Genero).Distinct().ToList();
        foreach (var genero in todosOsGenerosMusicais)
        {
            Console.WriteLine($"-> {genero}");
        }
    }

    public static void FiltrarArtistaPorGeneroMusical(List<Musica> musicas, string genero)
    {
        var artistasPorGeneroMusical = musicas.Where(musica => musica.Genero.Contains(genero)).OrderBy(musica => musica.Artista).Select(musica => musica.Artista).Distinct().ToList();
        Console.WriteLine($"Exibindo os Artistas por gênero musical >>> {genero}");
        foreach (var artista in artistasPorGeneroMusical)
        {
            Console.WriteLine($"-> {artista}");
        }
    }

    public static void FiltrarMusicaDeUmArtista(List<Musica> musicas, string nomeDoArtista)
    {
        var musicasDoArtista = musicas.Where(musica => musica.Artista.Equals(nomeDoArtista)).OrderBy(musica => musica.Nome).Select(musica => musica.Nome).Distinct().ToList();
        Console.WriteLine($"Músicas {nomeDoArtista}");
        foreach (var musica in musicasDoArtista)
        {
            Console.WriteLine($"-> {musica}");
        }
    }
    
    public static void FiltrarMusicaPorAno(List<Musica> musicas, int ano)
    {
        var musicaFiltradaPorAno = musicas.Where(musica => musica.Ano == ano).OrderBy(musica => musica.Nome).Select(musica => musica.Nome).Distinct().ToList();
        Console.WriteLine($"Músicas do ano de {ano}");
        foreach(var musica in musicaFiltradaPorAno)
        {
            Console.WriteLine($"-> {musica}");
        }
    }

    public static void FiltrarMusicaPorTonalidade(List<Musica> musicas, string tonalidade)
    {
        var musicaFiltradaPorTonalidade = musicas.Where(musica => musica.Tonalidade.Equals(tonalidade)).OrderBy(musica => musica.Nome).ToList();
        Console.WriteLine($"Todas as músicas que tem a tonalidade {tonalidade}:");
        foreach (var musica in musicaFiltradaPorTonalidade)
        {

            musica.ExibirDetalhesMusica();
            Console.WriteLine();
        }
    }
}
