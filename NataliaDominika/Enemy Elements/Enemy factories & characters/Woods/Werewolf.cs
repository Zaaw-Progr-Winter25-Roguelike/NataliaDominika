using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NataliaDominika.Enemy_Elements.Enemy_factories___characters.Woods
{
    public class Werewolf : Enemy
    {
        public Werewolf()
        {
            EnemyName = "Werewolf";
            HP = 70;

            behavior = new ClawScratchBehavior();

            LootDrop = new Fangs();
            DropChance = 70;
        }

        public override void Display()
        {
            Console.WriteLine("Przeciwnik : Werewolf");
        }
    }
}
