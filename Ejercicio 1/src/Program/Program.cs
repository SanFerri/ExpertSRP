using System;

namespace SRP
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Biblioteca biblioteca = new Biblioteca();
            Libro libro1 = new Libro("Design Patterns","Erich Gamma & Others","001-034");
            Libro libro2 = new Libro("Pro C#","Troelsen","001-035");
            biblioteca.AddLibro(libro1,"A","7");
            biblioteca.AddLibro(libro2, "B","3");
        }
    }
}
