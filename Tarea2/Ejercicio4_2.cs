using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



    public class Ejercicio4_2
    {
        public void Elevar()
        {
            // declaracion de variables
            double num, pot, resultado;

            Console.WriteLine("Introduce el numero que deseas elevar:");
            num = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Introduce el numero de la potencia a elevar:");
            pot = Convert.ToDouble(Console.ReadLine());

            //proceso

            resultado = Math.Pow(num, pot);

            Console.WriteLine("El resultado es:" + resultado);

            Console.ReadKey();

        }
    }
