using System;
using Design_Pattern_Factory_Method.Diet;
namespace Design_Pattern_Factory_Method
{
    public class Program
    {
        static void Main(string[] args)
        {
            DietFactory d1 = new DietFactory();
            d1.DietChosen("moshe", 36, 85, 1.60);
            DietFactory d2 = new DietFactory();
            d2.DietChosen("yosi", 30, 60, 1.50);
            DietFactory d3 = new DietFactory();
            d3.DietChosen("reuvan", 20, 102, 1.70);

            



        }
    }
}
