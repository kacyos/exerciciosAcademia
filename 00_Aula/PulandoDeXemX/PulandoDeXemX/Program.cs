namespace PulandoDeXemX {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("Escreva um número: ");
            int x = int.Parse(Console.ReadLine());

            for (int i = x; i <= 100; i+=x) {
                Console.WriteLine(i);
            }
        }
    }
}