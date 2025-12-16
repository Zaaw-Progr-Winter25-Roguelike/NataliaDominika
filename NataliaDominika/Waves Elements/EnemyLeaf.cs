using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace NataliaDominika.Waves_Elements
{
    public class EnemyLeaf : IWaveComponent
    {
        public Enemy Enemy { get; private set; }

        public EnemyLeaf(Enemy enemy)
        {
            Enemy = enemy;
        }
        public void Spawn()
        {
            Console.WriteLine($"Spawn -> {Enemy.EnemyName}");
            Enemy.Display();
        }

        public void ExecuteCommand(ICommand command)
        {
            command.Execute(Enemy);
        }
        public void UpdateStates()
        {
            Enemy.UpdateState();
        }

        public void ScaleDifficulty(float factor)
        {
            // Zwiększamy HP przeciwnika w zależności od współczynnika
            Enemy.AddHP((int)(Enemy.HP * (factor - 1)));
        }
    }
}
