using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {

    interface Ponto {
        void moverNaDiagonal(int delta);

        // metodo de iterface n pode ser private 
    }

    struct Coordenada : Ponto {
        public int X; 
        public int Y;

        public Coordenada(int x, int y) {
            this.X = x; this.Y = y; 
        }

        public void moverNaDiagonal(int delta) {
            X += delta; Y += delta; 
        }
    }

    internal class Struct {
        public static void Executar() {
            Coordenada c1;
            c1.X = 1; c1.Y = 2;

            Console.WriteLine("cord ({0}, {1})", c1.X, c1.Y);
            c1.moverNaDiagonal(4); 
            Console.WriteLine("cord ({0}, {1})", c1.X, c1.Y);
        }
    }
}
