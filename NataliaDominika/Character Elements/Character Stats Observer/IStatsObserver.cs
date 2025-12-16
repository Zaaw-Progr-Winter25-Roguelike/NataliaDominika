using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NataliaDominika.Character_Elements.Character_Stats_Observer
{
    public interface IStatsObserver
    {
        void OnStatsChanged(Character c, string eventType);
    }
}
