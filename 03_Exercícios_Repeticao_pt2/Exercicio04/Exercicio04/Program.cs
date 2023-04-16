namespace Exercicio04 {
    internal class Program {
        static void Main(string[] args) {
            int votoJoao = 0; int votoZeca = 0; int votoBranco = 0;
            while (true) {
                Console.WriteLine("Digite JOAO, ZECA ou BRANCO");
                string candidato = Console.ReadLine().ToUpper();

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
                        break;
                }

                if (candidato == "FIM") {
                    Console.Write($"Votos João: {votoJoao}\nVotos Zeca: {votoZeca}\nVotos Brancos: {votoBranco}");
                    break;
                }
            }
        }
    }
}