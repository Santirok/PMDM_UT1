using System;
namespace CoordenadasGeograficas
{
    public class Lugar
    {
        //Declaración de los campos de la clase
        public String nombre;
        public String direccion;
        public GeoPunto posicion;
        public String foto;
        public String telefono;
        public String url;
        public String comentario;
        public int valoracion;

        //Constructor para la clase con parámetros
        public Lugar(string nombre, string direccion, GeoPunto posicion, string foto, string telefono, string url, string comentario, int valoracion)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            this.posicion = posicion;
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
