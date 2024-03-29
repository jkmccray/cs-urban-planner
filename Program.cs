﻿using System;
using System.Collections.Generic;

namespace Planner
{
    class Program
    {
        static void Main(string[] args)
        {
            City Metropolis = new City();

            Building FiveOneTwoEigth = new Building("512 8th Avenue") {

            };
            FiveOneTwoEigth.Width = 150.5;
            FiveOneTwoEigth.Depth = 50.2;
            FiveOneTwoEigth.Stories = 10;
            FiveOneTwoEigth.Construct();
            FiveOneTwoEigth.Purchase("Andy");
            Metropolis.AddBuilding(FiveOneTwoEigth);

            Building Office = new Building("301 Plus Park Blvd");
            Office.Width = 100.8;
            Office.Depth = 75.4;
            Office.Stories = 13;
            Office.Construct();
            Office.Purchase("Steve");
            Metropolis.AddBuilding(Office);

            Building School = new Building("100 Education Way");
            School.Width = 50.7;
            School.Depth = 72.6;
            School.Stories = 2;
            School.Construct();
            School.Purchase("Nashville Metro");
            Metropolis.AddBuilding(School);

            // Metropolis.PrintCityInfo();

            foreach (Building building in Metropolis.Buildings)
            {
                building.PrintBuildingInfo();
            }
        }
    }
}
