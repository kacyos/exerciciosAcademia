namespace CalculoTriangulo {
    internal class Program {
        static void Main(string[] args) {
            int ladoA, ladoB, ladoC;

            Console.Write("digite o lado 01: ");
            ladoA = int.Parse(Console.ReadLine());

            Console.Write("\ndigite o lado 02: ");
            ladoB = int.Parse(Console.ReadLine());

            Console.Write("\ndigite o lado 03: ");
            ladoC = int.Parse(Console.ReadLine());

            if ((ladoC <= (ladoA + ladoB)) && (ladoA <= (ladoB + ladoC)) && (ladoB <= (ladoA + ladoC))) {

                if (ladoA == ladoB && ladoB == ladoC) {
                    Console.WriteLine("equilatero!");
                } else if (ladoA == ladoB || ladoB == ladoC || ladoA == ladoC) {
                    Console.WriteLine("isósceles!");
                } else {
                    Console.WriteLine("escaleno!");
                }

            } else {
                Console.WriteLine("Os números não representam os lados de um triângulo.");
            }



        }
    }
}