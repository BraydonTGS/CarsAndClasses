using System;
using static System.Console;


namespace CarClass
{
    public class Car
    {
        private string Model;
        private string Make;
        private int Year;
        private string CarColor;
        private ConsoleColor Color;

        public Car(string model, string make, int year, string carColor, ConsoleColor color)
        {
            Model = model;
            Make = make;
            Year = year;
            CarColor = carColor;
            Color = color;
        }

        public void DisplayCar()
        {
            ConsoleColor prevColor = ForegroundColor;
            ForegroundColor = Color;
            WriteLine($"\n>Model: {Model}");
            WriteLine($">Year: {Year}");
            WriteLine($">Color: {CarColor}");
            ForegroundColor = prevColor;
        }
    }
}



