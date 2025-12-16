using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NataliaDominika.Enemy_Elements.Enemy_Strategies
{
    public class IdleState : IEnemyState
    {
        public void Enter(Enemy enemy)
        {
            Console.WriteLine($"{enemy.EnemyName} stoi bezczynnie");
        }
        public void Update(Enemy enemy)
        {
            if (enemy.DistanceToPlayer < 10f)
            {
                enemy.ChangeState(new ChaseState());
            }
        }
        public void Exit(Enemy enemy) { }
    }
}
