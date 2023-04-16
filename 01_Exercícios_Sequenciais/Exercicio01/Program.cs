namespace Exercicio01 {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("Digite o 1º número: ");
            int n1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o 2º número: ");
            int n2 = int.Parse(Console.ReadLine());

            double media = ((n1 + n2) / 2.0);

            Console.WriteLine($"\nA média dos número é {media}");
            Console.ReadLine();
        }
    }
}