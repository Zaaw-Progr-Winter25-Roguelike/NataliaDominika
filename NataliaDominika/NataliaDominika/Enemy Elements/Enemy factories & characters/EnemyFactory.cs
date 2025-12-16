using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NataliaDominika.Enemy_Elements.Enemy_factories___characters
{
    public abstract class EnemyFactory
    {
        public abstract Enemy CreateEnemy(string subtype);
    }
}
