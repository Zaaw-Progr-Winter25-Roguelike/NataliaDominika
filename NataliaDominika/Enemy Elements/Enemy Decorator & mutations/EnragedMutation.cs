using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NataliaDominika.Enemy_Elements.Enemy_Decorator___mutations
{
    public class EnragedMutation : EnemyDecorator
    {
        public EnragedMutation(Enemy e) : base(e)
        {
            baseEnemy.AddHP(20);
        }

        public override void PerformAction()
        {
            Console.WriteLine("[ENRAGED MODE] zwiększone obrażenia");
            base.PerformAction();
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine("+ Mutacja: Enraged");
        }
    }
}
