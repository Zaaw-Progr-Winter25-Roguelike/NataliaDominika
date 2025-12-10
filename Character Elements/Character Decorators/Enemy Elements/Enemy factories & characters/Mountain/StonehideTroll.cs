using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class StonehideTroll : Enemy
    {
        public StonehideTroll()
        {
            EnemyName = "Stonehide Troll";
            HP = 35;

            behavior = new MassCrusherBehavior();

            LootDrop = new RuneStone();
            DropChance = 85;
        }

        public override void Display()
        {
            Console.WriteLine("Przeciwnik : Stonehide Troll");
        }
    }
}
