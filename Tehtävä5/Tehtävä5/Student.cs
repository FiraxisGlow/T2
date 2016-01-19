

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
    class Opiskelija
    {

        public string Name { get; set; }
        public string LastName { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }



        public void PrintData()
        {

            Console.WriteLine("Student info: " + Name + " " + LastName + ", " + ID + ", " + Age);

        }

        public void AGE()
        {
            Age++;
        }
    }
}
