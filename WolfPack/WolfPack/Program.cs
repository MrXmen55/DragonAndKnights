using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WolfPack
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Wolf> thePack = new List<Wolf>();

            Wolf jackie = new Wolf("Jackie");
            thePack.Add(jackie);

            Wolf john = new Wolf("John");
            thePack.Add(john);

            foreach (Wolf wolf in thePack)
            {
                wolf.Howl();
            }

            Console.ReadKey();




        }
    }
}
