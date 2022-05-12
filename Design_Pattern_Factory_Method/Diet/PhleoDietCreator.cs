using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern_Factory_Method.Diet
{
    internal class PhleoDietCreator : DietCreator
    {
        public override DietBase CreateDiet(int age, int wieght, double height)
        {
            return new PaleoDiet(age, wieght, height);
        }
    }
}
