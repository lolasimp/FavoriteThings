using System;

namespace Favorites.FavThings
{
    abstract class FavBase
    {
        protected readonly string _whichFood, _taste, _smell;

        public string Food { get; protected set; }
        public string WhichFood { get; }

        public FavBase(string whichFood, string taste, string smell)
        {
            _whichFood = whichFood;
            _taste = taste;
            _smell = smell;
        }

        protected FavBase(string v)
        {
        }

        public virtual void GetFood()
        {
            Console.WriteLine($"{ _whichFood} because ");
            Console.WriteLine($" it tastes {_taste}");
            Console.WriteLine($" and it's {_smell}.");
            Food = Console.ReadLine();
        }
    }
}
