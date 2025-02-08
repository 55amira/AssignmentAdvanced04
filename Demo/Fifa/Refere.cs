using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Fifa
{
    internal class Refere
    {
        public string Name { get; set; }

        public void Look(Ball ball)
        {
            Console.WriteLine($"Refree Name {Name} is looking at ball {ball}");
        }
        public override string ToString()
        {
            return $" Refree Name {Name}" ;
        }
    }
}
