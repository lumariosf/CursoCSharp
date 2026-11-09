using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    internal class ParametrosVariaveis {

        // palavra reservada params para agrupar varios valores
        public static void Recepcionar(params string[] pessoas) {
            foreach (var pessoa  in pessoas)
            {
                Console.WriteLine("olá {0}", pessoa);
            }
        }
        public static void Executar() {
            Recepcionar("Pedro", "Manu", "Luma"); 
        }
    }
}
