using System.Linq;
using ScreenSound4.Modelos;

namespace ScreenSound4.Filtros;

internal class LinqOrder
{
    public static void ExibirListaDeArtistasOrdenados(List<Musica> musica)
    {
        var artistasOrdenados = musica.OrderBy(musica => musica.Artista).Select(musica => musica.Artista).Distinct().ToList();
        foreach (var  artista in artistasOrdenados)
        {
            Console.WriteLine($"-> {artista}");
        }
    }
}
