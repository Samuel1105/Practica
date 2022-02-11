using System;

namespace Practica
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Cuantas Personas son:");
            int dato;
            dato = int.Parse(Console.ReadLine());
            string[] alumno = new string[dato];
            Persona[] P = new Persona[dato]; ; 
            for (int c = 0; c < dato; c++)
            {
                Console.WriteLine("Ingrese Nombre del Estudiante N° " + (c + 1));
                P[c].Nombre = Console.ReadLine().ToString();
                Console.WriteLine("Ingrese Edad del Estudiante N° " + (c + 1));
                P[c].Edad = int.Parse(Console.ReadLine());

               
            }
            for (int c = 0; c < dato; c++)
            {
                Console.Write(P[c].Nombre);
                Console.Write(" ");
                Console.WriteLine(P[c].Edad);
            }
            

        }
    }
}
