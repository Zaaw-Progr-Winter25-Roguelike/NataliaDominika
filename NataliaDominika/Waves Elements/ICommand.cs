using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NataliaDominika.Waves_Elements
{
    public interface ICommand
    {
        void Execute(Enemy enemy);
    }
}
