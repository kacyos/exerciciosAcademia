namespace Exercicio03 {
    internal class Program {
        static void Main(string[] args) {
            int numero = 0;

            Console.Write("Digite um número: ");
            numero = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++) {
                Console.WriteLine($"{i} x {numero} = {i * numero}");               
            }

            Console.ReadKey();
        }
    }
}