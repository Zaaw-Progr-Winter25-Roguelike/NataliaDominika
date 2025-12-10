using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.Waves_Elements
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
