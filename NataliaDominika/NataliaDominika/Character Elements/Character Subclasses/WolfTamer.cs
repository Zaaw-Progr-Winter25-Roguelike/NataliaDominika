using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NataliaDominika.Character_Elements.Character_Subclasses
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
