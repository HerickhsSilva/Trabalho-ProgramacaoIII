bool executar = true;

while (executar)
{
    Console.Clear();
    Console.WriteLine("MENU DE EXERCÍCIOS");
    Console.WriteLine("1 - Calculadora");
    Console.WriteLine("2 - Contar Vogais");
    Console.WriteLine("3 - Imprimir Apenas Vogais");
    Console.WriteLine("4 - Imprimir Apenas Consoantes");
    Console.WriteLine("5 - Validar idade");
    Console.WriteLine("6 - Cadastro de Livro");
    Console.WriteLine("7 - Aprovação de Aluno");
    Console.WriteLine("0 - Sair");
    Console.Write("\nEscolha uma opção: ");

    string? opcao = Console.ReadLine();
    Console.Clear();

    switch (opcao)
    {
        case "1":
            Calculadora.Executar();
            break;
        case "2":
            QtdVogais.Executar();
            break;
        case "3":
            ImprimirVogais.Executar();
            break;
        case "4":
            ImprimirConsoantes.Executar();
            break;
        case "5":
            Idades.Executar();
            break;
        case "6":
            CadastroLivros.Executar();
            break;
        case "7":
            AprovacaoAlunos.Executar();
            break;
        case "0":
            executar = false;
            Console.WriteLine("Encerrando o programa...");
            continue; // Pula o ReadKey final e sai do loop
        default:
            Console.WriteLine("Opção inválida!");
            break;
    }

    Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
    Console.ReadKey();
}
