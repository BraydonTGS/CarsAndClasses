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
            PrintCarThree();
            WriteLine(">Please Select From the Following Options: ");
            WriteLine("\n>1. Add a new Car: ");
            WriteLine(">2. Display your Cars: ");
            WriteLine(">3. Take out a Car: ");
            WriteLine(">4. Exit");
        }

        public static void CarOptions()
        {
            Clear();
            Title();
            PrintCarFour();
            WriteLine(">Please Select From the Following Options: ");
            WriteLine("\n>1. Wash Your Car: ");
            WriteLine(">2. Get Some Gas: ");
            WriteLine(">3. Drive to the Mountains: ");
            WriteLine(">4. Put Back in Garage: ");
            WriteLine(">5. Go Back");

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

        public static void PrintCarThree()
        {
            WriteLine(@"   ---------------------------.
 `/""""/""""/|""|'|""||""|   ' \.
 /    /    / |__| |__||__|      |
/----------=====================|
| \  /V\  /    _.               |
|()\ \W/ /()   _            _   |
|   \   /     / \          / \  |-( )
=C========C==_| ) |--------| ) _/==] _-{_}_)
 \_\_/__..  \_\_/_ \_\_/ \_\_/__.__.
--TIM--");
            WriteLine();
        }

        public static void PrintCarFour()
        {
            WriteLine(@"                                  @
               (__)    (__) _____/
            /| (oo) _  (oo)/----/_____    *
  _o\______/_|\_\/_/_|__\/|____|//////== *- *  * -
 /_________   \   00 |   00 |       /== -* * -
[_____/^^\_____\_____|_____/^^\_____]     *- * -
      \__/                 \__/");
            WriteLine();
        }


    }
}

