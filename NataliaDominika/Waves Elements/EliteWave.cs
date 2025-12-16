using NataliaDominika.Enemy_Elements.Enemy_Decorator___mutations;
using NataliaDominika.Enemy_Elements.Enemy_factories___characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NataliaDominika.Waves_Elements
{
    internal class EliteWave : WaveComposite
    {
        public EliteWave(EnemyFactory factory)
        {
            var elite = factory.CreateEnemy("witch");
            elite = new EnragedMutation(elite);
            Add(new EnemyLeaf(elite));
        }
    }
}
