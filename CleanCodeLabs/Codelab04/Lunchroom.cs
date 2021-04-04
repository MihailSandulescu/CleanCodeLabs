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
                Console.Write(luncher.Eat());
                if(luncher.Eat() != null)
                {
                    Console.WriteLine("");
                }
            }
        }
    }
}