using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataBaseMemory.Models
{
    public class Album
    {
        public int AlbumId { get; set; }
        public int ArtistaId { get; set; }  
        public string Titulo  { get; set; }
        public decimal Precio { get; set; }

        //relacion
        public Artista Artista { get; set; }
    }
}
