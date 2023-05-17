namespace Exercicio03 {
    internal class ContaCorrente {
        double saldo;

        public void definirSaldoInicial(double saldo) {
            this.saldo = saldo;
        }

        public void depositar(double valor) {
            this.saldo += valor;
            Console.WriteLine($"Depósito de {valor} realizado com sucesso!\n\n");
        }

        public bool sacar(double valor) {
            if (valor > saldo) {
                return false;
            } else {
                this.saldo -= valor;
                return true;
            }
        }
    }
}
