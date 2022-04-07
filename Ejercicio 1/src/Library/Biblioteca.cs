using System.Collections.Generic;
namespace SRP
{
    public class Biblioteca
    {
        private Dictionary<(int, int), Libro> libros { get; set; } 
        public Biblioteca()
        {
            this.libros = new Dictionary<(int, int), Libro>();
        }

        public void AddLibro(Libro libro, int sector, int estante)
        {
            if (!this.libros.ContainsValue(libro)){
                this.libros.Add((sector, estante), libro);}
        }

        public void RemoveLibro(int sector, int estante)
        {
            if (this.libros.ContainsKey((sector, estante))){ 
                this.libros.Remove((sector, estante));}
        }
    }
}