using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NataliaDominika.Character_Elements.Character_Subclasses
{
    public class SerpentWhisperer : Beastmaster
    {
        public SerpentWhisperer()
        {
            ClassName = "SerpentWhisperer";
        }
        public override void DisplayClass()
        {
            Console.WriteLine("Postać: Serpent Whisperer");
        }
    }
}
