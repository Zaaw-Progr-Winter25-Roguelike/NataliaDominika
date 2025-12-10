using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class DragonCaller : Beastmaster
    {
        public DragonCaller() 
        {
            ClassName = "DragonCaller";
        }
        public override void DisplayClass()
        {
            Console.WriteLine("Postać: Dragon Caller");
        }
    }
}
