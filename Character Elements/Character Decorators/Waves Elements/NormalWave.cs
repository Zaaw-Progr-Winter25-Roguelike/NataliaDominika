using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.Waves_Elements
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
