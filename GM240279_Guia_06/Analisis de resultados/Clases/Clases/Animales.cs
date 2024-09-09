using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Clases
{
    public abstract class Animales
    {
        protected string nombreComun;
        protected string nombreCientifico;
        protected string foto;
        protected string familia;
        protected string habitat;
        protected DateTime fechaRegistro;

        public Animales()
        {
            fechaRegistro = DateTime.Now;
        }

        public string NombreComun { get => nombreComun; set => nombreComun = value; }
        public string NombreCientifico { get => nombreCientifico; set => nombreCientifico = value; }
        public string Familia { get => familia; set => familia = value; }
        public string Habitat { get => habitat; set => habitat = value; }
        public DateTime FechaRegistro { get => fechaRegistro; }

        public string Foto
        {
            get => foto;
            set
            {
                if (!string.IsNullOrEmpty(nombreComun))
                {
                    foto = Application.StartupPath + "\\" + nombreComun + ".jpg";
                    File.Copy(value, foto, true);
                }
            }
        }
    }
}
