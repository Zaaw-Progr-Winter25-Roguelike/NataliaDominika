using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NataliaDominika.Enemy_Elements.Enemy_Strategies
{
    public class DirtBomsThrowBehavior : IEnemyBehavior
    {
        public void ExecuteBehavior()
        {
            Console.WriteLine("Moss goblin throws toxic dirt bombs at you");
        }
    }
}
