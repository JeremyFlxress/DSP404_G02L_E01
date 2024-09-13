using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;

namespace CajeroWeb.Models
{
    public class Transaccion
    {
        private string sNumeroTarjeta;
        private double fSaldo;
        //Constructor de la clase que solo acepta un parametro de tipo string
        public Transaccion(string tarjeta)
        {
            sNumeroTarjeta = tarjeta;
            fSaldo = 500;
        }
        /*
        Constructor de clase que acepta dos parametros: String y double. 
        Puede haber tantos constructores como se necesiten, pero c/definición debe tener
        una firma (lista y orden de tipos de datos en parametros) diferente
         */
        public Transaccion(string tarjeta, double saldo)
        {
            sNumeroTarjeta = tarjeta;
            fSaldo = saldo;
        }
        //Implementación de métodos get y set para acceder a campos de clase
        public double getSaldo()
        {
            return fSaldo;
        }
        public void setSaldo(double saldo)
        {
            fSaldo = saldo;
        }
        public string getNumeroTarjeta()
        {
            return sNumeroTarjeta;
        }
        public void setNumeroTarjeta(string tarjeta)
        {
            sNumeroTarjeta = tarjeta;
        }
        public void transferenciaNacional(double monto)
        {
            fSaldo = fSaldo - monto;
        }
        public void transferenciaInternacional(double monto)
        {
            fSaldo = fSaldo - monto;
        }
    }
}