using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NataliaDominika
{
    public abstract class Character
    {
        // Oznaczamy właściwości jako virtual, żeby dało się je nadpisać w dekoratorze
        public virtual int HP { get; protected set; } = 100;
        public virtual int MP { get; protected set; } = 50;
        public virtual int XP { get; protected set; } = 0;

        protected List<IStatsObserver> observers = new();
        protected ICombatStrategy strategy;

        public virtual string ClassName { get; set; }



        public virtual void SetStrategy(ICombatStrategy newStrategy)
        {
            strategy = newStrategy;
        }

        // metody powiadamiania i modyfikacji stanu również virtual
        public virtual void AttachObserver(IStatsObserver observer)
        {
            observers.Add(observer);
        }

        public virtual void Notify(string eventType)
        {
            foreach (var obs in observers)
            {
                obs.OnStatsChanged(this, eventType);
            }
        }

        public virtual void GainXP(int amount)
        {
            XP += amount;
            Notify("XP_CHANGED");
        }

        public virtual void TakeDamage(int dmg)
        {
            HP -= dmg;
            Notify("HP_CHANGED");

            if (HP <= 0)
            {
                Notify("DEAD");
            }
        }

        public virtual void AddHP(int amount)
        {
            HP += amount;
            Notify("HP_CHANGED");
        }

        public virtual void UseMana(int amount)
        {
            MP -= amount;
            Notify("MP_CHANGED");
        }

        public virtual void AddMP(int amount)
        {
            MP += amount;
            Notify("MP_CHANGED");
        }

        public virtual void PerformAttack()
        {
            strategy?.ExecuteAttack();
        }

        public abstract void DisplayClass();
    }
}
