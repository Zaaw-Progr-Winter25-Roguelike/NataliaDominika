using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NataliaDominika.Enemy_Elements.Enemy_Strategies
{
    internal class AttackState : IEnemyState
    {
        private float attackCooldown = 1.0f;
        private float cooldownTimer = 0f;
        public void Enter(Enemy enemy)
        {
            Console.WriteLine($"{enemy.EnemyName} zaczyna atakowac");
        }
        public void Update(Enemy enemy)
        {
            cooldownTimer -= 0.1f;
            if (cooldownTimer <= 0f)
            {

                Console.WriteLine($"{enemy.EnemyName} zadaje obrazenia.");
                cooldownTimer = attackCooldown;
            }

            if (enemy.HP <= 0)
            {
                return;
            }

            if (enemy.DistanceToPlayer > 3f)
            {
                enemy.ChangeState(new ChaseState());
            }
        }
        public void Exit(Enemy enemy)
        {
            Console.WriteLine($"{enemy.EnemyName} przestaje atakowac");
        }
    }
}
