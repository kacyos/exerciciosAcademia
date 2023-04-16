namespace Exercicio05 {
    internal class Program {
        static void Main(string[] args) {
            double nota1, nota2, media;

            Console.WriteLine("Digite a nota 01");
            nota1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a nota 02");
            nota2 = double.Parse(Console.ReadLine());

            media = (nota1 + nota2) / 2;

            if (media >= 7) {
                Console.WriteLine("Aprovado");
            } else {
                Console.WriteLine("Digite a nota do exame:");
                double exame = double.Parse(Console.ReadLine());
                string situacao = ((exame + media) / 2) >= 5 ? "Aprovado" : "Reprovado";

                Console.WriteLine($"O aluno está: {situacao}");                
            }

            Console.ReadKey();
        }
    }
}