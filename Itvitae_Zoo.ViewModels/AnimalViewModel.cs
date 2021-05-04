using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Itvitae_Zoo.Data;

namespace Itvitae_Zoo.ViewModels
{
    public class AnimalViewModel : ViewModelBaseClass
    {
        private Animal animal;
        public AnimalViewModel(Animal animal)
        {
            this.animal = animal;
        }

        public string Name
        {
            get => animal.Name;
            set
            {
                if(string.IsNullOrEmpty(value) == false && string.Equals(value, animal.Name))
                {
                    animal.Name = value;
                    RaiseProppertyChanged(nameof(Name));
                }
            }
        }

        public int Energy { get => animal.Energy; }

        internal Animal Animal { get => animal; }

        public void Eat()
        {
            animal.Eat();
            RaiseProppertyChanged(nameof(Energy));
        }
        public void UseEnergy()
        {
            animal.UseEnergy();
            RaiseProppertyChanged(nameof(Energy));
        }
    }
}
