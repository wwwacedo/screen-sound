﻿// Screen Sound

string mensagemDeBoasVindas = "Boas vindas ao Screen Sound";
List<string> listaDasBandas = new List<string> { "Kid Abelha", "Skank", "Luxúria" };

void ExibirLogo()
// https://fsymbols.com/pt/geradores/
{
	Console.Clear();
	Console.WriteLine(@"

░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
	Console.WriteLine(mensagemDeBoasVindas);
}

void ExibirOpcoesDoMenu()
{
	ExibirLogo();
	Console.WriteLine("\nDigite 1 para registrar uma banda");
	Console.WriteLine("Digite 2 para mostrar todas as bandas");
	Console.WriteLine("Digite 3 para avaliar uma banda");
	Console.WriteLine("Digite 4 para exibir a média de uma banda");
	Console.WriteLine("Digite -1 para sair");

	Console.Write("\nDigite a opção desejada: ");
	string opcaoEscolhida = Console.ReadLine()!; // ! means `not null assertion operator`
	int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

	switch (opcaoEscolhidaNumerica)
	{
		case 1:
			RegistrarBanda();
			break;
		case 2:
			MostrarBandasRegistradas();
			break;
		case 3:
			Console.WriteLine("Avaliar uma banda");
			break;
		case 4:
			Console.WriteLine("Exibir a média de uma banda");
			break;
		case -1:
			Console.WriteLine("Saindo do programa");
			break;
		default:
			Console.WriteLine("Opção inválida");
			break;
	}
}

void RegistrarBanda()
{
	Console.Clear();
	Console.WriteLine("**********************");
	Console.WriteLine("Registro de bandas");
	Console.WriteLine("**********************\n");
	Console.Write("Digite o nome da banda que deseja registrar: ");
	string nomeDaBanda = Console.ReadLine()!;
	listaDasBandas.Add(nomeDaBanda);
	Console.WriteLine($"\nA banda {nomeDaBanda} foi registrada com sucesso!");
	Thread.Sleep(2000);
	Console.Clear();
	ExibirOpcoesDoMenu();
}

void MostrarBandasRegistradas()
{
	Console.Clear();
	Console.WriteLine("************************************");
	Console.WriteLine("Exibindo todas as bandas registradas");
	Console.WriteLine("************************************\n");
	// for (int i = 0; i < listaDasBandas.Count; i++)
	// {
	// 	Console.WriteLine($"Banda: {listaDasBandas[i]}");;
	// }
	
	foreach (var banda in listaDasBandas)
	{
		Console.WriteLine($"Banda: {banda}");
	}
	
	Console.Write("\nDigite qualquer tecla para voltar ao menu principal...");
	Console.ReadKey();
	Console.Clear();
	ExibirOpcoesDoMenu();
}

ExibirOpcoesDoMenu();

