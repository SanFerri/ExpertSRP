using System.Collections.Generic;
namespace SRP
{
    /// <summary>
    /// Asi aplicariamos una clase biblioteca para cumplir con
    /// SRP.
    /// </summary>
    public class Biblioteca
    {
        private Dictionary<(string, string), Libro> libros { get; set; } 
        public Biblioteca()
        {
            this.libros = new Dictionary<(string, string), Libro>();
        }

        public void AddLibro(Libro libro, string sector, string estante)
        {
            if (!this.libros.ContainsValue(libro)){
                this.libros.Add((sector, estante), libro);}
        }

        public void RemoveLibro(string sector, string estante)
        {
            if (this.libros.ContainsKey((sector, estante))){ 
                this.libros.Remove((sector, estante));}
        }
    }
}