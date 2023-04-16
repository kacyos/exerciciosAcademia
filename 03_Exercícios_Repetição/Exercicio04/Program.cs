namespace Exercicio04 {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("Escreva o valor da base x: ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Escreva o valor do expoente y: ");
            int y = int.Parse(Console.ReadLine());

            int potencia = 1;

            for (int i = 0; i < y; i++) {
                potencia *= x;
            }

            Console.WriteLine(potencia);

            Console.ReadKey();
        }
    }
}