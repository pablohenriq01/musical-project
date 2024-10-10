using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

class Album {
    List<Musica> musicas = new List<Musica>();
    public string Nome { get; set; }
    public int DuracaoTotal => musicas.Sum(m => m.Duracao);

    public void AdicionarMusica(Musica musica){
        musicas.Add(musica);
    }

    public void ExibirMusicasDoAlbum(){
        System.Console.WriteLine($"\nLista de Musicas do Album {Nome}");
        foreach (var musica in musicas)
        {
            System.Console.WriteLine($"\nMusica : {musica.Nome}");
            System.Console.WriteLine($"Duração : {musica.Duracao}");
        }

        System.Console.WriteLine($"\nNecessita de {DuracaoTotal} min para ouvir todo o album");

    }
}