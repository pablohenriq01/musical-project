
Dictionary<string, List<int>> bandas = new Dictionary<string, List<int>>();
bandas.Add("Linkin Park", new List<int>{6, 10});
bandas.Add("Black Sabbath", new List<int>{10, 9});

void ExibirBandas(){ 
    foreach (string banda in bandas.Keys)
    {
    
    Console.WriteLine($"Banda : {banda}");

    }

}

void ExibirInicio(){
    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");

Console.WriteLine("\nBem vindo ao Screen Sound!");
}

void ExibirMenu(){
    Console.Clear();
    ExibirInicio();
    Console.WriteLine("\nEscolha o que quer fazer.");
    Console.WriteLine("1 - Registrar uma banda.");
    Console.WriteLine("2 - Listar todas as bandas.");
    Console.WriteLine("3 - Avaliar uma banda.");
    Console.WriteLine("4 - Para exibir a media de uma banda.");
    Console.WriteLine("Para sair do programa digite -1.");
    OpcoesMenu();
}

void OpcoesMenu(){
    Console.Write("\nDigite sua opção: ");
    string opcao = Console.ReadLine()!;
    int opcaoInt = int.Parse(opcao);

    switch (opcaoInt){
        case 1:
            RegistrosDeBandas();
            break;
        case 2:
            ExibirTodasAsBandas();
            break;
        case 3:
            AvaliacaoBandas();
            break;
        case 4:
            ExibirMediaBandas();
            break;
        case -1:
            break;
        default:
            Console.Clear();
            Console.WriteLine("\nDigite uma opção valida");
            Thread.Sleep(2000);
            ExibirMenu();
            break;
    }
}

void Titulo(string titulo){
    int quantLetras = titulo.Length;
    string asteristico = string.Empty.PadLeft(quantLetras,'*');

    Console.WriteLine(asteristico);
    Console.WriteLine(titulo);
    Console.WriteLine(asteristico);

}

void RegistrosDeBandas()
{
    Console.Clear();
    Titulo("Registro de bandas");
    Console.Write("Digite o nome da banda que deseja adicionar: ");
    string nomeBanda = Console.ReadLine()!;

    bandas.Add(nomeBanda,new List<int>());

    Console.WriteLine($"\nBanda {nomeBanda} adicionada com sucesso!");
    Thread.Sleep(3000);
    ExibirMenu();
}

void ExibirTodasAsBandas()
{
    Console.Clear();
    Titulo("Exibir todas as bandas!");
    ExibirBandas();
    Console.WriteLine("\nDigite algo para sair.");
    Console.ReadKey();
    
    ExibirMenu();
}

void AvaliacaoBandas(){
    Console.Clear();
    Titulo("Avaliação de Bandas");
    ExibirBandas();
    Console.Write("\nDigite o nome da banda que deseja avaliar: ");
    string nomeBanda = Console.ReadLine()!;
        if (bandas.ContainsKey(nomeBanda)){
            Console.Clear();
            Console.WriteLine($"A banda escolhida foi {nomeBanda}!");
            Console.Write("\nInsira de  0 a 10 a sua nota : ");
            int nota = int.Parse(Console.ReadLine()!);
            bandas[nomeBanda].Add(nota);
            Console.WriteLine($"\nSucesso, a nota {nota} foi adicionado a banda : {nomeBanda}! ");
            Thread.Sleep(2000);
            ExibirMenu();
        } else {
           Console.WriteLine("\nDigite uma banda valida!");
            Thread.Sleep(4000);
            AvaliacaoBandas();
        }
}

void ExibirMediaBandas(){
    Console.Clear();
    Titulo("Media de avaliação das bandas");
    ExibirBandas();
    Console.Write("\nDigite o nome da banda que deseja ver a media: ");
    string nomeBanda = Console.ReadLine()!;
    if(bandas.ContainsKey(nomeBanda)){
        double media = bandas[nomeBanda].Average();
        Console.WriteLine($"\nA media da banda {nomeBanda} é de {media}");
        Console.WriteLine("\nAperte algo para sair.");
        Console.ReadKey();
        ExibirMenu();
    } else {
        Console.WriteLine("\nDigite o nome de uma banda existente!");
        Thread.Sleep(3000);
        ExibirMediaBandas();
    }

}

ExibirMenu();