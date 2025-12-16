using NataliaDominika.Enemy_Elements.Enemy_factories___characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NataliaDominika.Waves_Elements
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
