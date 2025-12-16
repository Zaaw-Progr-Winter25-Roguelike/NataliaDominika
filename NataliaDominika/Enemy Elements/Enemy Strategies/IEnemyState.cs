using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NataliaDominika.Enemy_Elements.Enemy_Strategies
{
    public interface IEnemyState
    {
        void Enter(Enemy enemy);
        void Exit(Enemy enemy);
        void Update(Enemy enemy);
    }
}
