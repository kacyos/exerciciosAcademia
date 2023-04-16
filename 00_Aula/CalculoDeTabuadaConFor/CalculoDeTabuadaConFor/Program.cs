namespace CalculoDeTabuadaConFor {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("Digite um valor para tabuada: ");
            int valor = int.Parse(Console.ReadLine());

            for (int i = 0; i <= 10; i++) {
                Console.WriteLine($"{valor} x {i} = {i * valor}");
            }
        }
    }
}