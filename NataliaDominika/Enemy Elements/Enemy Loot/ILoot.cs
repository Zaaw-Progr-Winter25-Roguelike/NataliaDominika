using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NataliaDominika.Enemy_Elements.Enemy_Loot
{
    public interface ILoot
    {
        string Name { get; }
        int Value { get; }
    }
}
