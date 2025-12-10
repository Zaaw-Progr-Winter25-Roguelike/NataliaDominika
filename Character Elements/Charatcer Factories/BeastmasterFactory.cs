using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class BeastmasterFactory : CharacterFactory
    {
        public override Character CreateCharacter(string subtype)
        {
            return subtype.ToLower() switch
            {
                "wolftamer" => new WolfTamer(),
                "serpentwhisperer" => new SerpentWhisperer(),
                "dragoncaller" => new DragonCaller(),
                
                _=> throw new Exception("Unknown beastmaster subtype.")
            };
        }
    }
}
