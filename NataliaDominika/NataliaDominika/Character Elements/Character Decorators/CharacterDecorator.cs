using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NataliaDominika.Character_Elements.Character_Decorators
{
    public class CharacterDecorator : Character
    {
        protected Character baseCharacter;

        public CharacterDecorator(Character c)
        {
            baseCharacter = c ?? throw new ArgumentNullException(nameof(c));
        }

        // Nadpisujemy właściwości tak, by zwracały stan opakowanej postaci
        public override int HP => baseCharacter.HP;
        public override int MP => baseCharacter.MP;
        public override int XP => baseCharacter.XP;
        public override string ClassName
        {
            get => baseCharacter.ClassName;
            set => baseCharacter.ClassName = value;
        }

        // Delegujemy wszystkie metody do baseCharacter
        public override void AttachObserver(IStatsObserver observer)
        {
            baseCharacter.AttachObserver(observer);
        }

        public override void Notify(string eventType)
        {
            baseCharacter.Notify(eventType);
        }

        public override void GainXP(int amount)
        {
            baseCharacter.GainXP(amount);
        }

        public override void TakeDamage(int dmg)
        {
            baseCharacter.TakeDamage(dmg);
        }

        public override void AddHP(int amount)
        {
            baseCharacter.AddHP(amount);
        }

        public override void UseMana(int amount)
        {
            baseCharacter.UseMana(amount);
        }

        public override void AddMP(int amount)
        {
            baseCharacter.AddMP(amount);
        }

        public override void SetStrategy(ICombatStrategy newStrategy)
        {
            baseCharacter.SetStrategy(newStrategy);
        }

        public override void PerformAttack()
        {
            baseCharacter.PerformAttack();
        }

        public override void DisplayClass()
        {
            baseCharacter.DisplayClass();
        }
    }
}
