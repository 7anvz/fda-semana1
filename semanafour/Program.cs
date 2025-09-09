using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace semanafour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string mensaje;
            //Console.Write("INGRESE LOS AÑOS TRABAJADOS: ");
            //int añostraba = int.Parse(Console.ReadLine());
            //Console.Write("¿CUÁNTO HA OBTENIDO EN VENTAS?: ");
            //double ventas = int.Parse(Console.ReadLine());
            //Console.WriteLine("¿TIENE HIJOS?: ");
            //Console.WriteLine("[1] SI TENGO ");
            //Console.WriteLine("[2] NO TENGO ");
            //int hijos = int.Parse(Console.ReadLine());
            //if (añostraba >= 3 || ventas >= 3500 || hijos == 1) mensaje = "USTED RECIBE BONIFICACION";
            //else mensaje = "USTED NO RECIBE BONIFICACIÓN";
            //Console.WriteLine(mensaje);

            //ejer01();
            //ejer02();
            ejer03();
            //ejer04();
        }

        static void ejer01()
        {
            Console.Write("INGRESE SU NOMBRE: ");
            string name = Console.ReadLine();
            Console.Write("INGRESE SU CARRERA: ");
            string carrera = Console.ReadLine();
            Console.WriteLine($"\n{name}, Bienvenido al curso de F.DE ALGORITMOS ");
        }
        static void ejer02()
        {
          Console.WriteLine("\"RENZO\"");
        }
        static void ejer03()
        {
            Console.WriteLine("INGRESE NUMERO 1: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("INGRESE NUMERO 2: ");
            int num2 = int.Parse(Console.ReadLine());
            double division = (double)num1 / (double)num2;

            Console.WriteLine($"LA SUMA ES {num1 + num2}");
            Console.WriteLine($"LA RESTA ES {num1 - num2}");
            Console.WriteLine($"LA MULTIPLICACION ES {num1 * num2}");
            Console.WriteLine($"LA DIVISION ES {division:F2}");

        }

    }
}
