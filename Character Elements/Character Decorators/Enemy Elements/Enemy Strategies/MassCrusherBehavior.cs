using ConsoleApp5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class MassCrusherBehavior: IEnemyBehavior
    {
        public void ExecuteBehavior()
        {
            Console.WriteLine("Przeciwnik zastawia zasadzke na gracza");
        }
    }
}
