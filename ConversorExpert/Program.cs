using System;

class Program
{
    static void Main()
    {
        int codigoProduto = 0;
        int quantidade = 0;

        int passo = 1;

        while (true)
        {
            // PASSO 1 - Código do Produto
            while (passo == 1)
            {
                Console.Clear();
                Console.WriteLine("[Passo 1 de 3] - Seleção do Produto");
                Console.WriteLine("Digite o código do produto (1 a 10):");
                Console.WriteLine("Ou digite 'cancelar' para sair.");

                string input = Console.ReadLine().ToLower();

                if (input == "cancelar")
                {
                    Console.WriteLine("Pedido cancelado.");
                    return;
                }

                if (int.TryParse(input, out codigoProduto))
                {
                    if (codigoProduto >= 1 && codigoProduto <= 10)
                    {
                        passo = 2;
                    }
                    else
                    {
                        Console.WriteLine($"Código {codigoProduto} não encontrado. Nossos códigos vão de 1 a 10.");
                        Console.ReadKey();
                    }
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Digite um número.");
                    Console.ReadKey();
                }
            }

            // PASSO 2 - Quantidade
            while (passo == 2)
            {
                Console.Clear();
                Console.WriteLine("[Passo 2 de 3] - Quantidade");
                Console.WriteLine("Digite a quantidade:");
                Console.WriteLine("Ou digite 'voltar' ou 'cancelar'.");

                string input = Console.ReadLine().ToLower();

                if (input == "cancelar")
                {
                    Console.WriteLine("Pedido cancelado.");
                    return;
                }

                if (input == "voltar")
                {
                    passo = 1;
                    break;
                }

                if (int.TryParse(input, out quantidade) && quantidade > 0)
                {
                    passo = 3;
                }
                else
                {
                    Console.WriteLine("Quantidade inválida. Digite um número maior que zero.");
                    Console.ReadKey();
                }
            }

            // PASSO 3 - Confirmação
            while (passo == 3)
            {
                Console.Clear();
                Console.WriteLine("[Passo 3 de 3] - Confirmação");
                Console.WriteLine($"Produto: {codigoProduto}");
                Console.WriteLine($"Quantidade: {quantidade}");
                Console.WriteLine("Confirmar pedido? (s/n)");
                Console.WriteLine("Ou digite 'voltar' ou 'cancelar'.");

                string input = Console.ReadLine().ToLower();

                if (input == "cancelar")
                {
                    Console.WriteLine("Pedido cancelado.");
                    return;
                }

                if (input == "voltar")
                {
                    passo = 2;
                    break;
                }

                if (input == "s")
                {
                    Console.WriteLine("Pedido realizado com sucesso!");
                    Console.ReadKey();
                    return;
                }
                else if (input == "n")
                {
                    Console.WriteLine("Pedido não confirmado. Reiniciando...");
                    passo = 1;
                    Console.ReadKey();
                    break;
                }
                else
                {
                    Console.WriteLine("Opção inválida. Digite 's' ou 'n'.");
                    Console.ReadKey();
                }
            }
        }
    }
}
