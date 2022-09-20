using System;
using static System.Console;
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

        public void PickCar()
        {
            Write("Please Enter the Model you want to drive: ");
            string userResponse = Console.ReadLine().Trim();
            foreach (var car in myCars)
            {
                if (car.GetModel() == userResponse)
                {
                    car.DisplayCar();

                }
            }

            ReadLine();
        }

        public void DisplayCars()
        {
            if (myCars.Count == 0)
            {
                WriteLine("> The Garage is Empty... Please Add a Car!!! ");
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

