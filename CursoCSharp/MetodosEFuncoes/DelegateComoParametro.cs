using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MetodosEFuncoes {
    internal class DelegateComoParametro {

        public delegate int Operacao(int x, int y);

        public static int Soma(int x, int y) {
            return x + y; 
        }

        // parece o uso em haskell
        // tem inferência de tipos como no map/fold?
        public static string Calculadora(Operacao op, int x, int y) {
            var resultado = op(x, y); 
        }

        public static void Executar() {

        }
    }
}
