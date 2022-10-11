using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjRepaso13
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Ejercicio XIII
            //Crear una aplicación que, cuando el usuario ingrese un número, calcule el factorial del
            //mismo y lo muestre por pantalla.
            //Nota: El factorial de un número es el producto de todos los números enteros positivos
            //desde 1 hasta n. Por ejemplo: 5! = 1 x 2 x 3 x 4 x 5 = 120

            int numero;
            int fact=1;
            int n = 0;
            Console.WriteLine("Ingrese un numero entero");
            bool exito=false;
            do
            {
                exito = int.TryParse(Console.ReadLine(),out numero);
                if (exito)
                    {
                    if (numero == 0)
                    {
                        Console.WriteLine("Ingrese un valor distinto de 0");
                        exito = false;
                    }
                    else
                    {
                        for (int i = 1; i <= numero; i++)

                            fact = fact * i;
                    }    
                    
                   
                }
                else
                {
                    Console.WriteLine("El valor ingresado no es un número entero, vuelva a ingresar un valor");
                }
            } while (exito == false);

            Console.WriteLine("El factorial del número {0} es {1}", numero, fact);
            Console.ReadKey();
            
        }
    }
}
