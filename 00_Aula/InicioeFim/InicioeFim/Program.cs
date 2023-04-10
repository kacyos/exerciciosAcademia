namespace InicioeFim {
    internal class Program {
        static void Main(string[] args) {

            Console.Write("Informe o valor de início: ");
            int inicio = int.Parse(Console.ReadLine());

            Console.Write("Informe o valor final: ");
            int fim = int.Parse(Console.ReadLine());

            if(inicio > fim) {
                for (int i = inicio; i >= fim; --i) {
                    Console.WriteLine(i);
                }
            } else if (inicio < fim) {
                for (int i = inicio; i <= fim; i++) {
                    Console.WriteLine(i);
                }
            } else {
                Console.WriteLine("Valores iguais");
            }


        }
    }
}