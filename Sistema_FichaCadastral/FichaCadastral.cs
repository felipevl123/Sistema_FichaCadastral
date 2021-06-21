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

        public string NomeDeUsuario { get; private set; }
        public int Idade { get; private set; }
        public string Profissao { get; private set; }
        public int IdCadastro { get ; set ; }

        public FichaCadastral(string nome, int idade, string profissao)
        {
            NomeDeUsuario = nome;    
            Idade = idade;
            Profissao = profissao;
        }

        public override string ToString()
        {
            return $"Nome: {NomeDeUsuario}, Idade: {Idade}, Id de cadastro {IdCadastro}, Profisão {Profissao}";
        }

        public int CompareTo(object obj)
        {
            var ficha = (FichaCadastral)obj;

            return NomeDeUsuario.CompareTo(ficha.NomeDeUsuario);
        }
    }
}
