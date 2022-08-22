using DesafioFundamentos.Models;

// Coloca o encoding para UTF8 para exibir acentuação
Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal precoInicial = 0;
decimal precoPorHora = 0;
bool verificarPrecoInicial = true;
bool verificarPrecoPorHora = true;

Console.WriteLine("Seja bem vindo ao sistema de estacionamento!");

// Looping para assegurar que seja digitado um valor decimal para o preço inicial.
while (verificarPrecoInicial)
{
    Console.WriteLine("Digite o preço inicial: ");
    if(decimal.TryParse(Console.ReadLine(), out precoInicial))
    {
        verificarPrecoInicial = false;
    }
    else
    {
        Console.WriteLine("Por favor, digite um valor decimal para o preço inicial.");
        Console.ReadKey();
        Console.Clear();
    }
}

// Looping para assegurar que seja digitado um valor decimal para o preço por hora.
while (verificarPrecoPorHora)
{
    Console.WriteLine("Agora digite o preço por hora:");
    if(decimal.TryParse(Console.ReadLine(), out precoPorHora))
    {
        verificarPrecoPorHora = false;
    }
    else
    {
        Console.WriteLine("Por favor, digite um valor decimal para o preço da hora.");
        Console.ReadKey();
        Console.Clear();
    }
}


// Instancia a classe Estacionamento, já com os valores obtidos anteriormente
Estacionamento es = new Estacionamento(precoInicial, precoPorHora);

string opcao = string.Empty;
bool exibirMenu = true;

// Realiza o loop do menu
while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("4 - Encerrar");

    switch (Console.ReadLine())
    {
        case "1":
            es.AdicionarVeiculo();
            break;

        case "2":
            es.RemoverVeiculo();
            break;

        case "3":
            es.ListarVeiculos();
            break;

        case "4":
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }

    Console.WriteLine("Pressione uma tecla para continuar");
    Console.ReadLine();
}

Console.WriteLine("O programa se encerrou");
