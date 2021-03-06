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

            var listaDeCadastrados = new ListaDeFichas<FichaCadastral>();

            Console.WriteLine("Cadastre sua primeira conta\n");

            Cadastrar(listaDeCadastrados);

             SelecaoMenu(listaDeCadastrados);
            

            Console.Clear();
            Console.ReadLine();

        }

        

        public static void SelecaoMenu(ListaDeFichas<FichaCadastral> lista)
        {
            bool fechar = false;
            while (fechar != true)
            {
                Console.WriteLine("\nSelecione um menu:\n");
                Console.WriteLine($"1-Visualizar contas  || 2- Criar conta nova  || 3- Sair");

                var inputConsole = Console.ReadLine();
                int numeroMenu;
                var validaMenu = int.TryParse(inputConsole, out numeroMenu);
                if(validaMenu != true)
                {
                    numeroMenu = 4;
                }

                switch (numeroMenu)
                {
                    case 1:
                        Console.WriteLine($"\nVocê escolheu Visualizar");

                        Console.WriteLine("\nVisualizar Lista completa - 1" +
                            "\nFiltrar Lista - 2");
                        var input = Console.ReadLine();

                        if (input == "1")
                            Consulta.All_List(lista);

                        else if(input == "2")
                            Consulta.FilterFicha(lista);
                        else
                        {
                            Console.WriteLine("Digito invalido");
                            continue;
                        }
                        
                        break;


                    case 2:
                        Console.WriteLine($"Você escolheu Criar");
                        Cadastrar(lista);
                        break;


                    case 3:
                        fechar = true;
                        break;


                    default:
                        Console.WriteLine("Este digito é invalido");
                        break;
                }

               

            }
        }

        public static void Cadastrar(ListaDeFichas<FichaCadastral> lista)
        {
            bool valida = false;
            string nomeUnicoUso = null;
            int idadeEmInt = -1;
            string profissao = null;
            while (valida != true)
            {
                Console.Write("Digite seu nome:");
                nomeUnicoUso = Console.ReadLine();
                Console.Write("Digite sua idade:");
                var idade = Console.ReadLine();
                Console.Write("Digite sua profissao:");
                profissao = Console.ReadLine();

                Console.Clear();
                // Verifica se as variaveis digitadas são validas
                var testaInt = int.TryParse(idade, out idadeEmInt);
                if ((testaInt != true) || String.IsNullOrEmpty(nomeUnicoUso) || String.IsNullOrEmpty(profissao))
                {
                    Console.WriteLine("Informações incorretas");
                    Console.WriteLine("Não deve conter espaços em branco e idade deve ser em digito");
                    Console.WriteLine();
                    continue;
                }

                

                if (lista.Exists(x => x.NomeDeUsuario == nomeUnicoUso))
                {
                    Console.WriteLine($"Já existe uma pessoa com o nome de usuario {nomeUnicoUso}");
                    Console.WriteLine("Digite novamente as informações");
                    Console.WriteLine();
                    continue;
                }

                valida = true;
            }

            Console.WriteLine($"Informações:\n" +
                $" Nome {nomeUnicoUso}\n" +
                $" Idade {idadeEmInt}\n" +
                $" Profissão {profissao}");

            Console.WriteLine("Confirmar dados e salvar? \n" +
                "1- Sim.   2-Não");
            var selecao = Console.ReadLine();
            int nSelecao;
            bool validaSelecao = int.TryParse(selecao, out nSelecao);

            switch (nSelecao)
            {
                case 1:
                    lista.Add(new FichaCadastral(nomeUnicoUso, idadeEmInt, profissao));
                    Console.WriteLine("Cadastrado realizado com sucesso. Tecle enter para voltar a tela de inicio");
                    Console.ReadLine();
                    Console.Clear();
                    break;

                default:
                    Console.WriteLine("Por gentileza realizar o cadastro novamente... Tecle enter para continuar");
                    Console.ReadLine();
                    Console.Clear();
                    break;
            }
        }
    }
}
