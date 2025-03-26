using System.Globalization;

namespace GestorDeProdutos;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Insira os dados do produto abaixo");
        Console.WriteLine();
        
        Console.Write("Nome do Produto: ");
        string nomeProduto = Console.ReadLine();
        Console.Write("Preço do Produto: ");
        double preçoProduto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Quantidade do Produto: ");
        int  quantidadeProduto = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Produto produto = new Produto(nomeProduto, preçoProduto, quantidadeProduto);
        Console.WriteLine();

        Console.WriteLine("Dados do Produto: " + produto);
        Console.WriteLine();
        
        Console.Write("Gostaria de fazer alguma modificação? y/n ");
        char fazerModificacao = char.Parse(Console.ReadLine().ToLowerInvariant());
        
        while (fazerModificacao == 'y'  && fazerModificacao != 'n' )
        {
            Console.Clear();
            
            Console.WriteLine("Escolha uma das opções abaixos: ");

            Console.WriteLine("a. Adicionar Produto.");
            Console.WriteLine("b. Remover Produto.");
            Console.WriteLine("c. Alterar Nome.");
            Console.WriteLine("d. Alterar Preço.");
            Console.WriteLine("e. Alterar Quantidade.");
            Console.WriteLine("f. Alterar Tudo.");
            Console.WriteLine("g. Encerrar Programa.");

            char mudancasProduto = char.Parse(Console.ReadLine().ToLowerInvariant());

            if (mudancasProduto == 'a')
            {
                Console.Clear();
                
                Console.WriteLine("Quantidade de produtos no estoque: " + produto.Quantidade + " Unidades.");
                
                Console.Write("Insira quantidade de produtos a serem adicionados ao estoque: ");
                int adicionarProdutos = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                produto.AdicionarProdutos(adicionarProdutos);
                Console.WriteLine();

                Console.Write("Dados atualizados: " + produto);
                Console.WriteLine();

                Console.Write("Gostaria de fazer alguma modificação? y/n ");
                mudancasProduto = char.Parse(Console.ReadLine().ToLowerInvariant());
            }
            else if (mudancasProduto == 'b')
            {
                Console.Clear();
                
                Console.WriteLine("Quantidade de produtos no estoque: " + produto.Quantidade + " Unidades.");
                
                Console.Write("Insira quantidade de produtos a serem removidos do estoque: ");
                int  removerProdutos = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                produto.RemoverProdutos(removerProdutos);
                Console.WriteLine();
                Console.WriteLine("Dados atualizados: "  + produto);
                
                Console.Write("Gostaria de fazer alguma modificação? y/n ");
                mudancasProduto = char.Parse(Console.ReadLine().ToLowerInvariant());
            }
            else if (mudancasProduto == 'c')
            {
                Console.Clear();

                Console.WriteLine("Nome antigo: " + produto.Nome);
                Console.Write("Insira o novo nome do Produto: ");
                string novoNome = Console.ReadLine();
                produto.Nome = novoNome;
                Console.WriteLine();
                
                Console.WriteLine("Dados atualizados: " + produto);
                Console.Write("Gostaria de fazer alguma modificação? y/n ");
                mudancasProduto = char.Parse(Console.ReadLine().ToLowerInvariant());
            }
            else if (mudancasProduto == 'd')
            {
                Console.Clear();

                Console.WriteLine("Preço anterior: " + preçoProduto.ToString("F2", CultureInfo.InvariantCulture));
                Console.Write("Insira novo preço: ");
                produto.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Dados atualizados: " + produto);
                
                Console.Write("Gostaria de fazer alguma modificação? y/n ");
                mudancasProduto = char.Parse(Console.ReadLine().ToLowerInvariant());
            }
            else if (mudancasProduto == 'e')
            {
                Console.Clear();

                Console.WriteLine("Produtos no estoque: " + produto.Quantidade + " Unidades.");
                Console.Write("Insira nova quantidade: ");
                produto.Quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine();

                Console.WriteLine("Dados atualizados: " + produto);
                Console.Write("Gostaria de fazer alguma modificação? y/n ");
                mudancasProduto = char.Parse(Console.ReadLine().ToLowerInvariant());
            }
            else if (mudancasProduto == 'f')
            {
                Console.Clear();
                
                Console.Write("Nome do Produto: ");
                 nomeProduto = Console.ReadLine();
                Console.Write("Preço do Produto: ");
                 preçoProduto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantidade do Produto: ");
                  quantidadeProduto = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                 produto = new Produto(nomeProduto, preçoProduto, quantidadeProduto);
                Console.WriteLine();
                
                Console.WriteLine("Dados atualizados: " + produto);
                Console.Write("Gostaria de fazer alguma modificação? y/n ");
                mudancasProduto = char.Parse(Console.ReadLine().ToLowerInvariant());
            }
            
            else if (mudancasProduto == 'g')
            {
                break;
            }
        }
    }
}