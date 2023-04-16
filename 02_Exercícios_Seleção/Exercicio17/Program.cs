namespace Exercicio17 {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("Informe o tamanho do lado A: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Informe o tamanho do lado B: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Informe o tamanho do lado C: ");
            int c = int.Parse(Console.ReadLine());

            if (a <= (b + c) || b <= (c + a) || c <= (b + a)) {

                if (a == b && b == c) {
                    Console.WriteLine("Equilátero.");
                } else if (a == b || a == c || b == c) {
                    Console.WriteLine("Isoceles.");
                } else {
                    Console.WriteLine("Escaleno.");
                }
            }

            Console.ReadKey();
        }
    }
}