using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeraAplicacion
{
    class Program
    {
        static void Main(string[] args)
        {
            int NumeroUno;
            int NumeroDos;
            int resultado;
            string Dato;
            bool esNumero;




            Console.Write("Ingrese un numero: ");
            while (!int.TryParse(Console.ReadLine(), out NumeroUno))
            {
                Console.Clear();
                Console.Write("Error. Ingrese un numero: ");
            }


            Console.Clear();

            Console.Write("Ingrese otro numero: ");
            while (!int.TryParse(Console.ReadLine(), out NumeroDos))
            {
                Console.Clear();
                Console.Write("Error. Ingrese un numero: ");
                
            }


            resultado = NumeroUno + NumeroDos;
            Console.Clear();
            Console.WriteLine("Numero Uno es = " + NumeroUno + "\nNumero Dos es = " + NumeroDos + "\nEl resultado es = " + resultado);
            Console.ReadLine();

            
        }
    }
}
