using System;
using CleanCodeLabs.Codelab04.Workers;

namespace CleanCodeLabs.Codelab04
{
    internal class BatteryRechargerFacility
    {
        public static void RechargeBatteriesOf(Worker[] rechargers)
        {
            foreach (var recharger in rechargers)
            {
                // A required check because of our bad design :'(
                if (recharger.GetType() == typeof(Robot))
                {
                    Console.WriteLine(recharger.RechargeBatteries());
                }
            }
        }
    }
}