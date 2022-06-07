using System;
using System.Data.Entity;

namespace LibraryClasses
{   
    public class Pessoa
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string email { get; set; }
        public string telefone { get; set; }
        public int idade { get; set; }

        public Pessoa(int id, string nome, string email, string telefone, int idade)
        {
            this.id = id;
            this.nome = nome;
            this.email = email;
            this.telefone = telefone;
            this.idade = idade;
        }
    }
}
