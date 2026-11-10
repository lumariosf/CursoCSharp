using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes {
    internal class Queue {
        public static void Executar() {
            Queue<string> q = new Queue<string>();

            // push
            q.Enqueue("oi");
            q.Enqueue("oiii");
            q.Enqueue("oiiiii");

            // front
            Console.WriteLine(q.Peek());
         
            // length
            Console.WriteLine(q.Count());

            // pop
            q.Dequeue(); 
            Console.WriteLine(q.Count());
            Console.WriteLine(q.Peek());

            // find
            Console.WriteLine(q.Contains("oiiiiiiii"));

            foreach (var pessoa in q)
            {
                Console.WriteLine(pessoa);
            }
        }
    }
}
