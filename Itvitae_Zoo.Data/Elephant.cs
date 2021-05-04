namespace Itvitae_Zoo.Data
{
    public sealed class Elephant : Animal
    {
        private const string nameElephant = "Elephant";
        private const int energyAddition = 25;
        private const int energyUse = 5;

        public Elephant()
        {
            Name = nameElephant;
        }

        public new void Eat()
        {
            Energy += energyAddition;
        }

        public override void UseEnergy()
        {
            Energy -= energyUse;
        }
    }
}
