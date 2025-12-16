using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NataliaDominika.Enemy_Elements.Enemy_Decorator___mutations
{
    public class FrozenMutation : EnemyDecorator
    {
        public FrozenMutation(Enemy e) : base(e)
        {
            baseEnemy.AddHP(40);
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine("+ Mutacja: Frozen");
        }
    }
}
