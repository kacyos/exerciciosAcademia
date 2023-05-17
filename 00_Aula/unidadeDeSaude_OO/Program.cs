namespace VerificarIdadeMaiorouMenor {
    internal class Program {
        static void Main(string[] args) {
            int idade;

            Console.Write("Escreva sua idade: ");
            idade = int.Parse(Console.ReadLine());

            if(idade >= 18) {
                Console.WriteLine("Você é maior de idade!");
            } else {
                Console.WriteLine("Você é menor de idade!");
            }
        }
    }
}