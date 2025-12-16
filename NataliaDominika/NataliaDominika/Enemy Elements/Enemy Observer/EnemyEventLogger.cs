using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NataliaDominika.Enemy_Elements.Enemy_Observer
{
    public class EnemyEventLogger : IEnemyObserver
    {
        public void OnEnemyEvent(Enemy e, string eventType)
        {
            if (eventType == "DEAD")
                Console.WriteLine($"{e.EnemyName} został pokonany! Otrzymujesz: {e.LootDrop.Name}");

            if (eventType == "HP_CHANGED")
                Console.WriteLine($"{e.EnemyName} HP: {e.HP}");
        }
    }
}
