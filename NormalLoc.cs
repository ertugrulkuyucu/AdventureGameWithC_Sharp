using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGameWithCSharp
{
    public abstract class NormalLoc : Location
    {
		public NormalLoc(Player player, String name) : base(player)
		{
			this.name = name;
		}

		override public bool getLocation()
		{
			return true;
		}

	}
}
