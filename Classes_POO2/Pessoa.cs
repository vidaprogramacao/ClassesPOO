using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_POO2
{
    class Pessoa
    {
        // atributos da minha classe ↓
        private string nome;
        private int idade;

        // metodos get e set :D
        // get vai pegar
        // set vai gravar 

        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public void setIdade(int idade)
        {
            this.idade = idade;
        }

        // get 

        public string getNome()
        {
            return this.nome;
        }

        public int getIdade()
        {
            return this.idade;
        }
    }
}
