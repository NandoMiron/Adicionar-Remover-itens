using Aula42;
using System.Globalization;
internal class Program
{
    private static void Main(string[] args)
    {
        
        int novaQuantidade;         // cria uma variavel para repassar os valores do item que vão ser adicionados ou removidos
        Produto p = new Produto();  // cria o objeto da classe produto
        Console.WriteLine("Entra com os dados do produto : "); // pede para o usuario entrar com os dados
        Console.Write("Nome : "); // pede para o usuario entrar com o nome do produto a ser cadastrado
        p.Nome = Console.ReadLine(); // armazena o nome da variavel nome do objeto p
        Console.Write("Preço : ");// pede para o usuario digitar o preço do produto
        p.Preco = Double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture); // armazena o preço do produto na variavel Preco e formata o valor
        Console.Write("Quantidade em estoque : ");// pede para o usuario entrar com a quantidade de produtos em estoque
        p.Quantidade = int.Parse(Console.ReadLine()); //armazena a quantidade de produtos em estoque na variavel Quantidade do objeto p
        

        Console.WriteLine("Dados do produto : "+p); // mostra os dados do objeto p ja formatado
        Console.WriteLine();
        Console.Write("Digite o numero de produtos a serem adicionados  : ");//pede para o usuario digitar a quantidade de produtos que serão adicionados no estoque
        novaQuantidade = int.Parse(Console.ReadLine()); //le a quantidade e armazena na variavel novaQuantidade
        p.AdicionarProdutos(novaQuantidade); //chama o metodo AdicionarProdutos e passa como referencia a variavel novaQuantidade
        Console.WriteLine( p);// mostra a quantidade de produtos e total ja atualizados e formatados
        Console.WriteLine();
        Console.Write("Digite o numero de produtos a serem removidos  : ");//pede para o usuario digitar a quantidade de produtos a serem removidos
        novaQuantidade = int.Parse(Console.ReadLine());//le a quantidade de produtos que vão ser removidos e armazena na variavel novaQuantidade
        p.RemoverProdutos(novaQuantidade);// chama o metodo RemoverProdutos e passa como parametro a variavel novaQuantidade
        Console.WriteLine(p);//mostra na tela a quantidade de produtos e total ja atualizados
    }
}