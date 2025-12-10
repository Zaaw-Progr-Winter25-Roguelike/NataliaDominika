using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class MossGoblin: Enemy
    {
        public MossGoblin()
        {
            EnemyName = "Moss Goblin";
            HP = 90;

            behavior = new DirtBomsThrowBehavior();

            LootDrop = new Worms();
            DropChance = 60;
        }

        public override void Display()
        {
            Console.WriteLine("Przeciwnik : Moss Goblin");
        }
    }
}

