using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    internal class GetSet {

        public class Moto {
            // encapsulamento 
            private string Marca;
            private string Modelo;
            private uint Cilindrada; 

            public Moto(string marca, string modelo, uint cilindrada) {
                this.Marca = marca; 
                this.Modelo = modelo;
                this.Cilindrada = cilindrada; 
            }

            public Moto() { }

            public string getMarca() {
                return Marca; 
            }

            public string getModelo() {
                return Modelo;
            }

            public uint getCilindrada() {
                return Cilindrada;
            }

            public void setMarca(string marca) {
                // posso criar limitações aqui de qual valor pode assumir
                this.Marca = marca; 
            }

            public void setModelo(string modelo) {
                this.Modelo = modelo;
            }

            public void setCilindrada(uint cilindrada) {
                this.Cilindrada = cilindrada;
            }
        }


        public static void Executar() {
            Moto m1 = new Moto("Sla", "Marca", 780);
            Console.WriteLine(m1.getCilindrada());
            m1.setCilindrada(679);
            Console.WriteLine(m1.getCilindrada());
        }
    }
}
