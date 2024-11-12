using System;

namespace ScreenSound;

public class Podcast
{

	// Atributos
	List<Episodio> listaDeEpisodios = new();


	// Propriedades
	public string Host { get; }
	public string Nome { get; }
	public int TotalEpisodios => listaDeEpisodios.Count;


	// Construtor
	public Podcast(string nome, string host)
	{
		Nome = nome;
		Host = host;
	}

	public void AdicionarEpsisodio(Episodio episodio)
	{
		listaDeEpisodios.Add(episodio);
	}

	public void ExibirDetalhes()
	{
		Console.WriteLine($"\nPodcast: {Nome} - Host: {Host}");
		Console.WriteLine("Episódios:");
		foreach (Episodio episodio in listaDeEpisodios.OrderBy(ep => ep.Ordem))
		{
			Console.WriteLine($"\t- {episodio.Titulo}");
		}
		Console.WriteLine($"\nTotal de episódios: {TotalEpisodios}");
	}
}
