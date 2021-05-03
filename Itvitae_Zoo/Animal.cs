﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itvitae_Zoo
{
    abstract class Animal
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
