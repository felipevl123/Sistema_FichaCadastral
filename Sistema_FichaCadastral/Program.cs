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



            bool fechar = false;

            var listaDeCadastrados = new List<FichaCadastral>();

            listaDeCadastrados.Add(new FichaCadastral("Daniel", 18));

            Cadastrar(listaDeCadastrados);

            //IterarListaCadastro(listaDeCadastrados);

            while (fechar == false)
            {
                fechar = SelecaoMenu(fechar);
            }

            Console.Clear();
            Console.ReadLine();

        }

        private static void IterarListaCadastro(List<FichaCadastral> lista)
        {
            foreach (var ficha in lista)
            {
                Console.WriteLine(ficha);
            }

            Console.WriteLine("Terminou...");
            Console.WriteLine();
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
            string nomeUnicoUso = null;
            int idadeEmInt = -1;

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
                

                valida = int.TryParse(idade, out idadeEmInt);
                if(valida != true)
                {
                    Console.WriteLine("idade deve ser digitada em digito");
                    Console.WriteLine();
                }
            }

            Console.WriteLine("Deu tudo certo!");
            
            // Tentar resolver o problema com ReadLine onde não lê int
            
            if (lista.Exists(x => x.Nome == nomeUnicoUso))
            {
                Console.WriteLine("esse nome ja existe");
            }

            lista.Add(new FichaCadastral(nomeUnicoUso, idadeEmInt));
            Console.WriteLine("Cadastrado realizado com sucesso. Tecle enter para voltar a tela de inicio");
            Console.ReadLine();

            
        }

        




    }
}
