using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_02
{
    public class clsEmpleado
    {
        private string Nombres;
        private string Apellidos;
        private DateTime FechaNacimiento;
        private int edad;

        //Datos laborales
        private DateTime FechaContratación;
        private decimal TasaISSS;
        private decimal TasaRenta;
        private decimal SueldoBase;
        private decimal SueldoFinal;

        //Banderas: indicando estado de registro de datos de cada empleado

        private Boolean DatosCompletos;
        private Boolean DatosLaboralesListos;

        /**
         * PROPIEDADES
         * Procedimiento de propiedad
         */

        public string nombreCompleto
        {
            get
            { return Apellidos + "," + Nombres; }
        }

        public Boolean datosPersonalesAceptados
        {
            get { return DatosCompletos; }
        }

        public Boolean datosLaboralesAceptados
        {
            get { return DatosLaboralesListos; }
        }

        /*
         * METODOS
         */

        public clsEmpleado()
        {
            TasaISSS = 3;
            TasaRenta = 10;
            FechaContratación = DateTime.Now;
            DatosCompletos = false;
            DatosLaboralesListos = false;
        }

        //METODO PARA DEFINIR DATOS PERSONALES
        public void definirDatosPersonales(string nom, string apell1, DateTime fechaNac)
        {
            // Recibe cada dato personal para evaluar si son correctos y asignar a los atributos
            long total_anios; //Diferencia de años entre dos fechas cualquiera
            DatosCompletos = false;


            //Nombre
            nom = nom.Trim();

            if(nom.Length == 0 )
            {
                MessageBox.Show("Falta ingresar Nombres a empleado");
                return;
            }
            else Nombres = nom; // Asigna el parametro recibido al atributo

            //Apellido
            apell1 = apell1.Trim();
            if (apell1.Length == 0)
            {
                MessageBox.Show("Falta ingresar Apellidos a empleado");
                return;
            }
            else Apellidos = apell1; // Asigna el parametro recibido al atributo


            //Verifica si la fecha está entre el rango estipulado
            total_anios = DateTime.Now.Year - fechaNac.Year;

            if(total_anios > 50)
            {
                MessageBox.Show("Empleado debe jubilarse, según código de trabajo de ES", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (total_anios > 0 && total_anios < 18)
            {
                MessageBox.Show("Persona menor de edad, según código de trabajo de ES", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (total_anios < 0)
            {
                MessageBox.Show("Revisa la fecha de nacimiento ingresada", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else 
            {
                FechaNacimiento = fechaNac;
                edad = Convert.ToInt32(total_anios);
            }
            DatosCompletos = true;
        }

        //METODO PARA DEFINIR DATOS LABORALES
        public void DefinirDatosLaborales(DateTime fechacontrato, decimal sueldoinic)
        {
            //Recibe datos laborales de empleado (Fecha contratación y sueldo base)
            long total_anios;
            DateTime fecha_inic18;

            DatosLaboralesListos = false;
            //Evaluando si los datos están incompletos
            if (!(DatosCompletos))
            {
                MessageBox.Show("Datos laborales no aceptados", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("Antes de continuar revise los datos personales", "Información",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;        
            }

            /*
             * Revisa datos laborales recibidos en parametros.
             * Determina si diferencia fecha contrato esta ubicada entre 18 años despues
             * de la fecha nacimiento de empleado(edad min.laboral) y hasta la fecha de hoy
             */
            fecha_inic18 = FechaNacimiento.AddYears(18);
            total_anios = fechacontrato.Year - DateTime.Now.Year;

            if (fechacontrato < fecha_inic18)
            {
                MessageBox.Show("Fecha contrato debe ser posterior al" + fecha_inic18, "Información",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (fechacontrato > DateTime.Now)
            {
                MessageBox.Show("Fecha contrato solo valida entre" + fecha_inic18 + " y hoy" +
                    DateTime.Now.ToString(),
                    "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else SueldoBase = sueldoinic;

            //Datos laborales son correctos y completos
            DatosLaboralesListos = true;

            calcularSueldoNeto();
        }

        //METODO PARA ASIGNAR DESCUENTO
        public void asignarDescuento(decimal isss = 2.50m, decimal renta = 10.50m)
        {
            //Evalua los porcentajes definidos en parametros
            if (isss > 2.5m && isss < 40)
            {
                TasaISSS = isss;
            }
            else
            {
                MessageBox.Show("Porcentaje de ISSS incorrecto, se usará: " + TasaISSS.ToString() + "%", 
                    "Tasa Incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (renta > 10.5m && renta < 40)
            {
                TasaRenta = renta;
            }
            else TasaRenta = 10.5m; // Se asigna un valor predeterminado
        }

        //METODO VER SUELDOS
        public void verSueldos(ref string sueldobase, ref string sueldofinal)
        {
            sueldobase = SueldoBase.ToString();
            sueldofinal = SueldoFinal.ToString();
        }

        //METODO CALCULAR SUELDO NETO
        private void calcularSueldoNeto()
        {
            //Hacer calculos de su propio sueldo Neto
            decimal Desc;
            SueldoFinal = SueldoBase;
            Desc = SueldoBase * (TasaISSS / 100);
            SueldoFinal -= Desc;
            Desc = SueldoBase * (TasaRenta / 100);
            SueldoFinal -= Desc;
        }
    }

}
