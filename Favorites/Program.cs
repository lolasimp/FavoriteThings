using System;
using Favorites.FavThings;

namespace Favorites
{
    class Program
    {
        static void Main(string[] args)
        {
            var fav1 = new Ceviche();
            var fav2 = new MoiMoi();
            var fav3 = new Calamari();
            var fav4 = new GummyBears();

            var favThings = new FavBase[] { fav1, fav2, fav3, fav4};
            foreach (var food in favThings)
            {
                food.GetFood();
            }

            Console.WriteLine("All done! Press Enter to leave.");
            Console.ReadLine();
        }
    }
}
