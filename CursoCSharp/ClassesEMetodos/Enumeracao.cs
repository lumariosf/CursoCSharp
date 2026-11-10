using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {

    public enum Genero { Acao, Aventura, Terror, Animacao, Comedia }
    public class Filme {
        public string Titulo;
        public Genero GenerodoFilme;
    } 


    internal class Enumeracao {
        public static void Executar() {
            // atribuir um valor 
            // ver como posso chamar por esse id
            int id = (int)Genero.Animacao;
            Console.WriteLine(id);

            Filme f1 = new Filme();
            f1.Titulo = "Vampiro";
            f1.GenerodoFilme = Genero.Acao;

            Console.WriteLine("{0} é {1}", f1.Titulo, f1.GenerodoFilme);
        }
    }
}
