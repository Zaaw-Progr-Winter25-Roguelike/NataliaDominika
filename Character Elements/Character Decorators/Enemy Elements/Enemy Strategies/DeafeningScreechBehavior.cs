using ConsoleApp5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class DeafeningScreechBehavior : IEnemyBehavior
    {
        public void ExecuteBehavior()
        {
            Console.WriteLine("Cave Harpy deafens you with her high pitch screech");
        }
    }
}
