namespace Interface {
    internal class MotorCombustao : IMotor {
        public double gasolina;
        public bool ligado;

        public void Desligar() {
            if (ligado) {
                ligado = false;
            }
            Console.WriteLine("Motor a combustão desligado!");
        }

        public void Ligar() {
            if (gasolina > 0 && !ligado) {
                ligado = true;
            }
            Console.WriteLine("Motor a combustão ligado!");
        }
    }
}