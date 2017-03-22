
using System;

namespace DragonAndKnights
{
    public class Knight
    {
        private int MinDamage;
        private int MaxDamage;
        public string Name;
        public bool IsDead;
        public int Health;


        public Knight(string name = "King Artur")
        {
            Random random = new Random();
            Health = 10;
            MinDamage = random.Next(0, 2);
            MaxDamage = random.Next(5, 10);
            IsDead = false;
            Name = name;
            Console.WriteLine("I'm " + Name + " and I have " + Health + " points of health!");
        }

        public void MakeDamage(Dragon targetDragon)
        {
            Random random = new Random();
            int damagePoints = random.Next(MinDamage, MaxDamage);
            Console.WriteLine(Name + " hits " + targetDragon.Name + " and makes " + damagePoints + " points of damage!");
            targetDragon.ReceiveDamage(damagePoints);
        }

        public void ReceiveDamage(int damagePoints)
        {
            Health = Health - damagePoints;
            Console.WriteLine(Name + " receives " + damagePoints + " points of damage!");
            if (Health <= 0) IsDead = true;
            if (IsDead) Console.WriteLine("Ops, looks like " + Name + " is dead!");
        }
    }
}