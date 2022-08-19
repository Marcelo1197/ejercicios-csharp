using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosCsharp
{
    internal class Sesion3
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente(nombre: "Marcelo", email: "marcelo@gmail.com", telefono: 38383829, direccion: "Cordova 222", esNuevo: true);
            cliente.mostrarDatos();
        }

        public class Cliente
        {
            private string Nombre { get; set; }
            private int Telefono { get; set; }
            private string Direccion { get; set; }
            private string Email { get; set; }
            private Boolean EsNuevo { get; set; }

            public Cliente (string nombre, int telefono, string direccion, string email, Boolean esNuevo)
            {
                this.Nombre = nombre;
                this.Telefono = telefono;
                this.Direccion = direccion;
                this.Email = email;
                this.EsNuevo = esNuevo;
            }

            public void mostrarDatos()
            {
                Console.WriteLine($"Datos del cliente\nNombre: {this.Nombre}\nTelefono: {this.Telefono}\nDireccion: {this.Direccion}\nEmail: {this.Email}\n¿Es un cliente nuevo? { (this.EsNuevo ? "SI" : "NO") }");
            }
        }

    }


}
