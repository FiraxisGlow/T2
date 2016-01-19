
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht6
{
    class Car
    {
        // properties
        public string Model { get; set; }
        public int Ymodel { get; set; }
        public string Manufacturer { get; set; }
        
     
       
        // method returns vehicle data
        public override string ToString()
        {
            return "- Merkki: " + Manufacturer + " - Malli: " + Model + " - Vuosimalli: " + Ymodel;
        }
    }
}