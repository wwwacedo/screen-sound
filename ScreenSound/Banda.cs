using System;

namespace ScreenSound;

public class Banda
{

	// Construtor
	public Banda(string nome)
	{
		Nome = nome;
	}

	// Atributos
	private List<Album> albuns = new List<Album>();

	// Propriedades
	public string Nome { get; }

	public void AdicionarAlbum(Album album)
	{
		albuns.Add(album);
	}

	public void ExibirDiscografia()
	{
		Console.WriteLine($"Discografia da banda '{Nome}':");
		foreach (Album album in albuns)
		{
			Console.WriteLine($"- {album.Nome} ({album.DuracaoTotal})");
		}
	}

}
