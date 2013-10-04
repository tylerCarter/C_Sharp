// Add a methon to Building
using System;

namespace ICAO119
{
    class Building
    {
        public int Floors;      // number of floors
        public int Area;        // number of footage of building
        public int Occupants;   // number of occupants

        // Display the area per person.
        public void AreaPerPerson()
        {
            Console.WriteLine(" " + Area / Occupants + " area per person");
        }
    }

    // Use the AreaPerPerson() method.
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

            Console.WriteLine("house has:\n " +
                              house.Floors + " floors\n " +
                              house.Occupants + " occupants\n " +
                              house.Area + " total area");
            house.AreaPerPerson();

            Console.WriteLine();

            Console.WriteLine("office has:\n " +
                              office.Floors + " floors\n " +
                              office.Occupants + " occupants\n " +
                              office.Area + " total area");
            office.AreaPerPerson();
        }
    }
}

