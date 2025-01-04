
using POO_CSharp_P2;
using System.Drawing;
using System.Globalization;
using System.Runtime.ConstrainedExecution;

internal class Program
{
    private static void Main(string[] args)
    {
//        Exercício Exemplo
//        Fazer um programa para ler os dados de um produto em estoque(nome, preço e
//        quantidade no estoque). Em seguida:
//        • Mostrar os dados do produto(nome, preço, quantidade no estoque, valor total no
//          estoque)
//        • Realizar uma entrada no estoque e mostrar novamente os dados do produto
//        • Realizar uma saída no estoque e mostrar novamente os dados do produto

        Produto p = new Produto();

        Console.WriteLine("Entre os dados do produto:");
        Console.Write("Nome: ");
        p.Nome = Console.ReadLine();
        Console.Write("Preço: ");
        p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Quantidade no estoque: ");
        p.Quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine();
        Console.WriteLine("Dados do produto: " + p);

        Console.WriteLine();
        Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
        int qte = int.Parse(Console.ReadLine());
        p.AdicionarProdutos(qte);
        Console.WriteLine();
        Console.WriteLine("Dados atualizados: " + p);


        Console.WriteLine();
        Console.Write("Digite o número de produtos a ser removido do estoque: ");
        qte = int.Parse(Console.ReadLine());
        p.RemoverProdutos(qte);
        Console.WriteLine();
        Console.WriteLine("Dados atualizados: " + p);
    }
}