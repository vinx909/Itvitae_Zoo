namespace Itvitae_Zoo.Data
{
    public abstract class Animal
    {
        private const int energyInitial = 100;
        private const int energyAddition = 25;

        public string Name { get; set; }
        public int Energy { get; set; }

        protected Animal()
        {
            Energy = energyInitial;
        }

        public void Eat()
        {
            Energy += energyAddition;
        }

        public abstract void UseEnergy();
    }
}
