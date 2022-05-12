using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern_Factory_Method.Diet
{
    abstract class DietCreator
    {
        public abstract DietBase CreateDiet(int age, int wieght, double height);
    }
}
