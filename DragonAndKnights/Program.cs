using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonAndKnights
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Knight> theArmy = new List<Knight>();
            Console.WriteLine("Can one hundred knights defeat one dragon? Lets see!");
            Dragon ALDUIN= new Dragon ();
            for (int i = 0; i < 3; i++)
            {
                Knight nextKnight = new Knight();
                theArmy.Add(nextKnight);
            }
            Console.WriteLine("Start battle!");
            while (!ALDUIN.IsDead)
            {
                foreach (Knight nextKnight in theArmy)
                {
                    nextKnight.MakeDamage(ALDUIN);
                    ALDUIN.MakeDamage(nextKnight);
                    if (nextKnight.IsDead)
                    {
                        theArmy.Remove(nextKnight);
                    }
                    if (theArmy.Count==0)
                    {
                        Console.WriteLine("ALDUIN win !");
                        break;
                    }
                    Console.ReadKey();
                }
               



            }
            // создай нового дракона с именем greenFrog
           
            // 100 раз сделай следующее:
            // создай нового рыцаря, добавив цифру к его имени, т.е. Sir Galahad 56
            // и добавь его в армию

            // ДА БУДЕТ БИТВА!

            // Пока дракон жив:

            // КАЖДЫЙ из ЖИВЫХ Рыцарей атакует дракона
            // Дракон атакует в ответ
            // Если рыцарь умер - убираем его из армии
            // Если в армии не осталось рыцарей - прекращаем игру, дракон победил
            Console.ReadKey();
            
            // Дракон умер, есть живые рыцари - рыцари победили!
            Console.ReadKey();

        }
    }
}
