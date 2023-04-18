using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            string teclado;
            int[] arreglo = new int[8];
            int y, contador3 = 0, contador4 = 0, contador5 = 0, contador6 = 0, tres = 3, cuatro = 4, cinco = 5, seis = 6;
            double potencia3 = 0, potencia4 = 0, potencia5 = 0, potencia6 = 0;

            //Estructura for para capturar los numeros
            for (int x = 0; x < arreglo.Length; x++)
            {
                Console.Write("Ingrese valor " + x +"\n");
                teclado = Console.ReadLine();
                y = int.Parse(teclado);
                if (y >= 3 && y <= 6)
                {
                    arreglo[x] = int.Parse(teclado);
                }
                else
                {
                    Console.Write("Valor erroneo" + "\n");
                    x = x - 1;
                }
            }

            //Estructura for para obtener numeros repetidos y potencias
            for (int i = 0; i < arreglo.Length; i++)
            {
                if(arreglo[i] == 3)
                {
                    contador3++;
                }

                if (arreglo[i] == 4)
                {
                    contador4++;
                }

                if (arreglo[i] == 5)
                {
                    contador5++;
                }

                if (arreglo[i] == 6)
                {
                    contador6++;
                }

                potencia3 = Math.Pow(tres, contador3);
                potencia4 = Math.Pow(cuatro, contador4);
                potencia5 = Math.Pow(cinco, contador5);
                potencia6 = Math.Pow(seis, contador6);
            }
            Console.WriteLine("El numero tres se repite " + contador3 + " veces y su potencia es: " + potencia3 + "\n");
            Console.WriteLine("El numero cuatro se repite " + contador4 + " veces y su potencia es: " + potencia4 + "\n");
            Console.WriteLine("El numero cinco se repite " + contador5 + " veces y su potencia es: " + potencia5 + "\n");
            Console.WriteLine("El numero tres se repite " + contador6 + " veces y su potencia es: " + potencia6 + "\n");
            Console.ReadKey();
        }
    }
}
    





