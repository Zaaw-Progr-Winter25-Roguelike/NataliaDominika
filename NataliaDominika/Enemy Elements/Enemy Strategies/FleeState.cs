using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NataliaDominika.Enemy_Elements.Enemy_Strategies
{
    public class FleeState : IEnemyState
    {
        public void Enter(Enemy enemy)
        {
            Console.WriteLine($"{enemy.EnemyName} ucieka - ma malo HP ({enemy.HP}).");
        }
        public void Update(Enemy enemy)
        {
            Console.WriteLine($"{enemy.EnemyName} oddala sie od gracza");
            if (enemy.HP > 50)
            {
                enemy.ChangeState(new ChaseState());
                return;
            }
            if (enemy.HP <= 0)
            {
                return;
            }
        }
        public void Exit(Enemy enemy)
        {
            Console.WriteLine($"{enemy.EnemyName} przestaje uciekac");
        }

    }
}
