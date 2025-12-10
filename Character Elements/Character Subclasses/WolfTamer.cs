using ConsoleApp5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class WolfTamer : Beastmaster
    {
        public WolfTamer()
        {
            ClassName = "WolfTamer";
        }
        public override void DisplayClass()
        {
            Console.WriteLine("Postać: Wolf Tamer");
        }
    }
}
