using System;

namespace Practica
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Cuantas Personas son:");
            int dato;
            int cont = 0;
            string nombre;
            int edad;
            dato = int.Parse(Console.ReadLine());
            Persona[] Pers = new Persona[dato];  
            for (int c = 0; c < dato; c++)
            {
                Console.WriteLine("Ingrese Nombre del Estudiante N° " + (c + 1));
                nombre = Console.ReadLine().ToString();
                Console.WriteLine("Ingrese Edad del Estudiante N° " + (c + 1));
                edad = int.Parse(Console.ReadLine());
                
                Pers[cont].Tnombre = nombre;
                Pers[cont].Tedad = edad;
                cont++;
               
            }
            for (int c = 0; c < dato; c++)
            {
                Console.Write(Pers[c].Tnombre);
                Console.Write(" ");
                Console.WriteLine(Pers[c].Tedad);
            }
            
            void burbuja()
            {
                Random R = new Random();
                Console.WriteLine("Cantidad de Numeros");
                int dato = int.Parse(Console.ReadLine());
                int[] vector = new int[dato];
                int aux;
                for (int c = 0; c < dato; c++)
                {
                    vector[c] = R.Next(1, 25);
                    Console.Write(vector[c] + " ");
                }

                for (int i = dato - 1; i > 0; i--)
                {
                    for (int j = 0; j < i; j++)
                    {
                        if (vector[j] > vector[j + 1])
                        {
                            aux = vector[j + 1];
                            vector[j + 1] = vector[j];
                            vector[j] = aux;

                        }
                    }
                }
                Console.WriteLine(" ");
                for (int c = 0; c < dato; c++)
                {
                    Console.Write(vector[c] + " ");
                }

            }

        }
    }
}
