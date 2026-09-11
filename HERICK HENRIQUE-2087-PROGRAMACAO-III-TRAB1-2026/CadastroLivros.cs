internal class CadastroLivros
{
    public class Livro
    {
        public string Titulo { get; set; } = string.Empty;
        public string Autor { get; set; } = string.Empty;
        public double Valor { get; set; }
    }
    internal static void Executar()
    {
        Livro livro = new Livro();

        Console.Write("Título do livro: ");
        livro.Titulo = Console.ReadLine() ?? "";
        Console.Write("Autor do livro: ");
        livro.Autor = Console.ReadLine() ?? "";
        Console.Write("Valor do livro (R$): ");
        livro.Valor = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("\nLivro Cadastrado");
        Console.WriteLine($"Título: {livro.Titulo}");
        Console.WriteLine($"Autor: {livro.Autor}");
        Console.WriteLine($"Valor: {livro.Valor:C2}");
    }
}