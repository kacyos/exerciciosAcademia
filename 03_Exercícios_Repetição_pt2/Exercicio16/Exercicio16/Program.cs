namespace Exercicio16 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Informe um número inteiro menor ou igual a 50: !");
            int numero = int.Parse(Console.ReadLine());

            int produto = numero;


            while(produto < 250) {
                if (produto * 3 > 250) { 
                    break;
                };
                produto *= 3;
            }

            Console.WriteLine($"sucessiva de N por 3 é: {produto}");
        }
    }
}