using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NataliaDominika.Character_Elements.Character_Factories
{
    public abstract class CharacterFactory
    {
        public abstract Character CreateCharacter(string subtype);
    }
}
