internal class QtdVogais
{
    internal static void Executar()
    {
        int contadorVogais = 0;
        char[] vogais = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
        Console.WriteLine("Por favor digite qualquer palavra para contar suas vogais: ");
        string palavra = Console.ReadLine();
        foreach (char letra in palavra)
        {
            if (vogais.Contains(letra))
            {
                contadorVogais++;
            }

        }
        Console.WriteLine("A palvra tem " + contadorVogais + " vogais");
    }
}