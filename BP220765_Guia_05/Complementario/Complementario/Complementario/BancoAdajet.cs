using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complementario
{
    public class BancoAdajet
    {
        private List<Cuenta> cuentas = new List<Cuenta>();

        public void CrearCuenta()
        {
            try
            {
                Console.Write("Ingrese el DUI del cliente: ");
                string dui = Console.ReadLine();

                Console.Write("Ingrese el saldo inicial: ");
                double saldo = Convert.ToDouble(Console.ReadLine());

                Console.Write("Ingrese el interés anual (entre 10% - 22.3%): ");
                double interes = Convert.ToDouble(Console.ReadLine());

                Cuenta nuevaCuenta = new Cuenta(dui, saldo, interes);
                cuentas.Add(nuevaCuenta);
                Console.WriteLine("Cuenta creada exitosamente.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        public void MostrarCuentas()
        {
            if (cuentas.Count == 0)
            {
                Console.WriteLine("No hay cuentas registradas.");
                return;
            }

            foreach (var cuenta in cuentas)
            {
                cuenta.MostrarDatos();
                Console.WriteLine("-----------------------------------");
            }
        }

        public void IngresarEnCuenta()
        {
            Console.Write("Ingrese el número de cuenta: ");
            string numeroCuenta = Console.ReadLine();

            var cuenta = cuentas.Find(c => c.NumeroCuenta == numeroCuenta);
            if (cuenta != null)
            {
                Console.Write("Ingrese la cantidad a ingresar: ");
                double cantidad = Convert.ToDouble(Console.ReadLine());
                cuenta.Ingresar(cantidad);
                Console.WriteLine("Ingreso realizado con éxito.");
            }
            else
            {
                Console.WriteLine("Cuenta no encontrada.");
            }
        }

        public void RetirarDeCuenta()
        {
            Console.Write("Ingrese el número de cuenta: ");
            string numeroCuenta = Console.ReadLine();

            var cuenta = cuentas.Find(c => c.NumeroCuenta == numeroCuenta);
            if (cuenta != null)
            {
                Console.Write("Ingrese la cantidad a retirar: ");
                double cantidad = Convert.ToDouble(Console.ReadLine());
                cuenta.Retirar(cantidad);
                Console.WriteLine("Retiro realizado con éxito.");
            }
            else
            {
                Console.WriteLine("Cuenta no encontrada.");
            }
        }

        public void EliminarCuenta()
        {
            Console.Write("Ingrese el número de cuenta: ");
            string numeroCuenta = Console.ReadLine();

            var cuenta = cuentas.Find(c => c.NumeroCuenta == numeroCuenta);
            if (cuenta != null)
            {
                cuentas.Remove(cuenta);
                Console.WriteLine("Cuenta eliminada con éxito.");
            }
            else
            {
                Console.WriteLine("Cuenta no encontrada.");
            }
        }

        public static void Main(string[] args)
        {
            BancoAdajet banco = new BancoAdajet();
            int opcion;

            do
            {
                Console.WriteLine("\n--- Banco Adajet ---");
                Console.WriteLine("1. Crear Cuenta");
                Console.WriteLine("2. Mostrar Cuentas");
                Console.WriteLine("3. Ingresar en Cuenta");
                Console.WriteLine("4. Retirar de Cuenta");
                Console.WriteLine("5. Eliminar Cuenta");
                Console.WriteLine("6. Salir");
                Console.Write("Seleccione una opción: ");
                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        banco.CrearCuenta();
                        break;
                    case 2:
                        banco.MostrarCuentas();
                        break;
                    case 3:
                        banco.IngresarEnCuenta();
                        break;
                    case 4:
                        banco.RetirarDeCuenta();
                        break;
                    case 5:
                        banco.EliminarCuenta();
                        break;
                    case 6:
                        Console.WriteLine("Saliendo...");
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            } while (opcion != 6);
        }
    }
}

