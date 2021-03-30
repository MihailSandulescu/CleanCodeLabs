using System;
using CleanCodeLabs.Codelab04.Workers;

namespace CleanCodeLabs.Codelab04
{
    internal class Lunchroom
    {
        private readonly Worker[] _lunchers;

        public Lunchroom(Worker[] lunchers)
        {
            _lunchers = lunchers;
        }

        public void StartLunching()
        {
            foreach (var luncher in _lunchers)
            {
                // A required check because of our bad design :'(
                if (luncher.GetType() != typeof(Robot))
                {
                    Console.WriteLine(luncher.Eat());
                }
            }
        }
    }
}