using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_FichaCadastral
{
    public class FichaCadastral 
    {

        public string Nome { get; private set; }
        public int Idade { get; private set; }
        public string Profisao { get; private set; }
        public int IdCadastro { get; }

        public FichaCadastral(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
            var randNum = new Random();

            IdCadastro = 100 * idade + (randNum.Next());
        }

        

        
       
    }
}
