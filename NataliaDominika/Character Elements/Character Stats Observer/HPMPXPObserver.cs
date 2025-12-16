using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NataliaDominika.Character_Elements.Character_Stats_Observer
{
    public class HPMPXPObserver : IStatsObserver
    {
        /*public void OnStatsChanged(Character c, string eventType)
        {
            if (eventType == "DEAD")
                Console.WriteLine($"Umarłeś!");

            if (eventType == "HP_CHANGED")
                Console.WriteLine($"{c.ClassName} HP: {c.HP}");

            if (eventType == "XP_CHANGED")
                Console.WriteLine($"{c.ClassName} XP: {c.XP}");

            if (eventType == "MP_CHANGED")
                Console.WriteLine($"{c.ClassName} MP: {c.MP}");
        }*/
        public void OnStatsChanged(Character c, string eventType)
        {
            var message = eventType switch
            {
                "DEAD" => "Umarłeś!",
                "HP_CHANGED" => $"{c.ClassName} HP: {c.HP}",
                "XP_CHANGED" => $"{c.ClassName} XP: {c.XP}",
                "MP_CHANGED" => $"{c.ClassName} MP: {c.MP}",
                _ => null
            };

            if (message != null)
                Console.WriteLine(message);
        }
    }
}
