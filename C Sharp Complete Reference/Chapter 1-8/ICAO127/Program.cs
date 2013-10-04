/*
    Add a parametrized method that computes the
    maximum number of people that can occupy a
    building assuming each needs a specified
    minimum space.
*/

using System;

namespace ICAO127
{
    class Building
    {
        public int Floors;      // number of floors
        public int Area;        // total square footage of building
        public int Occupants;   // number of occupants

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

    // Use MaxOccupant() method.
    class Program
    {
        static void Main()
        {
            Building house = new Building();
            Building office = new Building();

            // Assign values to fields in house.
            house.Occupants = 4;
            house.Area = 2500;
            house.Floors = 2;

            // Assign values to fields in office.
            office.Occupants = 25;
            office.Area = 4200;
            office.Floors = 3;

            Console.WriteLine("Maximum occupants for house if each has " +
                              300 + " square feet: " +
                              house.MaxOccupants(300));

            Console.WriteLine("Maximum occupants for office if each has " +
                              300 + " square feet: " + 
                              office.MaxOccupants(300));
        }
    }
}

