using System;
using System.Collections.Generic;

namespace GerenciamentoDeSistemas.Models
{
    public class Estoque
    {
        // Dicionário para armazenar frutas e suas quantidades.
        private Dictionary<string, int> inventario = new Dictionary<string, int>(); // Nome colocado para o dicionário é inventario.

        // Função adicionar frutas que executa a primeira opção do programa.
        public void AdicionarFruta()
        {
            // Nesta linha, pergunto qual fruta o usuário deseja adicionar.
            Console.WriteLine("Digite qual fruta deseja adicionar:");
            // Utilizo um ReadLine para receber a fruta que ele digitou.
            string fruta = Console.ReadLine();
            
            // Peço a quantidade de frutas que o usuário quer inserir no estoque.
            Console.WriteLine("Digite a quantidade da fruta:");
            // Recebo a quantidade através de um ReadLine.
            int quantidade = int.Parse(Console.ReadLine());

            // Aqui armazeno os valores do tipo de fruta e a quantidade que foi digitada.
            if (inventario.ContainsKey(fruta))
            {
                // Se a fruta já existe, apenas atualizo a quantidade.
                inventario[fruta] += quantidade;
            }
            else
            {
                // Se a fruta ainda não existe, adiciono ao inventário.
                inventario.Add(fruta, quantidade);
            }
        }

        // Função remover frutas que executa a segunda opção do programa.
        public void RemoverFruta()
        {
            // Peço ao usuário a fruta que ele deseja remover.
            Console.WriteLine("Digite a fruta que deseja remover:");
            // Recebo a fruta através do ReadLine.
            string fruta = Console.ReadLine();

            if (inventario.ContainsKey(fruta))
            {
                // Peço a quantidade de fruta a ser removida.
                Console.WriteLine("Digite a quantidade da fruta a ser removida:");
                // Recebo a quantidade através de um ReadLine.
                int quantidadeRemover = int.Parse(Console.ReadLine());

                // Verifico se a quantidade a ser removida é menor ou igual à quantidade disponível.
                if (quantidadeRemover <= inventario[fruta])
                {
                    // Faço a subtração da quantidade de frutas que devem ser removidas pela quantidade que existe no inventário.
                    inventario[fruta] -= quantidadeRemover;
                    // Confirma a quantidade de frutas removidas.
                    Console.WriteLine($"{quantidadeRemover} unidades de {fruta} removidas do estoque.");
                }
                else
                {
                    // Se a quantidade de frutas que o usuário deseja remover for maior do que a do inventário, exibo a seguinte mensagem.
                    Console.WriteLine($"Não há {quantidadeRemover} unidades de {fruta} disponíveis no estoque.");
                }
            }
            else
            {
                // Se a fruta não está no estoque, exibo a seguinte mensagem.
                Console.WriteLine($"A fruta {fruta} não está no estoque.");
            }
        }

        // Função listar quantidade de frutas que executa a terceira opção do programa.
        public void ListarQuantidadeFrutas()
        {
            Console.WriteLine("Quantidade de frutas em estoque:");

            // Exibo a quantidade de frutas dentro do estoque!
            foreach (var item in inventario)
            {
                Console.WriteLine($"{item.Key}: {item.Value} unidades");
            }
        }
    }
}

