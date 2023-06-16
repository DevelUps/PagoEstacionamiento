using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoEstacionamiento
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Hacer un programa que le diga al usuario el precio que debe pagar por el servicio de estacionamiento de un centro comercial con base en el tiempo que ha permanecido ahí, los primeros 60 minutos: $5.00, las primeras 2 horas $15.00 y de 2 horas en adelante: $40.00

         

            float minutos;
            // Solicitar al usuario que ingrese el tiempo en minutos
            Console.Write("Por favor ingresa el tiempo en minutos:  ");
            minutos = Convert.ToSingle(Console.ReadLine());

            // Verificar el tiempo ingresado y mostrar el precio correspondiente
            if (((minutos) > 0) && (minutos <= 60))

            {
                // Si el tiempo es menor o igual a 60 minutos, el precio es $5.00
                Console.WriteLine("Por favor pagar $ 5.00");
            }
            else
            {
                if (((minutos) > 60) && (minutos <= 120))
                    // Si el tiempo es mayor a 60 minutos pero menor o igual a 120 minutos, el precio es $15.00
                    Console.WriteLine("Por favor pagar $ 15.00");
                else
                if (minutos > 120)
                {
                    // Si el tiempo es mayor a 120 minutos, el precio es $40.00
                    Console.WriteLine("Por favor pagar $ 40.00");
                }

            }

            







                
            
        }
    }
}