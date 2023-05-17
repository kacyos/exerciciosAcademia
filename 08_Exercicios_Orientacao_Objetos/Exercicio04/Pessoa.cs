namespace Exercicio04 {
    internal class Pessoa {
        private string _nome;
        private int _idade;

        public string Nome {
            get {
                return _nome;
            }

            set {
                if (string.IsNullOrEmpty(value)) {
                    Console.WriteLine("O nome não pode ser vazio!");
                } else {
                    _nome = value;
                }
            }
        }
        public int Idade {
            get {
                return _idade;
            }
            set {
                if (value <= 0) {
                    Console.WriteLine("Idade deve ser maior que 0");
                } else {
                    _idade = value;
                }
            }
        }
    }
}
