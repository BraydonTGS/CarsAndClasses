using System;
using static System.Console;


namespace CarClass
{
    public class Car
    {
        private string Model;
        private string Make;
        private int Year;
        private int Miles;
        private string CarColor;
        private bool NeedsGas;
        private ConsoleColor Color = ConsoleColor.Green;

        public Car(string model, string make, int year, int miles, string carColor)
        {
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



