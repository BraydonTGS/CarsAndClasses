﻿using System;
namespace CarClass
{
    public class Garage
    {
        private List<Car> myCars;

        public Garage()
        {
            myCars = new List<Car>();

        }

        public void AddCarToGarage(Car newCar)
        {
            myCars.Add(newCar);
        }

        public void DisplayCars()
        {
            if (myCars.Count == 0)
            {
                Console.WriteLine("The Garage is Empty... Please Add a Car!!! ");
            }
            else
            {
                foreach (var cars in myCars)
                {
                    cars.DisplayCar();
                }
            }

        }


    }
}

