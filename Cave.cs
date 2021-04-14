using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGameWithCSharp
{
    public class Cave : BattleLoc
    {
        public Cave(Player player) : base(player, "Mağara", new Zombie(), "Food")
        {
        }
    }
}
