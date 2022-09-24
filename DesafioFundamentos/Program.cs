using DesafioFundamentos.Models;

// Coloca o encoding para UTF8 para exibir acentuação
Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal precoInicial = 0;
decimal precoPorHora = 0;

Console.Clear();
Console.WriteLine("--------------------------------------------");
Console.WriteLine("BEM VINDO AO NOSSO SISTEMA DE ESTACIONAMENTO");
Console.WriteLine("--------------------------------------------\n");
Console.WriteLine("Digite o preço inicial:");
precoInicial = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Agora digite o preço por hora:");
precoPorHora = Convert.ToDecimal(Console.ReadLine());

// Instancia a classe Estacionamento, já com os valores obtidos anteriormente
Estacionamento es = new Estacionamento(precoInicial, precoPorHora);

string opcao = string.Empty;
bool exibirMenu = true;

// Realiza o loop do menu
while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("------------------------");
    Console.WriteLine("DIGITE A OPÇÃO DESEJADA ");
    Console.WriteLine("------------------------");
    Console.WriteLine("1 - Cadastrar veículos");
    Console.WriteLine("2 - Remover veículos");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("4 - Encerrar");
    Console.WriteLine("---------------------\n");
    
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

    Console.WriteLine("Pressione uma tecla para continuar...");
    Console.ReadLine();
}

Console.WriteLine("O programa se encerrou");
