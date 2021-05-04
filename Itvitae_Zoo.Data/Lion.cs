namespace Itvitae_Zoo.Data
{
    public sealed class Lion : Animal
    {
        private const string nameLion = "Lion";
        private const int energyAddition = 50;
        private const int energyUse = 10;

        public Lion()
        {
            Name = nameLion;
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
