namespace CleanCodeLabs.Codelab04.Workers
{
    public abstract class Worker : ICanEat, IChargeable
    {
        protected Worker(string name)
        {
            Name = name;
        }

        public string Name { get; }

        public abstract string Work();

        public virtual string Eat()
        {
            return null;
        }

        public virtual string RechargeBatteries()
        {
            return null;
        }
    }
}