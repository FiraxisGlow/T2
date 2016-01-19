using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
* Copyright (C) Anton Kiri
*
*
* Olio-ohjelmointi
*
*
* 11.02.16
* Anton Kiri
*/

using System.Threading.Tasks;

namespace Teht6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Monta autoa omistat?");
            string rivi = Console.ReadLine();
            int luku = int.Parse(rivi);

            int max;
            max = luku;

            Car[] cars = new Car[max];

            for (int i = 0; i < max; i++)
            {
                cars[i] = new Car();
                Console.Write("Merkki " + (i + 1));
                cars[i].Manufacturer = Console.ReadLine();

                Console.Write("Auton " + (i + 1) + " Malli: ");
                cars[i].Model = Console.ReadLine();

                Console.Write("Auton vuosimalli" + (i + 1));
                string rivi1 = Console.ReadLine();
                cars[i].Ymodel = int.Parse(rivi1);

             


        
            Console.WriteLine();
        }

            for (int y = 0; y < max; y++)
            {
                Console.WriteLine("Auton " + (y + 1) + " tiedot: ");
                Console.WriteLine(cars[y].ToString());
              
            }

       
            Console.ReadLine();
        }
    }
}