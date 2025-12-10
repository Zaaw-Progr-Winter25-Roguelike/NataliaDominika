using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class EnemyDecorator : Enemy
    {
        public Enemy baseEnemy;

        public EnemyDecorator(Enemy e)
        {
            baseEnemy = e;
        }

        public override void Display() => baseEnemy.Display();
        public override void PerformAction() => baseEnemy.PerformAction();
    }
}
