List<Produto> listaProdutos = new List<Produto>();

while (true) // Loop para manter o menu ativo
{
    Console.Clear(); // Limpar a tela a cada interação com o menu
    Console.WriteLine("SELECIONE UMA OPÇÃO");
    Console.WriteLine("\n1 - PARA EXECUTAR LOOPS");
    Console.WriteLine("2 - PARA ADICIONAR PRODUTOS");
    Console.WriteLine("3 - PARA LER PRODUTOS");
    Console.WriteLine("4 - PARA SAIR:");
    Console.WriteLine("\nDIGITE O QUE DESEJA");

    string escolha = Console.ReadLine();

    switch (escolha)
    {
        case "1":
            ExecutarLoops();
            break;
        case "2":
            adicionarProdutos();
            break;
        case "3":
            lerProdutos();
            break;
        case "4":
            Console.Clear();
            Console.WriteLine("Saindo...");
            Thread.Sleep(2000); 
            return; 
        default:
            Console.WriteLine("Função em desenvolvimento");
            break;
    }

    Console.WriteLine("\nPressione qualquer tecla para continuar...");
    Console.ReadKey(); 
}

static void ExecutarLoops()
{
    Console.WriteLine("Executando exemplos de loops...");

    Console.WriteLine("\nExemplo de FOR:");
    for (int i = 1; i < 5; i++)
    {
        Console.WriteLine($"Número: {i}");
    }

    Console.WriteLine("\nExemplo de WHILE:");
    int contadorWhile = 1;
    while (contadorWhile <= 5)
    {
        Console.WriteLine($"Número: {contadorWhile}");
        contadorWhile++;
    }

    Console.WriteLine("\nExemplo de DO-WHILE:");
    int contadorDoWhile = 1;
    do
    {
        Console.WriteLine($"Número: {contadorDoWhile}");
        contadorDoWhile++;
    } while (contadorDoWhile <= 5);

    Console.WriteLine("\nExemplo de FOREACH:");
    string[] cores = { "Vermelho", "Azul", "Verde", "Amarelo" };
    foreach (string cor in cores)
    {
        Console.WriteLine($"Cor: {cor}");
    }
}

void adicionarProdutos()
{
    Produto item1 = new Produto();
    item1.Nome = "Big Mac";
    item1.Preco = 12.50;

    listaProdutos.Add(item1);

    Produto item2 = new Produto();
    item2.Nome = "Sorvete";
    item2.Preco = 3.50;

    listaProdutos.Add(item2);

    Console.Clear();
    Console.WriteLine("Produtos adicionados com sucesso!");
}

void lerProdutos()
{
    Console.Clear();
    if (listaProdutos.Count == 0)
    {
        Console.WriteLine("Não há produtos para exibir.");
    }
    else
    {
        foreach (Produto produto in listaProdutos)
        {
            Console.WriteLine($"Nome: {produto.Nome}, Preço: {produto.Preco}");
        }
    }
}

class Produto
{
    public string Nome { get; set; }
    public Double Preco { get; set; }
}
