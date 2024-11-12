using System;

namespace ScreenSound;

public class Album
{
	// Atributos
	private List<Musica> musicas = new List<Musica>();

	// Propriedades 
	public string Nome { get; set; }
	public int DuracaoTotal => musicas.Sum(musica => musica.Duracao);

	// Métodos
	public void AdicionarMusica(Musica musica)
	{
		musicas.Add(musica);
	}

	public void ExibirMusicasDoAlbum()
	{
		Console.WriteLine($"Lista de músicas do Álbum {Nome}: \n");
		foreach (Musica musica in musicas)
		{
			Console.WriteLine($"Nome da música: {musica.Nome}");
			if (string.IsNullOrEmpty(musica.Genero.Nome))
			{
				Console.WriteLine("Gênero não informado");
			}
			else
			{
				Console.WriteLine($"Gênero: {musica.Genero.Nome}");
			}
		}
		Console.WriteLine($"\nDuração total do álbum: {DuracaoTotal} segundos");
	}

}
