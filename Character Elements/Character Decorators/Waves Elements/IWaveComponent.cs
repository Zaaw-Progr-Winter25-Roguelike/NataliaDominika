using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ConsoleApp5.Waves_Elements
{
    public interface IWaveComponent
    {
        void Spawn();
        void ExecuteCommand(ICommand command);
        void UpdateStates();
        void ScaleDifficulty(float factor);
    }
}
