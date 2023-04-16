namespace Exercicio01 {
    internal class Program {
        static void Main(string[] args) {
            int numeroPessoas;
            int somaIdades = 0;

            Console.Write("Informe o número de pessoas: ");
            numeroPessoas = int.Parse(Console.ReadLine());
            Console.WriteLine();
            for (int i = 0; i < numeroPessoas; i++) {
                Console.Write($"Informe a idade da {i+1}º pessoa: ");
                somaIdades += int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            Console.Write($"A média das idades das {numeroPessoas} pessoas é: {(somaIdades / numeroPessoas)}");
            Console.ReadKey();
        }
    }
}