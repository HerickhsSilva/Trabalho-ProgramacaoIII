internal class ImprimirVogais
{
    internal static void Executar()
    {
        string v = "";
        char[] vogais = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
        Console.WriteLine("Digite uma palavra: ");
        string palavra = Console.ReadLine();
        foreach (char letra in palavra)
        {
            if (vogais.Contains(letra))
            {
                v += letra;
            }

        }

        Console.WriteLine(v);
    }
}