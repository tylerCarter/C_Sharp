// Add a Constructor to the Building Class
using System;

namespace ICAO131
{
    class Building
    {
        public int Floors;      // number of floors
        public int Area;        // total square footage of building
        public int Occupants;   // number of occupants

        // A parametrized constructor for Building.
        public Building(int f, int a, int o)
        {
            Floors = f;
            Area = a;
            Occupants = o;
        }

        // Return the area per person.
        public int AreaPerPerson()
        {
            return Area / Occupants;
        }

        // Return the maximum number of occupants if each
        // is to have at least the specified minimum area.
        public int MaxOccupants(int minArea)
        {
            return Area / minArea;
        }
    }

    // Use the parametrized Building constructor.
    class Program
    {
        static void Main()
        {
            Building house = new Building(2, 2500, 4);
            Building office = new Building(3, 4200, 25);

            Console.WriteLine("Maximum occupants for house if each has " +
                              300 + " square feet: " +
                              house.MaxOccupants(300));

            Console.WriteLine("Maximum occupants for office if each has " +
                              300 + " square feet: " +
                              office.MaxOccupants(300));
        }
    }
}


