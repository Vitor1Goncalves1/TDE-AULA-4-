double totalPedido = 0;

bool pedidoAberto = true;
while(pedidoAberto)
{
    Console.WriteLine("Bem vindo ao melhor sistema de gerenciamente de pedidos da ADS");
    Console.WriteLine("1- Adicionar item ao pedido");
    Console.WriteLine("2- Exibir total do pedido");
    Console.WriteLine("3- Finalizar pedido e sair");
    string opcao = Console.ReadLine();

    switch(opcao)
    {
        case "1":
        Console.WriteLine("Escolha um item do cardapio");
        Console.WriteLine("1- Pizza (R$30,00)");
        Console.WriteLine("2- Hamburguer (R$15,00)");
        Console.WriteLine("3- Refigerante (R$5,00)");
        string escolha = Console.ReadLine();

        if (escolha == "1")
        {
            Console.WriteLine("Voce adicionou uma pizza");
            totalPedido = totalPedido +30;
        }
        else if (escolha == "2")
        {
            Console.WriteLine("Voce adicional um hamburguer");
            totalPedido += 15;
        }
        else if (escolha == "3")
        {
            Console.WriteLine("Voce adicionou um refrigerente");
            totalPedido += 5;
        }
        else
        {
            Console.WriteLine("Opção Invalida");
        }
        break;
        
        case "2":
        Console.WriteLine($"O total do pedido foi {totalPedido}");
        break;

        case "3":
        Console.WriteLine("Volte sempre e obrigado por utilizar o sistema de gerenciamento da ulbra torres.");
        pedidoAberto = false;
        break;
        default:
        Console.WriteLine("Digite uma opção válida!");
        break;
    }

}

