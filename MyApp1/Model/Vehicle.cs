using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp1.Model
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int NumOfSeats { get; set; }

        public Vehicle(String name, int numOfSeats)
        {
            Name = name;
            NumOfSeats = numOfSeats;
        }
    }
}
