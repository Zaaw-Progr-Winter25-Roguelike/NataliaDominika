using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NataliaDominika.Character_Elements.Character_Decorators
{
    public class HolyAura : CharacterDecorator
    {
        public HolyAura(Character c) : base(c)
        {
            baseCharacter.AddMP(30);

        }
        public override void PerformAttack()
        {
            Console.WriteLine("[HOLY AURA] +30MP ");
            base.PerformAttack();
        }
        public override void DisplayClass()
        {
            base.DisplayClass();
            Console.WriteLine("+ Święta aura");
        }
    }
}
