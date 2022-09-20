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
        private ConsoleColor Color = ConsoleColor.Green;

        public Car(string make, string model, int year, int miles, string carColor)
        {
            Make = make;
            Model = model;
            Make = make;
            Year = year;
            Miles = miles;
            CarColor = carColor;
            NeedsGas = true;
            //Color = color;
        }

        public string GetModel()
        {
            return Model;
        }

        public void DisplayCar()
        {
            ConsoleColor prevColor = ForegroundColor;
            ForegroundColor = Color;
            WriteLine($"\n> Model: {Model}");
            WriteLine($"> Make: {Make}");
            WriteLine($"> Year: {Year}");
            WriteLine($"> Miles: {Miles}");
            WriteLine($"> Color: {CarColor}");
            ForegroundColor = prevColor;
        }

        public void Drive()
        {

        }

        public void GetGas()
        {

        }
    }
}



