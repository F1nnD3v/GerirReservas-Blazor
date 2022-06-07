namespace GerirPessoasWebsite.Modelos
{
    public class Pessoa
    {
        public int id { get; set; }
        public string nome { get; set; }
        public int idade { get; set; }
        public string email { get; set; }
        public string telefone { get; set; }


        public Pessoa(int id, string nome, int idade, string telefone, string email)
        {
            this.id = id;
            this.nome = nome;
            this.idade = idade;
            this.email = email;
            this.telefone = telefone;
        }
        public Pessoa(string nome, int idade, string telefone, string email)
        {
            this.nome = nome;
            this.idade = idade;
            this.email = email;
            this.telefone = telefone;
        }

        public Pessoa()
        {

        }
    }
}
