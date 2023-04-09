namespace _11VerificaHoraValida {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("Informe a hora (ex: 09): ");
            int hora = int.Parse(Console.ReadLine());

            Console.Write("Informe os minutos: (ex: 58)");
            int minutos = int.Parse(Console.ReadLine());

            Console.Write("\n*************************\n");
            if (hora > 23 || hora < 0) {
                Console.WriteLine("Hora inválida");
            }

            if (minutos > 59 || minutos < 0) {
                Console.WriteLine("Hora inválida");
            }
            Console.WriteLine($"\nHora digitada: {hora}:{minutos}\n");
            Console.Write("\n*************************\n");
        }
    }
}