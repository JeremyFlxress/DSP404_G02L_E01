using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complemetario_01
{
    public class clsCuenta
    {
        private static int contador = 1000001;
        private string numeroCuenta;
        private string dui;
        private double saldo;
        private double interesAnual;

        public string NumeroCuenta
        {
            get { return numeroCuenta; }
        }

        public string DUI
        {
            get { return dui; }
            set { dui = value; }
        }

        public double Saldo
        {
            get { return saldo; }
        }

        public double InteresAnual
        {
            get { return interesAnual; }
            set
            {
                if (value >= 10 && value <= 22.3)
                {
                    interesAnual = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("El interés anual debe estar entre 10% y 22.3%.");
                }
            }
        }

        // Constructor
        public clsCuenta(string dui, double saldoInicial, double interesAnual)
        {
            this.dui = dui;
            this.saldo = saldoInicial;
            this.InteresAnual = interesAnual;
            this.numeroCuenta = GenerarNumeroCuenta();
        }

        // Generar un número de cuenta único
        private string GenerarNumeroCuenta()
        {
            string fecha = DateTime.Now.ToString("ddMMyyyy");
            string numCuenta = $"{fecha}-{contador}";
            contador++;
            return numCuenta;
        }

        // Actualizar el saldo aplicando el interés diario
        public void ActualizarSaldo()
        {
            double interesDiario = (interesAnual / 100) / 365;
            saldo += saldo * interesDiario;
        }

        // Ingresar dinero en la cuenta
        public void Ingresar(double cantidad)
        {
            if (cantidad > 0)
            {
                saldo += cantidad;
            }
            else
            {
                throw new ArgumentException("La cantidad a ingresar debe ser mayor a cero.");
            }
        }

        // Retirar dinero de la cuenta
        public void Retirar(double cantidad)
        {
            if (cantidad > 0 && cantidad <= saldo)
            {
                saldo -= cantidad;
            }
            else
            {
                throw new ArgumentException("La cantidad a retirar debe ser mayor a cero y no exceder el saldo disponible.");
            }
        }

        // Mostrar todos los datos de la cuenta
        public string MostrarDatos()
        {
            return $"Número de Cuenta: {numeroCuenta}\nDUI: {dui}\nSaldo: {saldo:C}\nInterés Anual: {interesAnual}%";
        }
    }
}
