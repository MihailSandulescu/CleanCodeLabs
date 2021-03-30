namespace CleanCodeLabs.Codelab04.Workers
{
    public abstract class Worker
    {
        protected Worker(string name)
        {
            Name = name;
        }

        public string Name { get; }

        public abstract string Work();

        public abstract string Eat();

        public abstract string RechargeBatteries();
    }
}