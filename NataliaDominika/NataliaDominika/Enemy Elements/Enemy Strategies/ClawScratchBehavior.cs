using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NataliaDominika.Enemy_Elements.Enemy_Strategies
{
    public class ClawScratchBehavior : IEnemyBehavior
    {
        public void ExecuteBehavior()
        {
            Console.WriteLine("Werewolf slices your skin open with their sharp claws");
        }
    }
}
