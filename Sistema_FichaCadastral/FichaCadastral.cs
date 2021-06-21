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

        public string NomeDeUsuario { get; private set; }
        public int Idade { get; private set; }
        public string Profisao { get; private set; }
        public int IdCadastro { get; }

        public FichaCadastral(string nome, int idade, string profissao)
        {
<<<<<<< Updated upstream
            Nome = nome;
            Idade = idade;
            var randNum = new Random();

            IdCadastro = 100 * idade + (randNum.Next());
=======
            NomeDeUsuario = nome;    
            Idade = idade;
            Profisao = profissao;
        }

        public override string ToString()
        {
            return $"Nome: {NomeDeUsuario}, Idade: {Idade}, Id de cadastro {IdCadastro}, Profissão {Profisao}";
>>>>>>> Stashed changes
        }

        

<<<<<<< Updated upstream
        
       
=======
            return NomeDeUsuario.CompareTo(ficha.NomeDeUsuario);
        }
>>>>>>> Stashed changes
    }
}
