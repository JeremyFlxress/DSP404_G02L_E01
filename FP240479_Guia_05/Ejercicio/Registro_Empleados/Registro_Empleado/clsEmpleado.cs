using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class clsEmpleado
{
    // Atributos
    private string Nombres;
    private string Apellidos;
    private DateTime FechaNacimiento;
    private int Edad;
    private DateTime FechaContratacion;
    private decimal TasaIsss;
    private decimal TasaRenta;
    private decimal SueldoBase;
    private decimal SueldoFinal;
    private Boolean DatosCompletos;
    private Boolean DatosLaboralesListos;

    // Propiedades
    public string nombrecompleto
    {
        get { return Apellidos + "," + Nombres; }
    }

    public Boolean datospersonales_aceptados
    {
        get { return DatosCompletos; }
    }

    public Boolean datoslaborales_aceptados
    {
        get { return DatosLaboralesListos; }
    }

    // Método Constructor
    public clsEmpleado()
    {
        TasaIsss = 3;
        TasaRenta = 10;
        FechaContratacion = DateTime.Now;
        DatosCompletos = false;
        DatosLaboralesListos = false;
    }

    // Método DefinirDatosPersonales
    public void DefinirDatosPersonales(string nom, string apel1, DateTime fechanac)
    {
        long totalannos;
        DatosCompletos = false;
        nom = nom.Trim();

        if (nom.Length == 0)
        {
            MessageBox.Show("Falta ingresar nombres a empleados");
            return;
        }
        else Nombres = nom;

        apel1 = apel1.Trim();
        if (apel1.Length == 0)
        {
            MessageBox.Show("Falta ingresar apellidos de empleado");
            return;
        }
        else
            Apellidos = apel1;

        totalannos = DateTime.Now.Year - fechanac.Year;
        if (totalannos > 50)
        {
            MessageBox.Show("ERROR: Empleado debe jubilarse, según código de trabajo de ES");
            return;
        }
        else if (totalannos > 0 && totalannos < 18)
        {
            MessageBox.Show("ERROR: Persona menor de edad según código trabajo de ES");
            return;
        }
        else if (totalannos < 0)
        {
            MessageBox.Show("ERROR: Revise fecha de nacimiento ingresada");
            return;
        }
        else
        {
            FechaNacimiento = fechanac;
            Edad = Convert.ToInt32(totalannos);
        }
        DatosCompletos = true;
    }

    // Método DefinirDatosLaborales
    public void DefinirDatosLaborales(DateTime fechacontrato, decimal sueldoinic)
    {
        long totalannos;
        DateTime fechainic18;
        DatosLaboralesListos = false;

        if (!(DatosCompletos))
        {
            MessageBox.Show("Datos laborales no aceptados", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            MessageBox.Show("Antes de continuar, revise los datos personales",
                "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        fechainic18 = FechaNacimiento.AddYears(18);
        totalannos = fechacontrato.Year - DateTime.Now.Year;

        if (fechacontrato < fechainic18)
        {
            MessageBox.Show("Fecha contrato debe ser posterior al " + fechainic18);
            return;
        }
        else if (fechacontrato > DateTime.Now)
        {
            MessageBox.Show("Fecha contrato válida solo entre " + fechainic18 + " y hoy " +
               DateTime.Now.ToString());
            return;
        }
        else
        {
            SueldoBase = sueldoinic;
        }

        DatosLaboralesListos = true;
        CalcularSueldoNeto();
    }

    // Método AsignarDescuentos
    public void AsignarDescuentos(decimal isss = 2.50m, decimal renta = 10.50m)
    {
        if (isss > 2.50m && isss < 40)
        {
            TasaIsss = isss;
        }
        else
        {
            MessageBox.Show("Porcentaje de ISSS incorrecto, se usará " + TasaIsss.ToString() + " %");
        }

        if (renta > 10.5m && renta < 40)
        {
            TasaRenta = renta;
        }
        else
        {
            TasaRenta = 10.5m;
        }
    }

    // Método VerSueldos
    public void VerSueldos(ref string sb, ref string sf)
    {
        sb = SueldoBase.ToString();
        sf = SueldoFinal.ToString();
    }

    // Método CalcularSueldoNeto
    private void CalcularSueldoNeto()
    {
        decimal Desc;
        SueldoFinal = SueldoBase;
        Desc = SueldoBase * (TasaIsss / 100);
        SueldoFinal -= Desc;
        Desc = SueldoBase * (TasaRenta / 100);
        SueldoFinal -= Desc;
    }
}
