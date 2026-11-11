using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento {
    public class AmigoProximo {
        // n tem relação de herança mas tem relação de composição
        public readonly Subcelebridade amiga = new Subcelebridade();

        public void MeusAcessos() {
            Console.WriteLine("Amigo Próximo...");
            Console.WriteLine(amiga.infoPublica);
            Console.WriteLine(amiga.numeroCelular);
            Console.WriteLine(amiga.jeitoDeFalar);

            // n pode pq é por herança
            // Console.WriteLine(amiga.corDosOlhos); 
            //Console.WriteLine(amiga.segredoFamília);

            // n pode pq é private de subcelebridade
            // Console.WriteLine(amiga.usaMuitoPhotoshop);
        }
    }
}
