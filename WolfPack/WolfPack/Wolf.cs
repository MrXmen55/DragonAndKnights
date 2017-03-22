using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WolfPack
{
    class Wolf
    {
        public string Name;
        public Wolf(string name)
        {
            Name = name;
        }

        public void Howl()
        {
            Console.WriteLine(Name + " says: UUUUUUUUUUU!...");
        }
    }
}
