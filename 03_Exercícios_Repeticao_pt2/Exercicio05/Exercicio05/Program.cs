namespace Exercicio05 {
    internal class Program {
        static void Main(string[] args) {
            int votoJoao = 0;
            int votoZeca = 0;
            int votoBranco = 0;
            int votoNulo = 0;

            while (true) {
                Console.WriteLine("Digite JOAO, ZECA, BRANCO");
                string candidato = Console.ReadLine().ToLower().Trim();

                switch (candidato) {
                    case "JOAO":
                        votoJoao++;
                        break;
                    case "ZECA":
                        votoZeca++;
                        break;
                    case "BRANCO":
                        votoBranco++;
                        break;
                    default:
                        votoNulo++;
                        break;
                }

                if (candidato == "FIM") {
                    int total = votoBranco + votoJoao + votoNulo + votoZeca;

                    Console.Write($"\nTotal de votos: {total}\nVotos João: {votoJoao}\nVotos Zeca: {votoZeca}\nVotos Brancos: {votoBranco}\nVotos Nulos: {votoNulo}");
                    break;
                }
            }
        }
    }
}