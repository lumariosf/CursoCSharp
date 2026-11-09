using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {

    public class CalculadoraEstatica {
        // usar o static para não precisar instanciar a classe para usar os métodos
        public static int Somar(int a, int b) {
            return a + b;
        }

        public static int Subtrair(int a, int b) {
            return a - b;
        }

        public static int Multiplicar(int a, int b) {
            return a * b;
        }
    }


    internal class MetodosEstaticos {
        public static void Executar() {
            // sem precisar instanciar 
            // metodo pertennce a classe

            int resultado = CalculadoraEstatica.Somar(5, 5);
            Console.WriteLine(resultado);
        }
    }
}
