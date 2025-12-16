using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NataliaDominika.Character_Elements.Character_Strategies
{
    public class FireBallAttackStrategy : ICombatStrategy
    {
        public void ExecuteAttack()
        {
            Console.WriteLine("atak kulą ognia");
        }
    }
}
