using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semana1_para_c_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ejer2();
            Console.ReadKey();
           
        }

       static void ejer1()
        {
            string nombre, carrera;//declarando variables

            Console.Write("ingrese su nombre: ");
            nombre = Console.ReadLine();

            Console.Write("ingrese su carrera: ");
            carrera = Console.ReadLine();

            Console.WriteLine($"\n{nombre}, bienvenido a FA de {carrera}");
            // $ significa que conjcatenacion por interpolacion que se usa cuando hay muchas variables a concatenar
            // \n sirve para el salto de linea   
        }
        static void ejer2()
        {
            Console.Write("ingrese numero X: ");
            int x = int.Parse( Console.ReadLine() );

            Console.Write("ingrese numero Y: ");
            int y = int.Parse(Console.ReadLine());

            double resultado = (double)x / (double)y;

            Console.WriteLine("Suma: " + (x + y));
            Console.WriteLine("resta: " + (x - y));
            Console.WriteLine("multiplicacion: " + (x * y));
            Console.WriteLine("division: " + resultado);

        }
        static void ejer3()
        {

        }
        static void ejer4()
        {

        }
        static void ejer5()
        {

        }
        static void ejer6()
        {

        }

    }
}
