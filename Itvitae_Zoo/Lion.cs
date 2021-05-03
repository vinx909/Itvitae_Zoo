﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itvitae_Zoo
{
    sealed class Lion : Animal
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
