using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NataliaDominika.Enemy_Elements.Enemy_factories___characters.Woods
{
    public class WoodsEnemyFactory : EnemyFactory
    {
        public override Enemy CreateEnemy(string subtype)
        {
            return subtype.ToLower() switch
            {
                "treanthorror" => new TreantHorror(),
                "mossgoblin" => new MossGoblin(),
                "werewolf" => new Werewolf(),
                _ => throw new Exception("Unknown woods enemy type.")
            };
        }
    }
}
