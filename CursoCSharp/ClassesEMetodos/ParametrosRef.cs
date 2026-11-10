using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    internal class ParametrosRef {

        // ref é a versão de # do c++
        public static void alterarRef(ref int num) {
            num += 1000; 
        }

        public static void alterarOut(out int num) {
            num = 0; 
            num += 15;
        }

        public static void Executar() {

            // sempre tem que ser inicializada
            int a = 3;
            alterarRef(ref a);
            Console.WriteLine(a);

            // out é unidirecional 
            // apenas para salvar valor da função em uma variável 
            int b;
            alterarOut(out b);
            Console.WriteLine(b);
        }
    }
}
