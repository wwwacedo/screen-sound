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

// musica1.ExibirFichaTecnica();
// musica2.ExibirFichaTecnica();

// albumDoQueen.AdicionarMusica(musica1);
// albumDoQueen.AdicionarMusica(musica2);

// queen.AdicionarAlbum(albumDoQueen);
// queen.ExibirDiscografia();

Episodio ep1 = new(1, "Técnica de facilitação", 45);
ep1.AdicionarConvidados("Mariana");
ep1.AdicionarConvidados("Nathalie");
Console.WriteLine(ep1.Resumo);

Episodio ep2 = new(2, "Técnica de apresentação", 45);
ep2.AdicionarConvidados("Flávia");
ep2.AdicionarConvidados("Juliana");
Console.WriteLine(ep2.Resumo);

Podcast podcast = new("Podcast especial", "Maria");
podcast.AdicionarEpsisodio(ep1);
podcast.AdicionarEpsisodio(ep2);

podcast.ExibirDetalhes();