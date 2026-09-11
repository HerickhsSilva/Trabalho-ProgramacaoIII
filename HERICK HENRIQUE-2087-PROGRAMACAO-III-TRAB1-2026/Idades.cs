internal class Idades
{
    internal static void Executar()
    {
        Console.WriteLine("Me informe sua idade: ");
        int idade = int.Parse(Console.ReadLine());
        if (idade <= 19 && idade > 0)
        {
            Console.WriteLine("Jovem");
        }
        if (idade >= 20 && idade <= 59)
        {
            Console.WriteLine("Adulto");
        }
        if (idade >= 60)
        {
            Console.WriteLine("idoso");
        }
    }
}