using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NataliaDominika.Enemy_Elements.Enemy_factories___characters.Mountains
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
