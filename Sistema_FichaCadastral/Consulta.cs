using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_FichaCadastral
{
    class Consulta
    { 
        // Consulta toda lista
        public static void All_List(ListaDeFichas<FichaCadastral> listaParaConsulta)
        {
            listaParaConsulta.Sort();

            IterarPelaLista(listaParaConsulta);
        }
        // Verifica se a lista filtrada esta vazia
        public static bool VerificaListaVazia(IEnumerable<FichaCadastral> lista)
        {
            var l = lista.ToArray();
            if (l == null || l.Length < 1)
            {
                Console.WriteLine("Não existe elementos nestes parametro. Tecle enter para continuar");
                Console.ReadLine();
                Console.Clear();
                return true;
            }
            else
            {
                return false;
            }
        }


        // Adiciona um filtro e mostra todas as fichas com base no filtro
        public static void FilterFicha(ListaDeFichas<FichaCadastral> listaParaConsulta)
        {
            Console.WriteLine("Deseja filtrar a lista por:\n" +
                "1 - Nome\n" +
                "2 - Profissão\n" +
                "3 - Idade");
            var input = Console.ReadLine();
            
            if(input == "1")
            {
                Console.Write("Digite o nome de usuario que deseja buscar: ");
                var nome = Console.ReadLine();

                var lista = listaParaConsulta.Take(listaParaConsulta.Count).Where(f => f.NomeDeUsuario == nome);
                if (VerificaListaVazia(lista) == false)
                {
                    IterarPelaLista(lista);
                }

            }
            else if (input == "2")
            {
                Console.WriteLine("Digite a profissão que deseja buscar: ");
                var profissao = Console.ReadLine();

                var lista = listaParaConsulta.Take(listaParaConsulta.Count).Where(f => f.Profisao == profissao);
                if (VerificaListaVazia(lista) == false)
                {
                    IterarPelaLista(lista);
                }

            }
            else if (input == "3")
            {
                bool valida = false;
                int idade;
                while (valida == false)
                {
                    Console.WriteLine("Digite a idade que deseja buscar: ");
                    var entradaConsole = Console.ReadLine();

                    valida = int.TryParse(entradaConsole, out idade);
                    if (valida != true)
                    {
                        Console.WriteLine("Idade deve ser valida");
                        continue;
                    }

                    var lista = listaParaConsulta.Take(listaParaConsulta.Count).Where(f => f.Idade == idade);
                    if (VerificaListaVazia(lista) == false)
                    {
                        IterarPelaLista(lista);
                    }
                }

            }
            else
            {
                Console.WriteLine("Uma opção valida deve ser selecionada...");
            }
        }


        // Percorre por toda lista, mostrando na tela todas as contas
        private static void IterarPelaLista(IEnumerable<FichaCadastral> lista)
        {
            Console.WriteLine();
            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Terminou...Tecle enter para continuar");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
