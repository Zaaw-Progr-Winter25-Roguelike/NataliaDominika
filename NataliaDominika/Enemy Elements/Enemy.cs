using NataliaDominika.Enemy_Elements.Enemy_Observer;
using NataliaDominika.Enemy_Elements.Enemy_Strategies;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NataliaDominika
{
    public abstract class Enemy
    {
        public int HP { get; protected set; } = 100;

        protected IEnemyBehavior behavior;
        protected List<IEnemyObserver> observers = new();

        public string EnemyName { get; protected set; }

        public ILoot LootDrop { get; protected set; }
        public int DropChance { get; protected set; }
        public float DistanceToPlayer { get; protected set; }
        public int Speed { get; protected set; }
        public IEnemyState currentState;

        public void SetBehavior(IEnemyBehavior newBehavior)
        {
            behavior = newBehavior;
        }
        public void AttachObserver(IEnemyObserver observer)
        {
            observers.Add(observer);
        }
        public void Notify(string eventType)
        {
            foreach (var obs in observers)
            {
                obs.OnEnemyEvent(this, eventType);
            }
        }

        public void TakeDamage(int dmg)
        {
            HP -= dmg;
            Notify("HP_CHANGED");

            if (HP <= 0)
            {
                Notify("DEAD");
            }
        }

        public void AddHP(int amount)
        {
            HP += amount;
            Notify("HP_CHANGED");
        }

        public virtual void PerformAction()
        {
            behavior?.ExecuteBehavior();

        }

        public abstract void Display();

        public void ChangeState(IEnemyState newState)
        {
            currentState?.Exit(this);
            currentState = newState;
            currentState.Enter(this);
        }
        public void UpdateState()
        {
            currentState?.Update(this);
        }

    }
}
