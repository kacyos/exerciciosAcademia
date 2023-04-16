namespace Exercicio16 {
    internal class Program {
        static void Main(string[] args) {
            int[] x = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] y = new int[10] { 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };

            int[] uniao = new int[20];
            int[] diferenca = new int[20];
            int[] intersecao = new int[20];

            uniao = x.Union(y).ToArray();
            intersecao = x.Intersect(x.Intersect(y)).ToArray();
            diferenca = x.Except(y).ToArray().Concat(y.Except(x).ToArray()).ToArray();

            Console.WriteLine("\nUnião\n");
            for (int i = 0; i < diferenca.Length; i++) {
                Console.Write($" {diferenca[i]} |");
            }

            Console.WriteLine("\n\nIntersecao\n");
            for (int i = 0; i < intersecao.Length; i++) {
                Console.Write($" {intersecao[i]} |");
            }

            Console.WriteLine("\n\nDiferença\n");
            for (int i = 0; i < diferenca.Length; i++) {
                Console.Write($" {diferenca[i]} |");
            }

            Console.Read();
        }
    }
}