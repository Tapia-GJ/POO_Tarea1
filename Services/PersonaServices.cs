using _2023_05_24_Tarea1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _2023_05_24_Tarea1.Services
{
    public class PersonaServices
    {

        public double PedirNumeros()
        {
            try
            {
                double resultado = 0;
                Console.WriteLine("Dame el precio de 5 articulos");
                for (int i = 0; i < 5; i++)
                {
                    double numero = int.Parse(Console.ReadLine());
                    resultado += numero;
                }
                return resultado;
            }
            catch (Exception x)
            {

                throw new Exception("Opps Ocurrio un error" + x.Message);
            }
        }
        public double Menu()
        {
            try
            {
                Persona persona1 = new Persona();
                string datospersona = persona1.Llenado();
                PersonaServices services = new PersonaServices();
                double resultado = services.PedirNumeros();
                Console.WriteLine(datospersona);
                if (resultado < 5000)
                {
                    Console.WriteLine("Tu compra fue de: ");
                    return resultado;
                }
                else if (resultado >= 5000 && resultado < 8000)
                {
                    Console.WriteLine($"Tu compra es de: {resultado}");
                    resultado = resultado - (resultado * .10);
                    Console.WriteLine("Tu descuento es del 10% :D");
                    Console.WriteLine("El total de tu compra con descuento es: ");
                    return resultado;
                }
                else if (resultado >= 8000 && resultado < 10000)
                {
                    Console.WriteLine("Te regalamos 3 meses sin intereses");
                    return services.MesesSinIntereses(resultado, 1);
                }
                else
                {
                    Console.WriteLine($"Tienes la opcion de 3 meses o 6 meses sin intereses");
                    Console.WriteLine("Para 3 meses presiona: 1");
                    Console.WriteLine("Para 6 meses presiona: 2");
                    int meses = int.Parse(Console.ReadLine());
                    return services.MesesSinIntereses(resultado, meses);
                }
            }
            catch (Exception x)
            {

                throw new Exception("Opps Ocurrio un error" + x.Message);
            }
        }
        private double MesesSinIntereses(double resultado, int meses)
        {
            try
            {
                if (meses == 1)
                {
                    Console.WriteLine($"El total de tu compra es: {resultado}");
                    Console.WriteLine("Esto es lo que pagaras cada mes por 3 meses: ");
                    resultado = resultado / 3;
                    return resultado;
                }
                else if (meses == 2)
                {
                    Console.WriteLine($"El total de tu compra es: {resultado}");
                    Console.WriteLine("Esto es lo que pagaras cada mes por 6 meses: ");
                    resultado = resultado / 6;
                    return resultado;
                }
                return 0;
            }
            catch (Exception x)
            {

                throw new Exception("Opps Ocurrio un error" + x.Message);
            }
        }

    }
}
