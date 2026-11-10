using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// algoritmo para verificar se um número é impar ou par
namespace CursoCSharp.Exercicios {
    internal class Ex1 {
        public static void Executar() {
            Console.WriteLine("Insira um número: ");

            // precisa receber como string e depois passar como inteiro
            int valor = int.Parse(Console.ReadLine());

            if ((valor % 2) == 0) {
                Console.WriteLine("Par");
            } else {
                Console.WriteLine("Impar");
            }
        }
        
    }
}
