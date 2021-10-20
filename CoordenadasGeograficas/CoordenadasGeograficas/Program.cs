using System;

namespace CoordenadasGeograficas
{
    class MainClass
    {
        public static void Main(string[] args)
        { 
            //Instancia de la clase GeoPunto, albacete
            GeoPunto albacete = new GeoPunto(-1.85f, 38.99f);

            //Instanciar villarrobledo (que aquí así pero da igual como arriba o como abajo) 
            GeoPunto villarrobledo = new GeoPunto { 
                Longitud = -2.60f,
                Latitud= 39.26f};
			

            //Instancia de la clase lugar, IES Virrey MOrcillo

            //Muestre la información de los dos puntos geográficos
            Console.WriteLine("\nPUNTOS GEOGRÁFICOS\n");
            Console.WriteLine("Albacete:\t{0}", albacete.ToString());
            Console.WriteLine("Villarrobledo:\t{0}",villarrobledo.ToString());
            Console.WriteLine("Distancia:\t{0:0.00} kilometros",
                albacete.Haversine(villarrobledo)/1000);


            //Muestra la información del lugar

            //Muestra la distancia

            //Espera a que pulse una tecla para salir
            Console.WriteLine("Pulsa tecla para salir");
            Console.ReadKey();

             
        }
    }
}
