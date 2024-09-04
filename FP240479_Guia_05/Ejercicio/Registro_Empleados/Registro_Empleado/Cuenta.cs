using System;

public class Cuenta
{
    // Atributos
    private string numeroCuenta;
    private string duiCliente;
    private double saldoActual;
    private double interesAnual;

    // Propiedades
    public string NumeroCuenta
    {
        get { return numeroCuenta; }
        private set { numeroCuenta = value; }
    }

    public string DUICliente
    {
        get { return duiCliente; }
        set
        {
            if (value.Length == 10) // Esto valida el DUI de 9 digitos
                duiCliente = value;
            else
                throw new ArgumentException("DUI debe tener el formato correcto.");
        }
    }

    public double SaldoActual
    {
        get { return saldoActual; }
        private set { saldoActual = value; }
    }

    public double InteresAnual
    {
        get { return interesAnual; }
        set
        {
            if (value >= 10 && value <= 22.3)
                interesAnual = value;
            else
                throw new ArgumentException("El interés anual debe estar entre 10% y 22.3%.");
        }
    }

    // Constructor
    public Cuenta(string dui, double interes)
    {
        DUICliente = dui;
        InteresAnual = interes;
        saldoActual = 0;
        GenerarNumeroCuenta();
    }

    // Métodos
    private void GenerarNumeroCuenta()
    {
        string fecha = DateTime.Now.ToString("ddMMyyyy");
        Random rnd = new Random();
        int secuencia = rnd.Next(1000001, 9999999);
        NumeroCuenta = $"{fecha}-{secuencia.ToString("000000")}";
    }

    public void ActualizarSaldo()
    {
        double interesDiario = InteresAnual / 365 / 100;
        SaldoActual += SaldoActual * interesDiario;
    }

    public void Ingresar(double cantidad)
    {
        if (cantidad > 0)
            SaldoActual += cantidad;
        else
            throw new ArgumentException("La cantidad a ingresar debe ser positiva.");
    }

    public void Retirar(double cantidad)
    {
        if (cantidad > 0)
        {
            if (SaldoActual >= cantidad)
                SaldoActual -= cantidad;
            else
                throw new InvalidOperationException("Fondos insuficientes.");
        }
        else
            throw new ArgumentException("La cantidad a retirar debe ser positiva.");
    }

    public string MostrarDatos()
    {
        return $"Cuenta: {NumeroCuenta}, DUI: {DUICliente}, Saldo: {SaldoActual:C}, Interés Anual: {InteresAnual}%";
    }
}
