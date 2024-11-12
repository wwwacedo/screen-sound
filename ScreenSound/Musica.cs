using System;

namespace ScreenSound;

public class Musica
{
	// Construtor
	public Musica(Banda artista, string nome, Genero genero)
	{
		Artista = artista;
		Genero = genero;
		Nome = nome;

	}

	// Propriedades do objeto Música
	public string Nome { get; }
	public Banda Artista { get; }
	public int Duracao { get; set; }
	public bool Disponivel { get; set; }
	public string DescricaoResumida => $"A musica '{Nome}' pertence ao artista {Artista}";
	public Genero Genero { get; }


	public void ExibirFichaTecnica()
	{
		Console.WriteLine($"Nome: {Nome}");
		Console.WriteLine($"Artista: {Artista.Nome}");
		Console.WriteLine($"Duração: {Duracao}");
		Console.WriteLine($"Gênero: {Genero.Nome}");
		if (Disponivel)
		{
			Console.WriteLine("Disponível no plano.\n");
		}
		else
		{
			Console.WriteLine("Indisponível. Adquira o plano Plus+\n");
		}
	}
}
