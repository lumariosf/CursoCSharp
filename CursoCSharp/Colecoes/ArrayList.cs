using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes {
    internal class ExArrayList {
        public static void Executar() {
            ArrayList arraylist = new ArrayList {
               "palavra", 3, true, 
            };

            arraylist.Add(3.143);
            foreach (var item in arraylist) {
                Console.WriteLine(item);
                Console.WriteLine(item.GetType());
            }

        }
    }
}
