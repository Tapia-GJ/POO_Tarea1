using _2023_05_24_Tarea1.Entities;
using _2023_05_24_Tarea1.Services;
using System;

namespace _2023_05_24_Tarea1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonaServices services = new PersonaServices();
            Console.WriteLine(services.Menu()); 
        }
    }
}
