using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGameWithCSharp
{
     public class River : BattleLoc
    {
        public River(Player player) : base(player, "Nehir", new Bear(), "Water")
        {
        }
    }
}
