using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MetodosEFuncoes {
    internal class UsandoDelegate {

        delegate double soma(double a, double b);
        delegate void imprimirsoma(double a, double b);

        static double MinhaSoma(double a, double b) {
            return a + b; 
        }

        static void MeuImprimirSoma(double a, double b) {
            Console.WriteLine(a + b);
        }
        public static void Executar() {
            // posso pegar funções pre existentes e associar com o delegate
            // n precisa colocar a função lambda
            // so precisa bater os tipos do parametros e retorno
            soma op1 = MinhaSoma;
            Console.WriteLine(op1(2, 3.9));

            imprimirsoma op2 = MeuImprimirSoma;
            op2(5.4, 8);

            // tbm pode usar func e action
            Func<double, double, double> op3 = MinhaSoma;
            Console.WriteLine(op3(2.5, 3));

            Action<double, double> op4 = MeuImprimirSoma;
            op4(7.7, 23.4);
        }
    }
}
