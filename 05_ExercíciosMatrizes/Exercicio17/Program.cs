namespace Exercicio17 {
    internal class Program {
        static void Main(string[] args) {
            Random random = new Random();
            int[,] matriz = new int[10,10];

            for (int linha = 0; linha < matriz.GetLength(0); linha++) {
                for (int coluna = 0; coluna < matriz.GetLength(1); coluna++) {
                    matriz[linha, coluna] = random.Next(1, 300);
                    Console.Write($"{matriz[linha, coluna]}\t");
                }
                Console.WriteLine();
            }

            int maior = int.MinValue;
            int maiorL = 0; 
            int maiorC = 0;
            int menor = int.MaxValue;
            int menorL = 0; 
            int menorC = 0;

            for (int linha = 0; linha < matriz.GetLength(0); linha++) {
                for (int coluna = 0; coluna < matriz.GetLength(1); coluna++) {
                    if (matriz[linha, coluna] > maior) {
                        maior = matriz[linha, coluna];
                        maiorL = linha;
                        maiorC =coluna;
                    }
                }
            }

           
                for (int coluna = 0; coluna < matriz.GetLength(1); coluna++) {
                    if (matriz[maiorL, coluna] < menor) {
                        menor = matriz[maiorL, coluna];
                        menorL = maiorL;
                        menorC = coluna;
                    }
                }

                Console.WriteLine($"\n\nO maior elemento da matriz é : {maior} - linha: {maiorL + 1} / coluna: {maiorC + 1}");
                Console.WriteLine($"O menor elemento da linha {menorL + 1} matriz é : {menor} - linha: {menorL + 1} / coluna: {menorC + 1}");

            Console.ReadKey();
        }
    }
}