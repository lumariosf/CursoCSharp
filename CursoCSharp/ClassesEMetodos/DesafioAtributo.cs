using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    internal class DesafioAtributo {

        int a = 10; 
        public static void Executar() {
            // acessar a variável 'a' de dentro do método Executar
            int val = new DesafioAtributo().a;
            Console.WriteLine("Valor de 'a': {0}", val);
        }
    }
}
