using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Encapsulamento; 

namespace CursoCSharp.OrientacaoObj {

    public class FilhoNaoReconhecido : Subcelebridade {
        public new void MeusAcessos() {
            Console.WriteLine("Filho Não Reconhecido...");

            Console.WriteLine(infoPublica);
            Console.WriteLine(corDosOlhos);
            Console.WriteLine(jeitoDeFalar);

            // atributo interno só no mesmo projeto
            // Console.WriteLine(numeroCelular);

            // por herança apenas no próprio projeto
            // Console.WriteLine(segredoFamília);

            // private
            // Console.WriteLine(usaMuitoPhotoshop);
        }
    }


    public class AmigoDistante { 
        public readonly Subcelebridade amiga = new Subcelebridade();
        public void MeusAcessos() {
            Console.WriteLine("Subcelebridade...");

            Console.WriteLine(amiga.infoPublica);
            // n em herança
            // Console.WriteLine(amiga.corDosOlhos);

            // interno
            // Console.WriteLine(amiga.numeroCelular);

            // interno ou protected
            // Console.WriteLine(jeitoDeFalar);

            // por herança apenas no próprio projeto
            // Console.WriteLine(segredoFamília);

            // private
            // Console.WriteLine(usaMuitoPhotoshop);
        }
    }

    internal class Encapsulamento {
        public static void Executar() {
            // public (todos); internal (projeto); protected (herança); private (classe)

            Subcelebridade sub = new Subcelebridade(); 
            sub.MeusAcessos();

            new AmigoProximo().MeusAcessos();
            new FilhoReconhecido().MeusAcessos(); 

            new FilhoNaoReconhecido().MeusAcessos();
            new AmigoDistante().MeusAcessos(); 
        }
    }
}
