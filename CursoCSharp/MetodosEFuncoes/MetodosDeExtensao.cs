using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MetodosEFuncoes {

    // como se fosse funções da API do c#
    public static class ExtensoesInteiro {
        public static int Soma(this int num, int outroNumero) {
            return num + outroNumero; 
        }

        public static int Subtracao(this int num, int outroNumero) {
            return num - outroNumero; 
        }

    }
    internal class MetodosDeExtensao {
        public static void Executar() {
            int numero = 5;
            Console.WriteLine(numero.Soma(3));
            Console.WriteLine(9.Soma(10));

            Console.WriteLine(numero.Subtracao(5));
        }
    }
}
