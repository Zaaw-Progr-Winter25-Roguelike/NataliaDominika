using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.Waves_Elements
{
    public class BossWave : WaveComposite
    {
        public BossWave(EnemyFactory factory)
        {
            var boss = factory.CreateEnemy("drowned man");
            Add(new EnemyLeaf(boss));

            for (int i = 0; i < 3; i++)
                Add(new EnemyLeaf(factory.CreateEnemy("toad")));
        }
    }
}
