namespace LeituraDeArquivos {
    internal class Pessoa {

        public string Nome { get; set; }
        public string Email { get; set; }
        public string DataNascimento { get; set; }

        public Pessoa(string nome, string email, string dataNascimento) {
            Nome = nome;
            DataNascimento = dataNascimento;
            Email = email;
        }

        public Pessoa(string nome, string dataNascimento) {
            Nome = nome;
            DataNascimento = dataNascimento;
            gerarEmail();
        }

        private void gerarEmail() {
            try {
                string[] linha = Nome.ToLower().Split();

                if (linha.Length == 1) {
                    Email = linha[0] + "@ufn.edu.br";
                } else {
                    Email = linha[linha.Length - 1] + "_" + linha[0] + "@ufn.edu.br";
                }

            } catch (Exception) {

                Email = "Sem email";
            }
        }

        public override string ToString() {
            return Nome + " : " + Email;
        }

        public override bool Equals(object? obj) {
            return obj is Pessoa pessoa &&
                   Email == pessoa.Email;
        }
    }

}
