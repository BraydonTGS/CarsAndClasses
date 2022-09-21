using System;
using System.Drawing;
using static System.Console;
namespace CarClass
{
    public class World
    {

        public static void Start()
        {
            Printing.Title();
            Printing.PrintCarThree();
            Garage myGarage = new Garage();
            Write("> Press Any Key to Continue: ");
            ReadLine();
            Selection(myGarage);
        }

        public static void Selection(Garage garage)
        {
            Printing.UserSelection();
            string userSelection = ReadLine();
            switch (userSelection)
            {
                case "1":
                    AddCar(garage);
                    break;
                case "2":
                    DisplayCars(garage);
                    break;
                case "3":
                    SelectCar(garage);
                    break;
                case "4":
                    Exit();
                    break;
                default:
                    Error(garage);
                    break;
            }
            ReadLine();
        }

        public static void AddCar(Garage garage)
        {
            Printing.Title();
            Printing.PrintCarTwo();

            Write("> Please Enter the Make: ");
            string make = ReadLine().Trim();
            Write("\n> Please Enter the Model: ");
            string model = ReadLine().Trim();
            Write("\n> Please Enter the Year: ");
            bool parse = int.TryParse(ReadLine(), out int year);
            if (!parse)
            {
                Printing.InvalidSelection();
                AddCar(garage);
            }
            Write("\n> Please Enter the Number of Miles: ");
            bool parse2 = int.TryParse(ReadLine(), out int miles);
            if (!parse2)
            {
                Printing.InvalidSelection();
                AddCar(garage);
            }
            Write("\n> Please Enter the Color: ");
            string color = ReadLine().Trim();
            Car newCar = new Car(make, model, year, miles, color);
            garage.AddCarToGarage(newCar);
            Thread.Sleep(1500);
            newCar.DisplayCar();
            Write("\n> Car Added! Press Enter to Continue: ");
            ReadKey();
            Selection(garage);
        }

        public static void DisplayCars(Garage garage)
        {
            Printing.Title();
            WriteLine("\n> In the Garage: ");
            garage.DisplayCars();
            Write("\n> Press Enter to go back: ");
            ReadKey();
            Selection(garage);
        }

        public static void SelectCar(Garage garage)
        {
            var selectedCar = garage.PickCar(garage);
            Printing.Title();
            Thread.Sleep(1500);
            Spin(selectedCar, garage);
        }

        public static void Spin(Car myCar, Garage garage)
        {
            Printing.Title();
            myCar.DisplayCar();
            Write($"\n>You want to take out the {myCar.GetColor()}, {myCar.GetMake()}:{myCar.GetModel()}? (Y/N) ");
            string userSelection = ReadLine().Trim().ToUpper();
            switch (userSelection)
            {
                case "Y":
                    Printing.TripSelection();
                    break;
                case "N":
                    Selection(garage);
                    break;
                default:
                    Printing.InvalidSelection();
                    Spin(myCar, garage);
                    break;
            }
            ReadKey();

        }

        public static void Exit()
        {
            Environment.Exit(0);
        }

        public static void Error(Garage garage)
        {
            Printing.InvalidSelection();
            Selection(garage);

        }
    }
}

