using ConsoleApp5;
using ConsoleApp5.Waves_Elements;
using System;

public class Program
{
    public static void Main()
    {
        // Wywołanie character
        CharacterFactory factory = new BeastmasterFactory();
        Character beastmaster = factory.CreateCharacter("wolftamer");
        //sorcerer = new HolyAura(sorcerer);

        beastmaster.SetStrategy(new NecromancyAttackStrategy());
        beastmaster.AttachObserver(new HPMPXPObserver());
        beastmaster = new HolyAura(beastmaster);

        beastmaster.DisplayClass();
        beastmaster.PerformAttack();

        beastmaster.TakeDamage(20);
        beastmaster.GainXP(50);
        beastmaster.UseMana(10);
        beastmaster = new ManaRegenUpdate(beastmaster);

        /*sorcerer = factory.CreateCharacter("firemage");
        sorcerer.SetStrategy(new FireBallAttackStrategy());
        sorcerer.AttachObserver(new HPMPXPObserver());

        sorcerer.DisplayClass();
        sorcerer.PerformAttack();*/

        /*sorcerer =  new ManaRegenUpdate(sorcerer);

        sorcerer.TakeDamage(20);
        sorcerer.GainXP(50);
        sorcerer.UseMana(10);*/


        // Wywołanie Enemy
        EnemyFactory enemyFactory = new MountainEnemyFactory();

        // Przykładowy przeciwnik z dekoratorem
        Enemy witch = enemyFactory.CreateEnemy("witch");
        witch.AttachObserver(new EnemyEventLogger());
        witch = new EnragedMutation(witch);

        witch.Display();
        witch.PerformAction();
        witch.TakeDamage(20);


        // ------------------------------
        // Fale wrogów (Composite)

        // Normalna fala
        NormalWave normalWave = new NormalWave(enemyFactory, 4);
        Console.WriteLine("\n-- Normal Wave --");
        normalWave.Spawn();
        normalWave.ScaleDifficulty(1.1f);
        normalWave.ExecuteCommand(new AttackCommand());
        normalWave.UpdateStates();

        // Fala elitarna
        EliteWave eliteWave = new EliteWave(enemyFactory);
        Console.WriteLine("\n-- Elite Wave --");
        eliteWave.Spawn();
        eliteWave.ScaleDifficulty(1.3f);
        eliteWave.ExecuteCommand(new AttackCommand());
        eliteWave.UpdateStates();

        // Fala boss + miniony
        BossWave bossWave = new BossWave(enemyFactory);
        Console.WriteLine("\n-- Boss Wave --");
        bossWave.Spawn();
        bossWave.ScaleDifficulty(1.5f);
        bossWave.ExecuteCommand(new AttackCommand());
        bossWave.UpdateStates();


    }
}