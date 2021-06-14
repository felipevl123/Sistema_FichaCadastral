using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_FichaCadastral
{
    public class FichaCadastral : IIdentity, IComparable
    {

        public string Nome { get; private set; }
        public int Idade { get; private set; }
        public string Profisao { get; private set; }
        public int IdCadastro { get ; set ; }

        public FichaCadastral(string nome, int idade)
        {
            Nome = nome;    
            Idade = idade;
        }

        public override string ToString()
        {
            return $"Nome: {Nome}, Idade: {Idade}, Id de cadastro {IdCadastro}";
        }

        public int CompareTo(object obj)
        {
            var ficha = (FichaCadastral)obj;

            return Nome.CompareTo(ficha.Nome);
        }
    }
}
