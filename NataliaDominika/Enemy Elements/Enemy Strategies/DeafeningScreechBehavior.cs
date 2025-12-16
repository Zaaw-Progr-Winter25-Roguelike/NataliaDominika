using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NataliaDominika.Enemy_Elements.Enemy_Strategies
{
    public class DeafeningScreechBehavior : IEnemyBehavior
    {
        public void ExecuteBehavior()
        {
            Console.WriteLine("Cave Harpy deafens you with her high pitch screech");
        }
    }
}
