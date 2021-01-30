using System;

namespace netnivel2
{
    class Program
    {

        struct Persona
        {
            public string Nombre;
            public string Apellido;
            public int Edad;
        }


        static void Main()
        {
            Persona Martin = new Persona();
            Martin.Nombre = "Martín";
            Martin.Apellido = "Longo";
            Martin.Edad = 30;
            Console.WriteLine(Martin.Nombre);
            Console.WriteLine(Martin.Apellido);
        }
    }
}
