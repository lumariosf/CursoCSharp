using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MetodosEFuncoes {
    internal class Lambda {
        public static void Executar() {
            // passa os parametros e o corpo da funcao
            // todo action é void
            Action<string> algoNoConsole = (a) => {
                Console.WriteLine("lambda com c#" + a);
            };

            algoNoConsole("oi");

            // retorna um inteiro
            Func<int> jogarDado = () =>
            {
                Random random = new Random();
                return random.Next(1, 7);
            };

            Console.WriteLine(jogarDado());

            // anotação de uma linha
            Func<int, string> conversoHex = numero => numero.ToString("X");
            Console.WriteLine(conversoHex(1234));

            Func<int, int, int, string> formatarData = (dia, mes, ano) => String.Format("{0:D2}/{1:D2}/ {2:D2}", dia, mes, ano);

            Console.WriteLine(formatarData(1, 1, 1630));
        }
    }
}

