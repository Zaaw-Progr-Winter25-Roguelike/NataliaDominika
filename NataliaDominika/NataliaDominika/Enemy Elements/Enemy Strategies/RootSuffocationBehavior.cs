using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NataliaDominika.Enemy_Elements.Enemy_Strategies
{
    public class RootSuffocationBehavior : IEnemyBehavior
    {
        public void ExecuteBehavior()
        {
            Console.WriteLine("Treant Horror suffocates you with his root ");
        }
    }
}
