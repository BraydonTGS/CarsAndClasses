using System;
using static System.Console;
namespace CarClass
{
    public class World
    {
        public static void Run()
        {
            Printing.Title();
            Write("> Press Any Key to Continue: ");
            ReadLine();
            Printing.UserSelection();
            string userSelection = ReadLine();

            ReadLine();


        }
    }
}

