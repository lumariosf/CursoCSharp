using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// classe que n permite herança
namespace CursoCSharp.OrientacaoObj {

    sealed class SemFilho {
        public double ValorDaFortuna() {
            return 1_407_033.65; 
        }
    }

    //class SouFilho : SemFilho {}

    class Avo {
        public virtual bool honrarNomeFamilia() {
            return true; 
        }
    }

    class Pai : Avo {
        public sealed override bool honrarNomeFamilia() {
            return true;
        }
    }

    class FilhoRebelde : Pai {

        // método selado n pode usar override para subscrever
        //public override bool honrarNomeFamilia() {
        //    return false; 
        //}

        // entender melhor pq esse pode
        public new bool honrarNomeFamilia() {
            return false;
        }
    }


    internal class Sealed {
        public static void Executar() {
            SemFilho semFilho = new SemFilho();
            Console.WriteLine(semFilho.ValorDaFortuna());

            FilhoRebelde filho = new FilhoRebelde();
            Console.WriteLine(filho.honrarNomeFamilia());
        }
        
    }
}
