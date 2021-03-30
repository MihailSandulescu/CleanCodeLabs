using System;

namespace CleanCodeLabs.Codelab04.Workers
{
    public class Horse : Worker
    {
        public Horse(string name) : base(name)
        {
        }

        public override string Eat()
        {
            return "Eating some jummy hay!";
        }

        public override string RechargeBatteries()
        {
            throw new NotImplementedException("Animals don't have batteries to reload...");
        }

        public override string Work()
        {
            return "Working like a true working horse";
        }
    }
}