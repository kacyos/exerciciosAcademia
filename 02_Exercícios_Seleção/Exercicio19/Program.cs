namespace Exercicio19 {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("Digite o valor 1: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor 2: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor 3: ");
            int c = int.Parse(Console.ReadLine());

            if (a > b && a > c) {
                if (b > c) {
                    Console.WriteLine($"{c},{b},{a}");
                }
            } else if (b > a && b > c) {
                if (a > c) {
                    Console.WriteLine($"{c},{a},{b}");
                }

            } else if (c > a && c > b) {
                if (a > b) {
                    Console.WriteLine($"{b},{a},{c}");
                }
            } else {
                Console.WriteLine($"{a},{b},{c}");
            }

            Console.ReadKey();
        }
    }
}