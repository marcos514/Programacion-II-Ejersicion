using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjersicioUno
{
    class Program
    {
        static void Main(string[] args)
        {
            //pedir 5 numeros, mayor y menor
            int numeroMayor=0;
            int numeroMenor=0;
            int numero;
            int contador;

            for (contador = 0; contador < 5; contador++)
            {
                Console.Write("Ingrese un numero: ");
                while(!int.TryParse(Console.ReadLine(),out numero))
                {
                    Console.Clear();
                    Console.Write("Error. Ingrese un numero: ");

                }

                if (contador == 0)
                {
                    numeroMayor=numero;
                    numeroMenor=numero;
                }
                else
                {
                    if (numero > numeroMayor)
                    {
                        numeroMayor=numero;
                    }
                    else if(numero<numeroMenor)
                    {
                        numeroMenor=numero;
                    }
                }
                
            }
            Console.Clear();
            Console.WriteLine("El numero maximo es: " + numeroMayor);
            Console.WriteLine("El numero minimo es: " + numeroMenor);
            Console.ReadLine();
            
        }
    }
}
