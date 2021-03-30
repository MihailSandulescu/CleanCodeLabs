using System;
using CleanCodeLabs.Codelab04.Workers;

namespace CleanCodeLabs.Codelab04
{
    public class FactoryHall
    {
        private readonly Worker[] _workers;

        public FactoryHall(Worker[] workers)
        {
            _workers = workers;
        }

        public void StartWorking()
        {
            // WORK
            foreach (var worker in _workers)
            {
                Console.WriteLine(worker.Work());
            }

            // EAT
            new Lunchroom(_workers).StartLunching();

            // RECHARGE BATTERIES
            BatteryRechargerFacility.RechargeBatteriesOf(_workers);
        }
    }
}