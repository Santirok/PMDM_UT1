using System;
namespace CuentaBancaria
{
    public class ApunteBancario{
        //Prpopiedades autoimplementadas de la clase, solo permiten obtener sus valores

        //propiedad que almacen ala cantidad del apunte bancario
        public decimal Cantidad { get; }
        //propiedad que almacena la fecha del apunte bancario
        public DateTime Fecha { get; }
        //propiedad que almacena el concepto del apunte bancario
        public string Concepto { get; }
        public ApunteBancario(decimal cantidad, DateTime fecha, string concepto){
            //Inicializa los campos de los valores de los parámetros formales. 
            this.Cantidad = cantidad;
            this.Fecha = fecha;
            this.Concepto = concepto;
        }
    }
}

