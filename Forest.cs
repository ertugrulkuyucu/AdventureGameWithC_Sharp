using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGameWithCSharp
{
    public class Forest : BattleLoc
    {
        public Forest(Player player) : base(player, "Orman", new Vampire(), "Firewood")
        {
        }
    }
}
