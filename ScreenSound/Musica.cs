using System;

namespace ScreenSound;

public class Musica
{
	// Propriedades do objeto Música
	public string Nome { get; set; }
	public string Artista { get; set; }
	public int Duracao { get; set; }
	public bool Disponivel { get; set; }
	public string DescricaoResumida => $"A musica '{Nome}' pertence ao artista {Artista}";

	
	public void ExibirFichaTecnica()
	{
		System.Console.WriteLine($"Nome: {Nome}");
		System.Console.WriteLine($"Artista: {Artista}");
		System.Console.WriteLine($"Duração: {Duracao}");
		if (Disponivel)
		{
			System.Console.WriteLine("Disponível no plano.");
		}
		else
		{
			System.Console.WriteLine("Indisponível. Adquire o plano Plus+");
		}
	}
}
