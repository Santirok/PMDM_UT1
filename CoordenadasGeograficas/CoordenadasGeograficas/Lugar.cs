using System;
//Declaración del espacio de nombres
namespace CoordenadasGeograficas
{
    //Declaración de la clase lugar
    public class Lugar
    {
        //Declaración de los campos de la clase
        private String nombre;
        private String direccion;
        private GeoPunto posicion;
        private String foto;
        private String telefono;
        private String url;
        private String comentario;
        private int valoracion;

        //Constructor para la clase con parámetros
        public Lugar(string nombre, string direccion, float longitud, float latitud, string foto, string telefono, string url, string comentario, int valoracion)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            posicion = new GeoPunto(longitud, latitud);
            this.foto = foto;
            this.telefono = telefono;
            this.url = url;
            this.comentario = comentario;
            this.valoracion = valoracion;
        }
        public override string ToString()
        {
            return ("nombre = " + nombre + "Dirección = " + direccion + "Posición = " + posicion + "Foto = " + foto + "Teléfono = " + telefono +
                "Url = " + url + "Comentario = " + comentario + "Valoración = " + valoracion);
        }
    }
}
