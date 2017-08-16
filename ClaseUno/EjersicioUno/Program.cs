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
            int numeroMayor = 0;
            int numeroMenor = 0;
            int numero;
            int contador;
            float promedio;
            int sumador = 0;

            int primePar = 0;
            int lugarDelPrimerPar = 0;

            int ultimoImpar = 0;
            int LugarDelUltimoImpar = 0;

            int contadorPares = 0;

            int banderaParUno = 0;



            for (contador = 0; contador < 7; contador++)
            {

                Console.Clear();

                Console.Write("Ingrese un numero: ");

                while(!int.TryParse(Console.ReadLine(),out numero))
                {

                    Console.Clear();
                    Console.Write("Error. Ingrese un numero: ");

                }
                sumador += numero;


                if (numero % 2==0)
                {
                    if (banderaParUno == 0)
                    { 
                        primePar = numero;
                        lugarDelPrimerPar = contador+1;
                        banderaParUno++;
                    }
                    contadorPares++;
                    
                }
                else
                {
                    ultimoImpar = numero;
                    LugarDelUltimoImpar = contador+1;
                }



                if (contador == 0)
                {
                    numeroMayor = numero;
                    numeroMenor = numero;
                }
                else
                {
                    if (numero > numeroMayor)
                    {
                        numeroMayor = numero;
                    }
                    else if(numero<numeroMenor)
                    {
                        numeroMenor = numero;
                    }
                }
                
            }

            promedio =(float) sumador / (float)contador;

            Console.Clear();
            Console.WriteLine("El numero maximo es: " + numeroMayor);
            Console.WriteLine("El numero minimo es: " + numeroMenor);
            Console.WriteLine("El primer numero par es: " + primePar + " en la posicion: " + lugarDelPrimerPar);
            Console.WriteLine("El ultimo impar es: " + ultimoImpar + "en la posicion: " + LugarDelUltimoImpar);
            Console.WriteLine("La suma es: " + sumador);
            Console.WriteLine("Promedio: " + promedio);

            Console.ReadLine();
            
        }
    }
}
