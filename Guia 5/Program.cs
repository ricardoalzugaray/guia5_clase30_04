using System;

namespace Ejercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int libreta, nota, cant;
            string nombre, menorn = "yyyy", mayorn = "xxxx";
            Console.WriteLine("Ingrese cantidad de Alumnos");
            cant = Convert.ToInt32(Console.ReadLine());
            int mayorl = -10000, menorl = 10000;
            for (int i = 0; i < cant; i++)
            {
                Console.WriteLine("Ingrese N° libreta");
                libreta = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" ");
                Console.WriteLine("Ingrese Nombre del Alumno");
                nombre = Console.ReadLine();
                Console.WriteLine(" ");
                Console.WriteLine("Ingrese Nota");
                nota = Convert.ToInt32(Console.ReadLine());
                Console.ReadKey();
                if (nota < menorl)
                {
                    menorl = libreta;
                    menorn = nombre;
                }
                if (nota > mayorl)
                {
                    mayorl = libreta;
                    mayorn = nombre;
                }
            }
            Console.ReadKey();
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("Alumno con mayor nota: {0}", mayorn);
            Console.WriteLine("N° Libreta: {0}", mayorl);
            Console.WriteLine(" ");
            Console.WriteLine("Alumno con menor nota: {0}", menorn);
            Console.WriteLine("N° Libreta: {0}", menorl);
            Console.ReadKey();

        }
    }
}
