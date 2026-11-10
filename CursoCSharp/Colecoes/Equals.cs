using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes {
    internal class Equals {
        public static void Executar() {
            Produto p1 = new Produto("a", 1); 
            Produto p2 = new Produto("a", 1);
            Produto p3 = p2;

            // da que são diferentes
            // compara as referencias de memoria
            Console.WriteLine(p1 == p2);
            Console.WriteLine(p1.Equals(p2));

            // aqui compartilha o mesmo
            Console.WriteLine(p2 == p3);

           // precisa fazer uma mudança na função equals pra conseguir comparar
           // usa override

            // para o set tem que ser feito a mesma coisa mas com a função GetHashCode
        }
    }
}
