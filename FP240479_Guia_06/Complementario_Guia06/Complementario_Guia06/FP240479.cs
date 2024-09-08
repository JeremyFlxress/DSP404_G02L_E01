using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complementario_Guia06
{

    public abstract class Animales
    {
        public string NombreComun { get; set; }
        public string NombreCientifico { get; set; }
        public string Foto { get; set; }  
        public string Familia { get; set; }
        public string Habitat { get; set; }
        public DateTime FechaRegistro { get; set; }
    }

    public class Mamifero : Animales
    {
        public string DesarrolloEmbrionario { get; set; } 
        public int CantidadMamas { get; set; }
    }


    public class Reptil : Animales
    {
        public string TipoLocomocion { get; set; }  
        public string Orden { get; set; }  
    }


    public class Peces : Animales
    {
        public string SistemaEsqueletico { get; set; }  
        public string DesarrolloEmbrionario { get; set; } 
    }
    public class Artropodos : Animales
    {
        public string Tipo { get; set; } 
        public int CantidadPatas { get; set; }
        public int CantidadAntenas { get; set; }
    }



}
