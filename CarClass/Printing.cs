using System;
using static System.Console;
namespace CarClass
{
    public class Printing
    {
        public static void Title()
        {
            WriteLine(@" +-+-+-+-+-+ +-+ +-+-+-+-+-+-+
 |B|u|i|l|d| |a| |G|a|r|a|g|e|
 +-+-+-+-+-+ +-+ +-+-+-+-+-+-+");
            WriteLine();
        }

        public static void UserSelection()
        {
            Clear();
            Title();
            WriteLine("\n>Please Select From the Following Options: ");
            WriteLine("\n>1. Add a new Car: ");
            WriteLine(">2. Display your Cars: ");
            WriteLine(">3. Exit");
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
            WriteLine(@"");
            ReadKey();
        }
    }
}

