using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonAndKnights
{
    public class Dragon
    {

        
        private int MinDamage;
        private int MaxDamage;
        public string Name;
        public bool IsDead;
        public int Health;
 

        public Dragon(string name="ALDUIN")
        {
            Random random = new Random();
            Health = 30;
            MinDamage = random.Next(0, 10);
            MaxDamage = random.Next(10, 25);
            IsDead = false;
            Name = name;
            Console.WriteLine("I'm " + Name + " and I have " + Health + " points of health!");
        }

        public void MakeDamage(Knight targetKnight)
        {
            Random random = new Random();
            int damagePoints = random.Next(MinDamage, MaxDamage);
            Console.WriteLine(Name + " hits " + " and makes " + damagePoints + " points of damage!");
            targetKnight.ReceiveDamage(damagePoints);
        }

        public void ReceiveDamage(int damagePoints)
        {
            Health = Health - damagePoints;
            Console.WriteLine( Name + " receives " + damagePoints + " points of damage!");
            if (Health <= 0) IsDead = true;
            if (IsDead) Console.WriteLine("Ops, looks like " + Name + " is dead!");
        }

    }
}
