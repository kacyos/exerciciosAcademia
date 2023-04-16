namespace Exercicio09 {
    internal class Program {

        static void Main(string[] args) {
            int umATresFilhos = 0;
            int quatroASeteFilhos = 0;
            int maisQueOitoFilhos = 0;
            int semFilhos = 0;

            for (int i = 1; i <= 30; i++) {
                Console.Write($"Informe quantos filhos tem a {i}º pessoa: ");
                int numeroDeFilhos = int.Parse(Console.ReadLine());

                if (numeroDeFilhos > 0 && numeroDeFilhos <= 3) {
                    umATresFilhos++;
                } else if (numeroDeFilhos > 0 && numeroDeFilhos <= 7) {
                    quatroASeteFilhos++;
                } else if (numeroDeFilhos >= 7) {
                    maisQueOitoFilhos++;
                } else {
                    semFilhos++;
                }
            }

            Console.WriteLine($"Possui até 3 filhos: {umATresFilhos}");
            Console.WriteLine($"Possui até 7 filhos: {quatroASeteFilhos}");
            Console.WriteLine($"Possui 8 ou mais filhos: {maisQueOitoFilhos}");
            Console.WriteLine($"Não possui filhos: {semFilhos}");
        }
    }
}