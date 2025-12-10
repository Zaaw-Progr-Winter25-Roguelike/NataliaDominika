using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class TreantHorror : Enemy
    {
        public TreantHorror()
        {
            EnemyName = "Treant Horror";
            HP = 85;

            behavior = new RootSuffocationBehavior();

            LootDrop = new RootCore();
            DropChance = 50;
        }

        public override void Display()
        {
            Console.WriteLine("Przeciwnik : Treant Horror");
        }
    }
}
