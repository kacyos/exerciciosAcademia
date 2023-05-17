namespace Exercicio_Heranca02 {
    internal class Program {
        static void Main(string[] args) {
            Veiculo veiculo = new Veiculo();
            veiculo.marca = "Fiat";
            veiculo.modelo = "Uno";
            veiculo.Dirigir();

            Carro carro = new Carro();
            carro.marca = "Chevrolet";
            carro.modelo = "Chevet";
            carro.quantidadeDePortas = 2;
            carro.Dirigir();

            Moto moto = new Moto();
            moto.marca = "Honda";
            moto.modelo = "H452";
            moto.cilindradas = 700;
            moto.Dirigir();
        }
    }
}