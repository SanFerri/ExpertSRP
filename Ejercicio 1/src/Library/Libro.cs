using System;

namespace SRP
{
    public class Libro
    {

        public string Titulo { get ; }
        public string Autor { get ; }
        public string Codigo { get ;  }
        public string SectorBiblioteca { get ; set; }
        public string EstanteBiblioteca { get ; set; }

        public Libro(String titulo, String autor, String codigo)
        {
            this.Titulo = titulo;
            this.Autor = autor;
            this.Codigo = codigo;
        }

        /// <summary>
        /// Hay 2 razones para cambio, una es que el libro no sabe que libros
        /// hay en una biblioteca por lo cual no puede saber si ya esta ocupado
        /// el lugar o no. Y la segunda es que no sabe en que biblioteca se encuentra.
        /// 
        /// Nosotros agregariamos una clase Biblioteca con la resposabilidad de conocer
        /// los libros de la instancia y de verificar que el espacio donde se almacene un
        /// libro no este ocupado.
        /// </summary>
        /// <param name="sector"></param>
        /// <param name="estante"></param>
        public void AlmacenarLibro(String sector, String estante)
        {
            this.SectorBiblioteca = sector;
            this.EstanteBiblioteca = estante;
        }

    }
}
