using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NataliaDominika.Enemy_Elements.Enemy_factories___characters.Mountains
{
    public class MountainEnemyFactory : EnemyFactory
    {
        public override Enemy CreateEnemy(string subtype)
        {
            return subtype.ToLower() switch
            {
                "caveharpy" => new CaveHarpy(),
                "roc" => new Roc(),
                "stonehidetroll" => new StonehideTroll(),
                _ => throw new Exception("Unknown mountain enemy type.")
            };
        }
    }
}
