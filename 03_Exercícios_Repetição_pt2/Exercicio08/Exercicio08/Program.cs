using System.Drawing;

namespace Exercicio08 {
    internal class Program {
        static void Main(string[] args) {
            
            while (true) {
                Console.Write("Digite um número inteiro: ");
                string numero = Console.ReadLine();

                bool numeroEInteiro = Int32.TryParse(numero, out int valor);

                if (numeroEInteiro) {

                    if(valor % 2 == 0) {
                        Console.WriteLine($"O número: {numero} é par");
                        


                    } else {
                        Console.WriteLine($"O número: {numero} é impar");
                    }

                    Console.WriteLine("Deseja continuar? (s/n)");
                    char constinue = char.Parse(Console.ReadLine());

                    if(constinue == 's') {
                        continue;
                    } else {
                        break;
                    }

                } else {
                    continue;
                }
            }
           
        }
    }
}