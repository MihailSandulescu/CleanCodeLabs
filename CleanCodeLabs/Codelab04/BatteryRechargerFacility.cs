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
                Console.Write(recharger.RechargeBatteries());
                if(recharger.RechargeBatteries() != null)
                {
                    Console.WriteLine("");
                }
            }
        }
    }
}