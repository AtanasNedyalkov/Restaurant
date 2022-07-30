
namespace Restaurant
{
    public class Cake : Dessert
    {
        //· Grams = 250

        //· Calories = 1000

        //· CakePrice = 5
        public const double CakeGrams = 250;
        public const double CakeCalories = 1000;
        public const decimal CakePrice = 5.0m;
        public Cake(string name, decimal price, double grams, double calories) : base(name, CakePrice, CakeGrams, CakeCalories)
        {

        }
    }
}
