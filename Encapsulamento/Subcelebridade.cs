using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento {
    public class Subcelebridade {
        public string infoPublica = "Tenho um Instagram";           // tds
        protected string corDosOlhos = "Verde";                     // herança
        internal ulong numeroCelular = 558481026677;                // mesmo projeto (assembly)
        protected internal string jeitoDeFalar = "uso gírias";      // herança e mesmo projeto
        private protected string segredoFamília = "hihhihi";        // mesma classe ou herança no mesmo projeto

        bool usaMuitoPhotoshop = true;                              //por padrão é private

        public void MeusAcessos() {
            Console.WriteLine("Subcelebridade...");

            Console.WriteLine(infoPublica);
            Console.WriteLine(corDosOlhos);
            Console.WriteLine(numeroCelular);
            Console.WriteLine(jeitoDeFalar);
            Console.WriteLine(segredoFamília);
            Console.WriteLine(usaMuitoPhotoshop);
        }
    }
}
