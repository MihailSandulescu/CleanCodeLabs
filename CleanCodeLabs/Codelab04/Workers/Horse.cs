using System;

namespace CleanCodeLabs.Codelab04.Workers
{
    public class Horse : Worker, ICanEat
    {
        public Horse(string name) : base(name)
        {
        }

        public override string Eat()
        {
            return "Eating some jummy hay!";
        }

        public override string Work()
        {
            return "Working like a true working horse";
        }
    }
}