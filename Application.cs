Genero genero = new();
genero.Nome = "Rap";

Musica musica = new();

musica.Nome = "Soldado do Morro";
musica.Artista = "MV Bill";
musica.Duracao = 440;
musica.Disponivel = true;
musica.GeneroMusica = genero;

Musica musica1 = new();

musica1.Nome = "Noite";
musica1.Artista = "MV Bill";
musica1.Duracao = 320;
musica1.Disponivel = true;
musica1.GeneroMusica = genero;

musica.ExibeMusica();
Album album = new();

album.Nome = "Traficando Informação";
album.AdicionarMusica(musica1);
album.AdicionarMusica(musica);

album.ExibirMusicasDoAlbum();
