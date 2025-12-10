using ConsoleApp5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public interface IEnemyObserver
    {
        void OnEnemyEvent(Enemy enemy, string eventType);
    }
}
