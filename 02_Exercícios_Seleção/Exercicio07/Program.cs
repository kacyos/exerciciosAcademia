namespace Exercicio07 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Escreva uma frase:");
            string frase = Console.ReadLine();

            Console.WriteLine("\nEscreva uma palavra para pesquisa");
            string palavra = Console.ReadLine();

            bool contem = frase.ToLower().Contains(palavra.ToLower());

            if (contem) {
                Console.WriteLine($"A palavra: {palavra}, foi encontrada na frase:\n{frase}");
            } else {
                Console.WriteLine($"A palavra: {palavra}, não foi encontrada na frase:\n{frase}");
            }

            Console.ReadKey();
        }
    }
}