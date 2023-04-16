namespace Exercicio09 {
    internal class Program {
        static void Main(string[] args) {
            double valorGlicemia01, valorGlicemia02, valorGlicemia03, media;

            Console.Write("Informe o valor da medição de glicemia: ");
            valorGlicemia01 = double.Parse(Console.ReadLine());

            if (valorGlicemia01 < 65) {
                Console.WriteLine("\nRisco de hipoglicemia.\n");
            }

            if (valorGlicemia01 > 250) {
                Console.WriteLine("\nRisco de hipoglicemia.\n");
            }

            Console.Write("Informe o valor da medição de glicemia: ");
            valorGlicemia02 = double.Parse(Console.ReadLine());

            if (valorGlicemia02 < 65) {
                Console.WriteLine("\nRisco de hipoglicemia.\n");
            }

            if (valorGlicemia02 > 250) {
                Console.WriteLine("\nRisco de hipoglicemia.\n");
            }

            Console.Write("Informe o valor da medição de glicemia: ");
            valorGlicemia03 = double.Parse(Console.ReadLine());

            if (valorGlicemia03 < 65) {
                Console.WriteLine("\nRisco de hipoglicemia.\n");
            }  

            if (valorGlicemia03 > 250) {
                Console.WriteLine("\nRisco de hipoglicemia.\n");
            }

            media = (valorGlicemia01 + valorGlicemia02 + valorGlicemia03) / 3;

            if (media < 80) {
                Console.WriteLine("\nÉ preciso diminuir 2 unidades de insulina.\n");
            }

            if (media > 250) {
                Console.WriteLine("\nÉ necessário adicionar 2 unidades de insulina.\n");
            }

            Console.ReadKey();
        }
    }
}