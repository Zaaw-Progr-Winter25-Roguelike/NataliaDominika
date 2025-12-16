using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NataliaDominika.Enemy_Elements.Enemy_Strategies
{
    public class ChaseState : IEnemyState
    {
        public void Enter(Enemy enemy)
        {
            Console.WriteLine($"{enemy.EnemyName} stoi bezczynnie");
        }
        public void Update(Enemy enemy)
        {
            Console.WriteLine($"{enemy.EnemyName} zbliża się do gracza (speed {enemy.Speed}).");

            // Jeżeli HP małe → uciekaj
            if (enemy.HP < 30)
            {
                enemy.ChangeState(new FleeState());
                return;
            }

            // Jeśli dystans mały → zaatakuj
            if (enemy.DistanceToPlayer < 2f)
            {
                enemy.ChangeState(new AttackState());
            }
        }
        public void Exit(Enemy enemy) { }
    }
}
