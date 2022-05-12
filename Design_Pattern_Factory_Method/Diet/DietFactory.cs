using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern_Factory_Method.Diet
{
     class DietFactory
    {
        private DietBase creator { get; set; }

        public DietBase DietChosen(string baseMenu, int age, int wieght, double height)
        {
            if (age > 35 && wieght > 80 && height < 1.65)
            {
                Console.WriteLine("You need the Atkins diet");
                creator = new AtkinsCreator().CreateDiet(age, wieght, height);
                return creator;
            }
            if (wieght < 80 && age < 34 && height > 1.40)
            {
                Console.WriteLine("You need the Phleo diet");
                creator = new PhleoDietCreator().CreateDiet(age, wieght, height);
                return creator;
            }
            if ((age > 17 && age < 80) && wieght > 100 && height < 1.75) ;
            {
                Console.WriteLine("You need the Vegetarian diet");
                creator = new VegetarianDietCreator().CreateDiet(age, wieght, height);
                return creator;
            }
        }
    }
}
