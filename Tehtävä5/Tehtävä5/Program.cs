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


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtävä5
{
    class Program
    {
        static void Main(string[] args)
        {


            Opiskelija[] student = new Opiskelija[5];

            student[0] = new Opiskelija();
            student[0].Name = "Jarmo";
            student[0].LastName = "Holopainen";
            student[0].ID = "~9842";
            student[0].Age = 22;

            student[1] = new Opiskelija();
            student[1].Name = "Pena";
            student[1].LastName = "Taivainmäki";
            student[1].ID = "K1025";
            student[1].Age = 26;

            student[2] = new Opiskelija();
            student[2].Name = "Leena";
            student[2].LastName = "Saananjärvi";
            student[2].ID = "H1111";
            student[2].Age = 19;

            student[3] = new Opiskelija();
            student[3].Name = "Pasi";
            student[3].LastName = "Pihkasuo";
            student[3].ID = "G5421";
            student[3].Age = 24;

            student[4] = new Opiskelija();
            student[4].Name = "Hermanni";
            student[4].LastName = "Kivipuu";
            student[4].ID = "T1337";
            student[4].Age = 20;

            for (int o = 0; o < 5; o++)
            {
                student[o].PrintData();
                student[o].AGE();
            }

            Console.WriteLine("Vuoden päästä: ");
            for (int o = 0; o < 5; o++)
            {
                student[o].PrintData();
            }
            Console.ReadLine();
        }

    }
}
