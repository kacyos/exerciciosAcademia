namespace Aula_OO_1505 {
    internal class Program {
        static void Main(string[] args) {
            /*
              Veiculo v = new Veiculo();
              v.potencia = 500;
              v.modelo = "Gol";
              v.Ligar();

              VeiculoEletrico ve = new VeiculoEletrico();
              ve.potencia = 100;
              ve.modelo = "Tesla";
              ve.autonomia = 10;
              ve.Ligar();
              ve.Carregar();

              Motocicleta m = new Motocicleta();
              m.Ligar();
            */

            Animal c = new Cavalo("Cacio", 35, "Garanhão");
            c.emitirSom();

        }
    }
}