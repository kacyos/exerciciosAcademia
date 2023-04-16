namespace _18ExibeOMaiorValor {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("Digite o valor 1: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor 2: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor 3: ");
            int c = int.Parse(Console.ReadLine());

            if (a > b || a > c) {
                Console.WriteLine(a);
            } else if (b > a || b > c) {
                Console.WriteLine(b);
            } else if (c > a || c > b) { 
                Console.WriteLine(c);
            } else {
                Console.WriteLine("Os valores são iguais.");
            }
        }
    }
}