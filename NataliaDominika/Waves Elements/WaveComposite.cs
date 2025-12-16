using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NataliaDominika.Waves_Elements
{
    public class WaveComposite : IWaveComponent
    {
        private List<IWaveComponent> components = new();

        public void Add(IWaveComponent comp)
        {
            components.Add(comp);
        }

        public void Spawn()
        {
            foreach (var c in components)
                c.Spawn();
        }

        public void ExecuteCommand(ICommand command)
        {
            foreach (var c in components)
                c.ExecuteCommand(command);
        }
        public void UpdateStates()
        {
            foreach (var c in components)
            {
                if (c is EnemyLeaf leaf)
                    leaf.UpdateStates();
                else if (c is WaveComposite comp)
                    comp.UpdateStates();
            }
        }
        public void ScaleDifficulty(float factor)
        {
            foreach (var c in components)
                c.ScaleDifficulty(factor);
        }
    }
}
