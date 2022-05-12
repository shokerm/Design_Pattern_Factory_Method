﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern_Factory_Method.Diet
{
    internal class VegetarianDiet : DietBase
    {
        public VegetarianDiet(int age, int wieght, double height) : base(age, wieght, height)
        {
        }
    }
}
