using GerenciamentoDeSistemas.Models;

class Program
{
    static void Main()
    {
        // Configura a codificação de saída para UTF-8 para exibição correta de caracteres especiais.
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        // Cria uma instância da classe Estoque para gerenciar o estoque de frutas.
        Estoque es = new Estoque();

        // Variáveis para controle do menu.
        string opcao = string.Empty;
        bool exibirMenu = true;

        // Loop principal para exibir o menu e processar as opções do usuário.
        while (exibirMenu)
        {
            // Limpa a tela e exibe as opções do menu.
            Console.Clear();
            Console.WriteLine("Digite a opção:");
            Console.WriteLine("1 - Adicionar frutas no estoque");
            Console.WriteLine("2 - Remover fruta");
            Console.WriteLine("3 - Listar quantidade de frutas em estoque");
            Console.WriteLine("4 - Encerrar Programa");

            // Lê a opção do usuário.
            switch (Console.ReadLine())
            {
                case "1":
                    // Chama o método AdicionarFruta da instância do Estoque para adicionar frutas.
                    es.AdicionarFruta();
                    break;
                case "2":
                    // Chama o método RemoverFruta da instância do Estoque para remover frutas.
                    es.RemoverFruta();
                    break;
                case "3":
                    // Chama o método ListarQuantidadeFrutas da instância do Estoque para listar a quantidade de frutas.
                    es.ListarQuantidadeFrutas();
                    break;
                case "4":
                    // Encerra o loop do menu.
                    exibirMenu = false;
                    break;
                default:
                    // Mensagem exibida se o usuário inserir uma opção inválida.
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }

            // Aguarda o usuário pressionar qualquer tecla antes de continuar para o próximo ciclo do loop.
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
    }
}
