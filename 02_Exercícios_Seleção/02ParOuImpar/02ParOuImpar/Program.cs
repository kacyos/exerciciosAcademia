namespace _02ParOuImpar {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Digite o número: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0) {
                Console.WriteLine("O número digitado é par");
            } else {

                Console.WriteLine("O número digitado é ímpar");
            }
        }
    }
}