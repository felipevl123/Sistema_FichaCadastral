using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_FichaCadastral
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao Gerenciador de ficha cadastral");

            //Cadastrar();

            bool fechar = false;

            var listaDeCadastrados = new List<FichaCadastral>();

            while(fechar == false)
            {
                fechar = SelecaoMenu(fechar);
            }

            Console.Clear();
            Console.ReadLine();

        }


        public static bool SelecaoMenu(bool fechar)
        {
            Console.WriteLine();
            Console.WriteLine("Selecione um menu:");
            Console.WriteLine();
            Console.WriteLine($"1-{Menu.Visualizar}  2-{Menu.Editar}  3-{Menu.Criar} 4-{Menu.Sair}");
            var numeroMenu = int.Parse(Console.ReadLine());

            switch(numeroMenu)
            {
                case 1:
                    Console.WriteLine($"Você escolheu {Menu.Visualizar}");
                    break;
                case 2:
                    Console.WriteLine($"Você escolheu {Menu.Editar}");
                    break;
                case 3:
                    Console.WriteLine($"Você escolheu {Menu.Criar}");
                    break;
                case 4:
                    return fechar = true;

                default:
                    Console.WriteLine("Este digito é invalido");
                    break;
            }

            Console.WriteLine();
            Console.WriteLine("Chegou no final do switch");

            return fechar = false;
        }

        public static void Cadastrar(List<FichaCadastral> lista)
        {
            bool valida = false;
            string nomeUnicoUso;

            while (valida != true)
            {
                Console.Write("Digite seu nome:");
                nomeUnicoUso = Console.ReadLine();
                if (String.IsNullOrEmpty(nomeUnicoUso))
                {
                    Console.WriteLine("Nome deve ser preenchido");
                    Console.WriteLine();
                    continue;
                }
                Console.Write("Digite sua idade:");
                var idade = Console.ReadLine();
                int idadeEmInt;

                valida = int.TryParse(idade, out idadeEmInt);
                if(valida != true)
                {
                    Console.WriteLine("idade deve ser digitada em digito");
                    Console.WriteLine();
                }
            }

            
            // Tentar resolver o problema com ReadLine onde não lê int
            
            //if (lista.Exists(x => x.Nome == nomeUnicoUso))
            {

            }

            //lista.Add(new FichaCadastral(nomeUnicoUso, idadeUnicoUso));
            
        }

        public static bool ValidarDados(string nome)
        {
            if (String.IsNullOrEmpty(nome))
            {
                Console.WriteLine("Dados impossiveis de serem inseridos");
                return false;
            }
            return true;

        }




    }
}
