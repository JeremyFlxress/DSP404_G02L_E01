using System;
using System.Collections.Generic;
using System.Windows.Forms;

public class clsPlanilla
{
    private int Estado;
    private String Empresa;
    private DateTime FechaPlanilla;
    private Dictionary<int, clsEmpleado> Listaempleados = new Dictionary<int, clsEmpleado>();
    private int TotalEmpleados;

    public clsPlanilla()
    {
        Estado = 1;
        Empresa = "";
        FechaPlanilla = DateTime.Now;
        TotalEmpleados = 0;
    }

    public void AbrirPlanilla(DateTime fechaInicio, string nombreempresa = "(Sin nombre)")
    {
        nombreempresa = nombreempresa.Trim();
        switch (Estado)
        {
            case 1:
                FechaPlanilla = fechaInicio;
                if (nombreempresa.Length > 0) Empresa = nombreempresa;
                Estado = 2;
                MessageBox.Show("Planilla Abierta, inicie registro empleados",
                    "Planilla de " + Empresa + ", APERTURA: " + FechaPlanilla.ToString());
                break;
            case 2:
                MessageBox.Show("Planilla ya está abierta desde el: " + FechaPlanilla.ToString(),
                   "Planilla de " + Empresa);
                break;
            case 3:
                MessageBox.Show("Planilla creada el " + FechaPlanilla.ToString() +
                   " ya se cerró", "Planilla de " + Empresa);
                break;
        }
    }

    public void RecibirEmpleado(clsEmpleado nuevoEmpleado)
    {
        if (Estado == 2)
        {
            if (nuevoEmpleado.datospersonales_aceptados == false)
            {
                MessageBox.Show("Error, datos personales están incompletos",
                   "Control planilla");
                return;
            }
            if (nuevoEmpleado.datoslaborales_aceptados == false)
            {
                MessageBox.Show("Error, datos laborales están incompletos",
                   "Control planilla");
                return;
            }
            TotalEmpleados += 1;
            Listaempleados.Add(TotalEmpleados, nuevoEmpleado);
        }
        else
        {
            MessageBox.Show("Planilla aún no está abierta", "Planilla de " + Empresa);
            return;
        }
    }

    public void GenerarListado(ref DataGridView cuadro)
    {
        int i = 1;
        string sb = "0";
        string sn = "0";
        switch (Estado)
        {
            case 1:
                MessageBox.Show("Planilla aún no ha sido abierta", "Planilla " + Empresa);
                return;
            case 2:
                if (TotalEmpleados == 0)
                {
                    MessageBox.Show("Planilla no tiene aún empleados registrados",
                       "Planilla de " + Empresa);
                    return;
                }
                Estado = 3;
                MessageBox.Show("Planilla cerrada con " + TotalEmpleados + " empleados",
                   "Planilla de " + Empresa);
                MessageBox.Show("Planilla abierta el " + FechaPlanilla.ToString() + " se muestra ahora!!",
                   "Planilla de " + Empresa);
                break;
        }

        cuadro.Rows.Clear();
        cuadro.Columns.Clear();
        cuadro.Columns.Add("id", "num");
        cuadro.Columns.Add("nom", "nombre completo");
        cuadro.Columns.Add("sb", "sueldo base");
        cuadro.Columns.Add("sf", "sueldo neto final");

        cuadro.RowsDefaultCellStyle.BackColor = System.Drawing.Color.Bisque;
        cuadro.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.Beige;

        foreach (var result in Listaempleados)
        {
            cuadro.Rows.Add();
            cuadro.Rows[i - 1].Cells[0].Value = result.Key;
            cuadro.Rows[i - 1].Cells[1].Value = result.Value.nombrecompleto;
            result.Value.VerSueldos(ref sb, ref sn);
            cuadro.Rows[i - 1].Cells[2].Value = sb;
            cuadro.Rows[i - 1].Cells[3].Value = sn;
            i++;
        }
        MessageBox.Show("Planilla de pago final completa generada en pantalla!!");
    }

    public string TotaldeEmpleado
    {
        get { return TotalEmpleados.ToString(); }
    }

    // Ejercicio Complementario: Método para generar archivo de texto plano
    public void GenerarArchivoTexto(string nombreArchivo)
    {
        if (Estado != 3) // Asegura que la planilla esté cerrada y lista
        {
            MessageBox.Show("Planilla no ha sido generada aún.", "Error");
            return;
        }

        using (System.IO.StreamWriter file = new System.IO.StreamWriter(nombreArchivo))
        {
            foreach (var empleado in Listaempleados)
            {
                string sb = "0";
                string sn = "0";
                empleado.Value.VerSueldos(ref sb, ref sn);
                file.WriteLine($"ID: {empleado.Key}, Nombre: {empleado.Value.nombrecompleto}, Sueldo Base: {sb}, Sueldo Neto: {sn}");
            }
        }
        MessageBox.Show("Archivo de texto generado exitosamente.");
    }
}
