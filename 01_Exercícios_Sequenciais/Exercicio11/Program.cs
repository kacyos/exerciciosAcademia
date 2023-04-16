namespace Exercicio11 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Digite o número total de eleitores: ");
            int eleitores = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o número de votos válidos: ");
            int validos = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o número de votos nulos: ");
            int nulos = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o número de votos em branco: ");
            int brancos = int.Parse(Console.ReadLine());

            double percentualValidos = (double)validos / eleitores * 100;
            double percentualNulos = (double)nulos / eleitores * 100;
            double percentualBrancos = (double)brancos / eleitores * 100;

            Console.WriteLine("Percentual de votos válidos: " + percentualValidos.ToString("F2") + "%");
            Console.WriteLine("Percentual de votos nulos: " + percentualNulos.ToString("F2") + "%");
            Console.WriteLine("Percentual de votos em branco: " + percentualBrancos.ToString("F2") + "%");

            Console.ReadKey();
        }
    }
}