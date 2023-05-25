using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023_05_24_Tarea1.Entities
{
    public class Persona
    {
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }

        public string Llenado()
        {
            try
            {
                Console.WriteLine("Dime tu nombre:");
                this.Nombre = Console.ReadLine();
                Console.WriteLine("Dime tu Telefono:");
                this.Telefono = Console.ReadLine();
                Console.WriteLine("Dime tu Correo:");
                this.Correo = Console.ReadLine();
                string datos = $"Nombre: {this.Nombre}\nTelefono: {this.Telefono}\nCorreo: {this.Correo}";
                return datos;
            }
            catch (Exception x)
            {

                throw new Exception ("Opps Ocurrio un error"+x.Message);
            }
        }

    }
}
