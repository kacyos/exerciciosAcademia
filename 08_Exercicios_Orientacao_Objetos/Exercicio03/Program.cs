namespace Exercicio03 {
    internal class Program {
        static void Main(string[] args) {
            bool executando = true;

            ContaCorrente contaCorrente = new ContaCorrente();
            Console.WriteLine("Defina o saldo inicial: ");
            double saldo = double.Parse(Console.ReadLine());
            contaCorrente.definirSaldoInicial(saldo);



            while (executando) {
                Console.WriteLine("Escolha o que deseja: ");
                Console.Write("1-Sacar\n2-Depositar\n3-sair\n\n");
                Console.Write("Escolha: ");
                char escolha = char.Parse(Console.ReadLine());

                switch (escolha) {
                    case '1':
                        Console.Clear();
                        Console.WriteLine("*** Saque ***");
                        Console.Write("Valor do saque: ");
                        double valorSaque = double.Parse(Console.ReadLine());
                        if (contaCorrente.sacar(valorSaque)) {
                            Console.WriteLine("Saque efetuado com sucesso!\n\n");
                        } else {
                            Console.WriteLine("Saldo insuficiente.\n\n");
                        }
                        break;
                    case '2':
                        Console.Clear();
                        Console.WriteLine("*** Depósito ***");
                        Console.Write("Valor do depósito: ");
                        double valorDeposito = double.Parse(Console.ReadLine());
                        contaCorrente.depositar(valorDeposito);
                        break;
                    case '3':
                        executando = false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida!\n\n");
                        break;
                }
            }
        }
    }
}