using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



    class Ejercicio4_5
    {
        public void edadMinMax()
        {
            int cant = 0, min = 0, max = 0, edad = 0;

            Console.WriteLine("Dijite cantidad de personas");
            cant = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < cant; i++)
            {
                Console.WriteLine("Dijite  la edad de la persona {0}", i + 1);
                edad = Convert.ToInt32(Console.ReadLine());
                if (i == 0)
                    min = max = edad;
                else if (edad > max)
                    max = edad;
                else if (edad < min)
                    min = edad;
            }
            Console.WriteLine("La edad mayor es:" + max);
            Console.WriteLine("La edad menor es:" + min);

        }
    }
