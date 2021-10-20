//
//Program.cs
//Esta solución contendrá la definición de una cuenta bancaria. La clase CuentaBancaria representa una cuenta bancaria.
//

// Utiliza un espacio de nombres llamado System.
using System;
using System.Collections.Generic;

//Define un espacio de nombres llamado CuentaBancaria.
namespace CuentaBancaria{
    //Declara la clase principal de la aplicación.
    class Program{
        //Define el método principal de la aplicación.
        static void Main(string[] args) { 
            //Instancia la clase CuentaBancaria
            var cuenta = new CuentaBancaria("Juan García López", 1000);

            //Muestra la información de la cuenta
            Console.WriteLine($"\nLa cuenta {cuenta.Numero} creada por " + $"{cuenta.Cliente} " 
                + $"con un saldo inicial de { cuenta.Saldo}.");
          
            //Reliza un reintegro
            cuenta.Reintegro(500, DateTime.Now, "Pago del alquiler");
            Console.WriteLine($"\nSaldo de {cuenta.Saldo} tras un reintegro de 500");

            //Realiza un ingreso
            cuenta.Ingreso(100, DateTime.Now, "Ingreso nómina");
            Console.WriteLine($"\nSaldo de {cuenta.Saldo} tras un ingreso de 100");

            //Prueba a hacer un saldo negativo
            try { 
                var cuentaIncorrecta = new CuentaBancaria("Incorrecto.", -55);
            }
            catch (ArgumentOutOfRangeException e) {  
                //Muestra en la consola el mensaje "Error al crear una cuenta con saldo negativo."
                Console.WriteLine("\nError al crear una cuenta con saldo negativo.");
                Console.WriteLine(e.ToString());
            }
            try {
                //Muestra en la consola el mensaje "Intento de descubierto"
                cuenta.Reintegro(750, DateTime.Now, "Intento de  descubierto");
            }
            catch (InvalidOperationException e) {
                //Muestra en la consola el mensaje "Error al intentar un descubierto."
                Console.WriteLine("\nError al intentar un descubierto.");
                Console.WriteLine(e.ToString());
            }
            //Muestra en la consola el mensaje "Histórico de la cuenta" y da la opción de finalizar pulsando una tecla
            Console.WriteLine("\nHistórico de la cuenta:");
            Console.WriteLine(cuenta.ObtenerHistoricoCuenta());
            Console.Write("\nPulsa una tecla para finalizar...");
            Console.ReadLine();
        }
    }
}

