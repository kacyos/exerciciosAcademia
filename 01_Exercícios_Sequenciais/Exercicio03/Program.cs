namespace Exercicio03 {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("Digite um valor para 'A': ");
            string a = Console.ReadLine();

            Console.Write("Digite um valor para 'B'");
            string b = Console.ReadLine();

            string c = a;
            a = b;
            b = c;

            Console.WriteLine($"\nValores digitados:\nA: {a}\nB: {b}\n");
            Console.WriteLine($"\nValores invertidos:\nA: {a}\nB: {b}\n");
            Console.ReadKey();
        }
    }
}