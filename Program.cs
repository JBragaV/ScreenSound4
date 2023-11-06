using System.Text.Json;
using ScreenSound4.Modelos;
using ScreenSound4.Filtros;

using (HttpClient client = new HttpClient())
{
    try 
    { 
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        //Console.WriteLine(resposta);
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
        //LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
        //LinqOrder.ExibirListaDeArtistasOrdenados(musicas);
        //LinqFilter.FiltrarArtistaPorGeneroMusical(musicas, "rock");
        //LinqFilter.FiltrarMusicaDeUmArtista(musicas, "Michael Jackson");
        //LinqFilter.FiltrarMusicaDeUmArtista(musicas, "Michel Teló");
        //LinqFilter.FiltrarMusicaDeUmArtista(musicas, "U2");
        //LinqFilter.FiltrarMusicaPorAno(musicas, 2012);
        LinqFilter.FiltrarMusicaPorTonalidade(musicas, "C#");
        //var musicasPreferidasDoDaniel = new MusicasPreferidas("Daniel");
        //musicasPreferidasDoDaniel.AdicionarMusicasFavoritas(musicas[1]);
        //musicasPreferidasDoDaniel.AdicionarMusicasFavoritas(musicas[377]);
        //musicasPreferidasDoDaniel.AdicionarMusicasFavoritas(musicas[4]);
        //musicasPreferidasDoDaniel.AdicionarMusicasFavoritas(musicas[6]);
        //musicasPreferidasDoDaniel.AdicionarMusicasFavoritas(musicas[1467]);

        //musicasPreferidasDoDaniel.ExibirMusicasFavoritas();

        //var musicasPreferidasDaEmilly = new MusicasPreferidas("Emy");
        //musicasPreferidasDaEmilly.AdicionarMusicasFavoritas(musicas[980]);
        //musicasPreferidasDaEmilly.AdicionarMusicasFavoritas(musicas[513]);
        //musicasPreferidasDaEmilly.AdicionarMusicasFavoritas(musicas[1024]);
        //musicasPreferidasDaEmilly.AdicionarMusicasFavoritas(musicas[999]);
        //musicasPreferidasDaEmilly.AdicionarMusicasFavoritas(musicas[37]);

        ////musicasPreferidasDaEmilly.ExibirMusicasFavoritas();

        //musicasPreferidasDaEmilly.GerarDocumentoTXTComAsMusicasFavoritas();
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
}