using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern_Factory_Method
{
    abstract class DietBase
    {
        public string BaseMenu { get; set; }
        public int Age { get; set; }
        public int Wieght { get; set; }
        public double Height { get; set; }

        protected DietBase(int age, int wieght, double height)
        {
            
            Age = age;
            Wieght = wieght;
            Height = height;
        }
    }
}
