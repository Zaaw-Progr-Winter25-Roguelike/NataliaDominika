using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NataliaDominika.Enemy_Elements.Enemy_factories___characters.Mountains
{
    public class Roc : Enemy
    {
        public Roc()
        {
            EnemyName = "Roc";
            HP = 55;

            behavior = new AgressiveDiveBehavior();

            LootDrop = new Feathers();
            DropChance = 45;
        }

        public override void Display()
        {
            Console.WriteLine("Przeciwnik : Roc");
        }
    }
}
