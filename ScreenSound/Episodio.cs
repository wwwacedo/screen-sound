using System;

namespace ScreenSound;

public class Episodio
{
	// Atributos
	List<string> convidados = new();

	// Propriedades
	public int Ordem { get; }
	public string Titulo { get; }
	public int Duracao { get; }
	public string Resumo => $"{Ordem}. {Titulo} ({Duracao} minutos) - Convidados: {string.Join(", ", convidados)}";

	// Construtor
	public Episodio(int ordem, string titulo, int duracao)
	{
		Ordem = ordem;
		Titulo = titulo;
		Duracao = duracao;
	}

	public void AdicionarConvidados(string convidado)
	{
		convidados.Add(convidado);
	}
}
