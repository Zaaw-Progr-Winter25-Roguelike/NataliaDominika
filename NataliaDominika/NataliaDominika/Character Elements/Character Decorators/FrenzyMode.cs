using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NataliaDominika.Character_Elements.Character_Decorators
{
    public class FrenzyMode : CharacterDecorator
    {
        public FrenzyMode(Character c) : base(c)
        {
            baseCharacter.AddHP(50);
        }
        public override void PerformAttack()
        {
            Console.WriteLine("[FRENZY MODE] +20MP ");
            base.PerformAttack();
        }
        public override void DisplayClass()
        {
            base.DisplayClass();
            Console.WriteLine("+ Tryb szału");
        }
    }
}
