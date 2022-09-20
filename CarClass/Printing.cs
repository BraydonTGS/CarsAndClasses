using System;
using static System.Console;
namespace CarClass
{
    public class Printing
    {
        public static void Title()
        {
            Clear();
            WriteLine(@" +-+-+-+-+-+ +-+ +-+-+-+-+-+-+
 |B|u|i|l|d| |a| |G|a|r|a|g|e|
 +-+-+-+-+-+ +-+ +-+-+-+-+-+-+");
            WriteLine();
        }

        public static void UserSelection()
        {
            Clear();
            Title();
            WriteLine(">Please Select From the Following Options: ");
            WriteLine("\n>1. Add a new Car: ");
            WriteLine(">2. Display your Cars: ");
            WriteLine(">3. Exit");
        }

        public static void InvalidSelection()
        {
            Printing.Title();
            WriteLine("\nPlesase Enter a Valid Selection! ");
            Write("\nPress Enter to Continue. ");
            ReadKey();
        }

        public static void PrintCar()
        {
            WriteLine(@"              ____----------- _____
\~~~~~~~~~~/~_--~~~------~~~~~     \
 `---`\  _-~      |                   \
   _-~  <_         |                     \[]
 / ___     ~~--[""] |      ________-------'_
> /~` \    |-.   `\~~.~~~~~                _ ~ - _
 ~|  ||\%  |       |    ~  ._                ~ _   ~ ._
   `_//|_%  \      |          ~  .              ~-_   /\
          `--__     |    _-____  /\               ~-_ \/.
               ~--_ /  ,/ -~-_ \ \/          _______---~/
                   ~~-/._<   \ \`~~~~~~~~~~~~~     ##--~/
                         \    ) |`------##---~~~~-~  ) )
                          ~-_/_/                  ~~ ~~");
            WriteLine();


        }

        public static void PrintCarTwo()
        {
            WriteLine(@"                  _________________
              _.-'_____  _________ _`.
            .` ,'      ||         | `.`.
          .` ,'        ||         |   `.`.
        .`  /          ||         |  ,' ] `....___
      _`__.'''''''''''''''''''''''`''''''''|..___ `-.._
    .'                  [='                '     `'-.._`.
 ,:/.'''''''''''''''''''|''''''''''''''''''|'''''''''''\'\
  //||    _..._         |                  '    _..._  |)|
 /|//   ,',---.`.       |                  |  .',---.`.\>|
(':/   //' .-. `\\      \_________________/  '/' .-. `\\|_)
 `-...'||  '-'  ||________,,,,,,,,,,,,,,,__.'||  '-'  ||-'
       '.'.___.','                           '.'.___.','
  LGB    '-.m.-'                               '-.m.-'");
            WriteLine();
        }
    }
}

