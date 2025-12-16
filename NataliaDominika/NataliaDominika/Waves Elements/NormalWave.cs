using NataliaDominika.Enemy_Elements.Enemy_factories___characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NataliaDominika.Waves_Elements
{
    public class NormalWave : WaveComposite
    {
        public NormalWave(EnemyFactory factory, int count)
        {
            for (int i = 0; i < count; i++)
            {
                Add(new EnemyLeaf(factory.CreateEnemy("toad")));
            }
        }
    }
}
