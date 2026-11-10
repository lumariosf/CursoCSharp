using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes {
    internal class Stack {
        public static void Executar() {
            Stack<int> pilha = new Stack<int>();

            // push
            pilha.Push(3); 
            pilha.Push(4);
            pilha.Push(9);

            // pop back 

            foreach (int item in pilha)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine('\n');
            // pop front
            pilha.Pop();
            foreach (int item in pilha)
            {
                Console.WriteLine(item);
            }
        }
    }
}
