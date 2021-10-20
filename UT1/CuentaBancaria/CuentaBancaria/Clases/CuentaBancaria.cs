//
//CuentaBancaria.cs
//Esta solución contendrá la definición de una cuenta bancaria. La clase CuentaBancaria representa una cuenta bancaria.
//

//Utiliza un espacio de nombres llamado System.
using System;
using System.Collections.Generic;

//Define un espacio de nombres llamado CuentaBancaria
namespace CuentaBancaria {
    //Declara la clase principal de la aplicación
    public class CuentaBancaria{

        //Campo que almacena el valor a partir del cual se genera el número de cuenta
        private static int semillaNumeroCuenta = 1234567890;

        //Propiedades autoimplementadas de la clase

        //Propiedad que almacena el número de cuenta bancaria
        public string Numero { get; }

        //Propiedad que almacena el nombre del cliente de cuenta bancarai
        public string Cliente { get; set; }

        //Propiedad que almacena el saldo de cuenta bancaria
        public decimal Saldo {
            get {
                //Inicialia el saldo a 0
                decimal saldo = 0;
                //PARACADA apunte bancario
                foreach (var elemento in ApuntesCuenta){
                    saldo += elemento.Cantidad;
                }
                //Devuelve el saldo final
                return saldo;
            }
        }


        //Instancia la clase ApunteBancario
        private List<ApunteBancario> ApuntesCuenta = new List<ApunteBancario>();

        //Constructor
        public CuentaBancaria(string nombre, decimal saldoInicial){
            //Inicializa las porpiedades de la clase
            this.Numero = semillaNumeroCuenta.ToString();
            semillaNumeroCuenta++;
            this.Cliente = nombre;
            Ingreso(saldoInicial, DateTime.Now, "Saldo inicial");
        }

        //Método que permite realizar un ingreso
        public void Ingreso(decimal cantidad, DateTime fecha, string concepto) {
            //Comprueba si la cantidad es negativa o 0
            if (cantidad <= 0) {
                //Lanza la excepción correspondiente
                throw new ArgumentOutOfRangeException(nameof(cantidad),
                "La cantidad del ingreso debe ser positiva");
            }
            //Instancia la clase ApunteBancario para el dpósito
            var deposito = new ApunteBancario(cantidad, fecha, concepto);
            ApuntesCuenta.Add(deposito);
        }

        public void Reintegro(decimal cantidad, DateTime fecha, string
         concepto){
            if (cantidad <= 0) { 
                throw new ArgumentOutOfRangeException(nameof(cantidad),
                "La cantidad debe ser positiva");
            }
            if (Saldo - cantidad < 0) { 
                throw new InvalidOperationException("No existe suficiente saldo para el reintegro");
            }
            var reintegro = new ApunteBancario(-cantidad, fecha, concepto);
            ApuntesCuenta.Add(reintegro);
        }

        //Método que permite obtener el histórico de la cuenta
        public string ObtenerHistoricoCuenta() {
            //Instancia una clase String builder
            //
            var informe = new System.Text.StringBuilder();

            //Añade la línea como cabecera del informe
            informe.AppendLine("Fecha\t\tCantidad\tApunte");
            //Para cada uno delos apuntes de la cuenta...
            foreach (var item in ApuntesCuenta)
            {
                //...añade una línea al informe
                informe.AppendLine($"{item.Fecha.ToShortDateString()}\t{ item.Cantidad} " +
             $"\t\t{item.Concepto}");
            }
            //Devuelve el informe convertido en un string
            return informe.ToString();
        }
    }
}