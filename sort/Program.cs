using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sort
{
    class Program
    {      
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите число");
                string srt = Console.ReadLine();
                int number = Convert.ToInt32(srt);
                if (number < 10000 && number > 2)
                {
                    int[] mass = new int[number];
                    int[] x = new int[number];
                    int a = 1;
                    for (int t = 0; t < mass.Length; t++) { mass[t] = a; a++; }
                    for (int i = 0; i < mass.Length; i++) { if (mass[i] % 2 == 0) Console.Write(mass[i] + " "); else x[i] = mass[i]; }
                    Array.Reverse(x);
                    for (int h = 0; h < x.Length; h++) if (x[h] != 0) Console.Write(x[h] + " ");
                    Console.WriteLine();
                }
                else { Console.Clear(); Console.WriteLine("Введите другое число от 2 до 10 000"); }
            }                   
        }
    }
}
