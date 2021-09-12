using System;
using Ejercicios_Cap4y5;

//main
namespace Ejercicios_Cap4y5
{
    class Program
    {
        static void Main(string[] args)
        {
            int opc=1;
            switch(opc){
             case 1:
             Ejercicio4_1 ejer1 =new Ejercicio4_1();
             ejer1.Tabla();

            break;

            case 2:
             Ejercicio4_2 ejer2 =new Ejercicio4_2();
             ejer2.Elevar();

            break;
                
            case 3:
             Ejercicio4_5 ejer5 =new Ejercicio4_5();
             ejer5.edadMinMax();
             break;

             case 4:
             Ejercicio5_4 ejer6 =new Ejercicio5_4();
             Console.WriteLine("Ingrese el numero:");
             int num = Convert.ToInt32(Console.ReadLine());
             ejer6.fact(num);

             break;

             case 5:
             Ejercicio5_5 ejer7 =new Ejercicio5_5();
             ejer7.numeros();
             break;

             default: 
             Console.WriteLine("Error, no existe:");
            break;

            }
        }
    }
}