namespace Exercicio15 {
    internal class Program {
        static void Main(string[] args) {
            double nota, media = 0;

            Console.WriteLine("Digite as notas do aluno:");

            for (int i = 1; i <= 4; i++) {
                Console.Write($"Nota {i}: ");
                nota = double.Parse(Console.ReadLine());

                switch (i) {
                    case 1:
                        media = nota *= 2;
                        break;
                    case 2:
                        media += nota;
                        break;
                    case 3:
                        media += nota * 2;
                        break;
                    case 4:
                        media += nota * 4;
                        break;
                    default:
                        break;
                }

            }

            media /= 9;

            if (media >= 7.0) {
                Console.WriteLine("O aluno foi aprovado com média " + media.ToString("F1"));
            } else {
                Console.WriteLine("O aluno foi reprovado com média " + media.ToString("F1"));
            }
        }
    }
}