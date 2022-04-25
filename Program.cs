// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
/*Alumno Bernal Dominguez Jennifer
  Grupo: 4 B BIS
  Materia: Estructura de datos 
  Docente: Cleotilde Tenorio Hernandez
  Tema: Remedial */

  using System;
namespace VectoresCalificaciones
{
    class Program
    {

        static void Main(string[] args)
        {
            //String es el arreglo con los nombres de los alumnos y int es el de las calificaciones10
            Console.Clear();
            string[] alumnos = new string[] {"Carlos","Andrea","Pedro","Maria","Jose","Sofia","Diego","Erika","Pablo","Karla"};
            int[] calif = new int[10];
            int x=3, y=2;

            Console.SetCursorPosition(x,y);
            Console.WriteLine("REGISTRO DE CALIFICACIONES");
            Console.SetCursorPosition(x,y+2);
            Console.WriteLine("Escribir las calificaciones de cada alumno");
            y= 5;
            for(int i=0; i<10; i++){
                Console.SetCursorPosition(x,y); //3,5
                Console.WriteLine(i + ".- " + alumnos[i] + ": ");  //Esta parte sirve para dezplegar la lista enumerada de los alumnos guardados en el arreglo
                y++;
            }
            y= 5;
            for(int i=0; i<10; i++){
                x=15;
                Console.SetCursorPosition(x,y);
                calif[i] = Int32.Parse(Console.ReadLine()); //En esta parte se ingresan las calificacines de cada alumno
                y++;
                x= 3;
                
            }
            y++;
             
             //Aqui comienza la programada
             // Esta parte es el proceso de ordenamiento dentro de los dos for 
             // que verifica si se deben intercambiar los elementos del vector de calificaciones (calif).
            for (int k=0; k<calif.Length; k++)
            {
                for (int f = 0; f < calif.Length - 1 - k; f++)
                {
                    if (calif[f] < calif[f + 1])
                    {
                        int auxcalif; //En el caso que la calificacion de la posición 'f' 
                        auxcalif = calif[f]; // sea menor a de la posición siguiente 'f+1',
                        calif[f] = calif[f + 1]; // se van a intercambiar las calificaciones
                        calif[f + 1] = auxcalif; 
                        string auxalumnos;
                        auxalumnos = alumnos[f];
                        alumnos[f] = alumnos[f + 1];
                        alumnos[f + 1] = auxalumnos;
                    }
                }
            }

            // Aqui es donde se desplegara la lista con los nombres de los alumnos y las calificaciones ya ordenadas de mayor a menor.
            Console.SetCursorPosition(60,y-12);
   	        Console.WriteLine("Las calificaciones ordenadas son: ");
             y=5;
            
            for(int f=0;f < calif.Length;f++) 
            {
                Console.SetCursorPosition(60,y);
                Console.WriteLine(f + ".- " + alumnos[f] + ": " + calif[f]);
                y++;
            }
            
            Console.ReadLine();
            
        }//main
    }//program
}
