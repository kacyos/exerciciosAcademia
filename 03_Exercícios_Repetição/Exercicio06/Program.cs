namespace Exercicio06 {
    internal class Program {
        static void Main(string[] args) {
            int numeroAlunos, avaliacoes;

            Console.Write("Informe o número de alunos da turma: ");
            numeroAlunos = int.Parse(Console.ReadLine());

            Console.Write("Informe o número de avaliações: ");
            avaliacoes = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numeroAlunos; i++) {
                double nota = 0;

                Console.WriteLine($"\nInforme a nota do {i}º aluno: ");

                for (int j = 1; j <= avaliacoes; j++) {
                    Console.Write($"Avaliação {j}: ");
                    nota += double.Parse(Console.ReadLine());
                }

                nota /= avaliacoes;

                Console.WriteLine($"\nMédia final do {i}º aluno é: {nota}\n");
            }            
        }
    }
}