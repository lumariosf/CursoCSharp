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
            return "Resultado " + resultado; 
        }

        public static void Executar() {
            Operacao subtracao = (int x, int y) => x - y;
            Console.WriteLine(Calculadora(subtracao, 3, 2));

            Console.WriteLine(Calculadora(Soma, 3, 2));
        }
    }
}
