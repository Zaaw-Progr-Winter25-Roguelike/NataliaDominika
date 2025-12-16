using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace NataliaDominika.Waves_Elements
{
    public class AttackCommand : ICommand
    {
        public void Execute(Enemy enemy)
        {
            enemy.PerformAction(); // wykonanie behavior
            Console.WriteLine($"{enemy.EnemyName} wykonuje atak!");
        }
    }
}
