using DesafioFundamentos.Models;

        Console.WriteLine("Bem-vindo ao sistema de estacionamento!");

        Console.WriteLine("Digite o preço inicial:");
        decimal precoInicial = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("Digite o preço por hora:");
        decimal precoPorHora = Convert.ToDecimal(Console.ReadLine());

        Estacionamento estacionamento = new Estacionamento(precoInicial, precoPorHora);

        string opcao;
        do
        {
            Console.WriteLine("\nEscolha uma opção:");
            Console.WriteLine("1 - Cadastrar veículo");
            Console.WriteLine("2 - Remover veículo");
            Console.WriteLine("3 - Listar veículos");
            Console.WriteLine("4 - Encerrar");
            opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    estacionamento.AdicionarVeiculo();
                    break;
                case "2":
                    estacionamento.RemoverVeiculo();
                    break;
                case "3":
                    estacionamento.ListarVeiculos();
                    break;
                case "4":
                    Console.WriteLine("Encerrando o programa...");
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        } while (opcao != "4");

