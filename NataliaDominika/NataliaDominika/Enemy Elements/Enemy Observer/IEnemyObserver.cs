using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NataliaDominika.Enemy_Elements.Enemy_Observer
{
    public interface IEnemyObserver
    {
        void OnEnemyEvent(Enemy enemy, string eventType);
    }
}
