using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using static System.Console;
namespace CarClass
{
    public class Garage
    {
        private List<Car> myCars;

        protected static int NumberOfCars;

        public Garage()
        {
            myCars = new List<Car>();

        }

        public void AddCarToGarage(Car newCar)
        {
            myCars.Add(newCar);
            NumberOfCars++;
        }

        public Car PickCar(Garage garage)
        {
            Printing.Title();
            Write("> Please Enter the Model you want to drive: ");
            string userResponse = Console.ReadLine().Trim();

            if (myCars.Count == 0)
            {
                Write("\n> The Garage is Empty... Please Add a Car!!! ");
                ReadLine();
                World.Selection(garage);
            }
            else
            {
                for (int i = 0; i < myCars.Count; i++)
                {
                    if (myCars[i].GetModel() == userResponse)
                    {
                        Car selectedCar = myCars[i];
                        return selectedCar;
                    }
                }
            }

            Write("\n> That car was not found! Please Try again");
            ReadKey();
            return PickCar(garage);

        }

        public void DisplayCars()
        {
            if (myCars.Count == 0)
            {
                WriteLine("\n> The Garage is Empty... Please Add a Car!!! ");
            }
            else
            {
                foreach (var cars in myCars)
                {
                    cars.DisplayCar();
                    Thread.Sleep(500);
                }
            }

        }

    }
}

