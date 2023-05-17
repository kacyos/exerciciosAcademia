namespace Interface {
    internal class Program {
        static void Main(string[] args) {
            IMotor motor;

            Console.WriteLine("Digite 1 para ligar o motor elétrico e 2 para ligar o motor a ombustão");
            int op = int.Parse(Console.ReadLine());
            if (op == 1) {
                motor = new MotorEletico();
                motor.Ligar();
                motor.Desligar();
            } else if (op == 2) {
                motor = new MotorCombustao();
                motor.Ligar();
                motor.Desligar();
            }

        }
    }
}