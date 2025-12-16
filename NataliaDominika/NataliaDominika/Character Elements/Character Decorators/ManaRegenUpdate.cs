using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NataliaDominika.Character_Elements.Character_Decorators
{
    public class ManaRegenUpdate : CharacterDecorator
    {
        public ManaRegenUpdate(Character c) : base(c) { }

        public override void PerformAttack()
        {
            base.PerformAttack();
            Console.WriteLine("aktywacja regeneracji many");
        }
        public override void DisplayClass()
        {

            base.DisplayClass();
            Console.WriteLine(" + upgrade regeneracji many");
        }
    }
}
