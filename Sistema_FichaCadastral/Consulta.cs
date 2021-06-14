using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_FichaCadastral
{
    class Consulta
    { 
        //consulta toda lista
        public static void All_List(ListaDeFichas<FichaCadastral> listaParaConsulta)
        {
            listaParaConsulta.Sort();

            foreach (var ficha in listaParaConsulta)
            {
                Console.WriteLine(ficha);
            }

            Console.WriteLine("Terminou...");
            Console.WriteLine();
        }

        //adiciona um filtro e mostra todas as fichas com base no filtro
        public static void FilterFicha(ListaDeFichas<FichaCadastral> listaParaConsulta, int idade)
        {
            var lista = listaParaConsulta.Take(listaParaConsulta.Count).Where(f => f.Idade == idade);

            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }

        }        


    }
}
