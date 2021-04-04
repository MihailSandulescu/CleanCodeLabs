using System;

namespace CleanCodeLabs.Codelab04.Workers
{
    public class Human : Worker, ICanEat
    {
        public Human(string name) : base(name)
        {
        }

        public override string Eat()
        {
            return "Eating my 'bokes'";
        }

        public override string Work()
        {
            return "Doing some hard work, but I do get tired";
        }
    }
}