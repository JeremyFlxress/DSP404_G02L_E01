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
        public string nombre_empleado
        {
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
                if (nombre == "")
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

        public string fecha_nacimiento
        {//Propiedad solo léctura
            get
            {
                return (fecha_nac.ToShortDateString().ToString());
            }
        }
    }

    class clsDoctor : clsPersona
    {
        string cod_doctor;
        public string codigoDoctor
        {
            get { return cod_doctor; }
            set { cod_doctor = value; }
        }

        //Metodos
        public clsDoctor() //Metodo constructor
        {
            nombre = "";
            sueldo = 5;
            fecha_nac = Convert.ToDateTime("1990/1/1");
        }
        /*
         Este metodo en la clase Hija es el reemplazo exigido por la clase Base
        Observe que tiene el mismo nombre y Firma (lista / tipo de parametros) del metodo original
         */
        public override void asignarFechaNacimiento(string annio, string mes, string dia)
        {
            TimeSpan diftiempo; //Almacena un rango de tiempo entre dos fechas

            try
            { //Detecta si la fecha tiene el formato esperado

                DateTime fnac = Convert.ToDateTime(annio + "/" + mes + "/" + dia);
                diftiempo = fnac - DateTime.Now;
                //determina si fecha ingresada es al menos 18 años antes de la fecha actual
                if (diftiempo.TotalDays < -365 * 18)
                {
                    fecha_nac = fnac;
                }
                else
                {
                    MessageBox.Show("Fecha de nacimiento debe ser al menos 18 años antes de hoy",
                        "ERROR-Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException e)
            {
                MessageBox.Show("Fecha brindada es incorrecta", "ERROR-Sistema!!", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        //Sobrecarga de métodos:
        public void asignarFechanac(string fecha)
        {
            DateTime fechafin;
            //Función intenta convertir cadena fecha a tipo DateTime en fechafin
            if (DateTime.TryParse(fecha, out fechafin))
            {
                fecha_nac = fechafin;
            }
            else
            {
                MessageBox.Show("Fecha de nacimiento es recibida", "ERROR DE SISTEMA!!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
            //Confirma si datos para agregar un Doctor son correctos
            public bool DatossonCorrectos()
            {
                if (nombre != "")
                    if (sueldo > 0)
                        if (fecha_nac != Convert.ToDateTime("1900/01/01"))
                            return (true); // Los datos recibidos son correctos
                    else
                    MessageBox.Show("aun no se ha asignado fecha de nacimiento");
                    else
                    MessageBox.Show("Sueldo incorrecto");
                    else
                    MessageBox.Show("Nombre aun no asignado");
                return (false);
            }
        }

    class clsVendedor : clsPersona
    {
        //CAMPOS (Propios de clave derivada)
        DateTime fechacontratac;
        //METODOS
        public clsVendedor() //metodo constructor
        {
            fecha_nac = Convert.ToDateTime("1950/01/01");
            fechacontratac = Convert.ToDateTime("2000/01/01");
        }
        //Este metodo en la clase Hija reemplaza al metodo de la clase Base
        //->Observe que tiene el mismo nombre, pero diferente firma (lista de parametros)
        public new void asignarfechanac(DateTime fechanacimiento)
        {
            fecha_nac = fechanacimiento;
        }
        //PROPIEDADES
        public DateTime FechaContrato
        {
            get
            {
                return (fechacontratac);
            }
            set
            {
                this.fechacontratac = value;
            }
        }
    }//fin clase Vendedo
}
    
