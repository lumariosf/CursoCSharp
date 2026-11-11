using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento {
    public class FilhoReconhecido : Subcelebridade {
        public new void MeusAcessos() {
            Console.WriteLine("Filho Reconhecido...");

            Console.WriteLine(infoPublica);
            Console.WriteLine(corDosOlhos);
            Console.WriteLine(numeroCelular);
            Console.WriteLine(jeitoDeFalar);
            Console.WriteLine(segredoFamília);

            // n consegue acessar pq está privado em subcelebridade 
            // Console.WriteLine(usaMuitoPhotoshop);
        }
    }
}
