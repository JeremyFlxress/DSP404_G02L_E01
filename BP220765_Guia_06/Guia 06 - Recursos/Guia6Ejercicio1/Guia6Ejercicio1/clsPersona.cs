using System;
using System.Windows.Forms;
using System.IO;
using Guia6Ejercicio1;

namespace Guia6Ejercicio1
{
    public class clsPersona
    {
        // CAMPOS
        // (protected: indica que serán visibles solo dentro de los miembros de esta clase base y sus clases derivadas)
        protected string nombre;
        protected string foto; // URL de foto seleccionada para empleado
        protected DateTime fechanac;
        protected float sueldo;

        // MÉTODOS
        public clsPersona() // Constructor
        {
            nombre = "";
            foto = ""; // URL de foto-empleado aún no asignada
            fechanac = Convert.ToDateTime("1900/01/01"); // Fecha predeterminada
        }

        public virtual void asignarfechanac(string anno, string mes, string dia)
        {
            /*
            Este método deberá ser reemplazado en clases derivadas, con otro método
            que tenga el mismo encabezado (lista de parámetros o firma)
            */
            fechanac = Convert.ToDateTime(anno + "/" + mes + "/" + dia);
            MessageBox.Show("de clase Persona");
        }

        // PROPIEDADES
        public string nombreempleado
        {
            get
            {
                return nombre;
            }
            set
            {
                if (value.Length > 1)
                    nombre = value;
                else
                    nombre = "";
            }
        }

        public string URLfoto
        {
            // Accede a la URL del archivo JPG elegido por la persona
            get
            {
                return foto; // Retorna la URL de donde se seleccionó la foto
            }
            set
            {
                // Recibe la URL de la imagen seleccionada por el usuario
                if (nombre == "")
                {
                    MessageBox.Show("Usuario no tiene aún nombre asignado");
                }
                else
                {
                    // Genera la URL del nuevo archivo JPG, que se copiará hacia la carpeta de esta aplicación
                    foto = Application.StartupPath + "\\" + nombre + ".jpg";
                    // Copia el archivo de la ubicación elegida por el usuario hacia la ruta del ejecutable del proyecto actual
                    File.Copy(value, foto, true);
                }
            }
        }

        public float sueldobase
        {
            // Acceso lectura-escritura hacia el campo sueldo
            get
            {
                return sueldo;
            }
            set
            {
                if (value > 0)
                    sueldo = value;
                else
                    MessageBox.Show("Valor de sueldo incorrecto", "ERROR-SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public string fecha_nacimiento
        {
            // Propiedad solo-lectura
            get
            {
                return fechanac.ToShortDateString();
            }
        }
    }

    class clsDoctor : clsPersona
    {
        // CAMPO PRIVADO: Solo accesible dentro de esta clase
        string cod_doctor;

        // PROPIEDADES
        public string codigodoctor
        {
            get
            {
                return cod_doctor;
            }
            set
            {
                cod_doctor = value;
            }
        }

        // MÉTODOS
        public clsDoctor() // Constructor
        {
            nombre = "";
            sueldo = 5;
            fechanac = Convert.ToDateTime("1900/01/01");
        }

        // Este método en la clase hija reemplaza al método de la clase base
        // -> Observe que tiene el mismo nombre y FIRMA (lista/tipo de parámetros) del método original
        public override void asignarfechanac(string anno, string mes, string dia)
        {
            TimeSpan diftiempo; // Almacena un rango de tiempo entre 2 fechas
            try
            {
                DateTime fnac = Convert.ToDateTime(anno + "/" + mes + "/" + dia);
                // Calcula la diferencia de tiempo entre la fecha de nacimiento recibida y la fecha actual
                diftiempo = fnac - DateTime.Now;
                // Determina si la fecha ingresada es al menos 18 años antes de la fecha actual
                if (diftiempo.TotalDays < -365 * 18)
                    fechanac = fnac; // Acepta la fecha recibida en parámetros
                else
                    MessageBox.Show("Fecha nacimiento debe ser al menos 18 años antes de hoy", "ERROR-Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException e)
            {
                MessageBox.Show("Fecha brindada es incorrecta", "ERROR-SISTEMA!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Sobrecarga de método
        public void asignarfechanac(string fecha)
        {
            DateTime fechafin;
            // Función intenta convertir cadena fecha a tipo DateTime en fechafin.
            // Si es correcto, devuelve true
            if (DateTime.TryParse(fecha, out fechafin))
            {
                fechanac = fechafin;
            }
            else
                MessageBox.Show("Fecha de nacimiento es recibida", "ERROR DE SISTEMA!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // Confirma si los datos para agregar un Doctor son correctos
        public bool DatossonCorrectos()
        {
            if (nombre != "")
                if (sueldo > 0)
                    if (fechanac != Convert.ToDateTime("1900/01/01"))
                        return true; // Los datos recibidos son correctos
                    else
                        MessageBox.Show("Aún no se ha asignado fecha de nacimiento");
                else
                    MessageBox.Show("Sueldo incorrecto");
            else
                MessageBox.Show("Nombre aún no asignado");

            return false;
        }
    } // fin clase clsDoctor

    class clsVendedor : clsPersona
    {
        // CAMPOS (propios de clase derivada)
        DateTime fechacontratac;

        // MÉTODOS
        public clsVendedor() // Constructor
        {
            fechanac = Convert.ToDateTime("1950/01/01");
            fechacontratac = Convert.ToDateTime("2000/01/01");
        }

        // Este método en la clase hija reemplaza al método de la clase base
        // -> Observe que tiene el mismo nombre, pero diferente firma (lista de parámetros)
        public new void asignarfechanac(DateTime fechanacimiento)
        {
            fechanac = fechanacimiento;
        }

        // PROPIEDADES
        public DateTime FechaContrato
        {
            get
            {
                return fechacontratac;
            }
            set
            {
                this.fechacontratac = value;
            }
        }
    } // fin clase clsVendedor
}
