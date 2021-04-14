using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGameWithCSharp
{
    class Driver
    {

        static void Main(String[] args)
        {

            Game game1 = new Game();
            game1.login();
            Console.ReadKey();

        }

    }
}
