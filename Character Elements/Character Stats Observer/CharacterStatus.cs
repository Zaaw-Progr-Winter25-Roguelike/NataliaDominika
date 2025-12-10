using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.Character_Elements
{
    public class CharacterStatus
    {
        public enum StatusType
        {
            Alive,
            Dead,
            Stunned,
            Poisoned
        }

        private StatusType status;
        private readonly Character owner;

        public CharacterStatus(Character owner)
        {
            this.owner = owner;
            status = StatusType.Alive; 
        }

        public StatusType Status
        {
            get => status;
            set
            {
                if (status != value)
                {
                    status = value;
                    owner.Notify("STATUS_CHANGED");
                }
            }
        }

        public bool IsDead => status == StatusType.Dead;
        public bool IsAlive => status == StatusType.Alive;
    }
}
