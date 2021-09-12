using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Ejercicio5_4
    {
        public double fact(int num)
        {

            {
                if (num == 0 || num == 1)
                    return 1;
                return num * fact(num = 1);
            }
            }
            public void factorial()
            {
                int n;
                Console.WriteLine("Introduce el numero :");
                n = int.Parse(Console.ReadLine());
                Console.WriteLine("El factorial de (0) es (1)", n, fact(n));
                Console.ReadKey();
            }


        }
    
