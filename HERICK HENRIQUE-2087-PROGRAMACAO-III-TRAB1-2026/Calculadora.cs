internal class Calculadora
{
    internal static void Executar()
    {
        Console.WriteLine("Insira o primeiro numero na calculadora:");
        float numero1 = float.Parse(Console.ReadLine());
        Console.WriteLine("Insira o segundo numero na calculadora:");
        float numero2 = float.Parse(Console.ReadLine());
        Console.WriteLine("Informe a operação desejada\n1/adição\n2/subtração\n3/multiplicação\n4/divisão ");
        int operação = int.Parse(Console.ReadLine());
        float resultado;
        
        switch (operação){
            case 1:
                resultado = numero1 + numero2;
                Console.WriteLine(resultado);
                break;

            case 2:
                resultado = numero1 - numero2;
                Console.WriteLine(resultado);
                break;
            case 3:
                resultado = numero1 * numero2;
                Console.WriteLine(resultado);
                break;
            case 4:
                if (numero2 == 0) { Console.WriteLine("Não é possivel dividir por 0"); break; } 
                resultado = numero1 / numero2;
                Console.WriteLine(resultado);
                break;
        }


    }
}