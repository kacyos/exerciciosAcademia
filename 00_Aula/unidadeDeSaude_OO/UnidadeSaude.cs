namespace unidadeDeSaude_OO {
    internal class UnidadeSaude {
        string nome;
        string sigla;

        public string Nome { get; set; }
        public string Sigla { get; set; }

        public UnidadeSaude() {
        }

        public UnidadeSaude(string nome, string sigla) {
            Nome = nome.ToUpper();
            Sigla = sigla;
        }

        public UnidadeSaude(string nome) {
            Nome = nome.ToUpper();
        }
    }
}