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

<<<<<<< Updated upstream
            //Cadastrar();

            bool fechar = false;

            var listaDeCadastrados = new List<FichaCadastral>();

            while(fechar == false)
            {
                fechar = SelecaoMenu(fechar);
            }
=======
            var listaDeCadastrados = new ListaDeFichas<FichaCadastral>();

            //listaDeCadastrados.Add(new FichaCadastral("Daniel", 18, "Carpinteiro"));

            Console.WriteLine("Realize seu primeiro Cadastro\n");
            Cadastrar(listaDeCadastrados);

            SelecaoMenu(listaDeCadastrados);
            
>>>>>>> Stashed changes

            Console.Clear();
            Console.ReadLine();

        }


<<<<<<< Updated upstream
        public static bool SelecaoMenu(bool fechar)
=======
        public static void SelecaoMenu(ListaDeFichas<FichaCadastral> lista)
>>>>>>> Stashed changes
        {
            bool fecharMenu = false;
            while (fecharMenu != true)
            {
<<<<<<< Updated upstream
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
=======
                Console.WriteLine();
                Console.WriteLine("Selecione um menu:");
                Console.WriteLine();
                Console.WriteLine($"1- Visualizar_Contas 2- Criar Conta 3- Sair");
            
                // verifica se o numero digitado é valido
                var nConsole = Console.ReadLine();
                int nOutParse;

                var validaBool = int.TryParse(nConsole, out nOutParse);
                if(validaBool == false)
                {
                nOutParse = 5;
                }


                switch (nOutParse)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine($"\nVocê escolheu Visualizar");

                        Console.WriteLine("\nVisualizar Lista completa - 1" +
                            "\nFiltrar Lista - 2");
                        var input = Console.ReadLine();

                        if (input == "1")
                            Consulta.All_List(lista);
>>>>>>> Stashed changes

                        else if(input == "2")
                            Consulta.FilterFicha(lista);
                        else
                        {
                            Console.WriteLine("Uma opção valida deve ser selecionada");
                            Console.Clear();
                        }

                        break;


                    case 2:
                        Console.WriteLine($"Você escolheu Criar");
                        Cadastrar(lista);
                        break;


                    case 3:
                        fecharMenu = true;
                        break;


                    default:
                        Console.WriteLine("Este digito é invalido");
                        break;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Chegou no final do switch");

        }

        public static void Cadastrar(List<FichaCadastral> lista)
        {
            bool valida = false;
<<<<<<< Updated upstream
            string nomeUnicoUso;
=======
            string nomeUnicoUso = null;
            string profissao = null;
            int idadeEmInt = -1;
>>>>>>> Stashed changes

            while (valida != true)
            {
                Console.Write("\n\nDigite seu nome de usuario:");
                nomeUnicoUso = Console.ReadLine();
<<<<<<< Updated upstream
                if (String.IsNullOrEmpty(nomeUnicoUso))
=======
                Console.Write("Digite sua idade:");
                var idade = Console.ReadLine();
                Console.Write("Digite sua profissão:");
                profissao = Console.ReadLine();

                Console.Clear();


                // Verifica se a idade digitada em idade é numero, caso sim, guarda na variavel idade
                var testaInt = int.TryParse(idade, out idadeEmInt);
                if ((testaInt != true) || String.IsNullOrEmpty(nomeUnicoUso) || String.IsNullOrEmpty(profissao))
>>>>>>> Stashed changes
                {
                    Console.WriteLine("Nome deve ser preenchido");
                    Console.WriteLine();
                    continue;
                }
                Console.Write("Digite sua idade:");
                var idade = Console.ReadLine();
                int idadeEmInt;

<<<<<<< Updated upstream
                valida = int.TryParse(idade, out idadeEmInt);
                if(valida != true)
=======
                
                // Verifica se ja tem outro usuario com esse nome
                if (lista.Exists(x => x.NomeDeUsuario == nomeUnicoUso))
>>>>>>> Stashed changes
                {
                    Console.WriteLine("idade deve ser digitada em digito");
                    Console.WriteLine();
                }
            }
            Console.Clear();


<<<<<<< Updated upstream
            
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
=======
            Console.WriteLine($"Informações:\n" +
                $" Nome {nomeUnicoUso}\n" +
                $" Idade {idadeEmInt}\n" +
                $" Profissão {profissao}");

            Console.WriteLine("\nConfirmar dados e salvar? \n" +
                "1- Sim.   2-Não");
            var selecao = Console.ReadLine();
            int nSelecao;
            var validaSelecao = int.TryParse(selecao, out nSelecao);
            if(validaSelecao == false)
            {
                nSelecao = 2;
            }

            switch (nSelecao)
            {
                case 1:
                    lista.Add(new FichaCadastral(nomeUnicoUso, idadeEmInt, profissao));
                    Console.WriteLine("Cadastrado realizado com sucesso. Tecle enter para voltar a tela de inicio");
                    Console.ReadLine();
                    Console.Clear();
                    break;

                default:
                    Console.WriteLine("Por gentileza realizar o cadastro novamente");
                    Console.ReadLine();
                    Console.Clear();
                    break;
>>>>>>> Stashed changes
            }
            return true;

        }




    }
}
