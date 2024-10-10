class Musica{
    public string Nome { get; set; }
    public string Artista { get; set; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    public Genero GeneroMusica {get; set;}


    public void ExibeMusica(){
        System.Console.WriteLine($"Nome da musica : {Nome}");
        System.Console.WriteLine($"Artista : {Artista}");
        System.Console.WriteLine($"Duracao : {Duracao}");
        System.Console.WriteLine($"Disponivel no plano : {Disponivel}");
        System.Console.WriteLine($"Genero musical : {GeneroMusica.Nome}");
    }
}
