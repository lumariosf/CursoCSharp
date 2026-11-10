using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CursoCSharp.ClassesEMetodos;

namespace CursoCSharp {

    public struct SPonto {
        public int x; 
        public int y;
    }

    public class CPonto {
        public int x;
        public int y;
    }

    internal class ClasseVsStruct {
        public static void Executar() {

            SPonto p1 = new SPonto { x = 1, y = 2 };
            SPonto copiap1 = p1;
            p1.x = 3;

            // valores independentes, n aponta para o mesmo local de memória
            // paradigma funcional
            Console.WriteLine(p1.x);
            Console.WriteLine(copiap1.x);

            CPonto p2 = new CPonto { x = 1,y = 2 };
            CPonto copiap2 = p2;
            p2.x = 3;

            // na classe eles apontam para o mesmo local de memória
            // paradigma de orientação a objetos
            Console.WriteLine(p2.x);
            Console.WriteLine(copiap2.x); 
        }
    }
}
