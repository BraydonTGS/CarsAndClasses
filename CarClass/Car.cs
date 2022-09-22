using System;
using static System.Console;


namespace CarClass
{
    public class Car
    {
        private string Make;
        private string Model;
        private int Year;
        private int Miles;
        private string CarColor;
        private bool NeedsGas;
        private bool IsDirty;
        private ConsoleColor Color = ConsoleColor.Green;

        public Car(string make, string model, int year, int miles, string carColor)
        {
            Make = make;
            Model = model;
            Make = make;
            Year = year;
            Miles = miles;
            CarColor = carColor;
            NeedsGas = false;
            IsDirty = false;
        }

        public string GetModel()
        {
            return Model;
        }
        public string GetMake()
        {
            return Make;
        }
        public string GetColor()
        {
            return CarColor;
        }

        public void DisplayCar()
        {
            ConsoleColor prevColor = ForegroundColor;
            ForegroundColor = Color;
            WriteLine("\n=======================");
            WriteLine($"> Make: {Make}");
            WriteLine($"> Model: {Model}");
            WriteLine($"> Year: {Year}");
            WriteLine($"> Miles: {Miles}");
            WriteLine($"> Color: {CarColor}");
            WriteLine("=======================");
            ForegroundColor = prevColor;
        }

        public void Wash()
        {
            if (IsDirty)
            {
                WriteLine("\n> Your car is spotless now...");
                ReadKey();
                IsDirty = false;
            }
            else
            {
                WriteLine("\n> Your car is already clean! ");
                ReadKey();
            }

        }

        public void Drive()
        {
            if (!NeedsGas)
            {
                WriteLine("\n>What a beautiful drive to the mountains! ");
                WriteLine("\n>The car is filthy now! ");
                ReadKey();
                NeedsGas = true;
                IsDirty = true;

            }
            else
            {
                WriteLine("\n>The car is out of gas. You need to fill up first! ");
            }

        }

        public void GetGas()
        {
            if (NeedsGas)
            {
                WriteLine("\n>Dang! Gas is expensive... but you have a full tank now.");
                ReadKey();
                NeedsGas = false;
            }
            else
            {
                WriteLine("\n> You already have a full tank!!!");
                ReadKey();
            }
        }

        public void Park(Car car, Garage garage)
        {
            if (!NeedsGas && !IsDirty)
            {
                WriteLine("\n> You put the car back in the garage! ");
                ReadKey();
                World.DisplayCars(garage);
            }
            else if (IsDirty)
            {
                WriteLine("\n> You can't put the car away when it is dirty! ");
                ReadKey();
            }
            else if (NeedsGas)
            {
                WriteLine("\n> Please fill up your tank first! ");
                ReadKey();
            }

        }
    }
}



