namespace _16JogoCopaDoBrasil {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("Informe o placar do time da casa: ");
            int timeDaCasaJogo01 = int.Parse(Console.ReadLine());

            Console.Write("Informe o placar do time visitante: ");
            int timeVisitanteJogo01 = int.Parse(Console.ReadLine());

            bool casaClassifica = (timeDaCasaJogo01 - timeVisitanteJogo01) >= 2;
            bool visitanteClassifica = (timeVisitanteJogo01 - timeDaCasaJogo01) >= 2;

            if (casaClassifica) {
                Console.WriteLine($"Time da Casa {timeDaCasaJogo01} x {timeVisitanteJogo01} Time visitante  - Casa Classifica");
            } else if (visitanteClassifica) {
                Console.WriteLine($"Time da Casa {timeDaCasaJogo01} x {timeVisitanteJogo01} Time visitante - visitante Classifica");
            } else {
                Console.WriteLine("\n\n2º jogo\n\n");

                Console.Write("Informe o placar do 2º jogo time da casa: ");
                int timeDaCasaJogo02 = int.Parse(Console.ReadLine());

                Console.Write("Informe o placar do 2º jogo time visitante: ");
                int timeVisitanteJogo02 = int.Parse(Console.ReadLine());

                visitanteClassifica = ((timeDaCasaJogo01 + timeVisitanteJogo02) - (timeVisitanteJogo01 + timeDaCasaJogo02) >= 2);
                casaClassifica = ((timeVisitanteJogo01 + timeDaCasaJogo02) - (timeDaCasaJogo01 - timeDaCasaJogo02) >= 2);
                bool empate = ((timeVisitanteJogo01 + timeDaCasaJogo02) - (timeDaCasaJogo01 - timeDaCasaJogo02) == 0);

                if (casaClassifica) {
                    Console.WriteLine($"Time da Casa {timeDaCasaJogo02} x {timeVisitanteJogo02} Time visitante - Casa Classifica");
                    Console.WriteLine($"Agregado \nTime da Casa {timeDaCasaJogo02 + timeVisitanteJogo01} x {timeVisitanteJogo02 + timeDaCasaJogo01} Time visitante");
                } 

                if (visitanteClassifica) {
                    Console.WriteLine($"Time da Casa {timeDaCasaJogo02} x {timeVisitanteJogo02} Time visitante  - visitante Classifica");
                    Console.WriteLine($"Agregado \nTime da Casa {timeDaCasaJogo02 + timeVisitanteJogo01} x {timeVisitanteJogo02 + timeDaCasaJogo01} Time visitante");
                }

                if (empate) {
                    Console.WriteLine("Decisão nos penaltis!");
                }
            }
        }
    }
}