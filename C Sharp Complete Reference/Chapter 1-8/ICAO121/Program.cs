// Returns value from AreaPerPerson().
using System;

namespace ICAO119
{
    class Building
    {
        public int Floors;      // number of floors
        public int Area;        // number of footage of building
        public int Occupants;   // number of occupants

        // Return the area per person.
        public int AreaPerPerson()
        {
            return Area / Occupants;
        }
    }

    // Use the AreaPerPerson() method.
    class Program
    {
        static void Main()
        {
            Building house = new Building();
            Building office = new Building();
            int areaPP; // area per person

            // Assign values to fields in house.
            house.Occupants = 4;
            house.Area = 2500;
            house.Floors = 2;

            // Assign values to fields in office.
            office.Occupants = 25;
            office.Area = 4200;
            office.Floors = 3;

            // Obrain area per person for house.
            areaPP = house.AreaPerPerson();

            Console.WriteLine("house has:\n " +
                              house.Floors + " floors\n " +
                              house.Occupants + " occupants\n " +
                              house.Area + " total area\n " +
                              areaPP + " area per person");

            Console.WriteLine();

            // Obrain area per person for office.
            areaPP = office.AreaPerPerson();

            Console.WriteLine("office has:\n " +
                              office.Floors + " floors\n " +
                              office.Occupants + " occupants\n " +
                              office.Area + " total area\n " +
                              areaPP + " area per person");
        }
    }
}

