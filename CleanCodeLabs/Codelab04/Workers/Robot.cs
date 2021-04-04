using System;

namespace CleanCodeLabs.Codelab04.Workers
{
    public class Robot : Worker
    {
        public Robot(string name) : base(name)
        {
        }

        public override string RechargeBatteries()
        {
            return "RECHARGING BATTERIES, BEEP";
        }

        public override string Work()
        {
            return "DOING SO MUCH WORK, BEEP";
        }
    }
}