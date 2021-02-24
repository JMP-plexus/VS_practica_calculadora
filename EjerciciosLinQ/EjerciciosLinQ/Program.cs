using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosLinQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 1");
            int[] cadena = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var consulta = from n in cadena
                           where n%2==0
                           select n;

            Console.WriteLine("Numeros pares:");
            foreach (var i in consulta)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
            Console.WriteLine("Ejercicio 2");
            int[] cadena2 = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };
            var consulta2 = from n in cadena2
                           where n>=1&&n<=12
                           select n;

            Console.WriteLine("Numeros entre 1 y 12:");
            foreach (var i in consulta2)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
            Console.WriteLine("Ejercicio 3");
            int[] cadena3 = { 3, 9, 2, 8, 6, 5};
            var consulta3 = from n in cadena3
                            select n * n ;

            Console.WriteLine("Numeros  y sus cuadrados:");
            foreach (var i in consulta3)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();

            Console.WriteLine("Ejercicio 4");
            int[] cadena4 = { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };
            var consulta4 = from n in cadena4
                            group n by n into nG
                            select new { numero = nG.Key, apariciones = nG.Count() } ;

            Console.WriteLine("Numeros  y sus apariciones:");
            foreach (var i in consulta4)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();

            Console.WriteLine("Ejercicio 5");
            string[] cadena5 = { "ROMA", "LONDRES", "ZARAGOZA", "A CORUÑA", "ZURICH", "BERLIN", "AMSTERDAM", "AMBERES", "PARIS" };
            var consulta5 = from a in cadena5
                            where a.StartsWith("A")&&a.EndsWith("M")
                            select a;

            Console.WriteLine("Capital empieza por A y acaba en M");
            foreach (var i in consulta5)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();

            Console.WriteLine("Ejercicio 6");
            int[] cadena6 = { 5, 7, 13, 9, 55, 4, 16 };
            var consulta6 = from a in cadena6
                            orderby a descending
                            select a;

            Console.WriteLine("Introducir la cantidad de números más altos:");
            int cantidad = Int32.Parse( Console.ReadLine());
            for (int i=0;i<cantidad;i++)
            {
                Console.WriteLine(consulta6.ElementAt(i));
            }
            Console.ReadLine();
            /*  Console.WriteLine("Ejercicio 7");
              char[] cadena7 = {'M','O','P','A' };
              var consulta7 = from a in cadena7
                              orderby a descending
                              select a;   

              Console.WriteLine("Introducir la cantidad de números más altos:");
              char caracter = char.Parse(Console.ReadLine().Substring(0,1));
              var consulta7b = from a in cadena7
                              where a==caracter
                              select a;
              foreach (var i in consulta7b)
              {
                  consulta7
              }
              foreach (var i in consulta7)
              {
                  Console.WriteLine(i);
              }*/

            Console.WriteLine("Ejercicio 8");
            char[] cadena8 = {'a','b','c' };
            int[] cadena8b = { 1,2,3 };
            var consulta8 = from a in cadena8 from b in cadena8b
                            select new {x=a , y=b };

            Console.WriteLine("Producto cartesiano:");
            foreach (var i in consulta8)
            {
                Console.WriteLine("("+i.x+","+ i.y+")");
            }
            Console.ReadLine();
        }
    }
}
