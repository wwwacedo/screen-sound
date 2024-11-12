// Screen Sound

string mensagemDeBoasVindas = "Boas vindas ao Screen Sound";
Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("Linkin Park", new List<int> { 10, 9, 8, 10, 6 });
bandasRegistradas.Add("Metallica", new List<int> { 10, 7, 8, 3, 6 });

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
	ExibirTituloDaOpcao("Registrar banda");
	Console.Write("Digite o nome da banda que deseja registrar: ");
	string nomeDaBanda = Console.ReadLine()!;
	bandasRegistradas.Add(nomeDaBanda, new List<int>());
	Console.WriteLine($"\nA banda {nomeDaBanda} foi registrada com sucesso!");
	Thread.Sleep(2000);
	Console.Clear();
	ExibirOpcoesDoMenu();
}

void MostrarBandasRegistradas()
{
	Console.Clear();
	ExibirTituloDaOpcao("Bandas registradas");
	// for (int i = 0; i < listaDasBandas.Count; i++)
	// {
	// 	Console.WriteLine($"Banda: {listaDasBandas[i]}");;
	// }
	
	foreach (var banda in bandasRegistradas.Keys)
	{
		Console.WriteLine($"Banda: {banda}");
	}
	
	Console.Write("\nDigite qualquer tecla para voltar ao menu principal...");
	Console.ReadKey();
	Console.Clear();
	ExibirOpcoesDoMenu();
}

void ExibirTituloDaOpcao(string titulo)
{
    int quantidadeDeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");
}

ExibirOpcoesDoMenu();

