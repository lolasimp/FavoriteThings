using System;

namespace Favorites.FavThings
{
    abstract class FavBase
    {
        protected readonly string _whichFood, _taste, _smell;

       // public string Food { get; protected set; }

        public FavBase(string whichFood, string taste, string smell)
        {
            _whichFood = whichFood;
            _taste = taste;
            _smell = smell;
        }

        public virtual void GetFood()
        {
            Console.WriteLine($"{ _whichFood} because ");
            Console.WriteLine($" it tastes {_taste}");
            Console.WriteLine($" and it's {_smell}.");
            Console.ReadLine();
        }
    }
}
