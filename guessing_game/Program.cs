﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int tahmin = 0, tutulan, sayac = 0;
            Random rasgele = new Random();
            tutulan = rasgele.Next(1, 100);
            while (tahmin != tutulan)
            {
                sayac++;
                Console.WriteLine("Sayı giriniz");
                tahmin = Convert.ToInt32(Console.ReadLine());


                if (tahmin > tutulan)
                {
                    Console.WriteLine("Sayıyı küçült");

                }
                else if (tahmin < tutulan)
                {
                    Console.WriteLine("Sayıyı büyüt");
                }
            }

            Console.WriteLine("Tebrikler.");
            Console.WriteLine("{0}.hakkınızda bildiniz", sayac);
            Console.ReadKey();


        }
    }
}