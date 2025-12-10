using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class FireBallAttackStrategy : ICombatStrategy
    {
        public void ExecuteAttack()
        {
            Console.WriteLine("atak kulą ognia");
        }
    }
}
