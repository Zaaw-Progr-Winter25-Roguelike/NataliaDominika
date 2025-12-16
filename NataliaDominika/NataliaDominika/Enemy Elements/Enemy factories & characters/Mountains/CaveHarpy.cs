using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NataliaDominika.Enemy_Elements.Enemy_factories___characters.Mountains
{
    public class CaveHarpy : Enemy
    {
        public CaveHarpy()
        {
            EnemyName = "Cave Harpy";
            HP = 60;

            behavior = new DeafeningScreechBehavior();

            LootDrop = new Eyeball();
            DropChance = 70;
        }

        public override void Display()
        {
            Console.WriteLine("Przeciwnik : Cave harpy");
        }

    }
}
