using System;
using System.Collections.Generic;

namespace IceCreamShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Case menu = new Case();
            List<Flavor> availableFlavors = menu.Flavors;
            List<Cone> availableCones = menu.Cones;

            // TODO: Use a Comparer class to sort the 'flavors' array alphabetically by the 'name'
            //  field.
            FlavorComparer comparer = new FlavorComparer();

            // TODO: Use a Comparator class to sort the 'cones' array in increasing order by the 'cost'
            //  field.
            availableFlavors.Sort(comparer);

            availableCones.Sort(new ConeComparer());


            //availableFlavors.Sort(new FlavorComparer());

            // TODO: Print the 'flavors' and 'cones' lists (in a clear manner) to verify the sorting.
            foreach (var flavor in availableFlavors)
            {
                Console.WriteLine(flavor.Name);
            }

            availableCones.ForEach(Console.WriteLine);
        }
    }
}
