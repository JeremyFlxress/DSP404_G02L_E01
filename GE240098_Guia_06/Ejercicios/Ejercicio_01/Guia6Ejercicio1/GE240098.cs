using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Guia6Ejercicio1
{
    public class clsPersona
    {
        protected string nombre;
        protected string foto;
        protected float sueldo;
        protected DateTime fecha_nac;


        //METODOS
        public clsPersona()
        {
            this.nombre = "";
            this.foto = "";
            this.fecha_nac = Convert.ToDateTime("1990/01/01"); //Fecha predeterminada
        }
        public virtual void asignarFechaNacimiento(string annio, string mes, string dia)
        {
            /*
             Este metodo debera ser reemplazado en clases derivadas, con otro metodo
             que tenga el mismo encabezado (lista de parametros o firma)
             */
            fecha_nac = Convert.ToDateTime($"{annio}/{mes}/{dia}");
            MessageBox.Show("De clase persona");
        }

        //PROPIEDADES
        public string nombre_empleado{
            get
            {
                return this.nombre;
            }
            set
            {
                if (value.Length > 1)
                {
                    nombre = value;
                }
                else
                {
                    nombre = "";
                }
            }
        }
        public string URLfoto
        {
            get
            {
                return this.foto; //Retorna la URL
            }
            set
            {   //Recibe la URL de la imagen seleccionada por el usuario
                if(nombre == "")
                {
                    MessageBox.Show("Usuario no tiene aún nombre asignado", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    foto = Application.StartupPath + "\\" + nombre + ".jpg";
                    File.Copy(value, foto, true);
                }
            }
        }

        public float sueldobase
        {
            get
            {
                return sueldo;
            }
            set
            {
                if (value > 0) sueldo = value;
                else MessageBox.Show("Valor de sueldo incorrecto", "ERROR-SISTEMA",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public string fecha_na
        {//Propiedad solo léctura
            get
            {
                return (fecha_nac.ToShortDateString().ToString());
            }
        }
    }
}
