//SAS
//genbeta.com/desarrollo/como-calcular-la-distancia-entre-dos-puntos-geograficos-en-c-formula-de-haversine
//

using System;


namespace CoordenadasGeograficas
{
    public class GeoPunto
    { 

        //Declaración de los campos de la clase
        public float longitud;
        public float latitud;

        //Objeto público y est´tatico utilizado para indicar que un lugar no tiene posición asignada
        public static GeoPunto SIN_POSICION;

        //Almacenar y devolver valores de los campos longitud y latituda
        public float Longitud
        {
            get
            {
                return longitud;
            }
            set
            {
                longitud = value;
            }
        }
        public float Latitud
        {
            get
            {
                return latitud;
            }
            set
            {
                latitud = value;
            }
        }

        public float distancia;

        //Constructor para la clase sin parámetros
        public GeoPunto()
        {
            Longitud = 0;
            Latitud = 0;
        }
        //Constructor con parámetros
        public GeoPunto(float longitud, float latitud)
        {
            this.Longitud = longitud;
            this.Latitud = latitud;
        }
        //Modificación de la implementación del método ToString
        public override string ToString()
        {
            return ("Longitud = " + longitud + "Latitud = " + latitud);
        }

        public float Haversine(GeoPunto punto1) {
            double r = 6371000; // en metros
            double incremento_latitud = (Math.PI /180) * (latitud - punto1.latitud);
            double incremento_longitud = (Math.PI /180) * (longitud - punto1.longitud);
            double a = Math.Pow(Math.Sin(incremento_latitud / 2), 2) + Math.Cos(punto1.latitud) + Math.Cos(latitud) +
                (Math.Pow(Math.Sin((incremento_longitud/ 2)), 2));
            double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
            double distancia = r * c;
            return (float)distancia;
        }

        
    }
}
