namespace Exercicio12 {
    internal class Program {
        static void Main(string[] args) {
            int[] vetorV = new int[10] { 5, 18, 35, 2, 14, 33, 177, 32, 15, 5 };
            bool encontrado = false;

            while (true) {
                Console.Write("\nInforme um número e veja se ele existe no vetor: ");
                string numero = Console.ReadLine();

                if (numero.ToLower() == "x") {
                    break;
                }

                for (int i = 0; i < vetorV.Length; i++) {
                    if (vetorV[i] == int.Parse(numero)) {
                        Console.Write($"\nNúmero '{numero}' encontrado na posição: {i}");
                        encontrado = true;
                    }                    
                }

                if (!encontrado) {
                    Console.Write($"\nO Número não foi encontrado.\n");
                }

                encontrado = false;
            }
            
            
        }
    }
}