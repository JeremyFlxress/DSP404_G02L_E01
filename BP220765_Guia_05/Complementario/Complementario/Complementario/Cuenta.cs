namespace Complementario
{
    public class Cuenta
    {
        // Atributos
        private static int contador = 1000001; // Contador para el número correlativo
        private string numeroCuenta;
        private string duiCliente;
        private double saldoActual;
        private double interesAnual;

        // Propiedades
        public string NumeroCuenta
        {
            get { return numeroCuenta; }
        }

        public string DUI
        {
            get { return duiCliente; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    duiCliente = value;
                else
                    throw new ArgumentException("DUI no puede estar vacío.");
            }
        }

        public double SaldoActual
        {
            get { return saldoActual; }
            set
            {
                if (value >= 0)
                    saldoActual = value;
                else
                    throw new ArgumentException("El saldo no puede ser negativo.");
            }
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
        public Cuenta(string dui, double saldoInicial, double interes)
        {
            this.duiCliente = dui;
            this.saldoActual = saldoInicial;
            this.interesAnual = interes;
            this.numeroCuenta = GenerarNumeroCuenta();
        }

        // Método para generar el número de cuenta
        private string GenerarNumeroCuenta()
        {
            string fecha = DateTime.Now.ToString("ddMMyyyy");
            string cuenta = $"{fecha}-{contador}";
            contador++;
            return cuenta;
        }

        // Métodos
        public void ActualizarSaldo()
        {
            double interesDiario = interesAnual / 365 / 100;
            saldoActual += saldoActual * interesDiario;
        }

        public void Ingresar(double cantidad)
        {
            if (cantidad > 0)
                saldoActual += cantidad;
            else
                throw new ArgumentException("La cantidad a ingresar debe ser mayor a cero.");
        }

        public void Retirar(double cantidad)
        {
            if (cantidad > 0 && cantidad <= saldoActual)
                saldoActual -= cantidad;
            else
                throw new ArgumentException("La cantidad a retirar no es válida o excede el saldo disponible.");
        }

        public void MostrarDatos()
        {
            Console.WriteLine($"Número de Cuenta: {numeroCuenta}");
            Console.WriteLine($"DUI Cliente: {duiCliente}");
            Console.WriteLine($"Saldo Actual: {saldoActual:C}");
            Console.WriteLine($"Interés Anual: {interesAnual}%");
        }
    }
}

