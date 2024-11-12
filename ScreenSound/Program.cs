using ScreenSound;

Console.Clear();

Banda queen = new Banda("Queen");
Genero rock = new Genero("Rock");
Album albumDoQueen = new Album("A Night at the Opera");

Musica musica1 = new Musica(queen, "Love of My Life", rock) {
	Duracao = 213,
	Disponivel = true
};

Musica musica2 = new Musica(queen, "Bohemian Rhapsody", rock) {
	Duracao = 354,
	Disponivel = false,
};

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();

albumDoQueen.AdicionarMusica(musica1);
albumDoQueen.AdicionarMusica(musica2);

queen.AdicionarAlbum(albumDoQueen);
queen.ExibirDiscografia();
