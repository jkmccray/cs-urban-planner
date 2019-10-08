using System;
using System.Collections.Generic;

namespace Planner
{
    class City
    {
        public City()
        {
            _year = DateTime.Now.Year;
        }

        private string _name = "Metropolis";
        private string _mayor = "Jacquelyn McCray";
        private int _year;
        public List<Building> Buildings { get; set; }
        public void AddBuilding(Building building)
        {
            Buildings.Add(building);
        }
        public void PrintCityInfo()
        {
            Console.WriteLine($"City Name: {_name}");
            Console.WriteLine($"Established: {_year}");
            Console.WriteLine($"Mayor: {_mayor}");
        }
    }
}