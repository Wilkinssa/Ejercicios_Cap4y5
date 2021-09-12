using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class Ejercicio4_1
    {
        public void Tabla()
        {
            //declaramos variables
            int n, r;
            string teclado;

            //para introducir por teclado
            Console.WriteLine("Introduce un numero");
            teclado = Console.ReadLine();
            n = Convert.ToInt32(teclado);

            //proceso
            for (int x = 1; x <= 10; x++)
            {
                r = n * x;
                Console.WriteLine(n + "=" + x + "=" + r);
            }
            Console.WriteLine();
        }
    }

