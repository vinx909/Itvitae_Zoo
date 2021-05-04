using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Itvitae_Zoo.Data;

namespace Itvitae_Zoo.ViewModels
{
    public class MainViewModel : ViewModelBaseClass
    {
        private ObservableCollection<AnimalViewModel> Animals;

        public void FeedElephants()
        {
            FeedAnimals<Elephant>();
        }
        public void FeedLions()
        {
            FeedAnimals<Lion>();
        }
        public void FeedMonkeys()
        {
            FeedAnimals<Monkey>();
        }
        public void FeedAllAnimals()
        {
            FeedAnimals<Animal>();
        }

        private void FeedAnimals<T>() where T : Animal
        {
            foreach(AnimalViewModel animal in Animals)
            {
                Animal maybeAnimal = animal.Animal as T;
                if(maybeAnimal != null)
                {
                    maybeAnimal.Eat();
                    RaiseProppertyChanged(nameof(maybeAnimal.Energy));
                }
            }
        }
    }
}
