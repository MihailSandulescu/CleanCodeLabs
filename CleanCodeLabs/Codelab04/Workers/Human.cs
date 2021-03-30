using System;

namespace CleanCodeLabs.Codelab04.Workers
{
    public class Human : Worker
    {
        public Human(string name) : base(name)
        {
        }

        public override string Eat()
        {
            return "Eating my 'bokes'";
        }

        public override string RechargeBatteries()
        {
            throw new NotImplementedException("A human does not have batteries to recharge");
        }

        public override string Work()
        {
            return "Doing some hard work, but I do get tired";
        }
    }
}