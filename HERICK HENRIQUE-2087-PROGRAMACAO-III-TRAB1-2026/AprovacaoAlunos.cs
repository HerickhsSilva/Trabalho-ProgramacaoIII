using System.Runtime.InteropServices;

internal class AprovacaoAlunos
{

    public class Aluno
    {
        public string Nome { get; set; } = string.Empty;
        public string RA { get; set; } = string.Empty;
        public float NotaProva { get; set; }
        public float NotaTrabalho { get; set; }
        public int Frequencia { get; set; }


        public float CalcularMedia()
        {
            return (((NotaProva * 0.7F) + (NotaTrabalho * 0.3F))/2);
        }

        public bool VerificarPresenca()
        {
            if(Frequencia >= 60)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }

        internal static void Executar(){

        Aluno aluno = new Aluno();

        Console.WriteLine("Nome do aluno: ");
        aluno.Nome = Console.ReadLine() ?? "";

        Console.Write("RA do aluno: ");
        aluno.RA = Console.ReadLine() ?? "";

        do
        {
            Console.Write("Nota soma das Provas (0 a 20): ");
            aluno.NotaProva = float.Parse(Console.ReadLine());
        } while (aluno.NotaProva > 20 || aluno.NotaProva < 0);

        do
        {
            Console.Write("Nota soma dos Trabalhos (0 a 20): ");
            aluno.NotaTrabalho = float.Parse(Console.ReadLine());
        } while (aluno.NotaTrabalho > 20 || aluno.NotaTrabalho < 0);

        do
        {
            Console.Write("Frequência do aluno (0 a 100): ");
            aluno.Frequencia = int.Parse(Console.ReadLine());
        } while (aluno.Frequencia < 0 || aluno.Frequencia > 100);

        float mediaFinal = aluno.CalcularMedia();
        bool aprovadoPresenca = aluno.VerificarPresenca();
        bool aprovadoNota = mediaFinal >= 7.0;

        if (aprovadoNota && aprovadoPresenca)
        {
            Console.WriteLine("Situação: APROVADO");
        }
        else
        {
            Console.Write("Situação: REPROVADO");
        }

    }


 

    
}