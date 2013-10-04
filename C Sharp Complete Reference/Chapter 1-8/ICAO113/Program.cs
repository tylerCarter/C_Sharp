// A program that uses Building class.

using System;

namespace ICAO113
{
    class Building
    {
        public int Floors;      // number of floors.
        public int Area;        // total square footage of building.
        public int Occupants;   // number of occupants.
    }

    // This class declares an object of type Building.
    class Program
    {
        static void Main()
        {
            Building house = new Building(); // Create a Building object.
            int areaPP; // area per person

            // Assign values to fields in house.
            house.Occupants = 4;
            house.Area = 2500;
            house.Floors = 2;

            // Compute the area per person.
            areaPP = house.Area / house.Occupants;

            Console.WriteLine("house has:\n " +
                              house.Floors + " floors\n " +
                              house.Occupants + " occupants\n " +
                              house.Area + " total area\n " +
                              areaPP + " area per person");
        }
    }
}
