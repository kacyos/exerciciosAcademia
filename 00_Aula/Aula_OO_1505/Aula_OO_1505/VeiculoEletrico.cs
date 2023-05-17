namespace Aula_OO_1505 {
    internal class VeiculoEletrico : Veiculo {
        public double autonomia;

        public void Ligar() {
            if (autonomia > 0) {
                Console.WriteLine("Carro elétrico ligado");
            } else {
                Console.WriteLine("Não foi possível ligar. Sem bateria");
            }
        }

        public void Carregar() {
            this.autonomia += 10;
            Console.WriteLine("Carregado 10%");
        }
    }
}
