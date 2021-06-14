using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_FichaCadastral
{
    class ListaDeFichas<T> : List<T> where T: IIdentity
    {
        private int iterador = 1;

        public new void Add(T item)
        {
            item.IdCadastro = iterador;
            iterador++;
            base.Add(item);
        }

        
    }
}
