using System;
using System.Globalization;

namespace ExercicioControleEstoqueOO // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto();

            Console.WriteLine("Entre os dados do produto:");
            Console.WriteLine("");

            Console.Write("Nome: ");
            produto.Nome = Console.ReadLine();

            Console.Write("Preço: ");
            produto.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantidade no estoque: ");
            produto.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados do produto: " + produto);

            Console.WriteLine("");
            
            Console.WriteLine("Digite o número de produtos a ser adicionado ao estoque:");
            produto.AdicionarProdutos(int.Parse(Console.ReadLine()));
            
            Console.WriteLine("Dados do atualizados: " + produto);

            Console.WriteLine("");

            Console.WriteLine("Digite o número de produtos a ser removido do estoque:");
            produto.RemoverProduto(int.Parse(Console.ReadLine()));

            Console.WriteLine("Dados do atualizados: " + produto);
        }
    }
}