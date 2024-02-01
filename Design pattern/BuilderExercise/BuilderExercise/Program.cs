using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderExercise
{
    public class MainApp
    {
        public static void Main()
        {
            MealCombo combo;
            shop shop1= new shop();

            combo = new VegCombo();
            shop1.Construct(combo);
            combo.Meal.Show();

            combo=new NvCombo();
            shop1.Construct(combo);
            combo.Meal.Show();
        }
    }
    class shop
    {
        public void Construct(MealCombo mealCombo)
        {
            mealCombo.BurgerType();
            mealCombo.DessertType ();
            mealCombo.DrinkType ();
            mealCombo.ToyType ();
        }
    }
    abstract class MealCombo
    {
        protected Meal meal;
        public Meal Meal { get { return meal; } }
        public abstract void BurgerType();
        public abstract void DrinkType();
        public abstract void DessertType();
        public abstract void ToyType();


    }
    class VegCombo : MealCombo
    {
        public VegCombo()
        {
            meal = new Meal("Veg");
        }
        public override void BurgerType()
        {
            meal["Burger"] = "Paneer burger";
        }

        public override void DessertType()
        {
            meal["Dessert"] = "Donut";
        }

        public override void DrinkType()
        {
            meal["Drink"] = "Pepsi";
        }

        public override void ToyType()
        {
            meal["Toy"] = "Car";
        }
    }
    class NvCombo : MealCombo
    {
        public NvCombo()
        {
            meal = new Meal("Non veg");
        }
        public override void BurgerType()
        {
            meal["Burger"] = "Chicken burger";
        }

        public override void DessertType()
        {
            meal["Dessert"] = "Pie";
        }

        public override void DrinkType()
        {
            meal["Drink"] = "Coke";
        }

        public override void ToyType()
        {
            meal["Toy"] = "Plane";
        }
    }
    class Meal
    {
        private string _mealType;
        private Dictionary<string, string> _items = new Dictionary<string, string>();
        public Meal(string mealType)
        {
            this._mealType = mealType;
        }
        public string this[string key]
        {
            get { return _items[key]; }
            set
            {
                _items[key] = value;
            }
        }
        public void Show()
        {
            Console.WriteLine("===========================");
            Console.WriteLine("Burger:{0}", _items["Burger"]);
            Console.WriteLine("Drink:{0}", _items["Drink"]);
            Console.WriteLine("Dessert:{0}", _items["Dessert"]);
            Console.WriteLine("Toy:{0}", _items["Toy"]);

        }



    }
}
