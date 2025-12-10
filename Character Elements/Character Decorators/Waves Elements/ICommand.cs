using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.Waves_Elements
{
    public interface ICommand
    {
        void Execute(Enemy enemy);
    }
}
